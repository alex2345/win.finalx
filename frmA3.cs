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
    public partial class frmA3 : Form
    {
        public frmA3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1, n2, max;
            n1 = Convert.ToInt32(textBox1.Text);
            n2 = Convert.ToInt32(textBox2.Text);
            max = (n1 > n2) ? n1 : n2;
            MessageBox.Show("max=" + max.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            textBox1.Text = rnd.Next(1, 100 + 1).ToString();
            rnd = new Random( Convert.ToInt32(textBox1.Text) );
            textBox2.Text = rnd.Next(1, 100 + 1).ToString();
        }
    }
}
