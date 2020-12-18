using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppSalaryCalculation
{
    public partial class SalaryCalculator : Form
    {
        public SalaryCalculator()
        {
            InitializeComponent();
        }

        string yourName;
            
        double rateOfPay, hoursWorked, grossPay, netPay, tax, exchangeRate, total;

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program was created by Aleksandr Cuchriajev from UAB Acoptex. Contact us on info@acoptex.lt");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                yourName = TbxYourName.Text;
                hoursWorked = Convert.ToDouble(TbxHoursWorked.Text);
                rateOfPay = Convert.ToDouble(TbxRateOfPay.Text);
                TbxRateOfPay.Text = rateOfPay.ToString() + " USD";
                grossPay = hoursWorked * rateOfPay;
                TbxGrossPay.Text = grossPay.ToString()+" USD";
                tax = Convert.ToDouble(TbxTax.Text);               
                TbxTaxCalculation.Text = Convert.ToString(grossPay * (tax/100))+" USD";
                netPay = hoursWorked * rateOfPay *(1 - (tax/100));
                TbxNetPay.Text = netPay.ToString()+" USD";
                exchangeRate = Convert.ToDouble(TbxExchangeRate.Text);
                total = netPay * exchangeRate;
                TbxTotalEur.Text = total.ToString() + " EUR";
                //MessageBox.Show("Your name is " + yourName + ", you have worked " + hoursWorked.ToString() + " hours/or days with a rate of pay equal to " + rateOfPay.ToString()+" USD");

            }
            catch (Exception FormatException)
            {
                MessageBox.Show("Input string was not in a correct formator you forgot to type the value.");
            }
            finally
            {

            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            TbxYourName.Text = "";
            TbxRateOfPay.Text = "";
            TbxHoursWorked.Text = "";
            TbxGrossPay.Text = "";
            TbxTax.Text = "";
            TbxTaxCalculation.Text = "";
            TbxNetPay.Text = "";
            TbxTotalEur.Text = "";
            TbxExchangeRate.Text = "";
        }
    }
}
