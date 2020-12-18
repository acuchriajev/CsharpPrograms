using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppWeeklyBankDeposit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double deposit;
        int weeks;
        double savingsTotal;

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            deposit = Convert.ToDouble(TbxWeeklyDeposit.Text);
            weeks = Convert.ToInt32(TbxWeeks.Text);
            savingsTotal = deposit * weeks;
            TbxSavings.Text = savingsTotal.ToString("c");

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            TbxSavings.Text = "";
            TbxWeeklyDeposit.Text = "";
            TbxWeeks.Text = "";
        }
    }
}
