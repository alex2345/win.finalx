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
    public partial class frmD1 : Form
    {
        public frmD1()
        {
            InitializeComponent();
        }

        private void frmD1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:

                    pic1.Top -= 10;
                    break;
                case Keys.Down:

                    pic1.Top += 10;
                    break;
                case Keys.Left:

                    pic1.Left -= 10;
                    break;
                case Keys.Right:

                    pic1.Left += 10;
                    break;
            }
            //
            if (pic1.Top < 0) pic1.Top = this.Height; //超過頂端→置於底端
            if (pic1.Top > this.Height) pic1.Top = 0; //超過底端→置於頂端
            //
            if (pic1.Left > this.Width) pic1.Left = 0; //超過右端→置於左端
            if (pic1.Left < 0) pic1.Left = this.Width; //超過左端→置於右端
        }

    }
}
