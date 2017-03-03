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
    public partial class frmC5 : Form
    {
        public frmC5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            switch (comboBox1.Text)
            {
                case "未滿六歲":
                    pictureBox1.Visible = true;

                    break;
                case "6歲以上12歲未滿之兒童須父母、師長或成年親友陪伴輔導觀賞":
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = true;

                    break;
                case "12歲以上15歲未滿之青少年須父母、師長或成年親友陪伴輔導觀賞":
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = true;
                    break;
                case "15歲以上18歲未滿之青少年須父母、師長或成年親友陪伴輔導觀賞":
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = true;
                    pictureBox4.Visible = true;

                    break;
                case "18歲以上":
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = true;
                    pictureBox4.Visible = true;
                    pictureBox5.Visible = true;
                    break;

            }   
        }

        private void frmC5_Load(object sender, EventArgs e)
        {
            string[] ary = new string[] { "未滿六歲", "6歲以上12歲未滿之兒童須父母、師長或成年親友陪伴輔導觀賞", "12歲以上15歲未滿之青少年須父母、師長或成年親友陪伴輔導觀賞",
            "15歲以上18歲未滿之青少年須父母、師長或成年親友陪伴輔導觀賞","18歲以上"};
            comboBox1.Items.AddRange(ary);
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            comboBox1.Text = "未滿六歲";
        }

    }
}
