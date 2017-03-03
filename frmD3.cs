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
    public partial class frmD3 : Form
    {
        public frmD3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] a = new int[5] { 1, 2, 3, 4, 5 };
            int len1, ub1;
            len1 = a.Length;  //5
            ub1 = a.GetUpperBound(0); // 4
            MessageBox.Show("陣列元素總數 " + len1.ToString()
                                               + "\n第1維上限" + ub1.ToString()
                                               , "一維陣列");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[,] b = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            int len2, ub21, ub22;
            len2 = b.Length;
            ub21 = b.GetUpperBound(0);
            ub22 = b.GetUpperBound(1);
            MessageBox.Show("陣列元素總數 " + len2.ToString()
                + "\n第1維上限" + ub21.ToString()
                + "\n第2維上限" + ub22.ToString()
                , "二維陣列");
        }

    }
}
