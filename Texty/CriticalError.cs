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
    public partial class CriticalError : Form
    {
        public int result;
        public const int ABORT = 0;

        public CriticalError(string message)
        {
            InitializeComponent();
            ErrorMessage.Text = message;
        }

        private void Abort_Click(object sender, EventArgs e)
        {
            result = ABORT;
        }
    }
}
