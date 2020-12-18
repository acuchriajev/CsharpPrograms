using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppGeneratorOfRandomNumbers
{
    public partial class Form1 : Form {
        Random randomNumber = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if ((int)NudFrom.Value != (int)NudTo.Value)
            {
                int number = randomNumber.Next((int)NudFrom.Value, (int)NudTo.Value+1);
                LblRandomNumber.Text = number.ToString();
                if (cbNoRepeat.Checked)
                {
                    if (tbxRandomNumbers.Text.IndexOf(number.ToString()) == -1)
                   tbxRandomNumbers.AppendText(number.ToString() + "\n");
                }
                else
                {
                    tbxRandomNumbers.AppendText(number.ToString() + "\n");
                }
            }
            else { 
                MessageBox.Show("Fields From and To cannot be with the same values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            LblRandomNumber.Text = "0";
            tbxRandomNumbers.Clear();
            NudFrom.Value = 0;
            NudTo.Value=0;
            cbNoRepeat.Checked = false;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbxRandomNumbers.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LblRandomNumber.Text = "0";
            tbxRandomNumbers.Clear();
            NudFrom.Value = 0;
            NudTo.Value = 0;
            cbNoRepeat.Checked = false;
        }
    }
}
