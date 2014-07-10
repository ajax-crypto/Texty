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
    public partial class Credits : TextyForm
    {
        public Credits()
        {
            InitializeComponent();
            this.FadeInTimer.Enabled = true;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
