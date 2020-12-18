using Microsoft.VisualBasic;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsAppCafeteria
{
    public partial class FrmMain : Form
    {
       static float taxValuePerc, appetizer, main, refreshment, juice, pop, water, soup, salad, chicken, lasagna, steak, total, tax, subTotal, taxValue;
        static int bill;
        static string billLetters;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void newOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;
            tbxMain.Text = "0.00 $";
            tbxAppetizer.Text = "0.00 $";
            tbxRefreshment.Text = "0.00 $";
            tbxSubtotal.Text = "0.00 $";
            tbxTax.Text = "0.00 $";
            tbxTotal.Text = "0.00 $";
            rtbxResult.Text = "";
            bill++;
            tbxBillNo.Text = billLetters + bill.ToString();
            appetizer = 0;
            main = 0;
            refreshment = 0;
            tax = 0;
            total = 0;
            subTotal = 0;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                rtbxResult.SaveFile(saveFileDialog1.FileName);
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                rtbxResult.LoadFile(openFileDialog1.FileName);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rtbxResult.Text, rtbxResult.Font, Brushes.Black, e.MarginBounds, StringFormat.GenericTypographic);
        }

        

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;
            tbxMain.Text = "0.00 $";
            tbxAppetizer.Text = "0.00 $";
            tbxRefreshment.Text = "0.00 $";
            tbxSubtotal.Text = "0.00 $";
            tbxTax.Text = "0.00 $";
            tbxTotal.Text = "0.00 $";
            rtbxResult.Text = "";
            bill++;
            tbxBillNo.Text = billLetters + bill.ToString();
            appetizer = 0;
            main = 0;
            refreshment = 0;
            tax = 0;
            total = 0;
            subTotal = 0;  
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Prices();
            try { bill = int.Parse(Interaction.InputBox("Type the receipt no: ")); }
            catch
            {
                MessageBox.Show("Type number only. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bill = int.Parse(Interaction.InputBox("Type the receipt no: "));
            }
            billLetters = Interaction.InputBox("Type the bill series: ");
            taxValuePerc = 13;
            taxValue = taxValuePerc / 100.00F;
            tbxMain.Text = "0.00 $";
            tbxAppetizer.Text = "0.00 $";
            tbxRefreshment.Text = "0.00 $";
            tbxSubtotal.Text = "0.00 $";
            tbxTax.Text = "0.00 $";
            tbxTotal.Text = "0.00 $";
            tbxBillNo.Text = billLetters + bill.ToString();
            lblTaxValuePerc.Text = "Tax (" + taxValuePerc.ToString() + " %)";
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            rtbxResult.AppendText("Bill no: " +
                 tbxBillNo.Text + "\n\n");
            if (appetizer==salad)
            {
                rtbxResult.AppendText("Appetizer:\n\n" +
                 "Salad: " + salad.ToString("n2") + " $\n\n");
            }
            else if (appetizer == soup)
            {
                rtbxResult.AppendText("Appetizer:\n\n" +
                 "Soup: " + soup.ToString("n2") + " $\n\n");
            }
            if (main == steak)
            {
                rtbxResult.AppendText("Main:\n\n" +
                 "Steak: " + steak.ToString("n2") + " $\n\n");
            }
            else if (main == lasagna)
            {
                rtbxResult.AppendText("Main:\n\n" +
                 "Lasagna: " + lasagna.ToString("n2") + " $\n\n");
            }
            else if (main == chicken)
            {
                rtbxResult.AppendText("Main:\n\n" +
                 "Chicken: " + chicken.ToString("n2") + " $\n\n");
            }

            if (refreshment == water)
            {
                rtbxResult.AppendText("Refreshment:\n\n" +
                 "Water: " + water.ToString("n2") + " $\n\n");
            }
            else if (refreshment==juice)
            {
                rtbxResult.AppendText("Refreshment:\n\n" +
                 "Juice: " + juice.ToString("n2") + " $\n\n");
            }
            else if (refreshment==pop)
            {
                rtbxResult.AppendText("Refreshment:\n\n" +
                 "Pop: " + pop.ToString("n2") + " $\n\n");
            }

            rtbxResult.AppendText("------------------------------\n\n" +
                 "Subtotal: " + subTotal.ToString("n2") + " $\n\n");
            
            tax = subTotal * taxValue;            
            total = subTotal + tax;
            
            tbxTax.Text = tax.ToString("n2") + " $";
            tbxTotal.Text = total.ToString("n2") + " $";
            rtbxResult.AppendText("------------------------------\n\n" +
                 "Tax " + taxValuePerc + "% :" + tax.ToString("n2") + " $\n\n");
            rtbxResult.AppendText("------------------------------\n\n" +
                 "Total:" + total.ToString("n2") + " $\n\n");
        }

     

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program designed for small cafeteria.\n\n " +
                "Created by C# developer Aleksandr Cuchriajev.\n\n " +
                "Contact email: info.acoptex@gmail.com.\n\n" +
                "Ver.1.0\n\n" +
                "2020 Acoptex.lt All rights reserved.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            tbxRefreshment.Text = juice.ToString("n2") + " $";
           
            refreshment = juice;
            
            subTotal = appetizer + main + refreshment;
            tbxSubtotal.Text = subTotal.ToString("n2") + " $";

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            tbxRefreshment.Text = water.ToString("n2") + " $";
            refreshment = water;
            
            subTotal = appetizer + main + refreshment;
            tbxSubtotal.Text = subTotal.ToString("n2") + " $";

        }
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            tbxRefreshment.Text = pop.ToString("n2") + " $";
            refreshment = pop;
            
            subTotal = appetizer + main + refreshment;
            tbxSubtotal.Text = subTotal.ToString("n2") + " $";

        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            tbxMain.Text = steak.ToString("n2") + " $";
            main = steak;
            
            subTotal = appetizer + main + refreshment;
            tbxSubtotal.Text = subTotal.ToString("n2") + " $";

        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            tbxMain.Text = lasagna.ToString("n2") + " $";
            main = lasagna;
            
            subTotal = appetizer + main + refreshment;
            tbxSubtotal.Text = subTotal.ToString("n2") + " $";
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            tbxMain.Text = chicken.ToString("n2") + " $";
            main = chicken;
            
            subTotal = appetizer + main + refreshment;
            tbxSubtotal.Text = subTotal.ToString("n2") + " $";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            tbxAppetizer.Text = salad.ToString("n2") + " $";
            appetizer = salad;

            subTotal = appetizer + main + refreshment;
            tbxSubtotal.Text = subTotal.ToString("n2") + " $";

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            tbxAppetizer.Text = soup.ToString("n2") + " $";
            appetizer = soup;
            subTotal = appetizer + main + refreshment;
            tbxSubtotal.Text = subTotal.ToString("n2") + " $";
        }

        
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private static void Prices()
        {            
            soup = 2.00F;
            salad = 2.50F;
            pop = 1.25F;
            water = 1.00F;
            juice = 1.30F;
            chicken = 10.50F;
            lasagna = 11.75F;
            steak = 15.00F;           
            
            appetizer = 0;
            main = 0;
            refreshment = 0;
            tax = 0;
            total = 0;
            subTotal = 0;            
        }
    }
}
