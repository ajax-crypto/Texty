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
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveTT = new System.Windows.Forms.ToolTip(this.components);
            this.SaveButton = new System.Windows.Forms.Button();
            this.ModeLabel = new System.Windows.Forms.Label();
            this.Doc1 = new System.Windows.Forms.Label();
            this.FindTT = new System.Windows.Forms.ToolTip(this.components);
            this.FindBox = new System.Windows.Forms.TextBox();
            this.ReplaceTT = new System.Windows.Forms.ToolTip(this.components);
            this.ReplaceBox = new System.Windows.Forms.TextBox();
            this.FontTT = new System.Windows.Forms.ToolTip(this.components);
            this.FontSelection = new System.Windows.Forms.Button();
            this.OpenTT = new System.Windows.Forms.ToolTip(this.components);
            this.OpenButton = new System.Windows.Forms.Button();
            this.NewTT = new System.Windows.Forms.ToolTip(this.components);
            this.NewContent = new System.Windows.Forms.Button();
            this.BoldTT = new System.Windows.Forms.ToolTip(this.components);
            this.UnderlineTT = new System.Windows.Forms.ToolTip(this.components);
            this.UnderlineButton = new System.Windows.Forms.Button();
            this.SettingsTT = new System.Windows.Forms.ToolTip(this.components);
            this.SettingsButton = new System.Windows.Forms.Button();
            this.MainContainer = new System.Windows.Forms.SplitContainer();
            this.FindReplacePanel = new System.Windows.Forms.Panel();
            this.ReplaceAllBox = new System.Windows.Forms.CheckBox();
            this.MatchCaseBox = new System.Windows.Forms.CheckBox();
            this.ReplaceButton = new System.Windows.Forms.Button();
            this.FindButton = new System.Windows.Forms.Button();
            this.Contents = new System.Windows.Forms.RichTextBox();
            this.SidePanelContainer = new System.Windows.Forms.SplitContainer();
            this.OpenedFilesListBox = new System.Windows.Forms.ListBox();
            this.SystemExplorer = new System.Windows.Forms.TreeView();
            this.AppStatus = new System.Windows.Forms.StatusStrip();
            this.WCStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.LCStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.SaveStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.TextyMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exportToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hTMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.readOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordWrapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.FindTopButton = new System.Windows.Forms.Button();
            this.ItalicsButton = new System.Windows.Forms.Button();
            this.BoldButton = new System.Windows.Forms.Button();
            this.Minimise = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainContainer)).BeginInit();
            this.MainContainer.Panel1.SuspendLayout();
            this.MainContainer.Panel2.SuspendLayout();
            this.MainContainer.SuspendLayout();
            this.FindReplacePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SidePanelContainer)).BeginInit();
            this.SidePanelContainer.Panel1.SuspendLayout();
            this.SidePanelContainer.Panel2.SuspendLayout();
            this.SidePanelContainer.SuspendLayout();
            this.AppStatus.SuspendLayout();
            this.TextyMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // fontDialog
            // 
            this.fontDialog.Color = System.Drawing.SystemColors.ControlText;
            this.fontDialog.ShowApply = true;
            this.fontDialog.ShowColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(16, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 47);
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
            this.SaveButton.Location = new System.Drawing.Point(262, 10);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(43, 39);
            this.SaveButton.TabIndex = 2;
            this.SaveTT.SetToolTip(this.SaveButton, "Save Current File");
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
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
            // Doc1
            // 
            this.Doc1.AutoSize = true;
            this.Doc1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Doc1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doc1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Doc1.Location = new System.Drawing.Point(822, 576);
            this.Doc1.Name = "Doc1";
            this.Doc1.Size = new System.Drawing.Size(35, 17);
            this.Doc1.TabIndex = 14;
            this.Doc1.Text = "New";
            // 
            // FindTT
            // 
            this.FindTT.AutomaticDelay = 0;
            this.FindTT.IsBalloon = true;
            // 
            // FindBox
            // 
            this.FindBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FindBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindBox.Location = new System.Drawing.Point(3, 7);
            this.FindBox.Name = "FindBox";
            this.FindBox.Size = new System.Drawing.Size(218, 22);
            this.FindBox.TabIndex = 20;
            this.FindTT.SetToolTip(this.FindBox, "Search in Text");
            // 
            // ReplaceTT
            // 
            this.ReplaceTT.AutomaticDelay = 0;
            this.ReplaceTT.IsBalloon = true;
            // 
            // ReplaceBox
            // 
            this.ReplaceBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReplaceBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReplaceBox.Location = new System.Drawing.Point(3, 35);
            this.ReplaceBox.Name = "ReplaceBox";
            this.ReplaceBox.Size = new System.Drawing.Size(218, 22);
            this.ReplaceBox.TabIndex = 27;
            this.ReplaceTT.SetToolTip(this.ReplaceBox, "Replace Text");
            // 
            // FontTT
            // 
            this.FontTT.AutomaticDelay = 0;
            this.FontTT.IsBalloon = true;
            // 
            // FontSelection
            // 
            this.FontSelection.BackgroundImage = global::Texty.Properties.Resources.text;
            this.FontSelection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FontSelection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FontSelection.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.FontSelection.FlatAppearance.BorderSize = 0;
            this.FontSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FontSelection.Location = new System.Drawing.Point(463, 12);
            this.FontSelection.Name = "FontSelection";
            this.FontSelection.Size = new System.Drawing.Size(44, 39);
            this.FontSelection.TabIndex = 6;
            this.FontTT.SetToolTip(this.FontSelection, "Change Font");
            this.FontSelection.UseVisualStyleBackColor = true;
            this.FontSelection.Click += new System.EventHandler(this.FontSelection_Click);
            // 
            // OpenTT
            // 
            this.OpenTT.AutomaticDelay = 0;
            this.OpenTT.IsBalloon = true;
            // 
            // OpenButton
            // 
            this.OpenButton.BackgroundImage = global::Texty.Properties.Resources.opendoc;
            this.OpenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OpenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.OpenButton.FlatAppearance.BorderSize = 0;
            this.OpenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenButton.Location = new System.Drawing.Point(333, 12);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(42, 39);
            this.OpenButton.TabIndex = 3;
            this.OpenTT.SetToolTip(this.OpenButton, "Open an existing document");
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // NewTT
            // 
            this.NewTT.AutomaticDelay = 0;
            this.NewTT.IsBalloon = true;
            // 
            // NewContent
            // 
            this.NewContent.BackgroundImage = global::Texty.Properties.Resources._new;
            this.NewContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NewContent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewContent.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.NewContent.FlatAppearance.BorderSize = 0;
            this.NewContent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewContent.Location = new System.Drawing.Point(399, 12);
            this.NewContent.Name = "NewContent";
            this.NewContent.Size = new System.Drawing.Size(42, 39);
            this.NewContent.TabIndex = 7;
            this.NewTT.SetToolTip(this.NewContent, "Open new document (in Rich Text Mode)");
            this.NewContent.UseVisualStyleBackColor = true;
            this.NewContent.Click += new System.EventHandler(this.NewContent_Click);
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
            // UnderlineButton
            // 
            this.UnderlineButton.BackgroundImage = global::Texty.Properties.Resources.underline;
            this.UnderlineButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UnderlineButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UnderlineButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.UnderlineButton.FlatAppearance.BorderSize = 0;
            this.UnderlineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnderlineButton.Location = new System.Drawing.Point(637, 12);
            this.UnderlineButton.Name = "UnderlineButton";
            this.UnderlineButton.Size = new System.Drawing.Size(44, 39);
            this.UnderlineButton.TabIndex = 29;
            this.UnderlineTT.SetToolTip(this.UnderlineButton, "Underline selected text");
            this.UnderlineButton.UseVisualStyleBackColor = true;
            this.UnderlineButton.Click += new System.EventHandler(this.UnderlineButton_Click);
            // 
            // SettingsTT
            // 
            this.SettingsTT.AutomaticDelay = 0;
            this.SettingsTT.IsBalloon = true;
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
            // MainContainer
            // 
            this.MainContainer.Location = new System.Drawing.Point(5, 91);
            this.MainContainer.Name = "MainContainer";
            // 
            // MainContainer.Panel1
            // 
            this.MainContainer.Panel1.Controls.Add(this.FindReplacePanel);
            this.MainContainer.Panel1.Controls.Add(this.Contents);
            // 
            // MainContainer.Panel2
            // 
            this.MainContainer.Panel2.Controls.Add(this.SidePanelContainer);
            this.MainContainer.Size = new System.Drawing.Size(1052, 485);
            this.MainContainer.SplitterDistance = 812;
            this.MainContainer.TabIndex = 30;
            // 
            // FindReplacePanel
            // 
            this.FindReplacePanel.Controls.Add(this.ReplaceAllBox);
            this.FindReplacePanel.Controls.Add(this.MatchCaseBox);
            this.FindReplacePanel.Controls.Add(this.ReplaceButton);
            this.FindReplacePanel.Controls.Add(this.ReplaceBox);
            this.FindReplacePanel.Controls.Add(this.FindButton);
            this.FindReplacePanel.Controls.Add(this.FindBox);
            this.FindReplacePanel.Location = new System.Drawing.Point(588, 0);
            this.FindReplacePanel.Name = "FindReplacePanel";
            this.FindReplacePanel.Size = new System.Drawing.Size(224, 92);
            this.FindReplacePanel.TabIndex = 2;
            this.FindReplacePanel.Visible = false;
            // 
            // ReplaceAllBox
            // 
            this.ReplaceAllBox.AutoSize = true;
            this.ReplaceAllBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReplaceAllBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReplaceAllBox.Location = new System.Drawing.Point(116, 63);
            this.ReplaceAllBox.Name = "ReplaceAllBox";
            this.ReplaceAllBox.Size = new System.Drawing.Size(89, 21);
            this.ReplaceAllBox.TabIndex = 29;
            this.ReplaceAllBox.Text = "Replace All";
            this.ReplaceAllBox.UseVisualStyleBackColor = true;
            // 
            // MatchCaseBox
            // 
            this.MatchCaseBox.AutoSize = true;
            this.MatchCaseBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MatchCaseBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatchCaseBox.Location = new System.Drawing.Point(18, 63);
            this.MatchCaseBox.Name = "MatchCaseBox";
            this.MatchCaseBox.Size = new System.Drawing.Size(94, 21);
            this.MatchCaseBox.TabIndex = 28;
            this.MatchCaseBox.Text = "Match Case";
            this.MatchCaseBox.UseVisualStyleBackColor = true;
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
            this.ReplaceButton.Location = new System.Drawing.Point(202, 35);
            this.ReplaceButton.Name = "ReplaceButton";
            this.ReplaceButton.Size = new System.Drawing.Size(19, 21);
            this.ReplaceButton.TabIndex = 26;
            this.ReplaceButton.UseVisualStyleBackColor = false;
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
            this.FindButton.Location = new System.Drawing.Point(202, 7);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(19, 22);
            this.FindButton.TabIndex = 19;
            this.FindButton.UseVisualStyleBackColor = false;
            // 
            // Contents
            // 
            this.Contents.AcceptsTab = true;
            this.Contents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Contents.DetectUrls = false;
            this.Contents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contents.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contents.HideSelection = false;
            this.Contents.Location = new System.Drawing.Point(0, 0);
            this.Contents.Name = "Contents";
            this.Contents.Size = new System.Drawing.Size(812, 485);
            this.Contents.TabIndex = 1;
            this.Contents.Text = "";
            this.Contents.WordWrap = false;
            // 
            // SidePanelContainer
            // 
            this.SidePanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SidePanelContainer.Location = new System.Drawing.Point(0, 0);
            this.SidePanelContainer.Name = "SidePanelContainer";
            this.SidePanelContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SidePanelContainer.Panel1
            // 
            this.SidePanelContainer.Panel1.Controls.Add(this.OpenedFilesListBox);
            // 
            // SidePanelContainer.Panel2
            // 
            this.SidePanelContainer.Panel2.Controls.Add(this.SystemExplorer);
            this.SidePanelContainer.Size = new System.Drawing.Size(236, 485);
            this.SidePanelContainer.SplitterDistance = 242;
            this.SidePanelContainer.TabIndex = 17;
            // 
            // OpenedFilesListBox
            // 
            this.OpenedFilesListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OpenedFilesListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OpenedFilesListBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenedFilesListBox.FormattingEnabled = true;
            this.OpenedFilesListBox.ItemHeight = 17;
            this.OpenedFilesListBox.Location = new System.Drawing.Point(0, 0);
            this.OpenedFilesListBox.Name = "OpenedFilesListBox";
            this.OpenedFilesListBox.Size = new System.Drawing.Size(236, 242);
            this.OpenedFilesListBox.TabIndex = 0;
            this.OpenedFilesListBox.SelectedIndexChanged += new System.EventHandler(this.OpenedFilesListBox_SelectedIndexChanged);
            // 
            // SystemExplorer
            // 
            this.SystemExplorer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SystemExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SystemExplorer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SystemExplorer.Location = new System.Drawing.Point(0, 0);
            this.SystemExplorer.Name = "SystemExplorer";
            this.SystemExplorer.Size = new System.Drawing.Size(236, 239);
            this.SystemExplorer.TabIndex = 17;
            // 
            // AppStatus
            // 
            this.AppStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AppStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.AppStatus.Dock = System.Windows.Forms.DockStyle.None;
            this.AppStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppStatus.GripMargin = new System.Windows.Forms.Padding(0);
            this.AppStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WCStatusLabel,
            this.LCStatusLabel,
            this.SaveStatus});
            this.AppStatus.Location = new System.Drawing.Point(8, 575);
            this.AppStatus.Name = "AppStatus";
            this.AppStatus.Size = new System.Drawing.Size(156, 22);
            this.AppStatus.TabIndex = 31;
            // 
            // WCStatusLabel
            // 
            this.WCStatusLabel.Name = "WCStatusLabel";
            this.WCStatusLabel.Size = new System.Drawing.Size(55, 17);
            this.WCStatusLabel.Text = "Words :";
            // 
            // LCStatusLabel
            // 
            this.LCStatusLabel.Name = "LCStatusLabel";
            this.LCStatusLabel.Size = new System.Drawing.Size(49, 17);
            this.LCStatusLabel.Text = "Lines : ";
            // 
            // SaveStatus
            // 
            this.SaveStatus.Name = "SaveStatus";
            this.SaveStatus.Size = new System.Drawing.Size(35, 17);
            this.SaveStatus.Text = "New";
            // 
            // TextyMenu
            // 
            this.TextyMenu.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.TextyMenu.Location = new System.Drawing.Point(5, 66);
            this.TextyMenu.Name = "TextyMenu";
            this.TextyMenu.Size = new System.Drawing.Size(251, 25);
            this.TextyMenu.TabIndex = 32;
            this.TextyMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem,
            this.newToolStripMenuItem,
            this.recentToolStripMenuItem,
            this.toolStripSeparator1,
            this.exportToToolStripMenuItem,
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
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::Texty.Properties.Resources.opendoc;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = global::Texty.Properties.Resources._new;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // recentToolStripMenuItem
            // 
            this.recentToolStripMenuItem.Image = global::Texty.Properties.Resources.overview_pages_1_2561;
            this.recentToolStripMenuItem.Name = "recentToolStripMenuItem";
            this.recentToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.recentToolStripMenuItem.Text = "&Recent";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(132, 6);
            // 
            // exportToToolStripMenuItem
            // 
            this.exportToToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pDFToolStripMenuItem,
            this.hTMLToolStripMenuItem});
            this.exportToToolStripMenuItem.Name = "exportToToolStripMenuItem";
            this.exportToToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.exportToToolStripMenuItem.Text = "&Export To";
            // 
            // pDFToolStripMenuItem
            // 
            this.pDFToolStripMenuItem.Name = "pDFToolStripMenuItem";
            this.pDFToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.pDFToolStripMenuItem.Text = "&PDF";
            this.pDFToolStripMenuItem.Click += new System.EventHandler(this.pDFToolStripMenuItem_Click);
            // 
            // hTMLToolStripMenuItem
            // 
            this.hTMLToolStripMenuItem.Name = "hTMLToolStripMenuItem";
            this.hTMLToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.hTMLToolStripMenuItem.Text = "&HTML";
            this.hTMLToolStripMenuItem.Click += new System.EventHandler(this.hTMLToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = global::Texty.Properties.Resources.print;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(132, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::Texty.Properties.Resources.close;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
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
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Image = global::Texty.Properties.Resources.undo;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.undoToolStripMenuItem.Text = "U&ndo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Image = global::Texty.Properties.Resources.redo;
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.redoToolStripMenuItem.Text = "Red&o";
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
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Enabled = false;
            this.cutToolStripMenuItem.Image = global::Texty.Properties.Resources.cut;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.cutToolStripMenuItem.Text = "C&ut";
            // 
            // delToolStripMenuItem
            // 
            this.delToolStripMenuItem.Enabled = false;
            this.delToolStripMenuItem.Image = global::Texty.Properties.Resources.trash;
            this.delToolStripMenuItem.Name = "delToolStripMenuItem";
            this.delToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.delToolStripMenuItem.Text = "Delete";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = global::Texty.Properties.Resources.paste;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
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
            // 
            // replaceToolStripMenuItem
            // 
            this.replaceToolStripMenuItem.Image = global::Texty.Properties.Resources._ref;
            this.replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
            this.replaceToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.replaceToolStripMenuItem.Text = "Rep&lace";
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
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomToolStripMenuItem,
            this.zoomOutToolStripMenuItem,
            this.readOnlyToolStripMenuItem,
            this.wordWrapToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(48, 21);
            this.viewToolStripMenuItem.Text = "Vi&ew";
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.Image = global::Texty.Properties.Resources.magnify;
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.zoomToolStripMenuItem.Text = "&Zoom In";
            // 
            // zoomOutToolStripMenuItem
            // 
            this.zoomOutToolStripMenuItem.Image = global::Texty.Properties.Resources.zoomout;
            this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.zoomOutToolStripMenuItem.Text = "Zoom &Out";
            // 
            // readOnlyToolStripMenuItem
            // 
            this.readOnlyToolStripMenuItem.Name = "readOnlyToolStripMenuItem";
            this.readOnlyToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.readOnlyToolStripMenuItem.Text = "&Read Only";
            // 
            // wordWrapToolStripMenuItem
            // 
            this.wordWrapToolStripMenuItem.Name = "wordWrapToolStripMenuItem";
            this.wordWrapToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.wordWrapToolStripMenuItem.Text = "&Word Wrap";
            this.wordWrapToolStripMenuItem.Click += new System.EventHandler(this.wordWrapToolStripMenuItem_Click);
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
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Image = global::Texty.Properties.Resources.font_sel;
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.fontToolStripMenuItem.Text = "Fon&t";
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
            // 
            // foregroundToolStripMenuItem
            // 
            this.foregroundToolStripMenuItem.Image = global::Texty.Properties.Resources.fore;
            this.foregroundToolStripMenuItem.Name = "foregroundToolStripMenuItem";
            this.foregroundToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.foregroundToolStripMenuItem.Text = "&Foreground";
            // 
            // backgroundToolStripMenuItem
            // 
            this.backgroundToolStripMenuItem.Image = global::Texty.Properties.Resources.bg;
            this.backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
            this.backgroundToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.backgroundToolStripMenuItem.Text = "&Background";
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
            // 
            // rightAlignToolStripMenuItem
            // 
            this.rightAlignToolStripMenuItem.Image = global::Texty.Properties.Resources.align_right_256;
            this.rightAlignToolStripMenuItem.Name = "rightAlignToolStripMenuItem";
            this.rightAlignToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.rightAlignToolStripMenuItem.Text = "&Right Align";
            // 
            // leftAlignToolStripMenuItem
            // 
            this.leftAlignToolStripMenuItem.Image = global::Texty.Properties.Resources.align_center_256;
            this.leftAlignToolStripMenuItem.Name = "leftAlignToolStripMenuItem";
            this.leftAlignToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.leftAlignToolStripMenuItem.Text = "&Left Align";
            // 
            // centerAlignToolStripMenuItem
            // 
            this.centerAlignToolStripMenuItem.Image = global::Texty.Properties.Resources.align_left_256;
            this.centerAlignToolStripMenuItem.Name = "centerAlignToolStripMenuItem";
            this.centerAlignToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.centerAlignToolStripMenuItem.Text = "&Center Align";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creditsToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(48, 21);
            this.aboutToolStripMenuItem.Text = "&Help";
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.Image = global::Texty.Properties.Resources.credits;
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.creditsToolStripMenuItem.Text = "C&redits";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Image = global::Texty.Properties.Resources.about;
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.aboutToolStripMenuItem1.Text = "A&bout";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1061, 600);
            this.shapeContainer1.TabIndex = 33;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.FillColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleShape1.Location = new System.Drawing.Point(1, 12);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(9, 39);
            // 
            // FindTopButton
            // 
            this.FindTopButton.BackgroundImage = global::Texty.Properties.Resources.find;
            this.FindTopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FindTopButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FindTopButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.FindTopButton.FlatAppearance.BorderSize = 0;
            this.FindTopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindTopButton.Location = new System.Drawing.Point(700, 11);
            this.FindTopButton.Name = "FindTopButton";
            this.FindTopButton.Size = new System.Drawing.Size(44, 39);
            this.FindTopButton.TabIndex = 34;
            this.FindTopButton.UseVisualStyleBackColor = true;
            this.FindTopButton.Click += new System.EventHandler(this.FindTopButton_Click);
            // 
            // ItalicsButton
            // 
            this.ItalicsButton.BackgroundImage = global::Texty.Properties.Resources.italics;
            this.ItalicsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ItalicsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ItalicsButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.ItalicsButton.FlatAppearance.BorderSize = 0;
            this.ItalicsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItalicsButton.Location = new System.Drawing.Point(580, 12);
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
            this.BoldButton.Location = new System.Drawing.Point(525, 12);
            this.BoldButton.Name = "BoldButton";
            this.BoldButton.Size = new System.Drawing.Size(44, 39);
            this.BoldButton.TabIndex = 27;
            this.BoldButton.UseVisualStyleBackColor = true;
            this.BoldButton.Click += new System.EventHandler(this.BoldButton_Click);
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
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1061, 600);
            this.Controls.Add(this.Doc1);
            this.Controls.Add(this.FindTopButton);
            this.Controls.Add(this.TextyMenu);
            this.Controls.Add(this.MainContainer);
            this.Controls.Add(this.UnderlineButton);
            this.Controls.Add(this.ItalicsButton);
            this.Controls.Add(this.BoldButton);
            this.Controls.Add(this.ModeLabel);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.Minimise);
            this.Controls.Add(this.NewContent);
            this.Controls.Add(this.FontSelection);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AppStatus);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainView";
            this.Text = "Texty";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.MainContainer.Panel1.ResumeLayout(false);
            this.MainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainContainer)).EndInit();
            this.MainContainer.ResumeLayout(false);
            this.FindReplacePanel.ResumeLayout(false);
            this.FindReplacePanel.PerformLayout();
            this.SidePanelContainer.Panel1.ResumeLayout(false);
            this.SidePanelContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SidePanelContainer)).EndInit();
            this.SidePanelContainer.ResumeLayout(false);
            this.AppStatus.ResumeLayout(false);
            this.AppStatus.PerformLayout();
            this.TextyMenu.ResumeLayout(false);
            this.TextyMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        #region Native Hooks

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
            int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void MainView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern int SendMessageB(IntPtr hWnd, uint msg, int wParam, ref POINT lp);
        
        int updating = 0;
        int OldEventMask = 0;
        const uint EM_GETSCROLLPOS = 0x0400 + 221;
        const uint EM_SETSCROLLPOS = 0x0400 + 222;
        const int EM_SETEVENTMASK = 1073;
        const int WM_SETREDRAW = 11;
        struct POINT
        {
            public long X;
            public long Y;
        }

        POINT ScrollPosition = new POINT();

        public void BeginUpdate()
        {
            ++updating;
            if (updating > 1)
            {
                return;
            }
            SendMessageB(Contents.Handle, EM_GETSCROLLPOS, 0, ref ScrollPosition);
            OldEventMask = SendMessage(Contents.Handle, EM_SETEVENTMASK, 0, 0);
            SendMessage(Contents.Handle, WM_SETREDRAW, 0, 0);
        }

        public void EndUpdate()
        {
            --updating;
            if (updating > 0)
            {
                return;
            }
            SendMessageB(Contents.Handle, EM_SETSCROLLPOS, 0, ref ScrollPosition);
            SendMessage(Contents.Handle, WM_SETREDRAW, 1, 0);
            SendMessage(Contents.Handle, EM_SETEVENTMASK, 0, OldEventMask);
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
         );

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.Button FontSelection;
        private System.Windows.Forms.Button NewContent;
        private System.Windows.Forms.Label label1;
        private Button Minimise;
        private ToolTip SaveTT;
        private Button SettingsButton;
        private Label ModeLabel;
        private Label Doc1;
        private Button BoldButton;
        private Button ItalicsButton;
        private Button UnderlineButton;
        private ToolTip FindTT;
        private ToolTip ReplaceTT;
        private ToolTip FontTT;
        private ToolTip OpenTT;
        private ToolTip NewTT;
        private ToolTip BoldTT;
        private ToolTip UnderlineTT;
        private ToolTip SettingsTT;
        private SplitContainer MainContainer;
        public RichTextBox Contents;
        private SplitContainer SidePanelContainer;
        private TreeView SystemExplorer;
        private Panel FindReplacePanel;
        private Button FindButton;
        private TextBox FindBox;
        private Button ReplaceButton;
        private TextBox ReplaceBox;
        private StatusStrip AppStatus;
        private ToolStripStatusLabel WCStatusLabel;
        private ToolStripStatusLabel LCStatusLabel;
        private ToolStripStatusLabel SaveStatus;
        private MenuStrip TextyMenu;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem printToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem delToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem findToolStripMenuItem;
        private ToolStripMenuItem replaceToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem timeDateToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem zoomToolStripMenuItem;
        private ToolStripMenuItem zoomOutToolStripMenuItem;
        private ToolStripMenuItem readOnlyToolStripMenuItem;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ToolStripMenuItem foregroundToolStripMenuItem;
        private ToolStripMenuItem backgroundToolStripMenuItem;
        private ToolStripMenuItem alignmentrToolStripMenuItem;
        private ToolStripMenuItem rightAlignToolStripMenuItem;
        private ToolStripMenuItem leftAlignToolStripMenuItem;
        private ToolStripMenuItem centerAlignToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem creditsToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private CheckBox MatchCaseBox;
        private CheckBox ReplaceAllBox;
        private Button FindTopButton;
        private ToolStripMenuItem recentToolStripMenuItem;
        private ToolStripMenuItem wordWrapToolStripMenuItem;
        private ToolStripMenuItem exportToToolStripMenuItem;
        private ToolStripMenuItem pDFToolStripMenuItem;
        private ToolStripMenuItem hTMLToolStripMenuItem;
        private ListBox OpenedFilesListBox;
    }
}

