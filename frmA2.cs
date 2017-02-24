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
    public partial class frmA2 : Form
    {
        public frmA2()
        {
            InitializeComponent();
        }
  
        private void button_Click_1(object sender, EventArgs e)
        {
            byte max, min; max = 255; min = 0;
            MessageBox.Show("max=" + max.ToString() + ";  min=" + min.ToString(), "byte");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            sbyte max, min; max = 127; min = -128;
            MessageBox.Show("max=" + max.ToString() + "; min=" + min.ToString(), "sbyte");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            short max, min; max = 32767; min = -32768;
            MessageBox.Show("max=" + max.ToString() + "; min=" + min.ToString(), "short");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int max, min; max = 2147483647; min = -2147483648;
            MessageBox.Show("max=" + max.ToString() + "; min=" + min.ToString(), "int");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            ushort max, min; max = 65535; min = 0;
            MessageBox.Show("max=" + max.ToString() + "; min=" + min.ToString(), "ushort");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            float max, min; max = 3.4E37F; min = 1.5E-45F;
            MessageBox.Show("max=" + max.ToString() + "; min=" + min.ToString(), "float");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            decimal max; max = 0.3333333333333333333333333M;
            MessageBox.Show("max=" + max.ToString(), "decimal");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            char c1, c2; c1 = 'A'; c2 = 'B';
            MessageBox.Show("c1=" + c1.ToString() + ";  c2=" + c2.ToString(), "char");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string s1, s2, s; s1 = "ABC"; s2 = "123"; s = s1 + s2;
            MessageBox.Show("s1=" + s1 + "; s2=" + s2 + "; s=" + s, "string");   
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
