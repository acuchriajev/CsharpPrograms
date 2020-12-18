namespace WindowsFormsAppPriceQuote
{
    partial class PriceQuote
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
            this.LblName = new System.Windows.Forms.Label();
            this.TbxName = new System.Windows.Forms.TextBox();
            this.LblBasePrice = new System.Windows.Forms.Label();
            this.LblPackage = new System.Windows.Forms.Label();
            this.TbxBasePrice = new System.Windows.Forms.TextBox();
            this.TbxPackage = new System.Windows.Forms.TextBox();
            this.LblTradeIn = new System.Windows.Forms.Label();
            this.TbxTradeIn = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RbtnStarXL = new System.Windows.Forms.RadioButton();
            this.RbtnCometJS = new System.Windows.Forms.RadioButton();
            this.RbtnOrbitJ10 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RbtnStandard = new System.Windows.Forms.RadioButton();
            this.RbtnDeluxe = new System.Windows.Forms.RadioButton();
            this.LblSubTotal = new System.Windows.Forms.Label();
            this.TbxSubTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblHeading = new System.Windows.Forms.Label();
            this.TbxTax = new System.Windows.Forms.TextBox();
            this.TbxTaxCalculation = new System.Windows.Forms.TextBox();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.LblTotal = new System.Windows.Forms.Label();
            this.TbxTotal = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblName.Location = new System.Drawing.Point(12, 34);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(49, 17);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Name:";
            // 
            // TbxName
            // 
            this.TbxName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxName.Location = new System.Drawing.Point(107, 27);
            this.TbxName.Name = "TbxName";
            this.TbxName.Size = new System.Drawing.Size(113, 30);
            this.TbxName.TabIndex = 1;
            // 
            // LblBasePrice
            // 
            this.LblBasePrice.AutoSize = true;
            this.LblBasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblBasePrice.Location = new System.Drawing.Point(10, 73);
            this.LblBasePrice.Name = "LblBasePrice";
            this.LblBasePrice.Size = new System.Drawing.Size(80, 17);
            this.LblBasePrice.TabIndex = 2;
            this.LblBasePrice.Text = "Base Price:";
            // 
            // LblPackage
            // 
            this.LblPackage.AutoSize = true;
            this.LblPackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblPackage.Location = new System.Drawing.Point(12, 111);
            this.LblPackage.Name = "LblPackage";
            this.LblPackage.Size = new System.Drawing.Size(67, 17);
            this.LblPackage.TabIndex = 3;
            this.LblPackage.Text = "Package:";
            // 
            // TbxBasePrice
            // 
            this.TbxBasePrice.BackColor = System.Drawing.Color.Silver;
            this.TbxBasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxBasePrice.Location = new System.Drawing.Point(107, 63);
            this.TbxBasePrice.Name = "TbxBasePrice";
            this.TbxBasePrice.Size = new System.Drawing.Size(113, 30);
            this.TbxBasePrice.TabIndex = 4;
            // 
            // TbxPackage
            // 
            this.TbxPackage.BackColor = System.Drawing.Color.Silver;
            this.TbxPackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxPackage.Location = new System.Drawing.Point(107, 101);
            this.TbxPackage.Name = "TbxPackage";
            this.TbxPackage.Size = new System.Drawing.Size(113, 30);
            this.TbxPackage.TabIndex = 5;
            // 
            // LblTradeIn
            // 
            this.LblTradeIn.AutoSize = true;
            this.LblTradeIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblTradeIn.Location = new System.Drawing.Point(10, 146);
            this.LblTradeIn.Name = "LblTradeIn";
            this.LblTradeIn.Size = new System.Drawing.Size(65, 17);
            this.LblTradeIn.TabIndex = 6;
            this.LblTradeIn.Text = "Trade in:";
            // 
            // TbxTradeIn
            // 
            this.TbxTradeIn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TbxTradeIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxTradeIn.Location = new System.Drawing.Point(107, 136);
            this.TbxTradeIn.Name = "TbxTradeIn";
            this.TbxTradeIn.Size = new System.Drawing.Size(113, 30);
            this.TbxTradeIn.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RbtnOrbitJ10);
            this.groupBox1.Controls.Add(this.RbtnCometJS);
            this.groupBox1.Controls.Add(this.RbtnStarXL);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(223, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(107, 113);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose one";
            // 
            // RbtnStarXL
            // 
            this.RbtnStarXL.AutoSize = true;
            this.RbtnStarXL.Checked = true;
            this.RbtnStarXL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RbtnStarXL.Location = new System.Drawing.Point(7, 20);
            this.RbtnStarXL.Name = "RbtnStarXL";
            this.RbtnStarXL.Size = new System.Drawing.Size(73, 21);
            this.RbtnStarXL.TabIndex = 0;
            this.RbtnStarXL.TabStop = true;
            this.RbtnStarXL.Text = "Star XL";
            this.RbtnStarXL.UseVisualStyleBackColor = true;
            this.RbtnStarXL.CheckedChanged += new System.EventHandler(this.RbtnStarXL_CheckedChanged);
            // 
            // RbtnCometJS
            // 
            this.RbtnCometJS.AutoSize = true;
            this.RbtnCometJS.Location = new System.Drawing.Point(7, 48);
            this.RbtnCometJS.Name = "RbtnCometJS";
            this.RbtnCometJS.Size = new System.Drawing.Size(86, 21);
            this.RbtnCometJS.TabIndex = 1;
            this.RbtnCometJS.Text = "Comet JS";
            this.RbtnCometJS.UseVisualStyleBackColor = true;
            this.RbtnCometJS.CheckedChanged += new System.EventHandler(this.RbtnCometJS_CheckedChanged);
            // 
            // RbtnOrbitJ10
            // 
            this.RbtnOrbitJ10.AutoSize = true;
            this.RbtnOrbitJ10.Location = new System.Drawing.Point(7, 80);
            this.RbtnOrbitJ10.Name = "RbtnOrbitJ10";
            this.RbtnOrbitJ10.Size = new System.Drawing.Size(84, 21);
            this.RbtnOrbitJ10.TabIndex = 2;
            this.RbtnOrbitJ10.Text = "Orbit J10";
            this.RbtnOrbitJ10.UseVisualStyleBackColor = true;
            this.RbtnOrbitJ10.CheckedChanged += new System.EventHandler(this.RbtnOrbitJ10_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RbtnDeluxe);
            this.groupBox2.Controls.Add(this.RbtnStandard);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(346, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(107, 113);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choose one";
            // 
            // RbtnStandard
            // 
            this.RbtnStandard.AutoSize = true;
            this.RbtnStandard.Checked = true;
            this.RbtnStandard.Location = new System.Drawing.Point(7, 34);
            this.RbtnStandard.Name = "RbtnStandard";
            this.RbtnStandard.Size = new System.Drawing.Size(84, 21);
            this.RbtnStandard.TabIndex = 0;
            this.RbtnStandard.TabStop = true;
            this.RbtnStandard.Text = "Standard";
            this.RbtnStandard.UseVisualStyleBackColor = true;
            this.RbtnStandard.CheckedChanged += new System.EventHandler(this.RbtnStandard_CheckedChanged);
            // 
            // RbtnDeluxe
            // 
            this.RbtnDeluxe.AutoSize = true;
            this.RbtnDeluxe.Location = new System.Drawing.Point(6, 74);
            this.RbtnDeluxe.Name = "RbtnDeluxe";
            this.RbtnDeluxe.Size = new System.Drawing.Size(69, 21);
            this.RbtnDeluxe.TabIndex = 1;
            this.RbtnDeluxe.Text = "Deluxe";
            this.RbtnDeluxe.UseVisualStyleBackColor = true;
            this.RbtnDeluxe.CheckedChanged += new System.EventHandler(this.RbtnDeluxe_CheckedChanged);
            // 
            // LblSubTotal
            // 
            this.LblSubTotal.AutoSize = true;
            this.LblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblSubTotal.Location = new System.Drawing.Point(12, 184);
            this.LblSubTotal.Name = "LblSubTotal";
            this.LblSubTotal.Size = new System.Drawing.Size(69, 17);
            this.LblSubTotal.TabIndex = 10;
            this.LblSubTotal.Text = "SubTotal:";
            // 
            // TbxSubTotal
            // 
            this.TbxSubTotal.BackColor = System.Drawing.Color.Silver;
            this.TbxSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxSubTotal.Location = new System.Drawing.Point(107, 174);
            this.TbxSubTotal.Name = "TbxSubTotal";
            this.TbxSubTotal.Size = new System.Drawing.Size(113, 30);
            this.TbxSubTotal.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sales tax %:";
            // 
            // LblHeading
            // 
            this.LblHeading.AutoSize = true;
            this.LblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblHeading.Location = new System.Drawing.Point(235, 37);
            this.LblHeading.Name = "LblHeading";
            this.LblHeading.Size = new System.Drawing.Size(198, 17);
            this.LblHeading.TabIndex = 12;
            this.LblHeading.Text = "Venus Motors Price Quote";
            // 
            // TbxTax
            // 
            this.TbxTax.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TbxTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxTax.Location = new System.Drawing.Point(107, 208);
            this.TbxTax.Name = "TbxTax";
            this.TbxTax.Size = new System.Drawing.Size(39, 30);
            this.TbxTax.TabIndex = 13;
            // 
            // TbxTaxCalculation
            // 
            this.TbxTaxCalculation.BackColor = System.Drawing.Color.Silver;
            this.TbxTaxCalculation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxTaxCalculation.Location = new System.Drawing.Point(152, 208);
            this.TbxTaxCalculation.Name = "TbxTaxCalculation";
            this.TbxTaxCalculation.Size = new System.Drawing.Size(116, 30);
            this.TbxTaxCalculation.TabIndex = 14;
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Location = new System.Drawing.Point(346, 181);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(75, 23);
            this.BtnCalculate.TabIndex = 15;
            this.BtnCalculate.Text = "Calculate";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(346, 215);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(75, 23);
            this.BtnNew.TabIndex = 16;
            this.BtnNew.Text = "New";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.PriceQuote_Load);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(346, 247);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 17;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblTotal.Location = new System.Drawing.Point(10, 257);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(80, 17);
            this.LblTotal.TabIndex = 18;
            this.LblTotal.Text = "Total Price:";
            // 
            // TbxTotal
            // 
            this.TbxTotal.BackColor = System.Drawing.Color.Silver;
            this.TbxTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxTotal.Location = new System.Drawing.Point(107, 247);
            this.TbxTotal.Name = "TbxTotal";
            this.TbxTotal.Size = new System.Drawing.Size(113, 30);
            this.TbxTotal.TabIndex = 19;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(466, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // PriceQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 286);
            this.Controls.Add(this.TbxTotal);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.TbxTaxCalculation);
            this.Controls.Add(this.TbxTax);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblHeading);
            this.Controls.Add(this.TbxSubTotal);
            this.Controls.Add(this.LblSubTotal);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TbxTradeIn);
            this.Controls.Add(this.LblTradeIn);
            this.Controls.Add(this.TbxPackage);
            this.Controls.Add(this.TbxBasePrice);
            this.Controls.Add(this.LblPackage);
            this.Controls.Add(this.LblBasePrice);
            this.Controls.Add(this.TbxName);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PriceQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Price quote";
            this.Load += new System.EventHandler(this.PriceQuote_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TbxName;
        private System.Windows.Forms.Label LblBasePrice;
        private System.Windows.Forms.Label LblPackage;
        private System.Windows.Forms.TextBox TbxBasePrice;
        private System.Windows.Forms.TextBox TbxPackage;
        private System.Windows.Forms.Label LblTradeIn;
        private System.Windows.Forms.TextBox TbxTradeIn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RbtnOrbitJ10;
        private System.Windows.Forms.RadioButton RbtnCometJS;
        private System.Windows.Forms.RadioButton RbtnStarXL;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RbtnDeluxe;
        private System.Windows.Forms.RadioButton RbtnStandard;
        private System.Windows.Forms.Label LblSubTotal;
        private System.Windows.Forms.TextBox TbxSubTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblHeading;
        private System.Windows.Forms.TextBox TbxTax;
        private System.Windows.Forms.TextBox TbxTaxCalculation;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.TextBox TbxTotal;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}

