namespace WindowsFormsAppCafeteria
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTaxValuePerc = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.GBxAppetizer = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.GBxMain = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.GBxRefreshment = new System.Windows.Forms.GroupBox();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbxAppetizer = new System.Windows.Forms.TextBox();
            this.tbxMain = new System.Windows.Forms.TextBox();
            this.tbxRefreshment = new System.Windows.Forms.TextBox();
            this.tbxSubtotal = new System.Windows.Forms.TextBox();
            this.tbxTax = new System.Windows.Forms.TextBox();
            this.tbxTotal = new System.Windows.Forms.TextBox();
            this.rtbxResult = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.lblBillNo = new System.Windows.Forms.Label();
            this.tbxBillNo = new System.Windows.Forms.TextBox();
            this.GBxAppetizer.SuspendLayout();
            this.GBxMain.SuspendLayout();
            this.GBxRefreshment.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Appetizer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Main";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Refreshment";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "SubTotal";
            // 
            // lblTaxValuePerc
            // 
            this.lblTaxValuePerc.AutoSize = true;
            this.lblTaxValuePerc.Location = new System.Drawing.Point(23, 159);
            this.lblTaxValuePerc.Name = "lblTaxValuePerc";
            this.lblTaxValuePerc.Size = new System.Drawing.Size(54, 13);
            this.lblTaxValuePerc.TabIndex = 8;
            this.lblTaxValuePerc.Text = "Tax(     %)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 186);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Total";
            // 
            // GBxAppetizer
            // 
            this.GBxAppetizer.Controls.Add(this.radioButton2);
            this.GBxAppetizer.Controls.Add(this.radioButton1);
            this.GBxAppetizer.Location = new System.Drawing.Point(195, 29);
            this.GBxAppetizer.Name = "GBxAppetizer";
            this.GBxAppetizer.Size = new System.Drawing.Size(117, 100);
            this.GBxAppetizer.TabIndex = 12;
            this.GBxAppetizer.TabStop = false;
            this.GBxAppetizer.Text = "Appetizer";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 59);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Salad(2.50$)";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 29);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(86, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "Soup (2.00$)";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // GBxMain
            // 
            this.GBxMain.Controls.Add(this.radioButton5);
            this.GBxMain.Controls.Add(this.radioButton4);
            this.GBxMain.Controls.Add(this.radioButton3);
            this.GBxMain.Location = new System.Drawing.Point(318, 29);
            this.GBxMain.Name = "GBxMain";
            this.GBxMain.Size = new System.Drawing.Size(122, 100);
            this.GBxMain.TabIndex = 13;
            this.GBxMain.TabStop = false;
            this.GBxMain.Text = "Main";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(7, 68);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(95, 17);
            this.radioButton5.TabIndex = 2;
            this.radioButton5.Text = "Steak (15.00$)";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(7, 44);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(108, 17);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.Text = "Lasagna (11.75$)";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(7, 20);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(106, 17);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.Text = "Chicken (10.50$)";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // GBxRefreshment
            // 
            this.GBxRefreshment.Controls.Add(this.radioButton8);
            this.GBxRefreshment.Controls.Add(this.radioButton7);
            this.GBxRefreshment.Controls.Add(this.radioButton6);
            this.GBxRefreshment.Location = new System.Drawing.Point(195, 135);
            this.GBxRefreshment.Name = "GBxRefreshment";
            this.GBxRefreshment.Size = new System.Drawing.Size(117, 100);
            this.GBxRefreshment.TabIndex = 14;
            this.GBxRefreshment.TabStop = false;
            this.GBxRefreshment.Text = "Refreshment";
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(7, 68);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(86, 17);
            this.radioButton8.TabIndex = 2;
            this.radioButton8.Text = "Juice (1.30$)";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.radioButton8_CheckedChanged);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(7, 44);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(90, 17);
            this.radioButton7.TabIndex = 1;
            this.radioButton7.Text = "Water (1.00$)";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(7, 20);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(80, 17);
            this.radioButton6.TabIndex = 0;
            this.radioButton6.Text = "Pop (1.25$)";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Location = new System.Drawing.Point(25, 254);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(75, 23);
            this.BtnCalculate.TabIndex = 15;
            this.BtnCalculate.Text = "Calculate bill";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(114, 254);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(75, 23);
            this.BtnNew.TabIndex = 16;
            this.BtnNew.Text = "New order";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(195, 254);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 17;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(720, 24);
            this.menuStrip2.TabIndex = 19;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newOrderToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newOrderToolStripMenuItem
            // 
            this.newOrderToolStripMenuItem.Name = "newOrderToolStripMenuItem";
            this.newOrderToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.newOrderToolStripMenuItem.Text = "New order";
            this.newOrderToolStripMenuItem.Click += new System.EventHandler(this.newOrderToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.saveToolStripMenuItem.Text = "Save order";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.loadToolStripMenuItem.Text = "Load order";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.printPreviewToolStripMenuItem.Text = "Print preview";
            this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.printPreviewToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tbxAppetizer
            // 
            this.tbxAppetizer.Location = new System.Drawing.Point(89, 35);
            this.tbxAppetizer.Name = "tbxAppetizer";
            this.tbxAppetizer.ReadOnly = true;
            this.tbxAppetizer.Size = new System.Drawing.Size(100, 20);
            this.tbxAppetizer.TabIndex = 20;
            // 
            // tbxMain
            // 
            this.tbxMain.Location = new System.Drawing.Point(89, 61);
            this.tbxMain.Name = "tbxMain";
            this.tbxMain.ReadOnly = true;
            this.tbxMain.Size = new System.Drawing.Size(100, 20);
            this.tbxMain.TabIndex = 21;
            // 
            // tbxRefreshment
            // 
            this.tbxRefreshment.Location = new System.Drawing.Point(89, 88);
            this.tbxRefreshment.Name = "tbxRefreshment";
            this.tbxRefreshment.ReadOnly = true;
            this.tbxRefreshment.Size = new System.Drawing.Size(100, 20);
            this.tbxRefreshment.TabIndex = 22;
            // 
            // tbxSubtotal
            // 
            this.tbxSubtotal.Location = new System.Drawing.Point(89, 128);
            this.tbxSubtotal.Name = "tbxSubtotal";
            this.tbxSubtotal.ReadOnly = true;
            this.tbxSubtotal.Size = new System.Drawing.Size(100, 20);
            this.tbxSubtotal.TabIndex = 23;
            // 
            // tbxTax
            // 
            this.tbxTax.Location = new System.Drawing.Point(89, 154);
            this.tbxTax.Name = "tbxTax";
            this.tbxTax.ReadOnly = true;
            this.tbxTax.Size = new System.Drawing.Size(100, 20);
            this.tbxTax.TabIndex = 24;
            // 
            // tbxTotal
            // 
            this.tbxTotal.Location = new System.Drawing.Point(89, 183);
            this.tbxTotal.Name = "tbxTotal";
            this.tbxTotal.ReadOnly = true;
            this.tbxTotal.Size = new System.Drawing.Size(100, 20);
            this.tbxTotal.TabIndex = 25;
            // 
            // rtbxResult
            // 
            this.rtbxResult.Location = new System.Drawing.Point(455, 27);
            this.rtbxResult.Name = "rtbxResult";
            this.rtbxResult.Size = new System.Drawing.Size(256, 346);
            this.rtbxResult.TabIndex = 26;
            this.rtbxResult.Text = "";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "RTF files | *.rtf";
            // 
            // printDialog1
            // 
            this.printDialog1.AllowCurrentPage = true;
            this.printDialog1.AllowSelection = true;
            this.printDialog1.AllowSomePages = true;
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // lblBillNo
            // 
            this.lblBillNo.AutoSize = true;
            this.lblBillNo.Location = new System.Drawing.Point(23, 222);
            this.lblBillNo.Name = "lblBillNo";
            this.lblBillNo.Size = new System.Drawing.Size(40, 13);
            this.lblBillNo.TabIndex = 27;
            this.lblBillNo.Text = "Bill No:";
            // 
            // tbxBillNo
            // 
            this.tbxBillNo.Location = new System.Drawing.Point(89, 214);
            this.tbxBillNo.Name = "tbxBillNo";
            this.tbxBillNo.ReadOnly = true;
            this.tbxBillNo.Size = new System.Drawing.Size(100, 20);
            this.tbxBillNo.TabIndex = 28;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 383);
            this.Controls.Add(this.tbxBillNo);
            this.Controls.Add(this.lblBillNo);
            this.Controls.Add(this.rtbxResult);
            this.Controls.Add(this.tbxTotal);
            this.Controls.Add(this.tbxTax);
            this.Controls.Add(this.tbxSubtotal);
            this.Controls.Add(this.tbxRefreshment);
            this.Controls.Add(this.tbxMain);
            this.Controls.Add(this.tbxAppetizer);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.GBxRefreshment);
            this.Controls.Add(this.GBxMain);
            this.Controls.Add(this.GBxAppetizer);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblTaxValuePerc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Small Cafeteria";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.GBxAppetizer.ResumeLayout(false);
            this.GBxAppetizer.PerformLayout();
            this.GBxMain.ResumeLayout(false);
            this.GBxMain.PerformLayout();
            this.GBxRefreshment.ResumeLayout(false);
            this.GBxRefreshment.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTaxValuePerc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox GBxAppetizer;
        private System.Windows.Forms.GroupBox GBxMain;
        private System.Windows.Forms.GroupBox GBxRefreshment;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox tbxAppetizer;
        private System.Windows.Forms.TextBox tbxMain;
        private System.Windows.Forms.TextBox tbxRefreshment;
        private System.Windows.Forms.TextBox tbxSubtotal;
        private System.Windows.Forms.TextBox tbxTax;
        private System.Windows.Forms.TextBox tbxTotal;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newOrderToolStripMenuItem;
        private System.Windows.Forms.RichTextBox rtbxResult;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label lblBillNo;
        private System.Windows.Forms.TextBox tbxBillNo;
    }
}

