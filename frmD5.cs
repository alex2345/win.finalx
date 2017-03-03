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
    public partial class frmD5 : Form
    {
        public frmD5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text != "")
            {
                string str = textBox1.Text;

                MessageBox.Show("本字串有 " + str.Length.ToString() + " 個字元");
                for (int i = 0; i < str.Length; i++)
                {
                    MessageBox.Show(str[i].ToString());
                }
                this.textBox1.Focus();
                this.textBox1.Clear();
            }
            else
            {
                MessageBox.Show("please enter a string", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
