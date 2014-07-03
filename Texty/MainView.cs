using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Texty
{
    public partial class MainView : Form
    {
        ToolStripMenuItem copy, cut, paste, del;
        ContextMenuStrip cm;

        public MainView()
        {
            InitializeComponent();
            this.MouseDown += this.MainView_MouseDown;
            this.Contents.GotFocus += this.Contents_GotFocus;
            this.Contents.KeyDown += this.Contents_MultiKey;
            this.Contents.SelectionChanged += Contents_SelectionChanged;
            this.FindBox.KeyDown += this.FindBox_KeyDown;
            this.ReplaceBox.KeyDown += this.ReplaceBox_KeyDown;
            this.ExitButton.MouseEnter += ExitButton_MouseEnter;
            this.ExitButton.MouseLeave += ExitButton_MouseLeave;
            this.FindBox.GotFocus += FindBox_GotFocus;

            Program.settings = Settings.GetSettingsObject();
            UpdateSettings();
        }

        private void Contents_SelectionChanged(object sender, EventArgs e)
        {
            if (Contents.SelectedText.Length > 0)
            {
                cutToolStripMenuItem.Enabled = true;
                copyToolStripMenuItem.Enabled = true;
                delToolStripMenuItem.Enabled = true;
                CutButton.Enabled = true;
                CopyButton.Enabled = true;
            }
            else
            {
                cutToolStripMenuItem.Enabled = false;
                copyToolStripMenuItem.Enabled = false;
                delToolStripMenuItem.Enabled = false;
                CutButton.Enabled = false;
                CopyButton.Enabled = false;
            }
        }

        private void FindBox_GotFocus(object sender, EventArgs e)
        {
            Program.fromFindBox = true;
        }

        private void ExitButton_MouseLeave(object sender, EventArgs e)
        {
            ExitButton.BackgroundImage = Texty.Properties.Resources.close;
        }

        private void ExitButton_MouseEnter(object sender, EventArgs e)
        {
            ExitButton.BackgroundImage = Texty.Properties.Resources.ht_close;
        }

        private void UpdateSettings()
        {
            this.Contents.WordWrap = Program.settings.WordWrap;
            this.Contents.Font = new Font(Program.settings.FontFamily, Program.settings.FontSize);
            this.Contents.ForeColor = Color.FromArgb(
                                        Program.settings.ForeColor.R,
                                        Program.settings.ForeColor.G,
                                        Program.settings.ForeColor.B);
            this.Contents.BackColor = Color.FromArgb(
                                        Program.settings.BackColor.R,
                                        Program.settings.BackColor.G,
                                        Program.settings.BackColor.B);
            if (Program.mode == Program.TEXT)
            {
                switch (Program.settings.Alignment)
                {
                    case Settings.LEFTALIGN:
                        Contents.SelectionAlignment = HorizontalAlignment.Left;
                        break;
                    case Settings.CENTERALIGN:
                        Contents.SelectionAlignment = HorizontalAlignment.Center;
                        break;
                    case Settings.RIGHTALIGN:
                        Contents.SelectionAlignment = HorizontalAlignment.Right;
                        break;
                }
            }
            else
            {
                Contents.SelectAll();
                Contents.SelectionAlignment = HorizontalAlignment.Left;
                Contents.DeselectAll();
            }
        }

        private void ReplaceBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter &&
                FindBox.Text.Length > 0 &&
                ReplaceBox.Text.Length > 0)
            {
                int index = Contents.Text.IndexOf(FindBox.Text);
                Contents.Select(index, FindBox.Text.Length);
                Contents.SelectedText = ReplaceBox.Text;
            }
        }

        private void OpenFile()
        {
            if (!Program.IsSaved)
            {
                ModernDialog dialog = new ModernDialog("Save Existing ?", "Save the existing changes ?", "Dont", "Save");
                dialog.ShowDialog();
                switch (dialog.result)
                {
                    case ModernDialog.LEFT:
                        break;
                    case ModernDialog.CENTER:
                        bool result = SaveFile();
                        if (!result)
                            return;
                        break;
                    case ModernDialog.CANCEL:
                        return;
                }
            }
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Open File";
            open.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            open.FilterIndex = 2;
            open.RestoreDirectory = true;
            if (open.ShowDialog() == DialogResult.OK)
            {
                StatusLabel.Text = open.FileName;
                Stream stream = open.OpenFile();
                if (stream == null)
                {
                    MessageBox.Show("Error : Could not open file");
                }
                else
                {
                    using (stream)
                    {
                        Contents.Text = "";
                        ClearFormatting();
                        if (Path.GetExtension(open.FileName).Equals(".rtf"))
                            Contents.LoadFile(open.FileName);
                        else
                            Contents.Text = File.ReadAllText(open.FileName);
                        Program.content = Contents.Text;
                        String ext = Path.GetExtension(open.FileName);
                        Doc1.Text = Path.GetFileName(open.FileName);
                        processFile(ext);
                        Program.CurrentFile = open.FileName;
                        Program.IsNew = false;
                    }
                }
            }
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void processFile(String ext)
        {
            String content = Contents.Text;
            Dictionary<int, int> indexes = null;
            List<Triplet> list = null;
            if (ext.Equals(".c"))
            {
                //indexes = CodeHighlighter.GetIndexes(content, LangC.keywords);
                list = LangC.GetIndexesWithColor(content, Color.Blue, Color.Gray, Color.LawnGreen);
                foreach (Triplet t in list)
                {
                    //Debug.WriteLine("Coloring : " + t.start + "  " + t.end + " " + t.color.ToString());
                    Contents.Select(t.start, t.end);
                    Contents.SelectionColor = t.color;
                }
                return;
            }
            else if (ext.Equals(".cpp"))
            {
                indexes = CodeHighlighter.GetIndexes(content, LangCPP.keywords);

            }
            else if (ext.Equals(".java"))
            {
                indexes = CodeHighlighter.GetIndexes(content, LangJava.keywords);

            }
            else if (ext.Equals(".cs"))
            {
                indexes = CodeHighlighter.GetIndexes(content, LangCSharp.keywords);
            }
            else if (ext.Equals(".rtf"))
            {
                Program.mode = Program.TEXT;
                colorToolStripMenuItem.Enabled = true;
                timeDateToolStripMenuItem.Enabled = true;
                ModeLabel.Text = "Rich Text";
                BoldButton.Enabled = true;
                ItalicsButton.Enabled = true;
                UnderlineButton.Enabled = true;
                return;
            }
            else
            {
                ClearFormatting();
                Program.mode = Program.RAW;
                colorToolStripMenuItem.Enabled = false;
                alignmentrToolStripMenuItem.Enabled = false;
                ModeLabel.Text = "Raw Text";
                BoldButton.Enabled = true;
                ItalicsButton.Enabled = true;
                UnderlineButton.Enabled = true;
                UpdateSettings();
                return;
            }
            ClearFormatting();
            foreach (var pair in indexes)
            {
                Contents.Select(pair.Key, pair.Value);
                Contents.SelectionColor = Color.Blue;
            }
            Program.mode = Program.DEVELOPER;
            ModeLabel.Text = "Developer";
            colorToolStripMenuItem.Enabled = false;
            Contents.SelectAll();
            Contents.SelectionAlignment = HorizontalAlignment.Left;
            Contents.DeselectAll();
            Contents.SelectionStart = 0;
            timeDateToolStripMenuItem.Enabled = false;
            alignmentrToolStripMenuItem.Enabled = false;
            BoldButton.Enabled = false;
            ItalicsButton.Enabled = false;
            UnderlineButton.Enabled = false;
        }

        private void Exit()
        {
            if (Program.IsSaved == false)
            {
                try
                {
                    ModernDialog exit = new ModernDialog("Exit Texty ?",
                        "Do you want to exit without saving changes ?",
                        "Exit", "Save");
                    exit.ShowDialog();
                    switch (exit.result)
                    {
                        case ModernDialog.CANCEL:
                            break;
                        case ModernDialog.CENTER:
                            bool result = SaveFile();
                            //Debug.Write("here saved" + result);
                            if (result)
                                Application.Exit();
                            break;
                        case ModernDialog.LEFT:
                            Application.Exit();
                            break;
                    }
                }
                catch (Exception exp)
                {
                    CriticalError(exp.Message);
                }
            }
            else
            {
                Application.Exit();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void CriticalError(String desc)
        {
            CriticalError ce = new CriticalError(desc);
            ce.ShowDialog();
            Application.Exit();
        }

        private bool SaveFile()
        {
            if (Program.IsNew && !Program.IsSaved)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Title = "Save File";
                if (Program.mode == Program.TEXT)
                    save.Filter = "Rich Text Format (*.rtf)|*.rtf|All Files (*.*)|*.*";
                else
                    save.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                save.RestoreDirectory = true;
                save.FilterIndex = 2;
                var result = save.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Program.IsSaved = true;
                    Program.IsNew = false;
                    Program.CurrentFile = save.FileName;
                    Doc1.Text = Path.GetFileName(save.FileName);
                    try
                    {
                        if (Program.mode == Program.TEXT &&
                            Path.GetExtension(save.FileName).Equals(".rtf"))
                            Contents.SaveFile(save.FileName);
                        else
                            File.WriteAllText(save.FileName, Contents.Text);
                        processFile(Path.GetExtension(save.FileName));
                    }
                    catch (Exception exp)
                    {
                        CriticalError(exp.Message);
                    }
                    SaveStatus.Text = "Saved";
                }
                else if (result == DialogResult.Cancel)
                    return false;
            }
            else if (!Program.IsNew && !Program.IsSaved)
            {
                try
                {
                    if (Program.mode == Program.TEXT)
                        Contents.SaveFile(Program.CurrentFile);
                    else
                    {
                        File.WriteAllText(Program.CurrentFile, "");
                        File.WriteAllText(Program.CurrentFile, Contents.Text);
                    }
                }
                catch (Exception exp)
                {
                    CriticalError(exp.Message);
                }
                Program.IsSaved = true;
                SaveStatus.Text = "Saved";
            }
            return true;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void Contents_MultiKey(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.F)
                FindBox.Focus();
            else if (e.Control && e.KeyCode == Keys.Z)
                Contents.Undo();
            else if (e.Control && e.KeyCode == Keys.Y)
                Contents.Redo();
            else if (e.Control && e.KeyCode == Keys.N)
                NewFile();
            else if (e.Control && e.KeyCode == Keys.S)
                SaveFile();
            else if (e.Control && e.KeyCode == Keys.O)
                OpenFile();
            if (Program.mode != Program.DEVELOPER)
            {
                if (e.Control && e.KeyCode == Keys.B)
                    BoldText();
                else if (e.Control && e.KeyCode == Keys.I)
                    ItalicText();
                else if (e.Control && e.KeyCode == Keys.U)
                    UnderlineText();
            }
            else
            {
                // TODO : Auto bracket completion.
            }
        }

        private void UnderlineText()
        {
            if (Contents.SelectedText.Length > 0 && Program.mode == Program.TEXT)
            {
                FontStyle style = Contents.SelectionFont.Style;
                Contents.SelectionFont = new Font(Contents.SelectionFont, FontStyle.Underline | style);
            }
            else
            {
                FontStyle style = Contents.Font.Style;
                Contents.Font = new Font(Contents.Font, FontStyle.Underline | style);
            }
        }

        private void ItalicText()
        {
            if (Contents.SelectedText.Length > 0 && Program.mode == Program.TEXT)
            {
                FontStyle style = Contents.SelectionFont.Style;
                Contents.SelectionFont = new Font(Contents.SelectionFont, FontStyle.Italic | style);
            }
            else
            {
                FontStyle style = Contents.Font.Style;
                Contents.Font = new Font(Contents.Font, FontStyle.Italic | style);
            }
        }

        private void BoldText()
        {
            if (Contents.SelectedText.Length > 0 && Program.mode == Program.TEXT)
            {
                FontStyle style = Contents.SelectionFont.Style;
                Contents.SelectionFont = new Font(Contents.SelectionFont, FontStyle.Bold | style);
            }
            else
            {
                FontStyle style = Contents.Font.Style;
                Contents.Font = new Font(Contents.Font, FontStyle.Bold | style);
            }
        }


        private void Contents_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void FontSelect()
        {
            fontDialog.Color = Contents.ForeColor;
            fontDialog.Font = Contents.Font;
            if (fontDialog.ShowDialog() != DialogResult.Cancel)
            {
                if (Program.mode == Program.DEVELOPER)
                {
                    Contents.Font = fontDialog.Font;
                    Contents.ForeColor = fontDialog.Color;
                }
                else if (Program.mode == Program.TEXT)
                {
                    Font font = Contents.Font;
                    Contents.SelectionFont = fontDialog.Font;
                    Contents.SelectionColor = fontDialog.Color;
                    Contents.Font = font;
                }
            }
        }

        private void FontSelection_Click(object sender, EventArgs e)
        {
            FontSelect();
        }

        private void Contents_TextChanged(object sender, EventArgs e)
        {
            Program.IsSaved = false;
            String[] words = Contents.Text.Split(' ');
            String[] lines = Contents.Text.Split('\n');
            StatusLabel.Text = "Word Count : " + words.Length + " | Line Count : " + lines.Length;
            SaveStatus.Text = "Not Saved";
            Program.content = Contents.Text;
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            if (Contents.SelectionLength > 0)
                Clipboard.SetText(Contents.SelectedText);
        }

        private void Paste_Click(object sender, EventArgs e)
        {
            String paste = Clipboard.GetText();
            if (paste.Length > 0)
                Contents.SelectedText = paste;
        }

        private void Cut_Click(object sender, EventArgs e)
        {
            if (Contents.SelectionLength > 0)
            {
                Clipboard.SetText(Contents.SelectedText);
                Contents.SelectedText = "";
            }
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            cm = new ContextMenuStrip();
            cm.Opening += cm_Opening;
            cm.BackColor = Color.FromArgb(230, 230, 230);
            copy = new ToolStripMenuItem();
            copy.Text = "Copy";
            copy.Click += Copy_Click;
            copy.Image = Texty.Properties.Resources.duplicate;
            paste = new ToolStripMenuItem();
            paste.Text = "Paste";
            paste.Click += Paste_Click;
            paste.Image = Texty.Properties.Resources.paste;
            cut = new ToolStripMenuItem();
            cut.Text = "Cut";
            cut.Click += Cut_Click;
            cut.Image = Texty.Properties.Resources.cut;
            del = new ToolStripMenuItem();
            del.Text = "Delete";
            del.Click += del_Click;
            del.Image = Texty.Properties.Resources.trash;
            cm.Items.AddRange(new ToolStripMenuItem[] { cut, copy, paste, del });
            Contents.ContextMenuStrip = cm;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            SystemExplorer.Nodes.Add(path);
            PopulateTree(path, SystemExplorer.Nodes[0]);
        }

        private void del_Click(object sender, EventArgs e)
        {
            if (Contents.SelectedText.Length > 0)
                Contents.SelectedText = "";
        }

        private void cm_Opening(object sender, CancelEventArgs e)
        {
            if (Contents.SelectedText.Length < 1)
            {
                cut.Enabled = false;
                copy.Enabled = false;
                del.Enabled = false;
            }
            else
            {
                cut.Enabled = true;
                copy.Enabled = true;
                del.Enabled = true;
            }
            if (!Clipboard.ContainsText())
                paste.Enabled = true;
        }

        private bool NewFile()
        {
            if (Program.IsSaved == false)
            {
                try
                {
                    ModernDialog dialog = new ModernDialog("Save File",
                        "Save changes before opening document ?",
                        "Dont Save", "Save");
                    dialog.ShowDialog();
                    switch (dialog.result)
                    {
                        case ModernDialog.CANCEL:
                            return false;
                        case ModernDialog.CENTER:
                            bool result = SaveFile();
                            if (!result)
                                return false;
                            break;
                        case ModernDialog.LEFT:
                            break;
                    }
                }
                catch (Exception exp)
                {
                    CriticalError(exp.Message);
                }
            }
            Contents.Text = "";
            Program.IsNew = true;
            Program.IsSaved = false;
            Program.mode = Program.TEXT;
            colorToolStripMenuItem.Enabled = true;
            alignmentrToolStripMenuItem.Enabled = true;
            Doc1.Text = "New";
            return true;
        }

        private void NewContent_Click(object sender, EventArgs e)
        {
            NewFile();
        }

        private void Minimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Magnify_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            if (me.Button == MouseButtons.Right)
            {
                Program.zoom -= 1.0f;
                if (Program.zoom == 0.0f)
                    Program.zoom = 1.0f;
            }
            else if (me.Button == MouseButtons.Left)
            {
                Program.zoom += 1.0f;
            }
            Contents.ZoomFactor = Program.zoom;
        }

        private void PopulateTree(string dir, TreeNode node)
        {
            DirectoryInfo directory = new DirectoryInfo(dir);
            foreach (DirectoryInfo d in directory.GetDirectories())
            {
                try
                {
                    TreeNode t = new TreeNode(d.Name);
                    if (node != null) node.Nodes.Add(t);
                    else SystemExplorer.Nodes.Add(t);
                    PopulateTree(d.FullName, t);
                }
                catch (Exception exp)
                { }
            }
            foreach (FileInfo f in directory.GetFiles())
            {
                try
                {
                    if (f.Extension.Equals(".txt") || f.Extension.Equals(".c") ||
                        f.Extension.Equals(".cpp") || f.Extension.Equals(".java") ||
                        f.Extension.Equals(".rtf") || f.Extension.Equals(".cs"))
                    {
                        TreeNode t = new TreeNode(f.Name);
                        if (node != null) node.Nodes.Add(t);
                        else SystemExplorer.Nodes.Add(t);
                    }
                }
                catch (Exception exp)
                { }
            }
        }


        private void Settings_Click(object sender, EventArgs e)
        {

        }

        private void FindReplace_Click(object sender, EventArgs e)
        {
            try
            {
                IEnumerable<int> indexes = TextManipulation.AllIndexesOf(Program.content, FindBox.Text);
                SearchHighlight(FindBox.Text, indexes);
            }
            catch (ArgumentException exp)
            {
            }
        }

        public void SearchHighlight(string text, IEnumerable<int> indexes)
        {
            if (text.Length < 1)
                return;
            foreach (var index in indexes)
            {
                Contents.Select(index, text.Length);
                Contents.SelectionBackColor = Color.SteelBlue;
                Program.highlighted = true;
            }
        }

        private void Contents_GotFocus(object sender, EventArgs e)
        {
            if (Program.fromFindBox)
            {
                ClearFormatting();
                Program.fromFindBox = false;
                if (!Program.IsNew)
                    processFile(Path.GetExtension(Program.CurrentFile));
            }
        }

        private void ClearFormatting()
        {
            // if (Program.highlighted)
            // {
            Contents.SelectAll();
            Contents.SelectionBackColor = Color.FromArgb(
                                        Program.settings.BackColor.R,
                                        Program.settings.BackColor.G,
                                        Program.settings.BackColor.B);
            Contents.SelectionColor = Color.FromArgb(
                                        Program.settings.ForeColor.R,
                                        Program.settings.ForeColor.G,
                                        Program.settings.ForeColor.B);
            Contents.SelectionFont = new Font(Program.settings.FontFamily, Program.settings.FontSize);
            Contents.DeselectAll();
            Program.highlighted = false;
            //}
        }

        private void FindBox_TextChanged(object sender, EventArgs e)
        {
            if (FindBox.Text.Length > 0)
                FindButton.Enabled = true;
        }

        private void FindBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                IEnumerable<int> indexes = TextManipulation.AllIndexesOf(Program.content, FindBox.Text);
                SearchHighlight(FindBox.Text, indexes);
            }
        }

        private void CutButton_Click(object sender, EventArgs e)
        {
            if (Contents.SelectedText.Length > 0)
            {
                Clipboard.SetText(Contents.SelectedText);
                Contents.SelectedText = "";
            }
        }

        private void PasteButton_Click(object sender, EventArgs e)
        {
            Contents.Paste();
        }

        private void Print()
        {
            PrintDialog print = new PrintDialog();
            PrintDocument doc = new PrintDocument();
            doc.DocumentName = Program.CurrentFile;
            print.Document = doc;
            print.AllowSelection = true;
            print.AllowSomePages = true;
            print.UseEXDialog = true;
            if (print.ShowDialog() == DialogResult.OK)
            {
                doc.PrintPage += doc_PrintPage;
                doc.Print();
            }
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            Print();
        }

        private void doc_PrintPage(object sender, PrintPageEventArgs ev)
        {
            ev.Graphics.DrawString(Program.content, Contents.Font, Brushes.Black, ev.MarginBounds.Left, 0, new StringFormat());
        }

        private void SystemExplorer_AfterSelect(object sender, TreeViewEventArgs e)
        {
            bool open = true;
            if (Program.IsSaved == false)
            {
                open = NewFile();
                if (open)
                {
                    var file = e.Node.FullPath;
                    Contents.Text = File.ReadAllText(file);
                    processFile(Path.GetExtension(file));
                    Program.content = Contents.Text;
                    Program.CurrentFile = Path.GetFileName(file);
                }
            }

        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            if (Contents.SelectedText.Length > 0)
                Clipboard.SetText(Contents.SelectedText);
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SettingsPanel settings = new SettingsPanel();
            settings.ShowDialog();
            if (settings.result == SettingsPanel.SAVEDEXIT)
                UpdateSettings();
        }

        private void panel_Click(object sender, EventArgs e)
        {
            SettingsPanel sp = new SettingsPanel();
            sp.ShowDialog();
        }

        private void mode_Click(object sender, EventArgs e)
        {
            if (Program.mode == Program.TEXT)
            {
                Program.mode = Program.DEVELOPER;
                ModeLabel.Text = "Developer";
            }
            else
            {
                Program.mode = Program.TEXT;
                ModeLabel.Text = "";
            }
        }

        private void ReplaceButton_Click(object sender, EventArgs e)
        {
            if (FindBox.Text.Length > 0 &&
                ReplaceBox.Text.Length > 0)
            {
                int index = Contents.Text.IndexOf(FindBox.Text);
                Contents.Select(index, FindBox.Text.Length);
                Contents.SelectedText = ReplaceBox.Text;
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewFile();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Contents.SelectionLength > 0)
                Clipboard.SetText(Contents.SelectedText);
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Contents.SelectionLength > 0)
            {
                Clipboard.SetText(Contents.SelectedText);
                Contents.SelectedText = "";
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contents.Paste();
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindBox.Focus();
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FindBox.Text.Length > 0)
                ReplaceBox.Focus();
        }

        private void zoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.zoom += 1.0f;
            Contents.ZoomFactor = Program.zoom;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontSelect();
        }

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Credits credit = new Credits();
            credit.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Print();
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.zoom -= 1.0f;
            if (Program.zoom < 1.0f)
                Program.zoom = 1.0f;
            Contents.ZoomFactor = Program.zoom;
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contents.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contents.Redo();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rightAlignToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contents.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void leftAlignToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contents.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void centerAlignToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contents.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void timeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contents.Text += System.DateTime.Now;
        }

        private void foregroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string change = Contents.SelectedText;
            int start = Contents.SelectionStart;
            ColorDialog color = new ColorDialog();
            color.AnyColor = true;
            var result = color.ShowDialog();
            if (result == DialogResult.OK && change.Length > 0)
            {
                Contents.Select(start, change.Length);
                Contents.SelectionColor = color.Color;
            }
        }

        private void alignmentrToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string change = Contents.SelectedText;
            int start = Contents.SelectionStart;
            ColorDialog color = new ColorDialog();
            color.AnyColor = true;
            var result = color.ShowDialog();
            if (result == DialogResult.OK && change.Length > 0)
            {
                Contents.Select(start, change.Length);
                Contents.SelectionBackColor = color.Color;
            }
        }

        private void BoldButton_Click(object sender, EventArgs e)
        {
            BoldText();
        }

        private void ItalicsButton_Click(object sender, EventArgs e)
        {
            ItalicText();
        }

        private void UnderlineButton_Click(object sender, EventArgs e)
        {
            UnderlineText();
        }

        private void delToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Contents.SelectedText.Length > 0)
                Contents.SelectedText = "";
        }

        private void editToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
                pasteToolStripMenuItem.Enabled = true;
            else
                pasteToolStripMenuItem.Enabled = false;
        }

        private void ReplaceBox_TextChanged(object sender, EventArgs e)
        {
            if (ReplaceBox.Text.Length > 0)
                ReplaceButton.Enabled = true;
        }

    }

}
