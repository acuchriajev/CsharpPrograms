namespace WindowsFormsAppSalaryCalculation
{
    partial class SalaryCalculator
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
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.LblYourName = new System.Windows.Forms.Label();
            this.LblRateOfPay = new System.Windows.Forms.Label();
            this.TbxYourName = new System.Windows.Forms.TextBox();
            this.TbxRateOfPay = new System.Windows.Forms.TextBox();
            this.LblHoursWorked = new System.Windows.Forms.Label();
            this.TbxHoursWorked = new System.Windows.Forms.TextBox();
            this.LblGrossPay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TbxTax = new System.Windows.Forms.TextBox();
            this.TbxGrossPay = new System.Windows.Forms.TextBox();
            this.TbxTaxCalculation = new System.Windows.Forms.TextBox();
            this.LblNetPay = new System.Windows.Forms.Label();
            this.TbxNetPay = new System.Windows.Forms.TextBox();
            this.LblExchangeRate = new System.Windows.Forms.Label();
            this.TbxExchangeRate = new System.Windows.Forms.TextBox();
            this.LblTotal = new System.Windows.Forms.Label();
            this.TbxTotalEur = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Location = new System.Drawing.Point(24, 326);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(75, 23);
            this.BtnCalculate.TabIndex = 0;
            this.BtnCalculate.Text = "Calculate";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(126, 326);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(75, 23);
            this.BtnReset.TabIndex = 1;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(228, 326);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // LblYourName
            // 
            this.LblYourName.AutoSize = true;
            this.LblYourName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblYourName.Location = new System.Drawing.Point(13, 34);
            this.LblYourName.Name = "LblYourName";
            this.LblYourName.Size = new System.Drawing.Size(81, 17);
            this.LblYourName.TabIndex = 3;
            this.LblYourName.Text = "Your name:";
            // 
            // LblRateOfPay
            // 
            this.LblRateOfPay.AutoSize = true;
            this.LblRateOfPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblRateOfPay.Location = new System.Drawing.Point(14, 64);
            this.LblRateOfPay.Name = "LblRateOfPay";
            this.LblRateOfPay.Size = new System.Drawing.Size(85, 17);
            this.LblRateOfPay.TabIndex = 4;
            this.LblRateOfPay.Text = "Rate of pay:";
            // 
            // TbxYourName
            // 
            this.TbxYourName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TbxYourName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxYourName.Location = new System.Drawing.Point(179, 29);
            this.TbxYourName.Name = "TbxYourName";
            this.TbxYourName.Size = new System.Drawing.Size(125, 30);
            this.TbxYourName.TabIndex = 5;
            // 
            // TbxRateOfPay
            // 
            this.TbxRateOfPay.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TbxRateOfPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxRateOfPay.Location = new System.Drawing.Point(179, 64);
            this.TbxRateOfPay.Name = "TbxRateOfPay";
            this.TbxRateOfPay.Size = new System.Drawing.Size(125, 30);
            this.TbxRateOfPay.TabIndex = 6;
            // 
            // LblHoursWorked
            // 
            this.LblHoursWorked.AutoSize = true;
            this.LblHoursWorked.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblHoursWorked.Location = new System.Drawing.Point(12, 100);
            this.LblHoursWorked.Name = "LblHoursWorked";
            this.LblHoursWorked.Size = new System.Drawing.Size(135, 17);
            this.LblHoursWorked.TabIndex = 7;
            this.LblHoursWorked.Text = "Hours/Days worked:";
            // 
            // TbxHoursWorked
            // 
            this.TbxHoursWorked.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TbxHoursWorked.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxHoursWorked.Location = new System.Drawing.Point(179, 100);
            this.TbxHoursWorked.Name = "TbxHoursWorked";
            this.TbxHoursWorked.Size = new System.Drawing.Size(125, 30);
            this.TbxHoursWorked.TabIndex = 8;
            // 
            // LblGrossPay
            // 
            this.LblGrossPay.AutoSize = true;
            this.LblGrossPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblGrossPay.Location = new System.Drawing.Point(14, 136);
            this.LblGrossPay.Name = "LblGrossPay";
            this.LblGrossPay.Size = new System.Drawing.Size(77, 17);
            this.LblGrossPay.TabIndex = 9;
            this.LblGrossPay.Text = "Gross pay:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tax %";
            // 
            // TbxTax
            // 
            this.TbxTax.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TbxTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxTax.Location = new System.Drawing.Point(67, 172);
            this.TbxTax.Name = "TbxTax";
            this.TbxTax.Size = new System.Drawing.Size(38, 30);
            this.TbxTax.TabIndex = 11;
            // 
            // TbxGrossPay
            // 
            this.TbxGrossPay.BackColor = System.Drawing.Color.Silver;
            this.TbxGrossPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxGrossPay.Location = new System.Drawing.Point(179, 136);
            this.TbxGrossPay.Name = "TbxGrossPay";
            this.TbxGrossPay.Size = new System.Drawing.Size(125, 30);
            this.TbxGrossPay.TabIndex = 12;
            // 
            // TbxTaxCalculation
            // 
            this.TbxTaxCalculation.BackColor = System.Drawing.Color.Silver;
            this.TbxTaxCalculation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxTaxCalculation.Location = new System.Drawing.Point(179, 172);
            this.TbxTaxCalculation.Name = "TbxTaxCalculation";
            this.TbxTaxCalculation.Size = new System.Drawing.Size(125, 30);
            this.TbxTaxCalculation.TabIndex = 13;
            // 
            // LblNetPay
            // 
            this.LblNetPay.AutoSize = true;
            this.LblNetPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblNetPay.Location = new System.Drawing.Point(14, 208);
            this.LblNetPay.Name = "LblNetPay";
            this.LblNetPay.Size = new System.Drawing.Size(62, 17);
            this.LblNetPay.TabIndex = 14;
            this.LblNetPay.Text = "Net Pay:";
            // 
            // TbxNetPay
            // 
            this.TbxNetPay.BackColor = System.Drawing.Color.Silver;
            this.TbxNetPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxNetPay.Location = new System.Drawing.Point(179, 208);
            this.TbxNetPay.Name = "TbxNetPay";
            this.TbxNetPay.Size = new System.Drawing.Size(124, 30);
            this.TbxNetPay.TabIndex = 15;
            // 
            // LblExchangeRate
            // 
            this.LblExchangeRate.AutoSize = true;
            this.LblExchangeRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblExchangeRate.Location = new System.Drawing.Point(12, 244);
            this.LblExchangeRate.Name = "LblExchangeRate";
            this.LblExchangeRate.Size = new System.Drawing.Size(169, 17);
            this.LblExchangeRate.TabIndex = 16;
            this.LblExchangeRate.Text = "Exchange rate USD EUR:";
            // 
            // TbxExchangeRate
            // 
            this.TbxExchangeRate.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TbxExchangeRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxExchangeRate.Location = new System.Drawing.Point(179, 244);
            this.TbxExchangeRate.Name = "TbxExchangeRate";
            this.TbxExchangeRate.Size = new System.Drawing.Size(124, 30);
            this.TbxExchangeRate.TabIndex = 17;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblTotal.Location = new System.Drawing.Point(14, 280);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(44, 17);
            this.LblTotal.TabIndex = 18;
            this.LblTotal.Text = "Total:";
            // 
            // TbxTotalEur
            // 
            this.TbxTotalEur.BackColor = System.Drawing.Color.Silver;
            this.TbxTotalEur.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxTotalEur.Location = new System.Drawing.Point(179, 280);
            this.TbxTotalEur.Name = "TbxTotalEur";
            this.TbxTotalEur.Size = new System.Drawing.Size(124, 30);
            this.TbxTotalEur.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Type the values into the blue fields";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Notes:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(529, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // SalaryCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 376);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbxTotalEur);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.TbxExchangeRate);
            this.Controls.Add(this.LblExchangeRate);
            this.Controls.Add(this.TbxNetPay);
            this.Controls.Add(this.LblNetPay);
            this.Controls.Add(this.TbxTaxCalculation);
            this.Controls.Add(this.TbxGrossPay);
            this.Controls.Add(this.TbxTax);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblGrossPay);
            this.Controls.Add(this.TbxHoursWorked);
            this.Controls.Add(this.LblHoursWorked);
            this.Controls.Add(this.TbxRateOfPay);
            this.Controls.Add(this.TbxYourName);
            this.Controls.Add(this.LblRateOfPay);
            this.Controls.Add(this.LblYourName);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SalaryCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salary calculator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label LblYourName;
        private System.Windows.Forms.Label LblRateOfPay;
        private System.Windows.Forms.TextBox TbxYourName;
        private System.Windows.Forms.TextBox TbxRateOfPay;
        private System.Windows.Forms.Label LblHoursWorked;
        private System.Windows.Forms.TextBox TbxHoursWorked;
        private System.Windows.Forms.Label LblGrossPay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbxTax;
        private System.Windows.Forms.TextBox TbxGrossPay;
        private System.Windows.Forms.TextBox TbxTaxCalculation;
        private System.Windows.Forms.Label LblNetPay;
        private System.Windows.Forms.TextBox TbxNetPay;
        private System.Windows.Forms.Label LblExchangeRate;
        private System.Windows.Forms.TextBox TbxExchangeRate;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.TextBox TbxTotalEur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

