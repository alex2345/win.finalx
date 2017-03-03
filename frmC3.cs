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
    public partial class frmC3 : Form
    {
        public frmC3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] a = new int[0] { };
            int[] b = new int[0] { };
            int[] c = new int[0] { };
            int j = 0;
            for (int i = 0; i <= 2; i++)
            {
                Array.Resize(ref a, a.Length + 1);
                Array.Resize(ref b, b.Length + 1);
                Array.Resize(ref c, c.Length + 1);
                j = i + 1; a[i] = j; b[i] = j; c[i] = a[i] * b[i];
                richTextBox1.Text += "a[" + i.ToString()
                    + "] * b[" + i.ToString() + "]=" + j.ToString()
                    + " * " + j.ToString() + "=" + c[i].ToString() + "\n";
            }
        }

    }
}
