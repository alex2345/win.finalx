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
    public partial class frmE3 : Form
    {
        public frmE3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //顯示 Unicode
            char a1, a2;
            a1 = '\u4e2d'; //中
            a2 = '\u83ef';  //華
            MessageBox.Show( a1.ToString() + a2.ToString() );
            
            int n1, n2;
            n1 = (int)'中';
            n2 = (int)'華';
            MessageBox.Show(Convert.ToString(n1, 16).ToUpper() 
                + " " + Convert.ToString(n2, 16).ToUpper());
        }

    }
}
