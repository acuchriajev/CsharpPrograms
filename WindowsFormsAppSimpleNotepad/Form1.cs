using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppSimpleNotepad
{
    public partial class Notepad : Form
    {
        public Notepad()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This simple program was made by Acoptex.lt. 2020 All rights reserved.", "About",MessageBoxButtons.OK ,MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void insertDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbNotepad.AppendText(DateTime.Now.ToShortDateString()+"\n");
        }

        private void insertTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbNotepad.AppendText(DateTime.Now.ToShortTimeString() + "\n");
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbNotepad.SaveFile("notepadnotes.rtf");
        }

        private void insertDateAndTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbNotepad.AppendText(DateTime.Now + "\n");
        }

        private void clearContentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbNotepad.Text = "";
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                rtbNotepad.LoadFile("notepadnotes.rtf");
            }
            catch
            {
                MessageBox.Show("Failed to load. File corrupted or not existing.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
