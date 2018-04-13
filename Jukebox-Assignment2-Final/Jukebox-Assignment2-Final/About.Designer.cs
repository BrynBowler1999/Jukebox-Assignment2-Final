namespace Jukebox_Assignment2_Final
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.label_Title = new System.Windows.Forms.Label();
            this.textbox_Description = new System.Windows.Forms.TextBox();
            this.button_OK = new System.Windows.Forms.Button();
            this.picturebox_About = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_About)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label_Title.Location = new System.Drawing.Point(139, 45);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(175, 26);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "My Jukebox v1.0";
            // 
            // textbox_Description
            // 
            this.textbox_Description.Location = new System.Drawing.Point(144, 74);
            this.textbox_Description.Multiline = true;
            this.textbox_Description.Name = "textbox_Description";
            this.textbox_Description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textbox_Description.Size = new System.Drawing.Size(170, 126);
            this.textbox_Description.TabIndex = 1;
            this.textbox_Description.Text = resources.GetString("textbox_Description.Text");
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(101, 226);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(139, 23);
            this.button_OK.TabIndex = 2;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // picturebox_About
            // 
            this.picturebox_About.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picturebox_About.BackgroundImage")));
            this.picturebox_About.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picturebox_About.Location = new System.Drawing.Point(12, 30);
            this.picturebox_About.Name = "picturebox_About";
            this.picturebox_About.Size = new System.Drawing.Size(126, 170);
            this.picturebox_About.TabIndex = 3;
            this.picturebox_About.TabStop = false;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 261);
            this.Controls.Add(this.picturebox_About);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.textbox_Description);
            this.Controls.Add(this.label_Title);
            this.Name = "About";
            this.RightToLeftLayout = true;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_About)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.TextBox textbox_Description;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.PictureBox picturebox_About;
    }
}