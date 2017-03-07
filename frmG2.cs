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
    public partial class frmG2 : Form
    {
        DateTime EndTime;
        TimeSpan RemainderTime;
        public frmG2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EndTime = DateTime.Now.AddSeconds (Convert.ToDouble( label2.Text) );
            pic1.Image = Resource1.circle_red;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            RemainderTime = EndTime - DateTime.Now;
            if (RemainderTime.TotalSeconds > 0)
            {
                label1.Text = "(剩 10 ) 剩餘：" + RemainderTime.Seconds + "秒";
                if (RemainderTime.TotalSeconds <= 10)
                    pic1.Image=Resource1.circle_yellow;
            }
            else
            {   label1.Text = "時間到";
                pic1.Image = Resource1.circle_green;
                timer1.Stop();
            }
        }

    }
}
