namespace Jukebox_Assignment2_Final
{
    partial class form_Setup
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
            this.button_CopyTrack = new System.Windows.Forms.Button();
            this.btn_MoveTrack = new System.Windows.Forms.Button();
            this.btn_DeleteTrack = new System.Windows.Forms.Button();
            this.listbox_Import = new System.Windows.Forms.ListBox();
            this.btn_ImportFromDirectory = new System.Windows.Forms.Button();
            this.btn_ClearImportedTracks = new System.Windows.Forms.Button();
            this.listbox_GenraTracks = new System.Windows.Forms.ListBox();
            this.textbox_GenraTitle = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_NextGenra = new System.Windows.Forms.Button();
            this.btn_PreviousGenra = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.label_PresentGenra = new System.Windows.Forms.Label();
            this.label_ImportedTracks = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_CopyTrack
            // 
            this.button_CopyTrack.Location = new System.Drawing.Point(191, 136);
            this.button_CopyTrack.Name = "button_CopyTrack";
            this.button_CopyTrack.Size = new System.Drawing.Size(96, 23);
            this.button_CopyTrack.TabIndex = 0;
            this.button_CopyTrack.Text = "Copy Track >>";
            this.button_CopyTrack.UseVisualStyleBackColor = true;
            // 
            // btn_MoveTrack
            // 
            this.btn_MoveTrack.Location = new System.Drawing.Point(191, 165);
            this.btn_MoveTrack.Name = "btn_MoveTrack";
            this.btn_MoveTrack.Size = new System.Drawing.Size(96, 23);
            this.btn_MoveTrack.TabIndex = 1;
            this.btn_MoveTrack.Text = "Move Track >>";
            this.btn_MoveTrack.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteTrack
            // 
            this.btn_DeleteTrack.Location = new System.Drawing.Point(177, 207);
            this.btn_DeleteTrack.Name = "btn_DeleteTrack";
            this.btn_DeleteTrack.Size = new System.Drawing.Size(123, 39);
            this.btn_DeleteTrack.TabIndex = 2;
            this.btn_DeleteTrack.Text = "Delete Track From Genra";
            this.btn_DeleteTrack.UseVisualStyleBackColor = true;
            // 
            // listbox_Import
            // 
            this.listbox_Import.FormattingEnabled = true;
            this.listbox_Import.Location = new System.Drawing.Point(12, 64);
            this.listbox_Import.Name = "listbox_Import";
            this.listbox_Import.Size = new System.Drawing.Size(159, 225);
            this.listbox_Import.TabIndex = 3;
            // 
            // btn_ImportFromDirectory
            // 
            this.btn_ImportFromDirectory.Location = new System.Drawing.Point(12, 295);
            this.btn_ImportFromDirectory.Name = "btn_ImportFromDirectory";
            this.btn_ImportFromDirectory.Size = new System.Drawing.Size(159, 23);
            this.btn_ImportFromDirectory.TabIndex = 4;
            this.btn_ImportFromDirectory.Text = "Import Tracks From Directory";
            this.btn_ImportFromDirectory.UseVisualStyleBackColor = true;
            this.btn_ImportFromDirectory.Click += new System.EventHandler(this.btn_ImportFromDirectory_Click);
            // 
            // btn_ClearImportedTracks
            // 
            this.btn_ClearImportedTracks.Location = new System.Drawing.Point(12, 324);
            this.btn_ClearImportedTracks.Name = "btn_ClearImportedTracks";
            this.btn_ClearImportedTracks.Size = new System.Drawing.Size(159, 23);
            this.btn_ClearImportedTracks.TabIndex = 5;
            this.btn_ClearImportedTracks.Text = "Clear Imported Tracks";
            this.btn_ClearImportedTracks.UseVisualStyleBackColor = true;
            // 
            // listbox_GenraTracks
            // 
            this.listbox_GenraTracks.FormattingEnabled = true;
            this.listbox_GenraTracks.Location = new System.Drawing.Point(306, 90);
            this.listbox_GenraTracks.Name = "listbox_GenraTracks";
            this.listbox_GenraTracks.Size = new System.Drawing.Size(159, 199);
            this.listbox_GenraTracks.TabIndex = 6;
            // 
            // textbox_GenraTitle
            // 
            this.textbox_GenraTitle.Location = new System.Drawing.Point(306, 64);
            this.textbox_GenraTitle.Name = "textbox_GenraTitle";
            this.textbox_GenraTitle.Size = new System.Drawing.Size(159, 20);
            this.textbox_GenraTitle.TabIndex = 7;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(352, 295);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(66, 23);
            this.btn_Add.TabIndex = 8;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(352, 324);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(66, 23);
            this.btn_Delete.TabIndex = 9;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_NextGenra
            // 
            this.btn_NextGenra.Location = new System.Drawing.Point(424, 308);
            this.btn_NextGenra.Name = "btn_NextGenra";
            this.btn_NextGenra.Size = new System.Drawing.Size(77, 23);
            this.btn_NextGenra.TabIndex = 10;
            this.btn_NextGenra.Text = "Next >>";
            this.btn_NextGenra.UseVisualStyleBackColor = true;
            // 
            // btn_PreviousGenra
            // 
            this.btn_PreviousGenra.Location = new System.Drawing.Point(269, 308);
            this.btn_PreviousGenra.Name = "btn_PreviousGenra";
            this.btn_PreviousGenra.Size = new System.Drawing.Size(77, 23);
            this.btn_PreviousGenra.TabIndex = 11;
            this.btn_PreviousGenra.Text = "<< Previous";
            this.btn_PreviousGenra.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(426, 374);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 12;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(343, 374);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(75, 23);
            this.btn_Ok.TabIndex = 13;
            this.btn_Ok.Text = "Ok";
            this.btn_Ok.UseVisualStyleBackColor = true;
            // 
            // label_PresentGenra
            // 
            this.label_PresentGenra.AutoSize = true;
            this.label_PresentGenra.Location = new System.Drawing.Point(303, 48);
            this.label_PresentGenra.Name = "label_PresentGenra";
            this.label_PresentGenra.Size = new System.Drawing.Size(75, 13);
            this.label_PresentGenra.TabIndex = 14;
            this.label_PresentGenra.Text = "Present Genra";
            // 
            // label_ImportedTracks
            // 
            this.label_ImportedTracks.AutoSize = true;
            this.label_ImportedTracks.Location = new System.Drawing.Point(9, 48);
            this.label_ImportedTracks.Name = "label_ImportedTracks";
            this.label_ImportedTracks.Size = new System.Drawing.Size(84, 13);
            this.label_ImportedTracks.TabIndex = 15;
            this.label_ImportedTracks.Text = "Imported Tracks";
            // 
            // form_Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(513, 409);
            this.Controls.Add(this.label_ImportedTracks);
            this.Controls.Add(this.label_PresentGenra);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_PreviousGenra);
            this.Controls.Add(this.btn_NextGenra);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.textbox_GenraTitle);
            this.Controls.Add(this.listbox_GenraTracks);
            this.Controls.Add(this.btn_ClearImportedTracks);
            this.Controls.Add(this.btn_ImportFromDirectory);
            this.Controls.Add(this.listbox_Import);
            this.Controls.Add(this.btn_DeleteTrack);
            this.Controls.Add(this.btn_MoveTrack);
            this.Controls.Add(this.button_CopyTrack);
            this.Name = "form_Setup";
            this.Text = "Setup";
            this.Load += new System.EventHandler(this.form_Setup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_CopyTrack;
        private System.Windows.Forms.Button btn_MoveTrack;
        private System.Windows.Forms.Button btn_DeleteTrack;
        private System.Windows.Forms.ListBox listbox_Import;
        private System.Windows.Forms.Button btn_ImportFromDirectory;
        private System.Windows.Forms.Button btn_ClearImportedTracks;
        private System.Windows.Forms.ListBox listbox_GenraTracks;
        private System.Windows.Forms.TextBox textbox_GenraTitle;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_NextGenra;
        private System.Windows.Forms.Button btn_PreviousGenra;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Label label_PresentGenra;
        private System.Windows.Forms.Label label_ImportedTracks;
    }
}