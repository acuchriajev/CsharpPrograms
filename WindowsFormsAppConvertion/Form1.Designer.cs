namespace WindowsFormsAppConvertion
{
    partial class UnitConverter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnitConverter));
            this.cbFrom = new System.Windows.Forms.ComboBox();
            this.cbTo = new System.Windows.Forms.ComboBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.tbxFrom = new System.Windows.Forms.TextBox();
            this.tbxTo = new System.Windows.Forms.TextBox();
            this.btnDirection = new System.Windows.Forms.Button();
            this.cbChange = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbFrom
            // 
            this.cbFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbFrom.FormattingEnabled = true;
            this.cbFrom.Items.AddRange(new object[] {
            "mm",
            "cm",
            "dm",
            "m",
            "km",
            "mile"});
            this.cbFrom.Location = new System.Drawing.Point(24, 71);
            this.cbFrom.Name = "cbFrom";
            this.cbFrom.Size = new System.Drawing.Size(132, 33);
            this.cbFrom.TabIndex = 0;
            this.cbFrom.Text = "mm";
            // 
            // cbTo
            // 
            this.cbTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbTo.FormattingEnabled = true;
            this.cbTo.Items.AddRange(new object[] {
            "mm",
            "cm",
            "dm",
            "m",
            "km",
            "mile"});
            this.cbTo.Location = new System.Drawing.Point(279, 71);
            this.cbTo.Name = "cbTo";
            this.cbTo.Size = new System.Drawing.Size(132, 33);
            this.cbTo.TabIndex = 1;
            this.cbTo.Text = "mm";
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnConvert.Location = new System.Drawing.Point(162, 122);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(111, 42);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // tbxFrom
            // 
            this.tbxFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxFrom.Location = new System.Drawing.Point(24, 111);
            this.tbxFrom.Name = "tbxFrom";
            this.tbxFrom.Size = new System.Drawing.Size(132, 30);
            this.tbxFrom.TabIndex = 3;
            this.tbxFrom.Text = "0";
            // 
            // tbxTo
            // 
            this.tbxTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxTo.Location = new System.Drawing.Point(279, 110);
            this.tbxTo.Name = "tbxTo";
            this.tbxTo.Size = new System.Drawing.Size(132, 30);
            this.tbxTo.TabIndex = 4;
            this.tbxTo.Text = "0";
            // 
            // btnDirection
            // 
            this.btnDirection.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDirection.Location = new System.Drawing.Point(162, 71);
            this.btnDirection.Name = "btnDirection";
            this.btnDirection.Size = new System.Drawing.Size(111, 45);
            this.btnDirection.TabIndex = 5;
            this.btnDirection.Text = "<-------->";
            this.btnDirection.UseVisualStyleBackColor = true;
            this.btnDirection.Click += new System.EventHandler(this.btnDirection_Click);
            // 
            // cbChange
            // 
            this.cbChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbChange.FormattingEnabled = true;
            this.cbChange.Items.AddRange(new object[] {
            "Length",
            "Mass"});
            this.cbChange.Location = new System.Drawing.Point(149, 32);
            this.cbChange.Name = "cbChange";
            this.cbChange.Size = new System.Drawing.Size(136, 33);
            this.cbChange.TabIndex = 6;
            this.cbChange.Text = "Length";
            this.cbChange.SelectedIndexChanged += new System.EventHandler(this.cbChange_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(448, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
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
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // UnitConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 274);
            this.Controls.Add(this.cbChange);
            this.Controls.Add(this.btnDirection);
            this.Controls.Add(this.tbxTo);
            this.Controls.Add(this.tbxFrom);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.cbTo);
            this.Controls.Add(this.cbFrom);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UnitConverter";
            this.Text = "Unit converter";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFrom;
        private System.Windows.Forms.ComboBox cbTo;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox tbxFrom;
        private System.Windows.Forms.TextBox tbxTo;
        private System.Windows.Forms.Button btnDirection;
        private System.Windows.Forms.ComboBox cbChange;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

