using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoFiler
{
    public partial class InvalidDirectory : Form
    {
        public InvalidDirectory()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Okay_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
