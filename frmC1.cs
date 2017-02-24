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
    public partial class frmC1 : Form
    {
        public frmC1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum = 0, i = 0;
            for (i = 1; i <= 100; i++) sum += sum;
            MessageBox.Show("sum= " + sum.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sum = 0, i = 1;
            while (i <= 100)
            { sum += i; i++; }
            MessageBox.Show("sum= " + sum.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sum = 0, i = 1;
            do
            { sum += i; i++; } while (i <= 100);
            MessageBox.Show("sum= " + sum.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
