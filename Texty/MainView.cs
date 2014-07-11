using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Threading;
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
            this.MouseDown += MainView_MouseDown;
            this.Contents.GotFocus += Contents_GotFocus;
            this.Contents.KeyDown += Contents_MultiKey;
            this.Contents.SelectionChanged += Contents_SelectionChanged;
            this.Contents.TextChanged += Contents_TextChanged;
            this.OpenedFilesListBox.DrawItem += OpenedFilesListBox_DrawItem;
            this.ExitButton.MouseEnter += ExitButton_MouseEnter;
            this.ExitButton.MouseLeave += ExitButton_MouseLeave;
            this.SystemExplorer.AfterSelect += SystemExplorer_AfterSelect;

            this.ReplaceButton.Click += ReplaceButton_Click;
            this.FindButton.Click += FindReplace_Click;
            this.FindBox.KeyDown += FindBox_KeyDown;
            this.ReplaceBox.KeyDown += ReplaceBox_KeyDown;
            this.FindBox.GotFocus += FindBox_GotFocus;
            this.FindBox.TextChanged += FindBox_TextChanged;
            this.ReplaceBox.TextChanged += ReplaceBox_TextChanged;

            this.saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            this.newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            this.openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            this.printToolStripMenuItem.Click += printToolStripMenuItem_Click;
            this.exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            this.recentToolStripMenuItem.DropDownOpening += recentToolStripMenuItem_DropDownOpening;

            this.editToolStripMenuItem.DropDownOpening += editToolStripMenuItem_DropDownOpening;
            this.undoToolStripMenuItem.Click += undoToolStripMenuItem_Click;
            this.redoToolStripMenuItem.Click += redoToolStripMenuItem_Click;
            this.cutToolStripMenuItem.Click += cutToolStripMenuItem_Click;
            this.copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            this.pasteToolStripMenuItem.Click += pasteToolStripMenuItem_Click;
            this.delToolStripMenuItem.Click += delToolStripMenuItem_Click;
            this.timeDateToolStripMenuItem.Click += timeDateToolStripMenuItem_Click;

            this.zoomOutToolStripMenuItem.Click += zoomOutToolStripMenuItem_Click;
            this.zoomToolStripMenuItem.Click += zoomToolStripMenuItem_Click;

            this.fontToolStripMenuItem.Click += fontToolStripMenuItem_Click;
            this.foregroundToolStripMenuItem.Click += foregroundToolStripMenuItem_Click;
            this.backgroundToolStripMenuItem.Click += backgroundToolStripMenuItem_Click;
            this.rightAlignToolStripMenuItem.Click += rightAlignToolStripMenuItem_Click;
            this.leftAlignToolStripMenuItem.Click += leftAlignToolStripMenuItem_Click;
            this.centerAlignToolStripMenuItem.Click += centerAlignToolStripMenuItem_Click;

            this.creditsToolStripMenuItem.Click += creditsToolStripMenuItem_Click;
            this.aboutToolStripMenuItem1.Click += aboutToolStripMenuItem1_Click;

            Program.settings = Settings.GetSettingsObject();
            UpdateSettings();
        }

        void OpenedFilesListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            //if the item state is selected then change the back color 
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics,
                                          e.Font,
                                          e.Bounds,
                                          e.Index,
                                          e.State ^ DrawItemState.Selected,
                                          e.ForeColor,
                                          Color.FromArgb(230, 230, 230));

            // Draw the background of the ListBox control for each item.
            e.DrawBackground();
            // Draw the current item text
            e.Graphics.DrawString(OpenedFilesListBox.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds, StringFormat.GenericDefault);
            // If the ListBox has focus, draw a focus rectangle around the selected item.
            e.DrawFocusRectangle();
        }

        private void recentToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            List<string> names = History.FetchFileList();
            foreach (string name in names)
            {
                Debug.WriteLine(name);
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Text = Path.GetFileNameWithoutExtension(name);
                item.Image = Texty.Properties.Resources.overview_pages_1_256;
                item.Click += delegate(object _sender, EventArgs _e)
                {
                    OpenFile(name);
                };
                recentToolStripMenuItem.DropDownItems.Add(item);
            }
        }

        private void editToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            if (Contents.SelectedText.Length > 0)
            {
                cutToolStripMenuItem.Enabled = true;
                copyToolStripMenuItem.Enabled = true;
            }
            else
            {
                cutToolStripMenuItem.Enabled = false;
                copyToolStripMenuItem.Enabled = false;
            }

            if (Clipboard.ContainsText())
                pasteToolStripMenuItem.Enabled = true;
            else
                pasteToolStripMenuItem.Enabled = false;
        }

        private void Contents_SelectionChanged(object sender, EventArgs e)
        {
            if (Contents.SelectedText.Length > 0)
            {
                cutToolStripMenuItem.Enabled = true;
                copyToolStripMenuItem.Enabled = true;
                delToolStripMenuItem.Enabled = true;
            }
            else
            {
                cutToolStripMenuItem.Enabled = false;
                copyToolStripMenuItem.Enabled = false;
                delToolStripMenuItem.Enabled = false;
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

        private void ReadToApplication(string name)
        {
            Contents.Text = "";
            ClearFormatting();
            Doc1.Text = Path.GetFileName(name);
            FileHandler.ReadFile(name, ref Contents);
            FileStore.AddFile(name, Contents.Rtf);
            FileStore.SetCurrent(name);
            SetProperties(name);
            ProcessFile(name);
            Program.CurrentFile = name;
            Program.IsNew = false;
            Program.IsSaved = true;
            History.Add(name);
        }

        private void OpenFile(string name)
        {
            if (!File.Exists(name))
                return;
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
            ReadToApplication(name);
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
                Stream stream = open.OpenFile();
                if (stream == null)
                {
                    MessageBox.Show("Error : Could not open file");
                }
                else
                {
                    using (stream)
                    {
                        ReadToApplication(open.FileName);
                    }
                }
            }
        }

        private void SetProperties(string file)
        {
            string ext = Path.GetExtension(file);
            if (ext.Equals(".rtf") || ext.Equals(".docx"))
            {
                Program.mode = Program.TEXT;
                colorToolStripMenuItem.Enabled = true;
                timeDateToolStripMenuItem.Enabled = true;
                ModeLabel.Text = "Rich Text";
                BoldButton.Enabled = true;
                ItalicsButton.Enabled = true;
                UnderlineButton.Enabled = true;
                Program.readmode = false;
                Contents.ReadOnly = false;
                return;
            }
            else if (ext.Equals(".c") ||
                ext.Equals(".cpp") ||
                ext.Equals(".java") ||
                ext.Equals(".cs") ||
                ext.Equals(".js"))
            {
                Program.mode = Program.DEVELOPER;
                Program.readmode = true;
                ModeLabel.Text = "Developer";
                colorToolStripMenuItem.Enabled = false;
                Contents.SelectAll();
                Contents.SelectionAlignment = HorizontalAlignment.Left;
                Contents.DeselectAll();
                Contents.ReadOnly = true;
                Contents.SelectionStart = 0;
                timeDateToolStripMenuItem.Enabled = false;
                alignmentrToolStripMenuItem.Enabled = false;
                BoldButton.Enabled = false;
                ItalicsButton.Enabled = false;
                UnderlineButton.Enabled = false;
            }
            else
            {
                ClearFormatting();
                Program.mode = Program.RAW;
                Program.readmode = false;
                Contents.ReadOnly = false;
                colorToolStripMenuItem.Enabled = false;
                alignmentrToolStripMenuItem.Enabled = false;
                ModeLabel.Text = "Raw Text";
                BoldButton.Enabled = true;
                ItalicsButton.Enabled = true;
                UnderlineButton.Enabled = true;
                UpdateSettings();
            }
            int wc = Contents.Text.Split(' ').Length;
            int lc = Contents.Text.Split('\n').Length;
            WCStatusLabel.Text = "Words : " + wc;
            LCStatusLabel.Text = "Lines: " + lc;
            SaveStatus.Text = "Saved";
            OpenedFilesListBox.Items.Add(new FileContainer(file, Contents.Rtf));
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void ProcessFile(string name)
        {
            var list = FileHandler.GetHighlightingInfo(name, Contents.Text);
            ClearFormatting();

            // Lock Screen View
            BeginUpdate();
            foreach (Triplet t in list)
            {
                Contents.Select(t.start, t.end);
                Contents.SelectionColor = t.color;
            }
            // Unlock Screen View
            EndUpdate();

            // Scroll past the visible area to update screen
            Contents.SelectionStart = Contents.Text.Length - 1;
            Contents.SelectionStart = 0;
        }

        private void Exit()
        {
            History.SaveHistory();
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
                        if (Program.mode == Program.TEXT)
                            Contents.SaveFile(save.FileName);
                        else
                            File.WriteAllText(save.FileName, Contents.Text);
                        ProcessFile(Path.GetExtension(save.FileName));
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
                        Debug.WriteLine(Program.CurrentFile);
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
            if (e.Control && e.KeyCode == Keys.F)
                ShowFind();
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
                if (Program.readmode && !e.Control)
                {
                    if (e.KeyCode != Keys.Up && e.KeyCode != Keys.PageUp &&
                        e.KeyCode != Keys.Down && e.KeyCode != Keys.PageDown &&
                        e.KeyCode != Keys.Right && e.KeyCode != Keys.Home &&
                        e.KeyCode != Keys.Left && e.KeyCode != Keys.End)
                    {
                        ModernDialog change = new ModernDialog("Change Mode ?",
                            "Document is read-only, change mode ?", "Change", "Dont");
                        change.ShowDialog();
                        switch (change.result)
                        {
                            case ModernDialog.CENTER:
                                break;
                            case ModernDialog.LEFT:
                                Contents.ReadOnly = false;
                                Program.readmode = false;
                                break;
                        }
                    }
                }
                else
                    if (e.KeyCode == Keys.OemOpenBrackets && !e.Shift)
                        AutoCompletion.Opened('[');
                    else if (e.KeyCode == Keys.OemOpenBrackets && e.Shift)
                        AutoCompletion.Opened('{');
                    else if (e.KeyCode == Keys.OemQuotes && e.Shift)
                        AutoCompletion.Opened('"');
                    else if (e.KeyCode == Keys.OemQuotes && !e.Shift)
                        AutoCompletion.Opened('\'');
                    //else if(e.KeyCode == Keys.O
            }
        }

        private void Contents_TextChanged(object sender, EventArgs e)
        {
            Program.IsSaved = false;
            String[] words = Contents.Text.Split(' ');
            String[] lines = Contents.Text.Split('\n');
            WCStatusLabel.Text = "Words : " + words.Length;
            LCStatusLabel.Text = "Lines : " + lines.Length;
            SaveStatus.Text = "Not Saved";
            Program.content = Contents.Text;
            if (Program.mode == Program.DEVELOPER)
            {
                if (AutoCompletion.ToClose)
                {
                    Contents.Select(Contents.SelectionStart, 0);
                    Contents.SelectedText = AutoCompletion.GetClosingChar();
                    //Debug.WriteLine("auto : " + Contents.SelectedText);
                    Contents.SelectionStart -= 1;
                }
            }
        }

        private void ShowFind()
        {
            if (!FindReplacePanel.Visible)
            {
                Program.fromFindBox = true;
                int width = Contents.DisplayRectangle.Right;
                FindReplacePanel.Left = width - FindReplacePanel.Width;
                FindReplacePanel.Visible = true;
                ReplaceBox.Text = "";
                FindBox.Focus();
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
                if (Program.mode == Program.TEXT)
                {
                    Font font = Contents.Font;
                    Contents.SelectionFont = fontDialog.Font;
                    Contents.SelectionColor = fontDialog.Color;
                    Contents.Font = font;
                }
                else
                {
                    Contents.Font = fontDialog.Font;
                    Contents.ForeColor = fontDialog.Color;
                }
            }
        }

        private void FontSelection_Click(object sender, EventArgs e)
        {
            FontSelect();
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
            Contents.Focus();
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
            timeDateToolStripMenuItem.Enabled = true;
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
                        f.Extension.Equals(".rtf") || f.Extension.Equals(".cs") ||
                        f.Extension.Equals(".js") || f.Extension.Equals(".docx"))
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
            Find();
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
            FindReplacePanel.Visible = false;
            if (Program.fromFindBox)
            {
                ClearFormatting();
                Program.fromFindBox = false;
                if (Program.mode == Program.DEVELOPER)
                    ProcessFile(Path.GetExtension(Program.CurrentFile));
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
                Find();
            }
        }

        private IEnumerable<int> Find()
        {
            IEnumerable<int> indexes;
            if (MatchCaseBox.Checked)
                indexes = TextManipulation.AllIndexesOf(Contents.Text, FindBox.Text);
            else
                indexes = TextManipulation.AllIndexesOfNoCase(Contents.Text, FindBox.Text);
            SearchHighlight(FindBox.Text, indexes);
            return indexes;
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
            var file = e.Node.FullPath;
            OpenFile(file);
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
                if (ReplaceAllBox.Checked)
                {
                    IEnumerable<int> indexes = Find();
                    foreach (var index in indexes)
                    {
                        Contents.Select(index, FindBox.Text.Length);
                        Contents.SelectedText = ReplaceBox.Text;
                    }
                }
                else
                {
                    int index = Contents.Text.IndexOf(FindBox.Text);
                    if (index < 0)
                        return;
                    Contents.Select(index, FindBox.Text.Length);
                    Contents.SelectedText = ReplaceBox.Text;
                }
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

        private void FindTopButton_Click(object sender, EventArgs e)
        {
            ShowFind();
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Contents.WordWrap)
                Contents.WordWrap = false;
            else
                Contents.WordWrap = true;
        }

        private void pDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iTextSharp.text.Document doc = new iTextSharp.text.Document();
            iTextSharp.text.pdf.PdfWriter.GetInstance(doc, new FileStream(Program.CurrentFile + ".pdf", FileMode.OpenOrCreate));
            doc.Open();
            iTextSharp.text.html.simpleparser.HTMLWorker hw = new iTextSharp.text.html.simpleparser.HTMLWorker(doc);
            hw.Parse(new StringReader(MarkupConverter.RtfToHtmlConverter.ConvertRtfToHtml(Contents.Rtf)));
            doc.Close();
        }

        private void hTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string content = Contents.Rtf;
            string html = MarkupConverter.RtfToHtmlConverter.ConvertRtfToHtml(content);
            File.WriteAllText(Program.CurrentFile + ".html", html);
        }

        private void OpenedFilesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FileContainer file = (OpenedFilesListBox.SelectedItem as FileContainer);
            Contents.Rtf = FileStore.GetContents(file.GetPath());
            ProcessFile(file.GetPath());
        }

    }

}
