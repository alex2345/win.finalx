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
    public partial class frmF6 : Form
    {
        public frmF6()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = "選定日 " + dateTimePicker1.Value.ToShortDateString();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime begindate, enddate;
            begindate = monthCalendar1.SelectionStart; //選定起始日
            enddate = monthCalendar1.SelectionEnd;     //選定終止日
            label2.Text = "起日.日期 " + begindate.ToShortDateString();//起始日.日期
            label3.Text = "止日.日期 " + enddate.ToShortDateString();  //終止日.日期
            label4.Text = "止日.時間 " + enddate.ToShortTimeString();  //終止日.時間
            label5.Text = "止日.日期.時間 " + enddate.ToString();      //終止日.日期.時間

            TimeSpan ts = enddate.Subtract(begindate); int days = ts.Days;
            label6.Text = "選定起止日相差 " + days.ToString() + " 天";
        }

    }
}
