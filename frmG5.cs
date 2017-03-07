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
    public partial class frmG5 : Form
    {
        public frmG5()
        {
            InitializeComponent();
        }

        private void seed(out int s)//[4-39] 
        { //see [4-39] of "Visual C# 2015" for detail
            Random r = new Random();
            s = r.Next(1, 47);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int[] numbers; // declare numbers as an int array of any size
            numbers = new int[6];  // numbers is a 6-element array

            Random r = new Random(); label1.Text = "";
            for (int i = 0; i <= 5; i++)
            {
                // numbers[i] = r.Next(1, 47); //採用一般陣列.產生樂透  1..46
                seed(out numbers[i]);  //採用 out 識別字.產生樂透  1..46 [4-39] 
                if (i > 0)
                {
                    while (numbers[i] == numbers[i - 1]) //if 重複
                    {
                        //numbers[i] = r.Next(1, 47); //再次.採用一般陣列.產生樂透  1..46
                        seed(out numbers[i]);  //再次.採用 out 識別字.產生樂透  1..46 [4-39] 
                    }
                }
                label1.Text += numbers[i].ToString() + ", ";
            }
            label1.Text = label1.Text.Substring(0, label1.Text.Length - 2);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
