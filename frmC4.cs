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
    public partial class frmC4 : Form
    {
        public frmC4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int score;
            score = Convert.ToInt32(textBox1.Text);
            if (score >= 60)
            {
                label1.Text = "及 格";
            }
            else
                if (score >= 50)
                {
                    label1.Text = "補 考";
                }
                else
                {
                    label1.Text = "死 當";
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
