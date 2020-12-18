using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsAppConvertion
{
    public partial class UnitConverter : Form
    {
        Dictionary<string, double> metricData = new Dictionary<string,double>();
        public UnitConverter()
        {
            InitializeComponent();
            metricData.Add("mm",1 );
            metricData.Add("cm", 10);
            metricData.Add("dm", 100);
            metricData.Add("m", 1000);
            metricData.Add("km", 1000000);
            metricData.Add("mile", 1609344);
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double m1 = metricData[cbFrom.Text];
            double m2 = metricData[cbTo.Text];
            double n = Convert.ToDouble(tbxFrom.Text);
            tbxTo.Text = (n * m1 / m2).ToString();
        }

        private void btnDirection_Click(object sender, EventArgs e)
        {
            string temporaryValue = cbFrom.Text;
            cbFrom.Text = cbTo.Text;
            cbTo.Text = temporaryValue;
        }

        private void cbChange_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbChange.Text)
            {
                case "Length":
                    metricData.Clear();
                    metricData.Add("mm", 1);
                    metricData.Add("cm", 10);
                    metricData.Add("dm", 100);
                    metricData.Add("m", 1000);
                    metricData.Add("km", 1000000);
                    metricData.Add("mile", 1609344);
                    cbFrom.Items.Clear();
                    cbFrom.Items.Add("mm");
                    cbFrom.Items.Add("cm");
                    cbFrom.Items.Add("dm");
                    cbFrom.Items.Add("m");
                    cbFrom.Items.Add("km");
                    cbFrom.Items.Add("mile");
                    cbTo.Items.Clear();
                    cbTo.Items.Add("mm");
                    cbTo.Items.Add("cm");
                    cbTo.Items.Add("dm");
                    cbTo.Items.Add("m");
                    cbTo.Items.Add("km");
                    cbTo.Items.Add("mile");
                    cbFrom.Text = "mm";
                    cbTo.Text = "mm";
                    break;
                case "Mass":
                    metricData.Clear();
                    metricData.Add("g", 1);
                    metricData.Add("kg", 1000);
                    metricData.Add("ton", 1000000);
                    metricData.Add("lb", 453.6);
                    metricData.Add("oz", 283);                    
                    cbFrom.Items.Clear();
                    cbFrom.Items.Add("g");
                    cbFrom.Items.Add("kg");
                    cbFrom.Items.Add("ton");
                    cbFrom.Items.Add("lb");
                    cbFrom.Items.Add("oz");                   
                    cbTo.Items.Clear();
                    cbTo.Items.Add("g");
                    cbTo.Items.Add("kg");
                    cbTo.Items.Add("ton");
                    cbTo.Items.Add("lb");
                    cbTo.Items.Add("oz");                  
                    cbFrom.Text = "g";
                    cbTo.Text = "g";
                    break;            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program converts units.\n\n " +
                "Created by C# developer Aleksandr Cuchriajev.\n\n " +
                "Contact email: info.acoptex@gmail.com.\n\n" +
                "Ver.1.0\n\n" +
                "2020 Acoptex.lt All rights reserved.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
