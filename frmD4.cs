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
    public partial class frmD4 : Form
    {
        public frmD4()
        {
            InitializeComponent();
        }
        class Cshape //class
        {
            public double Area(int r) //method
            {
                double PI = 3.14; return (PI * r * r);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Cshape C = new Cshape();
            int r; r = Convert.ToInt32(textBox1.Text.Trim());
            MessageBox.Show("圓(r " + r.ToString() + ").面積 = " + C.Area(r).ToString(), "圓面積");
        }

    }
}
