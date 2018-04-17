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

        private void button_Setup_Click(object sender, EventArgs e)
        {
            form_Setup Setup = new form_Setup();
            if (Setup.ShowDialog() == DialogResult.OK)
            {
                listbox_Genra.Text = form_Setup.GetFiles;
            }
            Setup.Show();
        }
    }
}
