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
    public partial class frmG7 : Form
    {
        public frmG7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(textBox1.Text);
            //
            string s = Convert.ToString(i, 16).ToUpper();
            MessageBox.Show("10進位轉16進位 " + s);
            //
            s = Convert.ToString(i, 2);
            MessageBox.Show("10進位轉2進位 " + s);
        }

    }
}
