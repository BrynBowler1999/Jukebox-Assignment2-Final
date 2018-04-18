namespace Jukebox_Assignment2_Final
{
    partial class form_Jukebox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Jukebox));
            this.button_Setup = new System.Windows.Forms.Button();
            this.button_About = new System.Windows.Forms.Button();
            this.listbox_Queue = new System.Windows.Forms.ListBox();
            this.listbox_Genra = new System.Windows.Forms.ListBox();
            this.textbox_GenraTitle = new System.Windows.Forms.TextBox();
            this.textbox_CurrentSong = new System.Windows.Forms.TextBox();
            this.label_Copyright = new System.Windows.Forms.Label();
            this.player_Music = new AxWMPLib.AxWindowsMediaPlayer();
            this.hscrollbar_Genra = new System.Windows.Forms.HScrollBar();
            this.timer_Queue = new System.Windows.Forms.Timer(this.components);
            this.btn_Refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.player_Music)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Setup
            // 
            this.button_Setup.Location = new System.Drawing.Point(12, 570);
            this.button_Setup.Name = "button_Setup";
            this.button_Setup.Size = new System.Drawing.Size(75, 23);
            this.button_Setup.TabIndex = 0;
            this.button_Setup.Text = "Setup";
            this.button_Setup.UseVisualStyleBackColor = true;
            this.button_Setup.Click += new System.EventHandler(this.button_Setup_Click);
            // 
            // button_About
            // 
            this.button_About.Location = new System.Drawing.Point(93, 570);
            this.button_About.Name = "button_About";
            this.button_About.Size = new System.Drawing.Size(75, 23);
            this.button_About.TabIndex = 1;
            this.button_About.Text = "About";
            this.button_About.UseVisualStyleBackColor = true;
            // 
            // listbox_Queue
            // 
            this.listbox_Queue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.listbox_Queue.FormattingEnabled = true;
            this.listbox_Queue.Location = new System.Drawing.Point(118, 299);
            this.listbox_Queue.Name = "listbox_Queue";
            this.listbox_Queue.Size = new System.Drawing.Size(161, 173);
            this.listbox_Queue.TabIndex = 2;
            // 
            // listbox_Genra
            // 
            this.listbox_Genra.FormattingEnabled = true;
            this.listbox_Genra.Location = new System.Drawing.Point(118, 198);
            this.listbox_Genra.Name = "listbox_Genra";
            this.listbox_Genra.Size = new System.Drawing.Size(161, 69);
            this.listbox_Genra.TabIndex = 3;
            this.listbox_Genra.SelectedIndexChanged += new System.EventHandler(this.listbox_Genra_SelectedIndexChanged);
            // 
            // textbox_GenraTitle
            // 
            this.textbox_GenraTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.textbox_GenraTitle.Location = new System.Drawing.Point(118, 178);
            this.textbox_GenraTitle.Name = "textbox_GenraTitle";
            this.textbox_GenraTitle.ReadOnly = true;
            this.textbox_GenraTitle.Size = new System.Drawing.Size(161, 20);
            this.textbox_GenraTitle.TabIndex = 4;
            this.textbox_GenraTitle.Text = "Genra";
            // 
            // textbox_CurrentSong
            // 
            this.textbox_CurrentSong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.textbox_CurrentSong.Location = new System.Drawing.Point(101, 273);
            this.textbox_CurrentSong.Name = "textbox_CurrentSong";
            this.textbox_CurrentSong.ReadOnly = true;
            this.textbox_CurrentSong.Size = new System.Drawing.Size(191, 20);
            this.textbox_CurrentSong.TabIndex = 5;
            // 
            // label_Copyright
            // 
            this.label_Copyright.AutoSize = true;
            this.label_Copyright.Location = new System.Drawing.Point(232, 9);
            this.label_Copyright.Name = "label_Copyright";
            this.label_Copyright.Size = new System.Drawing.Size(149, 13);
            this.label_Copyright.TabIndex = 6;
            this.label_Copyright.Text = "Copyright © 2018 Bryn Bowler";
            // 
            // player_Music
            // 
            this.player_Music.Enabled = true;
            this.player_Music.Location = new System.Drawing.Point(12, 12);
            this.player_Music.Name = "player_Music";
            this.player_Music.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player_Music.OcxState")));
            this.player_Music.Size = new System.Drawing.Size(214, 46);
            this.player_Music.TabIndex = 7;
            // 
            // hscrollbar_Genra
            // 
            this.hscrollbar_Genra.Location = new System.Drawing.Point(118, 250);
            this.hscrollbar_Genra.Name = "hscrollbar_Genra";
            this.hscrollbar_Genra.Size = new System.Drawing.Size(161, 17);
            this.hscrollbar_Genra.TabIndex = 8;
            // 
            // timer_Queue
            // 
            this.timer_Queue.Interval = 1000;
            this.timer_Queue.Tick += new System.EventHandler(this.timer_Queue_Tick);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(162, 478);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_Refresh.TabIndex = 9;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // form_Jukebox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(393, 605);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.hscrollbar_Genra);
            this.Controls.Add(this.player_Music);
            this.Controls.Add(this.label_Copyright);
            this.Controls.Add(this.textbox_CurrentSong);
            this.Controls.Add(this.textbox_GenraTitle);
            this.Controls.Add(this.listbox_Genra);
            this.Controls.Add(this.listbox_Queue);
            this.Controls.Add(this.button_About);
            this.Controls.Add(this.button_Setup);
            this.DoubleBuffered = true;
            this.Name = "form_Jukebox";
            this.Text = "Jukebox";
            this.Load += new System.EventHandler(this.form_Jukebox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.player_Music)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Setup;
        private System.Windows.Forms.Button button_About;
        private System.Windows.Forms.ListBox listbox_Queue;
        private System.Windows.Forms.ListBox listbox_Genra;
        private System.Windows.Forms.TextBox textbox_GenraTitle;
        private System.Windows.Forms.TextBox textbox_CurrentSong;
        private System.Windows.Forms.Label label_Copyright;
        private AxWMPLib.AxWindowsMediaPlayer player_Music;
        private System.Windows.Forms.HScrollBar hscrollbar_Genra;
        private System.Windows.Forms.Timer timer_Queue;
        private System.Windows.Forms.Button btn_Refresh;
    }
}

