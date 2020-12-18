using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;

namespace GuessMelody
{
    static class TransferData
    {
        static public List<string> list = new List<string>();
        static public int gameDuration = 60;
        static public int musicDuration = 20;
        static public bool randomStart = false;
        static public string lastFolder = "";
        static public bool allFolders = false;

        static public void ReadMusic()
        {
            try
            {
                string[] songList = Directory.GetFiles(lastFolder, "*.mp3", allFolders ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
                list.Clear();
                list.AddRange(songList);
            }
            catch {  }
        }

        static string regKeyName = @"Software\AcoptexLt\GuessMusic";
        public static void WriteSettings()
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.CreateSubKey(regKeyName);
                if (rk == null) return;
                rk.SetValue("Last Folder", lastFolder);
                rk.SetValue("Random", randomStart);
                rk.SetValue("Game duration", gameDuration);
                rk.SetValue("Music duration", musicDuration);
                rk.SetValue("All Folders", allFolders);
            }
            finally
            {
                if (rk != null) rk.Close();
            }
        }
        public static void ReadSettings()
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.OpenSubKey(regKeyName);
                if (rk != null)
                {
                    lastFolder=(string)rk.GetValue("Last Folder");
                    randomStart=Convert.ToBoolean(rk.GetValue("Random", false));
                    gameDuration=(int)rk.GetValue("Game duration");
                    musicDuration=(int)rk.GetValue("Music duration");
                    allFolders=Convert.ToBoolean(rk.GetValue("All Folders", false));
                }
            }
            finally
            {
                if (rk != null) rk.Close();
            }
        }

    }
}
