using System;
using System.Windows.Forms;

namespace WindowsFormsAppPasswordGenerator
{
    public partial class PasswordGenerator : Form
    {
        Random rnd = new Random();
        public PasswordGenerator()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (clbPassword.CheckedItems.Count == 0) return;

            string password = "";
            char[] specialSymb = { '%', '!', '_', '#', '$','?' };
            for (int i = 0; i < NudPasswordLength.Value; i++)
            {
                int n = rnd.Next(0, clbPassword.CheckedItems.Count);
                string s = clbPassword.CheckedItems[n].ToString();
                switch (s)
                {
                    case "Numbers":
                        password += rnd.Next(10).ToString();
                        break;
                    case "Lowercase letters":
                        password += Convert.ToChar(rnd.Next(97, 122));
                        break;
                    case "Uppercase letters":
                        password += Convert.ToChar(rnd.Next(65, 88));
                        break;
                    default:
                        password += specialSymb[rnd.Next(specialSymb.Length)];
                        break;
                }

            }
            rtbPassword.AppendText(password+"\n\n");

            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rtbPassword.Text = "";
            clbPassword.SetItemChecked(0, false);
            clbPassword.SetItemChecked(1, false);
            clbPassword.SetItemChecked(2, false);
            clbPassword.SetItemChecked(3, false);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtbPassword.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            rtbPassword.SaveFile("password.rtf");
        }

        private void PasswordGenerator_Load(object sender, EventArgs e)
        {
            //clbPassword.SetItemChecked(0, true);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try { rtbPassword.LoadFile("password.rtf"); }
            catch { MessageBox.Show("File corrupted or not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program generates the password up to 128 chars.\n\n " +
                "Created by C# developer Aleksandr Cuchriajev.\n\n " +
                "Contact email: info.acoptex@gmail.com.\n\n" +
                "Ver.1.0\n\n" +
                "2020 Acoptex.lt All rights reserved.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
