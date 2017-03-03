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
    public partial class frmC6 : Form
    {
        public frmC6()
        {
            InitializeComponent();
        }
        string[] sname = new string[] { "星期日", "星期一 ", "星期二", "星期三", "星期四", "星期五", "星期六", };
        double[] sgrade = new double[] { 17.0, 18.5, 21.6, 19.5, 15.0, 12.0, 16.5 };
        double sum, avg;
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            for (int i = 0; i <= sname.GetUpperBound(0); i++)
                label1.Text += sname[i] + " " + Convert.ToString(sgrade[i]) + "\n";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sum = 0;
            for (int i = 0; i <= sgrade.GetUpperBound(0); i++)
                sum += sgrade[i];

            avg = sum / 7; avg = Math.Round(avg, 1);
            MessageBox.Show("一周均溫= " + avg.ToString() + "度");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
