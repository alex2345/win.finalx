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
    public partial class frmA1 : Form
    {
        public frmA1()
        {
            InitializeComponent();
            Random rnd = new Random();
            textBox1.Text = rnd.Next(1, 10 + 1).ToString();
            textBox2.Text = rnd.Next(1, 10 + 1).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c, d;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            c = a + b; d = a * b;
            MessageBox.Show("a+b= " + c.ToString() + ";  a*b= " + d.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
