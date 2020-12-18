using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessMelody
{
    public partial class Main : Form
    {
        Settings mySettings = new Settings();
        Game myGame = new Game();
        public Main()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Guess melody is a game for two players to guess melody and found the winner.\n\n " +
               "Created by C# developer Aleksandr Cuchriajev.\n\n " +
               "Contact email: info.acoptex@gmail.com.\n\n" +
               "Ver.1.0\n\n" +
               "2020 Acoptex.lt All rights reserved.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            mySettings.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
            myGame.ShowDialog();
        }

        private void startNewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myGame.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            TransferData.ReadSettings();
            TransferData.ReadMusic();
        }
    }
}
