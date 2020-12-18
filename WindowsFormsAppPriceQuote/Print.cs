using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppPriceQuote;

namespace WindowsFormsAppPriceQuote
{
    public partial class Print : Form
    {
        public Print()
        {
            InitializeComponent();
            
           
        }

        
        private void BtnClosePrint_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
