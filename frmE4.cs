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
    public partial class frmE4 : Form
    {
        public frmE4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //顯示 ASCII 32~255 字元
            char c1;
            for (int c = 32; c <= 255; c++)
            {
                c1 = (char)c;
                richTextBox1.Text
                    += "ASCII(" + c.ToString()
                    + ")=" + c1.ToString() + "\n";
            }//for
        }

    }
}
