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
    public partial class frmB3 : Form
    {
        public frmB3()
        {
            InitializeComponent();
        }

        private void frmB3_KeyDown(object sender, KeyEventArgs e)
        {
            label3.Text = e.KeyCode.ToString();
            label4.Text = e.KeyValue.ToString();
        }

        private void frmB3_KeyPress(object sender, KeyPressEventArgs e)
        {
            byte b; 
            label1.Text = e.KeyChar.ToString();

            b = (byte)e.KeyChar; 
            label2.Text = b.ToString();

        }

    }
}
