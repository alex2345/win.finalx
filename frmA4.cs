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
    public partial class frmA4 : Form
    {
        private int cnt = 0;
        private string[] str1 = new string[10];

        public frmA4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text != "")
            {
                listBox1.Items.Add(textBox1.Text);
                str1[cnt] = textBox1.Text; cnt += 1;
                this.textBox1.Focus();
                this.textBox1.Clear();
            }
            else
            {
                MessageBox.Show("please enter a string to add", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textBox1.Focus();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = ""; string str = "";
            for (int i = 0; i < cnt; i++) str += str1[i] + " ";
            label1.Text += str;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmA4_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("John & Mary"); cnt += 1;
            listBox1.Items.Add("are going to"); cnt += 1;
            str1[0] = listBox1.Items[0].ToString();
            str1[1] = listBox1.Items[1].ToString(); 
            textBox1.Text = "movie.";
        }

    }
}
