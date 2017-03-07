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
    public partial class frmG3 : Form
    {
        public frmG3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double f1, c1, f2, c2;
            if (radioButton1.Checked == true)
            {
                try
                {
                    c1 = Convert.ToDouble(textBox1.Text);
                    f1 = c1 * 9 / 5 + 32;
                    f1 = Math.Round(f1, 1);
                    label1.Text = "華氏 " + f1.ToString() + " 度";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("請輸入溫度度數\n" + ex.Message);
                }
            }
            if (radioButton2.Checked == true)
            {
                try
                {
                    f2 = Convert.ToDouble(textBox1.Text);
                    c2 = (f2 - 32) * 5 / 9;
                    c2 = Math.Round(c2, 1);
                    label1.Text = "攝式 " + c2.ToString() + " 度";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("請輸入溫度度數\n" + ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
