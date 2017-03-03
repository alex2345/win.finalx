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
            label1.Text = dateTimePicker1.Value.ToShortDateString();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime begindate, enddate;
            begindate = monthCalendar1.SelectionStart;
            enddate = monthCalendar1.SelectionEnd;
            label2.Text = begindate.ToShortDateString();
            label3.Text = enddate.ToShortDateString();
            label4.Text = enddate.ToShortTimeString();
            label5.Text = enddate.ToString();
        }

    }
}
