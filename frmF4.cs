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
    public partial class frmF4 : Form
    {
        public frmF4()
        {
            InitializeComponent();
        }

        private void frmF4_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("abc");
            listBox1.Items.Add("def");
            listBox1.Items.Add("ghi");
        }

        private void button3_Click(object sender, EventArgs e)
        {//搜索
            listBox1.SelectedIndex = listBox1.FindString(textBox2.Text);
            button4.Visible = true; //修改
            button5.Visible = true; //確認
        }

        private void button7_Click(object sender, EventArgs e)
        {//插入指定索引
            int n;
            n = Convert.ToInt32(textBox3.Text); //插入第幾筆
            listBox1.Items.Insert(n, textBox1.Text);
            textBox3.Text = "0";
            this.textBox1.Clear();
            this.textBox3.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {//刪除
            while (listBox1.SelectedIndices.Count > 0)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndices[0]);
            }      
        }

        private void button4_Click(object sender, EventArgs e)
        {//修改為指定搜索值
            listBox1.Items[listBox1.SelectedIndex] = this.textBox2.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {//確認
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                listBox1.ClearSelected();
            }
            button4.Visible = false; //修改
            button5.Visible = false; //確認
        }

        private void button6_Click(object sender, EventArgs e)
        {//清除
            listBox1.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {//新增
            listBox1.Items.Add(textBox1.Text.Trim());
            this.textBox1.Clear();
        }

    }
}
