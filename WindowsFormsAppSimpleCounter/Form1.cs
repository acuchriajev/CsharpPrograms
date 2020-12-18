using System;
using System.Windows.Forms;

namespace WindowsFormsAppSimpleCounter
{
    public partial class Form1 : Form
    {
        int counter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            counter++;
            lblNumber.Text = counter.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (lblNumber.Text.Equals("0")){
                counter = 0;
            }
            else
            {
                counter--;
                lblNumber.Text = counter.ToString();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            counter = 0;
            lblNumber.Text = "0";
            lblNumber.Text = counter.ToString();
        }
    }
}
