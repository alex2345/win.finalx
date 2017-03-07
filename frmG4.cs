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
    public partial class frmG4 : Form
    {
        public frmG4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int guess;
            Random r = new Random();
            guess = r.Next(1, 47);
            MessageBox.Show(guess.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
