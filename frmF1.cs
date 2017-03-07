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
    public partial class frmF1 : Form
    {
        public frmF1()
        {
            InitializeComponent();
        }

        public void OnClickMeClicked(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                this.label1.Text = textBox1.Text + "(男生)";
                //
                if (radioButton3.Checked == true) this.label1.Text += ".A型";
                else if (radioButton4.Checked == true) this.label1.Text += ".B型";
                //
                if (checkBox1.Checked == true) this.label1.Text += ".愛跑步";
                if (checkBox2.Checked == true) this.label1.Text += ".愛瑜珈";
            }
            else if (radioButton2.Checked == true)
            {
                this.label1.Text = textBox1.Text + "(女生)";
                //
                if (radioButton3.Checked == true) this.label1.Text += ".A型";
                else if (radioButton4.Checked == true) this.label1.Text += ".B型";
                //
                if (checkBox1.Checked == true) this.label1.Text += ".愛跑步";
                if (checkBox2.Checked == true) this.label1.Text += ".愛瑜珈";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.groupBox1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.groupBox1.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            OnClickMeClicked(sender, e);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            OnClickMeClicked(sender, e);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            OnClickMeClicked(sender, e);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            OnClickMeClicked(sender, e);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            OnClickMeClicked(sender, e);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            OnClickMeClicked(sender, e);
        }

    }
}
