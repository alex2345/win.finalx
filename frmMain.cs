using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winFinal
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void toolStrip_a1_Click(object sender, EventArgs e)
        {
            frmA1 a1 = new winFinal.frmA1();a1.Show();
        }
    }
}
