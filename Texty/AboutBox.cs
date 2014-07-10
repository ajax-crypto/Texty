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
    public partial class AboutBox : TextyForm
    {
        public AboutBox()
        {
            InitializeComponent();
            this.FadeInTimer.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
