using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPriceQuote
{
    public partial class PriceQuote : Form
    {
        public PriceQuote()
        {
            InitializeComponent();
        }

        string name;
        double basePrice, package, tradeIn, subTotal, tax, taxCalculation, total;
        double baseStar, baseComet, baseOrbit, standardPackage, deluxePackage;

        public void RbtnDeluxe_CheckedChanged(object sender, EventArgs e)
        {
            package = deluxePackage;
            TbxPackage.Text = deluxePackage.ToString() + " $";
        }

        public void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter values in blue fields only.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void RbtnStandard_CheckedChanged(object sender, EventArgs e)
        {
            package = standardPackage;
            TbxPackage.Text = standardPackage.ToString() + " $";
        }

        public void RbtnOrbitJ10_CheckedChanged(object sender, EventArgs e)
        {
            basePrice = baseOrbit;
            TbxBasePrice.Text = baseOrbit.ToString() + " $";
        }

        public void PriceQuote_Load(object sender, EventArgs e)
        {
            RbtnCometJS.Checked = false;
            RbtnOrbitJ10.Checked = false;
            RbtnStarXL.Checked = false;
            RbtnStandard.Checked = false;
            RbtnDeluxe.Checked = false;

            baseStar = 10500;
            baseComet = 15500;
            baseOrbit = 21000;

            standardPackage = 2000;
            deluxePackage = 3000;
            TbxName.Text = "";
            TbxBasePrice.Text = "0";
            TbxPackage.Text = "0";
            TbxSubTotal.Text = "0";
            TbxTax.Text = "0";
            TbxTotal.Text = "0";
            TbxTaxCalculation.Text = "0";
            TbxTradeIn.Text = "0";
            basePrice = 0;
            package = 0;
           
        }

        public void RbtnCometJS_CheckedChanged(object sender, EventArgs e)
        {
            basePrice = baseComet;
            TbxBasePrice.Text = baseComet.ToString() + " $";
        }

        public void RbtnStarXL_CheckedChanged(object sender, EventArgs e)
        {
            basePrice = baseStar;
            TbxBasePrice.Text = baseStar.ToString() + " $";
        }

        public void BtnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                name = TbxName.Text;
                tax = Convert.ToDouble(TbxTax.Text);
                tradeIn = Convert.ToDouble(TbxTradeIn.Text);
                subTotal = basePrice + package - tradeIn;
                TbxSubTotal.Text = subTotal.ToString() + " $";
                taxCalculation = subTotal * (tax / 100);
                TbxTaxCalculation.Text = taxCalculation.ToString() + " $";

                total = subTotal + taxCalculation;
                TbxTotal.Text = total.ToString() + " $";

                var result = new Print();
                //Print.LblNamePrint.Text = TbxName.Text;
                //LblBasePricePrint.Text = TbxBasePrice.Text;
                //LblPackagePrint.Text = TbxPackage.Text;
                //LblTradeInPrint.Text = TbxTradeIn.Text;
                //LblSubTotalPrint.Text = TbxSubTotal.Text;
                //LblTaxPrint.Text = TbxTax.Text;
                //LblSalesPrint.Text = TbxTaxCalculation.Text;
                //LblTotalPricePrint.Text = TbxTotal.Text;
                result.ShowDialog();
                
            }   
            catch (FormatException)
            {
                MessageBox.Show("Input string was not in a correct format, one or some input fields were empty. Click on button 'New' to start again.", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }           
            
        }
      
       
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("2020 Acopex. All rights reserved. This program created by Aleksandr Cuchriajev (email info@acoptex.lt)", "About",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
