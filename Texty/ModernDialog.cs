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
    public partial class ModernDialog : Form
    {
        public const int LEFT = 0;
        public const int CENTER = 1;
        public const int CANCEL = 2;
        public int result { set; get; }

        public ModernDialog(string header, string desc, string left, string center)
        {
            InitializeComponent();
            this.Opacity = 0;
            this.FadeTimer.Enabled = true;
            this.FadeTimer.Elapsed += FadeTimer_Elapsed;
            HeaderLabel.Text = header;
            DescriptionLabel.Text = desc;
            LeftButton.Text = left;
            CenterButton.Text = center;
        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            this.result = LEFT;
            this.Close();
        }

        private void CenterButton_Click(object sender, EventArgs e)
        {
            this.result = CENTER;
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.result = CANCEL;
            this.Close();
        }

        private void ModernDialog_Load(object sender, EventArgs e)
        {
            this.HeaderLabel.Left = (this.ClientRectangle.Width - this.HeaderLabel.ClientRectangle.Width) / 2;
            this.DescriptionLabel.Left = (this.ClientRectangle.Width - this.DescriptionLabel.ClientRectangle.Width) / 2;
        }


    }
}
