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
    public partial class frmC2 : Form
    {
        public frmC2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int m, n, p;
            Label[] Lbl_Shade1 = new Label[] { label1, label2 };
            Lbl_Shade1[0].Text = ""; Lbl_Shade1[1].Text = "";
            int[,] a = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            for (int i = 0; i <= 1; i++)
                for (int j = 0; j <= 2; j++)
                    Lbl_Shade1[i].Text += (a[i, j].ToString() + "  ");

            Label[] Lbl_Shade2 = new Label[] { label3, label4, label5 };
            Lbl_Shade2[0].Text = ""; Lbl_Shade2[1].Text = ""; Lbl_Shade2[2].Text = "";
            int[,] b = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            for (int i = 0; i <= 2; i++)
                for (int j = 0; j <= 1; j++)
                    Lbl_Shade2[i].Text += (b[i, j].ToString() + "  ");

            m = a.GetUpperBound(0);
            n = a.GetUpperBound(1);
            p = b.GetUpperBound(1);
            Label[] Lbl_Shade3 = new Label[] { label6, label7 };
            Lbl_Shade3[0].Text = ""; Lbl_Shade3[1].Text = "";

            int[,] c = new int[2, 2];
            for (int i = 0; i <= m; i++)
            {
                for (int j = 0; j <= p; j++)
                {
                    c[i, j] = 0;
                    for (int k = 0; k <= n; k++)
                    {
                        c[i, j] += a[i, k] * b[k, j];
                    }
                    Lbl_Shade3[i].Text += (c[i, j].ToString() + "  ");
                }

            }
        }

    }
}
