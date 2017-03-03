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
    public partial class frmA5 : Form
    {
        public frmA5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool b1, b2; string s;

            if (checkBox1.Checked == true) b1 = true;
            else b1 = false;

            if (checkBox2.Checked == true) b2 = true;
            else b2 = false; s = (b1 && b2) ? "true" : "false";

            switch (s)
            {
                case "true":
                    MessageBox.Show("True ==> 可以買");
                    break;
                case "false":
                    MessageBox.Show("False ==>不可以買");
                    break;
            }

        }

    }
}
