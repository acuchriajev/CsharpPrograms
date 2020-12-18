namespace WindowsFormsAppWeeklyBankDeposit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.TbxWeeklyDeposit = new System.Windows.Forms.TextBox();
            this.TbxWeeks = new System.Windows.Forms.TextBox();
            this.TbxSavings = new System.Windows.Forms.TextBox();
            this.BtnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Weekly deposit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of weeks";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Savings";
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Location = new System.Drawing.Point(29, 172);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(75, 23);
            this.BtnCalculate.TabIndex = 3;
            this.BtnCalculate.Text = "Calculate";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(191, 172);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 4;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // TbxWeeklyDeposit
            // 
            this.TbxWeeklyDeposit.Location = new System.Drawing.Point(166, 39);
            this.TbxWeeklyDeposit.Name = "TbxWeeklyDeposit";
            this.TbxWeeklyDeposit.Size = new System.Drawing.Size(100, 20);
            this.TbxWeeklyDeposit.TabIndex = 5;
            // 
            // TbxWeeks
            // 
            this.TbxWeeks.Location = new System.Drawing.Point(166, 78);
            this.TbxWeeks.Name = "TbxWeeks";
            this.TbxWeeks.Size = new System.Drawing.Size(100, 20);
            this.TbxWeeks.TabIndex = 6;
            // 
            // TbxSavings
            // 
            this.TbxSavings.Location = new System.Drawing.Point(166, 116);
            this.TbxSavings.Name = "TbxSavings";
            this.TbxSavings.Size = new System.Drawing.Size(100, 20);
            this.TbxSavings.TabIndex = 7;
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(110, 172);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(75, 23);
            this.BtnReset.TabIndex = 8;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 217);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.TbxSavings);
            this.Controls.Add(this.TbxWeeks);
            this.Controls.Add(this.TbxWeeklyDeposit);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Savings calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.TextBox TbxWeeklyDeposit;
        private System.Windows.Forms.TextBox TbxWeeks;
        private System.Windows.Forms.TextBox TbxSavings;
        private System.Windows.Forms.Button BtnReset;
    }
}

