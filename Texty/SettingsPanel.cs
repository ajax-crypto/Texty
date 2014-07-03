using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Texty
{
    public partial class SettingsPanel : Form
    {

        public int result;

        public const int SAVEDEXIT = 0;
        public const int NOTSAVEDEXIT = 1;
        public const int EXIT = 2;

        public SettingsPanel()
        {
            InitializeComponent();
            this.MouseDown += SettingsPanel_MouseDown;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void WordWrapSet_CheckedChanged_1(object sender, EventArgs e)
        {
            if (WordWrapSet.Checked)
                Program.settings.WordWrap = true;
            else
                Program.settings.WordWrap = false;
            this.result = NOTSAVEDEXIT;
        }

        private void DefaultFontButton_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            if (font.ShowDialog() == DialogResult.OK)
            {
                Program.settings.FontFamily = font.Font.FontFamily.GetName(0);
                Program.settings.FontSize = font.Font.SizeInPoints;
                SampleTextLabel.Font = font.Font;
                this.result = NOTSAVEDEXIT;
            }
        }

        private void ForeColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            color.AnyColor = true;
            if (color.ShowDialog() == DialogResult.OK)
            {
                Program.settings.AssignForeColor(color.Color.R, color.Color.G, color.Color.B);
                this.result = NOTSAVEDEXIT;
            }
        }

        private void BackColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            color.AnyColor = true;
            if (color.ShowDialog() == DialogResult.OK)
            {
                Program.settings.AssignBackColor(color.Color.R, color.Color.G, color.Color.B);
                this.result = NOTSAVEDEXIT;
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Program.settings.SaveToFile();
            this.result = SAVEDEXIT;
        }

        private void LeftAlignment_CheckedChanged(object sender, EventArgs e)
        {
            Program.settings.Alignment = Settings.LEFTALIGN;
        }

        private void CenterAlignment_CheckedChanged(object sender, EventArgs e)
        {
            Program.settings.Alignment = Settings.CENTERALIGN;
        }

        private void RightAlignment_CheckedChanged(object sender, EventArgs e)
        {
            Program.settings.Alignment = Settings.RIGHTALIGN;
        }


    }
}
