namespace WindowsFormsAppGeneratorOfRandomNumbers
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.LblRandomNumber = new System.Windows.Forms.Label();
            this.NudFrom = new System.Windows.Forms.NumericUpDown();
            this.NudTo = new System.Windows.Forms.NumericUpDown();
            this.tbxRandomNumbers = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.cbNoRepeat = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.NudFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudTo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(24, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "To";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(223, 30);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // LblRandomNumber
            // 
            this.LblRandomNumber.AutoSize = true;
            this.LblRandomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblRandomNumber.Location = new System.Drawing.Point(240, 183);
            this.LblRandomNumber.Name = "LblRandomNumber";
            this.LblRandomNumber.Size = new System.Drawing.Size(29, 31);
            this.LblRandomNumber.TabIndex = 3;
            this.LblRandomNumber.Text = "0";
            // 
            // NudFrom
            // 
            this.NudFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NudFrom.Location = new System.Drawing.Point(101, 21);
            this.NudFrom.Name = "NudFrom";
            this.NudFrom.Size = new System.Drawing.Size(51, 30);
            this.NudFrom.TabIndex = 4;
            // 
            // NudTo
            // 
            this.NudTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NudTo.Location = new System.Drawing.Point(101, 65);
            this.NudTo.Name = "NudTo";
            this.NudTo.Size = new System.Drawing.Size(51, 30);
            this.NudTo.TabIndex = 5;
            // 
            // tbxRandomNumbers
            // 
            this.tbxRandomNumbers.Location = new System.Drawing.Point(29, 144);
            this.tbxRandomNumbers.Multiline = true;
            this.tbxRandomNumbers.Name = "tbxRandomNumbers";
            this.tbxRandomNumbers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxRandomNumbers.Size = new System.Drawing.Size(163, 144);
            this.tbxRandomNumbers.TabIndex = 6;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(223, 113);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Reset";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(223, 70);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 8;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // cbNoRepeat
            // 
            this.cbNoRepeat.AutoSize = true;
            this.cbNoRepeat.Location = new System.Drawing.Point(29, 113);
            this.cbNoRepeat.Name = "cbNoRepeat";
            this.cbNoRepeat.Size = new System.Drawing.Size(86, 17);
            this.cbNoRepeat.TabIndex = 9;
            this.cbNoRepeat.Text = "No repetition";
            this.cbNoRepeat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 300);
            this.Controls.Add(this.cbNoRepeat);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tbxRandomNumbers);
            this.Controls.Add(this.NudTo);
            this.Controls.Add(this.NudFrom);
            this.Controls.Add(this.LblRandomNumber);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generator of random numbers";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NudFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudTo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label LblRandomNumber;
        private System.Windows.Forms.NumericUpDown NudFrom;
        private System.Windows.Forms.NumericUpDown NudTo;
        private System.Windows.Forms.TextBox tbxRandomNumbers;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.CheckBox cbNoRepeat;
    }
}

