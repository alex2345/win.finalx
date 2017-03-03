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
    public partial class frmD2 : Form
    {
        public frmD2()
        {
            InitializeComponent();
        }
        private bool b1 = false;
        private void button1_Click(object sender, EventArgs e)
        {
            b1 = !b1;
            if (b1) 
            {
                pic1.Image = Resource1.circle_red;
                pic2.Image = Resource1.circle_green;
            }
            else
            {
                pic2.Image = Resource1.circle_red;
                pic1.Image = Resource1.circle_green;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
