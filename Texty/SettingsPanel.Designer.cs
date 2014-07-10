using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Texty
{
    partial class SettingsPanel
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

        //#region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ForeColorButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.WordWrapSet = new System.Windows.Forms.CheckBox();
            this.DefaultFontButton = new System.Windows.Forms.Button();
            this.ColorBox = new System.Windows.Forms.GroupBox();
            this.BackColorButton = new System.Windows.Forms.Button();
            this.FontBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RightAlignment = new System.Windows.Forms.RadioButton();
            this.CenterAlignment = new System.Windows.Forms.RadioButton();
            this.LeftAlignment = new System.Windows.Forms.RadioButton();
            this.SampleTextLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FadeInTimer)).BeginInit();
            this.ColorBox.SuspendLayout();
            this.FontBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FadeInTimer
            // 
            this.FadeInTimer.Enabled = true;
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.Location = new System.Drawing.Point(146, 12);
            this.HeaderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(117, 37);
            this.HeaderLabel.TabIndex = 0;
            this.HeaderLabel.Text = "Settings";
            this.HeaderLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // ExitButton
            // 
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ExitButton.Location = new System.Drawing.Point(219, 383);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(111, 37);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Close";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ForeColorButton
            // 
            this.ForeColorButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ForeColorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ForeColorButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ForeColorButton.Location = new System.Drawing.Point(30, 25);
            this.ForeColorButton.Margin = new System.Windows.Forms.Padding(4);
            this.ForeColorButton.Name = "ForeColorButton";
            this.ForeColorButton.Size = new System.Drawing.Size(119, 37);
            this.ForeColorButton.TabIndex = 10;
            this.ForeColorButton.Text = "Foreground";
            this.ForeColorButton.UseVisualStyleBackColor = true;
            this.ForeColorButton.Click += new System.EventHandler(this.ForeColorButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Word Wrap";
            // 
            // WordWrapSet
            // 
            this.WordWrapSet.AutoSize = true;
            this.WordWrapSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WordWrapSet.Location = new System.Drawing.Point(115, 40);
            this.WordWrapSet.Margin = new System.Windows.Forms.Padding(4);
            this.WordWrapSet.Name = "WordWrapSet";
            this.WordWrapSet.Size = new System.Drawing.Size(12, 11);
            this.WordWrapSet.TabIndex = 8;
            this.WordWrapSet.UseVisualStyleBackColor = true;
            this.WordWrapSet.CheckedChanged += new System.EventHandler(this.WordWrapSet_CheckedChanged_1);
            // 
            // DefaultFontButton
            // 
            this.DefaultFontButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DefaultFontButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DefaultFontButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DefaultFontButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DefaultFontButton.Location = new System.Drawing.Point(35, 159);
            this.DefaultFontButton.Margin = new System.Windows.Forms.Padding(4);
            this.DefaultFontButton.Name = "DefaultFontButton";
            this.DefaultFontButton.Size = new System.Drawing.Size(103, 31);
            this.DefaultFontButton.TabIndex = 9;
            this.DefaultFontButton.Text = "Default Font";
            this.DefaultFontButton.UseVisualStyleBackColor = false;
            this.DefaultFontButton.Click += new System.EventHandler(this.DefaultFontButton_Click);
            // 
            // ColorBox
            // 
            this.ColorBox.Controls.Add(this.BackColorButton);
            this.ColorBox.Controls.Add(this.ForeColorButton);
            this.ColorBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorBox.Location = new System.Drawing.Point(28, 282);
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.Size = new System.Drawing.Size(348, 75);
            this.ColorBox.TabIndex = 11;
            this.ColorBox.TabStop = false;
            this.ColorBox.Text = "Default Colors";
            // 
            // BackColorButton
            // 
            this.BackColorButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackColorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackColorButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackColorButton.Location = new System.Drawing.Point(191, 25);
            this.BackColorButton.Margin = new System.Windows.Forms.Padding(4);
            this.BackColorButton.Name = "BackColorButton";
            this.BackColorButton.Size = new System.Drawing.Size(111, 37);
            this.BackColorButton.TabIndex = 11;
            this.BackColorButton.Text = "Background";
            this.BackColorButton.UseVisualStyleBackColor = true;
            this.BackColorButton.Click += new System.EventHandler(this.BackColorButton_Click);
            // 
            // FontBox
            // 
            this.FontBox.Controls.Add(this.groupBox1);
            this.FontBox.Controls.Add(this.SampleTextLabel);
            this.FontBox.Controls.Add(this.DefaultFontButton);
            this.FontBox.Controls.Add(this.WordWrapSet);
            this.FontBox.Controls.Add(this.label2);
            this.FontBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FontBox.Location = new System.Drawing.Point(28, 65);
            this.FontBox.Name = "FontBox";
            this.FontBox.Size = new System.Drawing.Size(348, 211);
            this.FontBox.TabIndex = 13;
            this.FontBox.TabStop = false;
            this.FontBox.Text = "Default Font";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RightAlignment);
            this.groupBox1.Controls.Add(this.CenterAlignment);
            this.groupBox1.Controls.Add(this.LeftAlignment);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(24, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 69);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alignment";
            // 
            // RightAlignment
            // 
            this.RightAlignment.AutoSize = true;
            this.RightAlignment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RightAlignment.Location = new System.Drawing.Point(204, 29);
            this.RightAlignment.Name = "RightAlignment";
            this.RightAlignment.Size = new System.Drawing.Size(92, 21);
            this.RightAlignment.TabIndex = 16;
            this.RightAlignment.TabStop = true;
            this.RightAlignment.Text = "Right Align";
            this.RightAlignment.UseVisualStyleBackColor = true;
            this.RightAlignment.CheckedChanged += new System.EventHandler(this.RightAlignment_CheckedChanged);
            // 
            // CenterAlignment
            // 
            this.CenterAlignment.AutoSize = true;
            this.CenterAlignment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CenterAlignment.Location = new System.Drawing.Point(97, 29);
            this.CenterAlignment.Name = "CenterAlignment";
            this.CenterAlignment.Size = new System.Drawing.Size(100, 21);
            this.CenterAlignment.TabIndex = 15;
            this.CenterAlignment.TabStop = true;
            this.CenterAlignment.Text = "Center Align";
            this.CenterAlignment.UseVisualStyleBackColor = true;
            this.CenterAlignment.CheckedChanged += new System.EventHandler(this.CenterAlignment_CheckedChanged);
            // 
            // LeftAlignment
            // 
            this.LeftAlignment.AutoSize = true;
            this.LeftAlignment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LeftAlignment.Location = new System.Drawing.Point(11, 29);
            this.LeftAlignment.Name = "LeftAlignment";
            this.LeftAlignment.Size = new System.Drawing.Size(82, 21);
            this.LeftAlignment.TabIndex = 14;
            this.LeftAlignment.TabStop = true;
            this.LeftAlignment.Text = "Left Align";
            this.LeftAlignment.UseVisualStyleBackColor = true;
            this.LeftAlignment.CheckedChanged += new System.EventHandler(this.LeftAlignment_CheckedChanged);
            // 
            // SampleTextLabel
            // 
            this.SampleTextLabel.AutoSize = true;
            this.SampleTextLabel.Location = new System.Drawing.Point(217, 167);
            this.SampleTextLabel.Name = "SampleTextLabel";
            this.SampleTextLabel.Size = new System.Drawing.Size(82, 17);
            this.SampleTextLabel.TabIndex = 11;
            this.SampleTextLabel.Text = "Sample Text";
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SaveButton.Location = new System.Drawing.Point(63, 381);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(114, 39);
            this.SaveButton.TabIndex = 12;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SettingsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(409, 438);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ColorBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.FontBox);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SettingsPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsPanel";
            ((System.ComponentModel.ISupportInitialize)(this.FadeInTimer)).EndInit();
            this.ColorBox.ResumeLayout(false);
            this.FontBox.ResumeLayout(false);
            this.FontBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       // #endregion

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
            int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        //call functions to move the form in your form's MouseDown event
        private void SettingsPanel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ForeColorButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox WordWrapSet;
        private System.Windows.Forms.Button DefaultFontButton;
        private System.Windows.Forms.GroupBox ColorBox;
        private System.Windows.Forms.Button BackColorButton;
        private GroupBox FontBox;
        private Label SampleTextLabel;
        private GroupBox groupBox1;
        private Button SaveButton;
        private RadioButton LeftAlignment;
        private RadioButton RightAlignment;
        private RadioButton CenterAlignment;
    }
}