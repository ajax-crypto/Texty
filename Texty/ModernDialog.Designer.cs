namespace Texty
{
    partial class ModernDialog
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
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.CenterButton = new System.Windows.Forms.Button();
            this.LeftButton = new System.Windows.Forms.Button();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.FadeTimer = new System.Timers.Timer();
            ((System.ComponentModel.ISupportInitialize)(this.FadeTimer)).BeginInit();
            this.SuspendLayout();
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DescriptionLabel.Location = new System.Drawing.Point(22, 58);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(0, 15);
            this.DescriptionLabel.TabIndex = 9;
            // 
            // CancelButton
            // 
            this.CancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelButton.Location = new System.Drawing.Point(208, 91);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 32);
            this.CancelButton.TabIndex = 8;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // CenterButton
            // 
            this.CenterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CenterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CenterButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CenterButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CenterButton.Location = new System.Drawing.Point(114, 91);
            this.CenterButton.Name = "CenterButton";
            this.CenterButton.Size = new System.Drawing.Size(75, 32);
            this.CenterButton.TabIndex = 7;
            this.CenterButton.UseVisualStyleBackColor = true;
            this.CenterButton.Click += new System.EventHandler(this.CenterButton_Click);
            // 
            // LeftButton
            // 
            this.LeftButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LeftButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LeftButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LeftButton.Location = new System.Drawing.Point(18, 91);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(75, 32);
            this.LeftButton.TabIndex = 6;
            this.LeftButton.UseVisualStyleBackColor = true;
            this.LeftButton.Click += new System.EventHandler(this.LeftButton_Click);
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HeaderLabel.Location = new System.Drawing.Point(93, 20);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(74, 25);
            this.HeaderLabel.TabIndex = 5;
            this.HeaderLabel.Text = "Header";
            this.HeaderLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FadeTimer
            // 
            this.FadeTimer.Enabled = true;
            this.FadeTimer.Interval = 20D;
            this.FadeTimer.SynchronizingObject = this;
            // 
            // ModernDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(302, 144);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.CenterButton);
            this.Controls.Add(this.LeftButton);
            this.Controls.Add(this.HeaderLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ModernDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModernDialog";
            ((System.ComponentModel.ISupportInitialize)(this.FadeTimer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void FadeTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            this.Opacity += 0.1;
            if (this.Opacity >= .9)
            {
                this.Opacity = 1;
                this.FadeTimer.Enabled = false;
            }
        }

        //#endregion

        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button CenterButton;
        private System.Windows.Forms.Button LeftButton;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Timers.Timer FadeTimer;
    }
}