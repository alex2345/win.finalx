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
    public partial class frmB1 : Form
    {
        public frmB1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello", "幼獅青年", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult ans;
            ans = MessageBox.Show("想蹺課嗎?", "幼獅職訓", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (ans == DialogResult.Yes)
            {      MessageBox.Show("YES");
            }
            else
            {
                MessageBox.Show("NO ");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
