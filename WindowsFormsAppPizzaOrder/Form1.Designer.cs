namespace WindowsFormsAppPizzaOrder
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblBestPrice = new System.Windows.Forms.Label();
            this.LblShopName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RBtnXlarge = new System.Windows.Forms.RadioButton();
            this.RBtnLarge = new System.Windows.Forms.RadioButton();
            this.RBtnMedium = new System.Windows.Forms.RadioButton();
            this.RBtnSmall = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RBtnDeluxe = new System.Windows.Forms.RadioButton();
            this.RBtnStuffedCrust = new System.Windows.Forms.RadioButton();
            this.RBtnMeatLovers = new System.Windows.Forms.RadioButton();
            this.RBtnVeggie = new System.Windows.Forms.RadioButton();
            this.RBtnBasic = new System.Windows.Forms.RadioButton();
            this.LblItemSurcharge = new System.Windows.Forms.Label();
            this.LblPrice = new System.Windows.Forms.Label();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.LblQuantity = new System.Windows.Forms.Label();
            this.TbxQuantity = new System.Windows.Forms.TextBox();
            this.LblSubtotal = new System.Windows.Forms.Label();
            this.LblTax = new System.Windows.Forms.Label();
            this.TbxTax = new System.Windows.Forms.TextBox();
            this.LblTotal = new System.Windows.Forms.Label();
            this.LblPriceCalc = new System.Windows.Forms.Label();
            this.LblSubtotalCalc = new System.Windows.Forms.Label();
            this.LblTaxCalc = new System.Windows.Forms.Label();
            this.LblTotalCalc = new System.Windows.Forms.Label();
            this.LblBasePriceCalc = new System.Windows.Forms.Label();
            this.LblISCalc = new System.Windows.Forms.Label();
            this.BtnNew = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblBestPrice
            // 
            this.LblBestPrice.AutoSize = true;
            this.LblBestPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblBestPrice.Location = new System.Drawing.Point(11, 62);
            this.LblBestPrice.Name = "LblBestPrice";
            this.LblBestPrice.Size = new System.Drawing.Size(75, 17);
            this.LblBestPrice.TabIndex = 0;
            this.LblBestPrice.Text = "Base price";
            // 
            // LblShopName
            // 
            this.LblShopName.AutoSize = true;
            this.LblShopName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblShopName.Location = new System.Drawing.Point(9, 0);
            this.LblShopName.Name = "LblShopName";
            this.LblShopName.Size = new System.Drawing.Size(203, 31);
            this.LblShopName.TabIndex = 1;
            this.LblShopName.Text = "Alex pizza shop";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RBtnXlarge);
            this.groupBox1.Controls.Add(this.RBtnLarge);
            this.groupBox1.Controls.Add(this.RBtnMedium);
            this.groupBox1.Controls.Add(this.RBtnSmall);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(286, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 115);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Size";
            // 
            // RBtnXlarge
            // 
            this.RBtnXlarge.AutoSize = true;
            this.RBtnXlarge.Location = new System.Drawing.Point(7, 91);
            this.RBtnXlarge.Name = "RBtnXlarge";
            this.RBtnXlarge.Size = new System.Drawing.Size(64, 21);
            this.RBtnXlarge.TabIndex = 3;
            this.RBtnXlarge.Text = "xlarge";
            this.RBtnXlarge.UseVisualStyleBackColor = true;
            this.RBtnXlarge.CheckedChanged += new System.EventHandler(this.RBtnXlarge_CheckedChanged);
            // 
            // RBtnLarge
            // 
            this.RBtnLarge.AutoSize = true;
            this.RBtnLarge.Location = new System.Drawing.Point(7, 68);
            this.RBtnLarge.Name = "RBtnLarge";
            this.RBtnLarge.Size = new System.Drawing.Size(58, 21);
            this.RBtnLarge.TabIndex = 2;
            this.RBtnLarge.Text = "large";
            this.RBtnLarge.UseVisualStyleBackColor = true;
            this.RBtnLarge.CheckedChanged += new System.EventHandler(this.RBtnLarge_CheckedChanged);
            // 
            // RBtnMedium
            // 
            this.RBtnMedium.AutoSize = true;
            this.RBtnMedium.Location = new System.Drawing.Point(7, 44);
            this.RBtnMedium.Name = "RBtnMedium";
            this.RBtnMedium.Size = new System.Drawing.Size(75, 21);
            this.RBtnMedium.TabIndex = 1;
            this.RBtnMedium.Text = "medium";
            this.RBtnMedium.UseVisualStyleBackColor = true;
            this.RBtnMedium.CheckedChanged += new System.EventHandler(this.RBtnMedium_CheckedChanged);
            // 
            // RBtnSmall
            // 
            this.RBtnSmall.AutoSize = true;
            this.RBtnSmall.Location = new System.Drawing.Point(7, 20);
            this.RBtnSmall.Name = "RBtnSmall";
            this.RBtnSmall.Size = new System.Drawing.Size(58, 21);
            this.RBtnSmall.TabIndex = 0;
            this.RBtnSmall.Text = "small";
            this.RBtnSmall.UseVisualStyleBackColor = true;
            this.RBtnSmall.CheckedChanged += new System.EventHandler(this.RBtnSmall_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RBtnDeluxe);
            this.groupBox2.Controls.Add(this.RBtnStuffedCrust);
            this.groupBox2.Controls.Add(this.RBtnMeatLovers);
            this.groupBox2.Controls.Add(this.RBtnVeggie);
            this.groupBox2.Controls.Add(this.RBtnBasic);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(417, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(156, 147);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Type";
            // 
            // RBtnDeluxe
            // 
            this.RBtnDeluxe.AutoSize = true;
            this.RBtnDeluxe.Location = new System.Drawing.Point(7, 116);
            this.RBtnDeluxe.Name = "RBtnDeluxe";
            this.RBtnDeluxe.Size = new System.Drawing.Size(67, 21);
            this.RBtnDeluxe.TabIndex = 4;
            this.RBtnDeluxe.Text = "deluxe";
            this.RBtnDeluxe.UseVisualStyleBackColor = true;
            this.RBtnDeluxe.CheckedChanged += new System.EventHandler(this.RBtnDeluxe_CheckedChanged);
            // 
            // RBtnStuffedCrust
            // 
            this.RBtnStuffedCrust.AutoSize = true;
            this.RBtnStuffedCrust.Location = new System.Drawing.Point(7, 92);
            this.RBtnStuffedCrust.Name = "RBtnStuffedCrust";
            this.RBtnStuffedCrust.Size = new System.Drawing.Size(104, 21);
            this.RBtnStuffedCrust.TabIndex = 3;
            this.RBtnStuffedCrust.Text = "stuffed crust";
            this.RBtnStuffedCrust.UseVisualStyleBackColor = true;
            this.RBtnStuffedCrust.CheckedChanged += new System.EventHandler(this.RBtnStuffedCrust_CheckedChanged);
            // 
            // RBtnMeatLovers
            // 
            this.RBtnMeatLovers.AutoSize = true;
            this.RBtnMeatLovers.Location = new System.Drawing.Point(7, 68);
            this.RBtnMeatLovers.Name = "RBtnMeatLovers";
            this.RBtnMeatLovers.Size = new System.Drawing.Size(99, 21);
            this.RBtnMeatLovers.TabIndex = 2;
            this.RBtnMeatLovers.Text = "meat lovers";
            this.RBtnMeatLovers.UseVisualStyleBackColor = true;
            this.RBtnMeatLovers.CheckedChanged += new System.EventHandler(this.RBtnMeatLovers_CheckedChanged);
            // 
            // RBtnVeggie
            // 
            this.RBtnVeggie.AutoSize = true;
            this.RBtnVeggie.Location = new System.Drawing.Point(7, 44);
            this.RBtnVeggie.Name = "RBtnVeggie";
            this.RBtnVeggie.Size = new System.Drawing.Size(68, 21);
            this.RBtnVeggie.TabIndex = 1;
            this.RBtnVeggie.Text = "veggie";
            this.RBtnVeggie.UseVisualStyleBackColor = true;
            this.RBtnVeggie.CheckedChanged += new System.EventHandler(this.RBtnVeggie_CheckedChanged);
            // 
            // RBtnBasic
            // 
            this.RBtnBasic.AutoSize = true;
            this.RBtnBasic.Location = new System.Drawing.Point(7, 20);
            this.RBtnBasic.Name = "RBtnBasic";
            this.RBtnBasic.Size = new System.Drawing.Size(59, 21);
            this.RBtnBasic.TabIndex = 0;
            this.RBtnBasic.Text = "basic";
            this.RBtnBasic.UseVisualStyleBackColor = true;
            this.RBtnBasic.CheckedChanged += new System.EventHandler(this.RBtnBasic_CheckedChanged);
            // 
            // LblItemSurcharge
            // 
            this.LblItemSurcharge.AutoSize = true;
            this.LblItemSurcharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblItemSurcharge.Location = new System.Drawing.Point(11, 96);
            this.LblItemSurcharge.Name = "LblItemSurcharge";
            this.LblItemSurcharge.Size = new System.Drawing.Size(102, 17);
            this.LblItemSurcharge.TabIndex = 5;
            this.LblItemSurcharge.Text = "Item surcharge";
            // 
            // LblPrice
            // 
            this.LblPrice.AutoSize = true;
            this.LblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblPrice.Location = new System.Drawing.Point(11, 133);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(40, 17);
            this.LblPrice.TabIndex = 7;
            this.LblPrice.Text = "Price";
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Location = new System.Drawing.Point(293, 209);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(75, 23);
            this.BtnCalculate.TabIndex = 9;
            this.BtnCalculate.TabStop = false;
            this.BtnCalculate.Text = "Calculate";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(417, 209);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 11;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LblQuantity
            // 
            this.LblQuantity.AutoSize = true;
            this.LblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblQuantity.Location = new System.Drawing.Point(11, 172);
            this.LblQuantity.Name = "LblQuantity";
            this.LblQuantity.Size = new System.Drawing.Size(61, 17);
            this.LblQuantity.TabIndex = 12;
            this.LblQuantity.Text = "Quantity";
            // 
            // TbxQuantity
            // 
            this.TbxQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxQuantity.Location = new System.Drawing.Point(115, 162);
            this.TbxQuantity.Name = "TbxQuantity";
            this.TbxQuantity.Size = new System.Drawing.Size(120, 30);
            this.TbxQuantity.TabIndex = 13;
            this.TbxQuantity.Text = "0";
            this.TbxQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblSubtotal
            // 
            this.LblSubtotal.AutoSize = true;
            this.LblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblSubtotal.Location = new System.Drawing.Point(13, 212);
            this.LblSubtotal.Name = "LblSubtotal";
            this.LblSubtotal.Size = new System.Drawing.Size(60, 17);
            this.LblSubtotal.TabIndex = 14;
            this.LblSubtotal.Text = "Subtotal";
            // 
            // LblTax
            // 
            this.LblTax.AutoSize = true;
            this.LblTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblTax.Location = new System.Drawing.Point(13, 249);
            this.LblTax.Name = "LblTax";
            this.LblTax.Size = new System.Drawing.Size(47, 17);
            this.LblTax.TabIndex = 15;
            this.LblTax.Text = "Tax %";
            // 
            // TbxTax
            // 
            this.TbxTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxTax.Location = new System.Drawing.Point(59, 239);
            this.TbxTax.Name = "TbxTax";
            this.TbxTax.Size = new System.Drawing.Size(38, 30);
            this.TbxTax.TabIndex = 17;
            this.TbxTax.Text = "0.0";
            this.TbxTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblTotal.Location = new System.Drawing.Point(12, 285);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(40, 17);
            this.LblTotal.TabIndex = 18;
            this.LblTotal.Text = "Total";
            // 
            // LblPriceCalc
            // 
            this.LblPriceCalc.AutoSize = true;
            this.LblPriceCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblPriceCalc.Location = new System.Drawing.Point(148, 126);
            this.LblPriceCalc.Name = "LblPriceCalc";
            this.LblPriceCalc.Size = new System.Drawing.Size(66, 25);
            this.LblPriceCalc.TabIndex = 21;
            this.LblPriceCalc.Text = "0.00 $";
            // 
            // LblSubtotalCalc
            // 
            this.LblSubtotalCalc.AutoSize = true;
            this.LblSubtotalCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblSubtotalCalc.Location = new System.Drawing.Point(148, 205);
            this.LblSubtotalCalc.Name = "LblSubtotalCalc";
            this.LblSubtotalCalc.Size = new System.Drawing.Size(66, 25);
            this.LblSubtotalCalc.TabIndex = 22;
            this.LblSubtotalCalc.Text = "0.00 $";
            // 
            // LblTaxCalc
            // 
            this.LblTaxCalc.AutoSize = true;
            this.LblTaxCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblTaxCalc.Location = new System.Drawing.Point(148, 241);
            this.LblTaxCalc.Name = "LblTaxCalc";
            this.LblTaxCalc.Size = new System.Drawing.Size(66, 25);
            this.LblTaxCalc.TabIndex = 23;
            this.LblTaxCalc.Text = "0.00 $";
            // 
            // LblTotalCalc
            // 
            this.LblTotalCalc.AutoSize = true;
            this.LblTotalCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblTotalCalc.Location = new System.Drawing.Point(148, 278);
            this.LblTotalCalc.Name = "LblTotalCalc";
            this.LblTotalCalc.Size = new System.Drawing.Size(66, 25);
            this.LblTotalCalc.TabIndex = 24;
            this.LblTotalCalc.Text = "0.00 $";
            // 
            // LblBasePriceCalc
            // 
            this.LblBasePriceCalc.AutoSize = true;
            this.LblBasePriceCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblBasePriceCalc.Location = new System.Drawing.Point(148, 55);
            this.LblBasePriceCalc.Name = "LblBasePriceCalc";
            this.LblBasePriceCalc.Size = new System.Drawing.Size(66, 25);
            this.LblBasePriceCalc.TabIndex = 25;
            this.LblBasePriceCalc.Text = "0.00 $";
            // 
            // LblISCalc
            // 
            this.LblISCalc.AutoSize = true;
            this.LblISCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblISCalc.Location = new System.Drawing.Point(148, 89);
            this.LblISCalc.Name = "LblISCalc";
            this.LblISCalc.Size = new System.Drawing.Size(66, 25);
            this.LblISCalc.TabIndex = 26;
            this.LblISCalc.Text = "0.00 $";
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(293, 245);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(75, 23);
            this.BtnNew.TabIndex = 27;
            this.BtnNew.Text = "New order";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 311);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.LblISCalc);
            this.Controls.Add(this.LblBasePriceCalc);
            this.Controls.Add(this.LblTotalCalc);
            this.Controls.Add(this.LblTaxCalc);
            this.Controls.Add(this.LblSubtotalCalc);
            this.Controls.Add(this.LblPriceCalc);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.TbxTax);
            this.Controls.Add(this.LblTax);
            this.Controls.Add(this.LblSubtotal);
            this.Controls.Add(this.TbxQuantity);
            this.Controls.Add(this.LblQuantity);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.LblPrice);
            this.Controls.Add(this.LblItemSurcharge);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LblShopName);
            this.Controls.Add(this.LblBestPrice);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizza order program";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblBestPrice;
        private System.Windows.Forms.Label LblShopName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RBtnXlarge;
        private System.Windows.Forms.RadioButton RBtnLarge;
        private System.Windows.Forms.RadioButton RBtnMedium;
        private System.Windows.Forms.RadioButton RBtnSmall;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RBtnDeluxe;
        private System.Windows.Forms.RadioButton RBtnStuffedCrust;
        private System.Windows.Forms.RadioButton RBtnMeatLovers;
        private System.Windows.Forms.RadioButton RBtnVeggie;
        private System.Windows.Forms.RadioButton RBtnBasic;
        private System.Windows.Forms.Label LblItemSurcharge;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label LblQuantity;
        private System.Windows.Forms.TextBox TbxQuantity;
        private System.Windows.Forms.Label LblSubtotal;
        private System.Windows.Forms.Label LblTax;
        private System.Windows.Forms.TextBox TbxTax;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label LblPriceCalc;
        private System.Windows.Forms.Label LblSubtotalCalc;
        private System.Windows.Forms.Label LblTaxCalc;
        private System.Windows.Forms.Label LblTotalCalc;
        private System.Windows.Forms.Label LblBasePriceCalc;
        private System.Windows.Forms.Label LblISCalc;
        private System.Windows.Forms.Button BtnNew;
    }
}

