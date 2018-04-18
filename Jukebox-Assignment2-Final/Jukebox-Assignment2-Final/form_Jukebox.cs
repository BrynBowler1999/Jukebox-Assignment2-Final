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
            //Hides the music when the Form opens
        }

        bool PlayingSong = false;
        //Creates the Bool used by the Play Song Timer

        string applicationPath = Directory.GetCurrentDirectory() + "\\";
        //Creates a string to the Firecoty the Programme is stored in

        private void button_Setup_Click(object sender, EventArgs e)
        {
            form_Setup Setup = new form_Setup();
            if (Setup.ShowDialog() == DialogResult.OK)
            {
                listbox_Genra.Text = form_Setup.GetFiles;
            }
            Setup.Show();
            //Opens the Setup Form
        }

        private void form_Jukebox_Load(object sender, EventArgs e)
        {
            timer_Queue.Start();
            //Starts the Queue Timer when the Form opens
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            listbox_Genra.DataSource = File.ReadAllLines(applicationPath + "GenraTracks.txt");
            //Pulls the Genra Track Names from the Genra Tracks Text File
        }

        private void listbox_Genra_SelectedIndexChanged(object sender, EventArgs e)
        {
            listbox_Queue.Items.Add(listbox_Genra.SelectedItem);
            //Adds a song from the Genra Listbox to the Queue Listbox upon clicking
        }

        private void timer_Queue_Tick(object sender, EventArgs e)
        {
            if (textbox_CurrentSong.Text == "")
            //Runs the if Statment when the Current Song Textbox is populated
            {
                if (listbox_Queue.Items.Count > 0)
                //Runs the if statement when the Queue has more than 0 Items in it
                {
                    string SongName = listbox_Queue.Items[0].ToString();
                    //Creates a string of the name of the top Item in the Queue Listbox
                    textbox_CurrentSong.Text = SongName;
                    //Applies that string to the Currently Playing Textbox
                    timer_Queue.Stop();
                    //Stops the timer used for the Queue
                    listbox_Queue.Items.RemoveAt(0);
                    //Removes the top Item from the Queue Listbox
                }
            }

            if (PlayingSong == false)
            //If the song is not playing this program is run 
            {
                timer_Queue.Start();
                //Starts the Queue Timer
                if (textbox_CurrentSong.Text != "")
                //If the Current Song textbox is empty the if statement is ran
                {
                    WMPLib.WindowsMediaPlayer player_Music = new WMPLib.WindowsMediaPlayer();
                    //Enables the Windows Media Player
                    player_Music.URL = (applicationPath + "//Tracks/" + textbox_CurrentSong.Text);
                    //Takes the Name in the Current Song textbox and matches it with the File Name in the Directory 
                    player_Music.controls.play();
                    //PLays the File
                    timer_Queue.Stop();
                    //Stops the Queue Timer
                }
            }
        }

        private void button_About_Click(object sender, EventArgs e)
        {
            About About = new About();
            if (About.ShowDialog() == DialogResult.OK)
            {
                listbox_Genra.Text = form_Setup.GetFiles;
            }
            About.Show();
            //Opens the About Form
        }
    }
}
