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

        private void toolStrip_a2_Click(object sender, EventArgs e)
        {
            frmA2 a2 = new winFinal.frmA2(); a2.Show();
        }

        private void toolStrip_a3_Click(object sender, EventArgs e)
        {
            frmA3 a3 = new winFinal.frmA3(); a3.Show();
        }

        private void toolStrip_a4_Click(object sender, EventArgs e)
        {
            frmA4 a4 = new winFinal.frmA4(); a4.Show();
        }

        private void toolStrip_a5_Click(object sender, EventArgs e)
        {
            frmA5 a5 = new winFinal.frmA5(); a5.Show();
        }

        private void toolStrip_a6_Click(object sender, EventArgs e)
        {
            frmA6 a6 = new winFinal.frmA6(); a6.Show();
        }
    }
}
