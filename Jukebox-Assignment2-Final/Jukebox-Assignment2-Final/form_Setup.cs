﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MyDialogs;

namespace Jukebox_Assignment2_Final
{
    public partial class form_Setup : Form
    {
        public static string MP3Files;
        //Public String created for the Importing of File Names

        public static string GetFiles
        {
            get
            {
                return MP3Files;
            }
            set
            {
                MP3Files = value;
            }
        }
        public form_Setup()
        {
            InitializeComponent();
        }

        private void form_Setup_Load(object sender, EventArgs e)
        {

        }

        private void btn_ImportFromDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            //Opens a new Folder Browser Dialog

            if (FBD.ShowDialog() == DialogResult.OK)
            {
                string[] files = Directory.GetFiles(FBD.SelectedPath);
                string[] dirs = Directory.GetDirectories(FBD.SelectedPath);

                //Pulls the file names from the directory

                foreach (string file in files)
                {
                    listbox_Import.Items.Add(Path.GetFileName(file));
                }
                foreach (string dir in dirs)
                {
                    listbox_Import.Items.Add(Path.GetFileName(dir));
                }

                //Puts the File Names into the Import listbox
            }
        }

        private void btn_ClearImportedTracks_Click(object sender, EventArgs e)
        {
            listbox_Import.Items.Clear();
        }
        // Clears the Import Listbox

        private void btn_MoveTrack_Click(object sender, EventArgs e)
        {
            if (listbox_Import.Text != "")
            {
                string MovedItem;
                MovedItem = (listbox_Import.Text);

                listbox_GenraTracks.Items.Add(listbox_Import.Text);
                listbox_Import.Items.Remove(MovedItem);
            }
        }
        //Moves the File Names from the Import Listbox to the Genra Tracks Listbox

        private void button_CopyTrack_Click(object sender, EventArgs e)
        {
            if (listbox_Import.Text != "")
            {
                listbox_GenraTracks.Items.Add(listbox_Import.Text);
            }
        }
        //Copies the File Names from the Import Listbox to the Genra Tracks Listbox

        private void btn_DeleteTrack_Click(object sender, EventArgs e)
        {
            string RemovedItem;
            RemovedItem = (listbox_GenraTracks.Text);

            listbox_GenraTracks.Items.Remove(RemovedItem);
        }
        //Deletes Tracks from the Genra Tracks Listbox

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (textbox_GenraTitle.Text == "")
            {
                MessageBox.Show("You must enter a Genra Title");
            }
            //Assures that the Genras have a Title

            if (textbox_GenraTitle.Text != "")
            {
                string applicationPath = Directory.GetCurrentDirectory() + "//";
                //Creates a string which references the Directory the programme is stored in

                StreamWriter myTracksStream = File.AppendText(applicationPath + "GenraTracks.txt");
                StreamWriter myTitleStream = File.AppendText(applicationPath + "GenraTitle.txt");
                //Creates a Text File which the Genra Title and Genra Tracks are stored in

                string[] Tracks = listbox_GenraTracks.Items.OfType<string>().ToArray();
                //Creates and Array of the Genra Tracks so the names are displayed correctly in the Text File

                foreach (string Values in Tracks)
                {
                    myTracksStream.WriteLine(Values);
                }
                //Writes all the track names into the Text File line by line

                myTitleStream.WriteLine(textbox_GenraTitle.Text);
                //Writes the Genra Title into the Text File

                myTitleStream.Close();
                myTracksStream.Close();
                //Closes the Stream Writer
            }
        }
        
        private void btn_Ok_Click(object sender, EventArgs e)
        {
            this.Close();
            //Closes the Setup Form
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            //Closes the Setup Form
        }
    }
}
