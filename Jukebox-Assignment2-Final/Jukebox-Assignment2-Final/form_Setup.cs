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
using MyDialogs;

namespace Jukebox_Assignment2_Final
{
    public partial class form_Setup : Form
    {
        public static string MP3Files;

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

            if (FBD.ShowDialog() == DialogResult.OK)
            {
                string[] files = Directory.GetFiles(FBD.SelectedPath);
                string[] dirs = Directory.GetDirectories(FBD.SelectedPath);

                foreach (string file in files)
                {
                    listbox_Import.Items.Add(Path.GetFileName(file));
                }
                foreach (string dir in dirs)
                {
                    listbox_Import.Items.Add(Path.GetFileName(dir));
                }
            }
        }

        private void btn_ClearImportedTracks_Click(object sender, EventArgs e)
        {
            listbox_Import.Items.Clear();
        }

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

        private void button_CopyTrack_Click(object sender, EventArgs e)
        {
            if (listbox_Import.Text != "")
            {
                listbox_GenraTracks.Items.Add(listbox_Import.Text);
            }
        }

        private void btn_DeleteTrack_Click(object sender, EventArgs e)
        {
            string RemovedItem;
            RemovedItem = (listbox_GenraTracks.Text);

            listbox_GenraTracks.Items.Remove(RemovedItem);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (textbox_GenraTitle.Text == "")
            {
                MessageBox.Show("You must enter a Genra Title");
            }

            if (textbox_GenraTitle.Text != "")
            {
                string applicationPath = Directory.GetCurrentDirectory() + "//";

                StreamWriter myTracksStream = File.AppendText(applicationPath + "GenraTracks.txt");
                StreamWriter myTitleStream = File.AppendText(applicationPath + "GenraTitle.txt");

                string[] Tracks = listbox_GenraTracks.Items.OfType<string>().ToArray();


                foreach (string Values in Tracks)
                {
                    myTracksStream.WriteLine(Values);
                }

                myTitleStream.WriteLine(textbox_GenraTitle.Text);

                myTitleStream.Close();
                myTracksStream.Close();
            }
            
        }
    }
}
