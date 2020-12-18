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
    public partial class Game : Form
    {
        Random rnd = new Random();
        public Game()
        {
            InitializeComponent();
        }

        void MakeMusic() 
        {
            
            int n = rnd.Next(0,TransferData.list.Count);
            WMP.URL = TransferData.list[n];
            // WMP.Ctlcontrols.play();
            TransferData.list.RemoveAt(n);
            LBLSongCount.Text = TransferData.list.Count.ToString();
        }
        private void btnNextSong_Click(object sender, EventArgs e)
        {
            timer1.Start();
            MakeMusic();
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
            WMP.Ctlcontrols.stop();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            LBLSongCount.Text = TransferData.list.Count.ToString();
            progressBar1.Maximum = TransferData.gameDuration;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            WMP.Ctlcontrols.pause();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            timer1.Start();
            WMP.Ctlcontrols.play();
        }
    }
}
