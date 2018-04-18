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
using System.Diagnostics;

namespace Jukebox_Assignment2_Final
{
    public partial class form_Jukebox : Form
    {
        public form_Jukebox()
        {
            InitializeComponent();
            player_Music.Hide();
        }

        bool PlayingSong = false;
        string applicationPath = Directory.GetCurrentDirectory() + "\\";

        private void button_Setup_Click(object sender, EventArgs e)
        {
            form_Setup Setup = new form_Setup();
            if (Setup.ShowDialog() == DialogResult.OK)
            {
                listbox_Genra.Text = form_Setup.GetFiles;
            }
            Setup.Show();
        }

        private void form_Jukebox_Load(object sender, EventArgs e)
        {
            timer_Queue.Start();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            string applicationPath = Directory.GetCurrentDirectory() + "\\";

            listbox_Genra.DataSource = File.ReadAllLines(applicationPath + "GenraTracks.txt");
        }

        private void listbox_Genra_SelectedIndexChanged(object sender, EventArgs e)
        {
            listbox_Queue.Items.Add(listbox_Genra.SelectedItem);
        }

        private void timer_Queue_Tick(object sender, EventArgs e)
        {
            if (textbox_CurrentSong.Text == "")
            {
                if (listbox_Queue.Items.Count > 0)
                {
                    string SongName = listbox_Queue.Items[0].ToString();
                    textbox_CurrentSong.Text = SongName;
                    timer_Queue.Stop();
                    listbox_Queue.Items.RemoveAt(0);
                }
            }

            if (PlayingSong == false)
            {
                timer_Queue.Start();
                if (textbox_CurrentSong.Text != "")
                {
                    WMPLib.WindowsMediaPlayer player_Music = new WMPLib.WindowsMediaPlayer();
                    player_Music.URL = (applicationPath + "//Tracks/" + textbox_CurrentSong.Text);
                    player_Music.controls.play();
                    timer_Queue.Stop();
                }
            }
        }

        private void timer_Play_Tick(object sender, EventArgs e)
        {
            if (PlayingSong == true)
            {
                timer_Play.Start();
                if (textbox_CurrentSong.Text == "")
                {
                    textbox_CurrentSong.Clear();
                }
                timer_Play.Stop();
            }
        }
    }
}
