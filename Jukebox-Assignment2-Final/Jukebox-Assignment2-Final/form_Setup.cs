using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
