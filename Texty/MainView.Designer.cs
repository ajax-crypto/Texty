using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Texty
{
    partial class MainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Contents = new System.Windows.Forms.RichTextBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.SaveStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveTT = new System.Windows.Forms.ToolTip(this.components);
            this.SaveButton = new System.Windows.Forms.Button();
            this.SystemExplorer = new System.Windows.Forms.TreeView();
            this.FindBox = new System.Windows.Forms.TextBox();
            this.TextyMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.timeDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foregroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alignmentrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightAlignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftAlignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centerAlignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ModeLabel = new System.Windows.Forms.Label();
            this.ReplaceBox = new System.Windows.Forms.TextBox();
            //this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            //this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.Doc1 = new System.Windows.Forms.Label();
            this.UnderlineButton = new System.Windows.Forms.Button();
            this.ItalicsButton = new System.Windows.Forms.Button();
            this.BoldButton = new System.Windows.Forms.Button();
            this.ReplaceButton = new System.Windows.Forms.Button();
            this.CopyButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.FindButton = new System.Windows.Forms.Button();
            this.PasteButton = new System.Windows.Forms.Button();
            this.CutButton = new System.Windows.Forms.Button();
            this.Minimise = new System.Windows.Forms.Button();
            this.NewContent = new System.Windows.Forms.Button();
            this.FontSelection = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.OpenButton = new System.Windows.Forms.Button();
            this.FindTT = new System.Windows.Forms.ToolTip(this.components);
            this.ReplaceTT = new System.Windows.Forms.ToolTip(this.components);
            this.FontTT = new System.Windows.Forms.ToolTip(this.components);
            this.OpenTT = new System.Windows.Forms.ToolTip(this.components);
            this.NewTT = new System.Windows.Forms.ToolTip(this.components);
            this.BoldTT = new System.Windows.Forms.ToolTip(this.components);
            this.UnderlineTT = new System.Windows.Forms.ToolTip(this.components);
            this.SettingsTT = new System.Windows.Forms.ToolTip(this.components);
            this.TextyMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Contents
            // 
            this.Contents.AcceptsTab = true;
            this.Contents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Contents.DetectUrls = false;
            this.Contents.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contents.HideSelection = false;
            this.Contents.Location = new System.Drawing.Point(5, 91);
            this.Contents.Name = "Contents";
            this.Contents.Size = new System.Drawing.Size(837, 485);
            this.Contents.TabIndex = 0;
            this.Contents.Text = "";
            this.Contents.WordWrap = false;
            this.Contents.TextChanged += new System.EventHandler(this.Contents_TextChanged);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.Location = new System.Drawing.Point(12, 596);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 21);
            this.StatusLabel.TabIndex = 5;
            // 
            // fontDialog
            // 
            this.fontDialog.Color = System.Drawing.SystemColors.ControlText;
            this.fontDialog.ShowApply = true;
            this.fontDialog.ShowColor = true;
            // 
            // SaveStatus
            // 
            this.SaveStatus.AutoSize = true;
            this.SaveStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveStatus.Location = new System.Drawing.Point(384, 596);
            this.SaveStatus.Name = "SaveStatus";
            this.SaveStatus.Size = new System.Drawing.Size(0, 21);
            this.SaveStatus.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(12, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 65);
            this.label1.TabIndex = 9;
            this.label1.Text = "Texty";
            // 
            // SaveTT
            // 
            this.SaveTT.AutomaticDelay = 0;
            this.SaveTT.IsBalloon = true;
            // 
            // SaveButton
            // 
            this.SaveButton.BackgroundImage = global::Texty.Properties.Resources.save;
            this.SaveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Location = new System.Drawing.Point(295, 12);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(43, 39);
            this.SaveButton.TabIndex = 2;
            this.SaveTT.SetToolTip(this.SaveButton, "Save Current File");
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SystemExplorer
            // 
            this.SystemExplorer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SystemExplorer.Location = new System.Drawing.Point(849, 91);
            this.SystemExplorer.Name = "SystemExplorer";
            this.SystemExplorer.Size = new System.Drawing.Size(204, 485);
            this.SystemExplorer.TabIndex = 15;
            this.SystemExplorer.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.SystemExplorer_AfterSelect);
            // 
            // FindBox
            // 
            this.FindBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FindBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindBox.Location = new System.Drawing.Point(529, 594);
            this.FindBox.Name = "FindBox";
            this.FindBox.Size = new System.Drawing.Size(177, 22);
            this.FindBox.TabIndex = 18;
            this.FindTT.SetToolTip(this.FindBox, "Search in Text");
            this.FindBox.TextChanged += new System.EventHandler(this.FindBox_TextChanged);
            // 
            // TextyMenu
            // 
            this.TextyMenu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TextyMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.TextyMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TextyMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.TextyMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.TextyMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.TextyMenu.Location = new System.Drawing.Point(16, 67);
            this.TextyMenu.Name = "TextyMenu";
            this.TextyMenu.Size = new System.Drawing.Size(251, 25);
            this.TextyMenu.TabIndex = 22;
            this.TextyMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem,
            this.newToolStripMenuItem,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(40, 21);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::Texty.Properties.Resources.save;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::Texty.Properties.Resources.opendoc;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = global::Texty.Properties.Resources._new;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = global::Texty.Properties.Resources.print;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::Texty.Properties.Resources.close;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator4,
            this.copyToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.delToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator3,
            this.findToolStripMenuItem,
            this.replaceToolStripMenuItem,
            this.toolStripSeparator5,
            this.timeDateToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(43, 21);
            this.editToolStripMenuItem.Text = "&Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click_1);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Image = global::Texty.Properties.Resources.undo;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.undoToolStripMenuItem.Text = "U&ndo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Image = global::Texty.Properties.Resources.redo;
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.redoToolStripMenuItem.Text = "Red&o";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(135, 6);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Enabled = false;
            this.copyToolStripMenuItem.Image = global::Texty.Properties.Resources.duplicate;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Enabled = false;
            this.cutToolStripMenuItem.Image = global::Texty.Properties.Resources.cut;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.cutToolStripMenuItem.Text = "C&ut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // delToolStripMenuItem
            // 
            this.delToolStripMenuItem.Enabled = false;
            this.delToolStripMenuItem.Image = global::Texty.Properties.Resources.trash;
            this.delToolStripMenuItem.Name = "delToolStripMenuItem";
            this.delToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.delToolStripMenuItem.Text = "Delete";
            this.delToolStripMenuItem.Click += new System.EventHandler(this.delToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = global::Texty.Properties.Resources.paste;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(135, 6);
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Image = global::Texty.Properties.Resources.find;
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.findToolStripMenuItem.Text = "Fin&d";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
            // 
            // replaceToolStripMenuItem
            // 
            this.replaceToolStripMenuItem.Image = global::Texty.Properties.Resources._ref;
            this.replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
            this.replaceToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.replaceToolStripMenuItem.Text = "Rep&lace";
            this.replaceToolStripMenuItem.Click += new System.EventHandler(this.replaceToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(135, 6);
            // 
            // timeDateToolStripMenuItem
            // 
            this.timeDateToolStripMenuItem.Image = global::Texty.Properties.Resources.time;
            this.timeDateToolStripMenuItem.Name = "timeDateToolStripMenuItem";
            this.timeDateToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.timeDateToolStripMenuItem.Text = "&Time/Date";
            this.timeDateToolStripMenuItem.Click += new System.EventHandler(this.timeDateToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomToolStripMenuItem,
            this.zoomOutToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(48, 21);
            this.viewToolStripMenuItem.Text = "Vi&ew";
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.Image = global::Texty.Properties.Resources.magnify;
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.zoomToolStripMenuItem.Text = "&Zoom In";
            this.zoomToolStripMenuItem.Click += new System.EventHandler(this.zoomToolStripMenuItem_Click);
            // 
            // zoomOutToolStripMenuItem
            // 
            this.zoomOutToolStripMenuItem.Image = global::Texty.Properties.Resources.zoomout;
            this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.zoomOutToolStripMenuItem.Text = "Zoom &Out";
            this.zoomOutToolStripMenuItem.Click += new System.EventHandler(this.zoomOutToolStripMenuItem_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.colorToolStripMenuItem,
            this.alignmentrToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(64, 21);
            this.formatToolStripMenuItem.Text = "&Format";
            this.formatToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Image = global::Texty.Properties.Resources.font_sel;
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.fontToolStripMenuItem.Text = "Fon&t";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.foregroundToolStripMenuItem,
            this.backgroundToolStripMenuItem});
            this.colorToolStripMenuItem.Image = global::Texty.Properties.Resources.palette;
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.colorToolStripMenuItem.Text = "Co&lor";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // foregroundToolStripMenuItem
            // 
            this.foregroundToolStripMenuItem.Image = global::Texty.Properties.Resources.fore;
            this.foregroundToolStripMenuItem.Name = "foregroundToolStripMenuItem";
            this.foregroundToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.foregroundToolStripMenuItem.Text = "&Foreground";
            this.foregroundToolStripMenuItem.Click += new System.EventHandler(this.foregroundToolStripMenuItem_Click);
            // 
            // backgroundToolStripMenuItem
            // 
            this.backgroundToolStripMenuItem.Image = global::Texty.Properties.Resources.bg;
            this.backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
            this.backgroundToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.backgroundToolStripMenuItem.Text = "&Background";
            this.backgroundToolStripMenuItem.Click += new System.EventHandler(this.backgroundToolStripMenuItem_Click);
            // 
            // alignmentrToolStripMenuItem
            // 
            this.alignmentrToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rightAlignToolStripMenuItem,
            this.leftAlignToolStripMenuItem,
            this.centerAlignToolStripMenuItem});
            this.alignmentrToolStripMenuItem.Image = global::Texty.Properties.Resources.align_justify_256;
            this.alignmentrToolStripMenuItem.Name = "alignmentrToolStripMenuItem";
            this.alignmentrToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.alignmentrToolStripMenuItem.Text = "&Alignment";
            this.alignmentrToolStripMenuItem.Click += new System.EventHandler(this.alignmentrToolStripMenuItem_Click);
            // 
            // rightAlignToolStripMenuItem
            // 
            this.rightAlignToolStripMenuItem.Image = global::Texty.Properties.Resources.align_right_256;
            this.rightAlignToolStripMenuItem.Name = "rightAlignToolStripMenuItem";
            this.rightAlignToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.rightAlignToolStripMenuItem.Text = "&Right Align";
            this.rightAlignToolStripMenuItem.Click += new System.EventHandler(this.rightAlignToolStripMenuItem_Click);
            // 
            // leftAlignToolStripMenuItem
            // 
            this.leftAlignToolStripMenuItem.Image = global::Texty.Properties.Resources.align_center_256;
            this.leftAlignToolStripMenuItem.Name = "leftAlignToolStripMenuItem";
            this.leftAlignToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.leftAlignToolStripMenuItem.Text = "&Left Align";
            this.leftAlignToolStripMenuItem.Click += new System.EventHandler(this.leftAlignToolStripMenuItem_Click);
            // 
            // centerAlignToolStripMenuItem
            // 
            this.centerAlignToolStripMenuItem.Image = global::Texty.Properties.Resources.align_left_256;
            this.centerAlignToolStripMenuItem.Name = "centerAlignToolStripMenuItem";
            this.centerAlignToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.centerAlignToolStripMenuItem.Text = "&Center Align";
            this.centerAlignToolStripMenuItem.Click += new System.EventHandler(this.centerAlignToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creditsToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(48, 21);
            this.aboutToolStripMenuItem.Text = "&Help";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.Image = global::Texty.Properties.Resources.credits;
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.creditsToolStripMenuItem.Text = "C&redits";
            this.creditsToolStripMenuItem.Click += new System.EventHandler(this.creditsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Image = global::Texty.Properties.Resources.about;
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.aboutToolStripMenuItem1.Text = "A&bout";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // ModeLabel
            // 
            this.ModeLabel.AutoSize = true;
            this.ModeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModeLabel.Location = new System.Drawing.Point(132, 50);
            this.ModeLabel.Name = "ModeLabel";
            this.ModeLabel.Size = new System.Drawing.Size(0, 13);
            this.ModeLabel.TabIndex = 23;
            // 
            // ReplaceBox
            // 
            this.ReplaceBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReplaceBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReplaceBox.Location = new System.Drawing.Point(727, 593);
            this.ReplaceBox.Name = "ReplaceBox";
            this.ReplaceBox.Size = new System.Drawing.Size(177, 22);
            this.ReplaceBox.TabIndex = 25;
            this.ReplaceTT.SetToolTip(this.ReplaceBox, "Replace Text");
            this.ReplaceBox.TextChanged += new System.EventHandler(this.ReplaceBox_TextChanged);
            /*
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1061, 627);
            this.shapeContainer1.TabIndex = 26;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape1.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rectangleShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.rectangleShape1.FillColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rectangleShape1.Location = new System.Drawing.Point(-1, 11);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.SelectionColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rectangleShape1.Size = new System.Drawing.Size(12, 38);
             */
            // 
            // Doc1
            // 
            this.Doc1.AutoSize = true;
            this.Doc1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Doc1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doc1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Doc1.Location = new System.Drawing.Point(845, 67);
            this.Doc1.Name = "Doc1";
            this.Doc1.Size = new System.Drawing.Size(43, 21);
            this.Doc1.TabIndex = 14;
            this.Doc1.Text = "New";
            // 
            // UnderlineButton
            // 
            this.UnderlineButton.BackgroundImage = global::Texty.Properties.Resources.underline;
            this.UnderlineButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UnderlineButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UnderlineButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.UnderlineButton.FlatAppearance.BorderSize = 0;
            this.UnderlineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnderlineButton.Location = new System.Drawing.Point(660, 12);
            this.UnderlineButton.Name = "UnderlineButton";
            this.UnderlineButton.Size = new System.Drawing.Size(44, 39);
            this.UnderlineButton.TabIndex = 29;
            this.UnderlineTT.SetToolTip(this.UnderlineButton, "Underline selected text");
            this.UnderlineButton.UseVisualStyleBackColor = true;
            this.UnderlineButton.Click += new System.EventHandler(this.UnderlineButton_Click);
            // 
            // ItalicsButton
            // 
            this.ItalicsButton.BackgroundImage = global::Texty.Properties.Resources.italics;
            this.ItalicsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ItalicsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ItalicsButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.ItalicsButton.FlatAppearance.BorderSize = 0;
            this.ItalicsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItalicsButton.Location = new System.Drawing.Point(611, 12);
            this.ItalicsButton.Name = "ItalicsButton";
            this.ItalicsButton.Size = new System.Drawing.Size(44, 39);
            this.ItalicsButton.TabIndex = 28;
            this.ItalicsButton.UseVisualStyleBackColor = true;
            this.ItalicsButton.Click += new System.EventHandler(this.ItalicsButton_Click);
            // 
            // BoldButton
            // 
            this.BoldButton.BackgroundImage = global::Texty.Properties.Resources.bold;
            this.BoldButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BoldButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BoldButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.BoldButton.FlatAppearance.BorderSize = 0;
            this.BoldButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BoldButton.Location = new System.Drawing.Point(558, 12);
            this.BoldButton.Name = "BoldButton";
            this.BoldButton.Size = new System.Drawing.Size(44, 39);
            this.BoldButton.TabIndex = 27;
            this.BoldButton.UseVisualStyleBackColor = true;
            this.BoldButton.Click += new System.EventHandler(this.BoldButton_Click);
            // 
            // ReplaceButton
            // 
            this.ReplaceButton.BackColor = System.Drawing.Color.White;
            this.ReplaceButton.BackgroundImage = global::Texty.Properties.Resources._ref;
            this.ReplaceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ReplaceButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReplaceButton.Enabled = false;
            this.ReplaceButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.ReplaceButton.FlatAppearance.BorderSize = 0;
            this.ReplaceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReplaceButton.Location = new System.Drawing.Point(885, 594);
            this.ReplaceButton.Name = "ReplaceButton";
            this.ReplaceButton.Size = new System.Drawing.Size(19, 21);
            this.ReplaceButton.TabIndex = 24;
            this.ReplaceButton.UseVisualStyleBackColor = false;
            this.ReplaceButton.Click += new System.EventHandler(this.ReplaceButton_Click);
            // 
            // CopyButton
            // 
            this.CopyButton.BackgroundImage = global::Texty.Properties.Resources.duplicate;
            this.CopyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CopyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CopyButton.Enabled = false;
            this.CopyButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.CopyButton.FlatAppearance.BorderSize = 0;
            this.CopyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CopyButton.Location = new System.Drawing.Point(919, 582);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(44, 39);
            this.CopyButton.TabIndex = 21;
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackgroundImage = global::Texty.Properties.Resources.settings;
            this.SettingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Location = new System.Drawing.Point(909, 2);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(34, 29);
            this.SettingsButton.TabIndex = 20;
            this.SettingsTT.SetToolTip(this.SettingsButton, "Open settings panel");
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // FindButton
            // 
            this.FindButton.BackColor = System.Drawing.Color.White;
            this.FindButton.BackgroundImage = global::Texty.Properties.Resources.find;
            this.FindButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FindButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FindButton.Enabled = false;
            this.FindButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.FindButton.FlatAppearance.BorderSize = 0;
            this.FindButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindButton.Location = new System.Drawing.Point(702, 594);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(19, 22);
            this.FindButton.TabIndex = 11;
            this.FindButton.UseVisualStyleBackColor = false;
            this.FindButton.Click += new System.EventHandler(this.FindReplace_Click);
            // 
            // PasteButton
            // 
            this.PasteButton.BackgroundImage = global::Texty.Properties.Resources.paste;
            this.PasteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PasteButton.FlatAppearance.BorderSize = 0;
            this.PasteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasteButton.Location = new System.Drawing.Point(1007, 584);
            this.PasteButton.Name = "PasteButton";
            this.PasteButton.Size = new System.Drawing.Size(50, 33);
            this.PasteButton.TabIndex = 17;
            this.PasteButton.UseVisualStyleBackColor = true;
            this.PasteButton.Click += new System.EventHandler(this.PasteButton_Click);
            // 
            // CutButton
            // 
            this.CutButton.BackgroundImage = global::Texty.Properties.Resources.cut;
            this.CutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CutButton.Enabled = false;
            this.CutButton.FlatAppearance.BorderSize = 0;
            this.CutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CutButton.Location = new System.Drawing.Point(962, 584);
            this.CutButton.Name = "CutButton";
            this.CutButton.Size = new System.Drawing.Size(50, 33);
            this.CutButton.TabIndex = 16;
            this.CutButton.UseVisualStyleBackColor = true;
            this.CutButton.Click += new System.EventHandler(this.CutButton_Click);
            // 
            // Minimise
            // 
            this.Minimise.BackgroundImage = global::Texty.Properties.Resources.min;
            this.Minimise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Minimise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimise.FlatAppearance.BorderSize = 0;
            this.Minimise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimise.Location = new System.Drawing.Point(960, 2);
            this.Minimise.Name = "Minimise";
            this.Minimise.Size = new System.Drawing.Size(35, 29);
            this.Minimise.TabIndex = 10;
            this.Minimise.UseVisualStyleBackColor = true;
            this.Minimise.Click += new System.EventHandler(this.Minimise_Click);
            // 
            // NewContent
            // 
            this.NewContent.BackgroundImage = global::Texty.Properties.Resources._new;
            this.NewContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NewContent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewContent.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.NewContent.FlatAppearance.BorderSize = 0;
            this.NewContent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewContent.Location = new System.Drawing.Point(432, 12);
            this.NewContent.Name = "NewContent";
            this.NewContent.Size = new System.Drawing.Size(42, 39);
            this.NewContent.TabIndex = 7;
            this.NewTT.SetToolTip(this.NewContent, "Open new document (in Rich Text Mode)");
            this.NewContent.UseVisualStyleBackColor = true;
            this.NewContent.Click += new System.EventHandler(this.NewContent_Click);
            // 
            // FontSelection
            // 
            this.FontSelection.BackgroundImage = global::Texty.Properties.Resources.text;
            this.FontSelection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FontSelection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FontSelection.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.FontSelection.FlatAppearance.BorderSize = 0;
            this.FontSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FontSelection.Location = new System.Drawing.Point(496, 12);
            this.FontSelection.Name = "FontSelection";
            this.FontSelection.Size = new System.Drawing.Size(44, 39);
            this.FontSelection.TabIndex = 6;
            this.FontTT.SetToolTip(this.FontSelection, "Change Font");
            this.FontSelection.UseVisualStyleBackColor = true;
            this.FontSelection.Click += new System.EventHandler(this.FontSelection_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackgroundImage = global::Texty.Properties.Resources.close;
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Location = new System.Drawing.Point(1011, 2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(38, 29);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.BackgroundImage = global::Texty.Properties.Resources.opendoc;
            this.OpenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OpenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.OpenButton.FlatAppearance.BorderSize = 0;
            this.OpenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenButton.Location = new System.Drawing.Point(366, 12);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(42, 39);
            this.OpenButton.TabIndex = 3;
            this.OpenTT.SetToolTip(this.OpenButton, "Open an existing document");
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // FindTT
            // 
            this.FindTT.AutomaticDelay = 0;
            this.FindTT.IsBalloon = true;
            // 
            // ReplaceTT
            // 
            this.ReplaceTT.AutomaticDelay = 0;
            this.ReplaceTT.IsBalloon = true;
            // 
            // FontTT
            // 
            this.FontTT.AutomaticDelay = 0;
            this.FontTT.IsBalloon = true;
            // 
            // OpenTT
            // 
            this.OpenTT.AutomaticDelay = 0;
            this.OpenTT.IsBalloon = true;
            // 
            // NewTT
            // 
            this.NewTT.AutomaticDelay = 0;
            this.NewTT.IsBalloon = true;
            // 
            // BoldTT
            // 
            this.BoldTT.AutomaticDelay = 0;
            this.BoldTT.IsBalloon = true;
            // 
            // UnderlineTT
            // 
            this.UnderlineTT.AutomaticDelay = 0;
            this.UnderlineTT.IsBalloon = true;
            // 
            // SettingsTT
            // 
            this.SettingsTT.AutomaticDelay = 0;
            this.SettingsTT.IsBalloon = true;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1061, 627);
            this.Controls.Add(this.ReplaceButton);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.UnderlineButton);
            this.Controls.Add(this.ItalicsButton);
            this.Controls.Add(this.BoldButton);
            this.Controls.Add(this.ReplaceBox);
            this.Controls.Add(this.ModeLabel);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.FindBox);
            this.Controls.Add(this.PasteButton);
            this.Controls.Add(this.CutButton);
            this.Controls.Add(this.SystemExplorer);
            this.Controls.Add(this.Doc1);
            this.Controls.Add(this.Contents);
            this.Controls.Add(this.Minimise);
            this.Controls.Add(this.SaveStatus);
            this.Controls.Add(this.NewContent);
            this.Controls.Add(this.FontSelection);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.TextyMenu);
            this.Controls.Add(this.label1);
            //this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.TextyMenu;
            this.Name = "MainView";
            this.Text = "Texty";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.TextyMenu.ResumeLayout(false);
            this.TextyMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
            int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        //call functions to move the form in your form's MouseDown event
        private void MainView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion

        public System.Windows.Forms.RichTextBox Contents;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.Button FontSelection;
        private System.Windows.Forms.Button NewContent;
        private System.Windows.Forms.Label SaveStatus;
        private System.Windows.Forms.Label label1;
        private Button Minimise;
        private Button FindButton;
        private ToolTip SaveTT;
        private TreeView SystemExplorer;
        private Button CutButton;
        private Button PasteButton;
        private TextBox FindBox;
        private Button SettingsButton;
        private Button CopyButton;
        private MenuStrip TextyMenu;
        private Label ModeLabel;
        private Button ReplaceButton;
        private TextBox ReplaceBox;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem findToolStripMenuItem;
        private ToolStripMenuItem replaceToolStripMenuItem;
        private ToolStripMenuItem zoomToolStripMenuItem;
        private ToolStripMenuItem creditsToolStripMenuItem;
        //private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        //private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Label Doc1;
        private ToolStripMenuItem aboutToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem printToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem zoomOutToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem alignmentrToolStripMenuItem;
        private ToolStripMenuItem rightAlignToolStripMenuItem;
        private ToolStripMenuItem leftAlignToolStripMenuItem;
        private ToolStripMenuItem centerAlignToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem timeDateToolStripMenuItem;
        private ToolStripMenuItem foregroundToolStripMenuItem;
        private ToolStripMenuItem backgroundToolStripMenuItem;
        private Button BoldButton;
        private Button ItalicsButton;
        private Button UnderlineButton;
        private ToolStripMenuItem delToolStripMenuItem;
        private ToolTip FindTT;
        private ToolTip ReplaceTT;
        private ToolTip FontTT;
        private ToolTip OpenTT;
        private ToolTip NewTT;
        private ToolTip BoldTT;
        private ToolTip UnderlineTT;
        private ToolTip SettingsTT;
    }
}

