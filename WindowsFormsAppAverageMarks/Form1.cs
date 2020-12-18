using System;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppAverageMarks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int mark1;
        int mark2;
        int mark3;
        double result;

        private void BtStart_Click(object sender, EventArgs e)
        {
            mark1 = int.Parse(Interaction.InputBox("Type the mark1", "Mark1", "", 200));
            mark2 = int.Parse(Interaction.InputBox("Type the mark2", "Mark2", "", 200));
            mark3 = int.Parse(Interaction.InputBox("Type the mark3", "Mark3", "", 200));
            result = (double) (mark1 + mark2 + mark3) / 3;
            MessageBox.Show("The result is "+ result.ToString());
        }
    }
}
