using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GuessMelody
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            TransferData.allFolders = cbxAllFolders.Checked;
            TransferData.gameDuration = Convert.ToInt32(cbxGameDuration.Text);
            TransferData.musicDuration = Convert.ToInt32(cbxMusicDuration.Text);
            TransferData.randomStart = cbRandomStart.Checked;
            TransferData.WriteSettings();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadFirst();
            this.Hide();
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string[] songList = Directory.GetFiles(fbd.SelectedPath, "*.mp3", (cbxAllFolders.Checked) ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
                TransferData.lastFolder = fbd.SelectedPath;
                lbxSongsList.Items.Clear();
                lbxSongsList.Items.AddRange(songList);
                TransferData.list.Clear();
                TransferData.list.AddRange(songList);
            };
        }
        void LoadFirst(){
            cbxAllFolders.Checked = TransferData.allFolders;
            cbxGameDuration.Text = TransferData.gameDuration.ToString();
            cbxMusicDuration.Text = TransferData.musicDuration.ToString();
            cbRandomStart.Checked = TransferData.randomStart;
        }
        private void Settings_Load(object sender, EventArgs e)
        {
            LoadFirst();
            lbxSongsList.Items.Clear();
            lbxSongsList.Items.AddRange(TransferData.list.ToArray());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbxSongsList.Items.Clear();
        }
    }
}
