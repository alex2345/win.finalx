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
    public partial class frmG1 : Form
    {
        DateTime EndTime;
        TimeSpan RemainderTime;
        public frmG1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EndTime = DateTime.Now.AddHours(Convert.ToDouble(textBox1.Text));
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            RemainderTime = EndTime - DateTime.Now;
            if (RemainderTime.TotalSeconds > 0)
            {
                label1.Text = "剩餘：" + RemainderTime.Hours + "時" + RemainderTime.Minutes + "分" + RemainderTime.Seconds + "秒";
            }
            else
            {
                label1.Text = "時間到";
                timer1.Stop();
            }
        }

    }
}
