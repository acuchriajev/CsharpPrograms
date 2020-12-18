using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPizzaOrder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double small, medium, large, xlarge;
        double basic, veggie, meatLovers, stuffedCrust, deluxe;
        double basePrice, basicSurcharge, subTotal, price, quantity, tax, taxCalc, total;

        private void BtnNew_Click(object sender, EventArgs e)
        {
            basePrice = 0;
            basicSurcharge = 0;

            LblBasePriceCalc.Text = "0.00 $";
            LblISCalc.Text = "0.00 $";
            LblPriceCalc.Text = "0.00 $";

            LblSubtotalCalc.Text = "0.00 $";
            LblTaxCalc.Text = "0.00 $";
            LblTotalCalc.Text = "0.00 $";
            TbxQuantity.Text = "0";
            TbxTax.Text = "0.0";

            RBtnBasic.Checked = false;
            RBtnDeluxe.Checked = false;
            RBtnLarge.Checked = false;
            RBtnMeatLovers.Checked = false;
            RBtnMedium.Checked = false;
            RBtnSmall.Checked = false;
            RBtnStuffedCrust.Checked = false;
            RBtnVeggie.Checked = false;
            RBtnXlarge.Checked = false;
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                quantity = Convert.ToInt32(TbxQuantity.Text);
                tax = Convert.ToDouble(TbxTax.Text);
                subTotal = price * quantity;
                taxCalc = subTotal * (tax / 100);
                total = taxCalc + subTotal;
                LblSubtotalCalc.Text = subTotal.ToString() + " $";
                LblTaxCalc.Text = taxCalc.ToString() + " $";
                LblTotalCalc.Text = total.ToString() + " $";
            }
            catch (FormatException)
            {
                MessageBox.Show("Input string was not in a correct format. Start with new order.");
            }
            
        }
        

        private void RBtnDeluxe_CheckedChanged(object sender, EventArgs e)
        {
            basicSurcharge = deluxe;
            LblISCalc.Text = basicSurcharge.ToString() + " $";
            price = basePrice + basicSurcharge;
            LblPriceCalc.Text = price.ToString() + " $";
        }
        private void RBtnStuffedCrust_CheckedChanged(object sender, EventArgs e)
        {
            basicSurcharge = stuffedCrust;
            LblISCalc.Text = basicSurcharge.ToString() + " $";
            price = basePrice + basicSurcharge;
            LblPriceCalc.Text = price.ToString() + " $";
        }
        private void RBtnMeatLovers_CheckedChanged(object sender, EventArgs e)
        {
            basicSurcharge = meatLovers;
            LblISCalc.Text = basicSurcharge.ToString() + " $";
            price = basePrice + basicSurcharge;
            LblPriceCalc.Text = price.ToString() + " $";
        }
        private void RBtnVeggie_CheckedChanged(object sender, EventArgs e)
        {
            basicSurcharge = veggie;
            price = basePrice + basicSurcharge;
            LblISCalc.Text = basicSurcharge.ToString() + " $";
            LblPriceCalc.Text = price.ToString() + " $";
        }
        private void RBtnBasic_CheckedChanged(object sender, EventArgs e)
        {
            basicSurcharge = basic;
            price = basePrice + basicSurcharge;
            LblISCalc.Text = basicSurcharge.ToString()+" $";
            LblPriceCalc.Text = price.ToString() + " $";

        }

        private void RBtnMedium_CheckedChanged(object sender, EventArgs e)
        {
            basePrice = medium;
            price = basePrice + basicSurcharge;
            LblBasePriceCalc.Text = basePrice.ToString() + " $";
            LblPriceCalc.Text=price.ToString() + " $";

        }

        private void RBtnSmall_CheckedChanged(object sender, EventArgs e)
        {
            basePrice = small;

            total = basePrice + basicSurcharge;
           
            LblBasePriceCalc.Text = basePrice.ToString() + " $";
            LblPriceCalc.Text = total.ToString() + " $";
        }
        private void RBtnXlarge_CheckedChanged(object sender, EventArgs e)
        {
            basePrice = xlarge;
            LblBasePriceCalc.Text = basePrice.ToString() + " $";
            total = basePrice + basicSurcharge;
            LblPriceCalc.Text = total.ToString() + " $";
        }

        private void RBtnLarge_CheckedChanged(object sender, EventArgs e)
        {
            basePrice = large;
            LblBasePriceCalc.Text = basePrice.ToString() + " $";
            total = basePrice + basicSurcharge;
            LblPriceCalc.Text = total.ToString() + " $";
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            small = 4.99;
            medium =5.99;
            large =7.99;
            xlarge =9.99;

            basic = 0.89;
            veggie = 1.49;
            meatLovers = 2.07;
            stuffedCrust = 3.45;
            deluxe = 4.75;
           

            RBtnBasic.Checked = false;
            RBtnDeluxe.Checked = false;
            RBtnMeatLovers.Checked = false;
            RBtnStuffedCrust.Checked = false;
            RBtnVeggie.Checked = false;

            RBtnMedium.Checked = false;
            RBtnSmall.Checked = false;
            RBtnLarge.Checked = false;
            RBtnXlarge.Checked = false;
        }
    }
}
