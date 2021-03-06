
namespace JournalApp2
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.lblUser = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnJournal = new System.Windows.Forms.Button();
            this.btnNotes = new System.Windows.Forms.Button();
            this.btnEntries = new System.Windows.Forms.Button();
            this.btnReadingList = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblUser.Location = new System.Drawing.Point(12, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(59, 29);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "User ID: ";
            this.lblUser.Click += new System.EventHandler(this.lblUser_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Gabriola", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblWelcome.Location = new System.Drawing.Point(718, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(568, 118);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome To  Your Journey";
            this.lblWelcome.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnJournal
            // 
            this.btnJournal.BackColor = System.Drawing.Color.Transparent;
            this.btnJournal.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnJournal.Location = new System.Drawing.Point(12, 74);
            this.btnJournal.Name = "btnJournal";
            this.btnJournal.Size = new System.Drawing.Size(308, 99);
            this.btnJournal.TabIndex = 2;
            this.btnJournal.Text = "Start Journaing!";
            this.btnJournal.UseVisualStyleBackColor = false;
            this.btnJournal.Click += new System.EventHandler(this.btnJournal_Click);
            // 
            // btnNotes
            // 
            this.btnNotes.BackColor = System.Drawing.Color.Transparent;
            this.btnNotes.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNotes.Location = new System.Drawing.Point(12, 284);
            this.btnNotes.Name = "btnNotes";
            this.btnNotes.Size = new System.Drawing.Size(308, 99);
            this.btnNotes.TabIndex = 3;
            this.btnNotes.Text = "Quick Notes";
            this.btnNotes.UseVisualStyleBackColor = false;
            this.btnNotes.Click += new System.EventHandler(this.btnNotes_Click);
            // 
            // btnEntries
            // 
            this.btnEntries.BackColor = System.Drawing.Color.Transparent;
            this.btnEntries.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEntries.Location = new System.Drawing.Point(12, 179);
            this.btnEntries.Name = "btnEntries";
            this.btnEntries.Size = new System.Drawing.Size(308, 99);
            this.btnEntries.TabIndex = 4;
            this.btnEntries.Text = "Past Entries";
            this.btnEntries.UseVisualStyleBackColor = false;
            this.btnEntries.Click += new System.EventHandler(this.btnEntries_Click);
            // 
            // btnReadingList
            // 
            this.btnReadingList.BackColor = System.Drawing.Color.Transparent;
            this.btnReadingList.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReadingList.Location = new System.Drawing.Point(12, 389);
            this.btnReadingList.Name = "btnReadingList";
            this.btnReadingList.Size = new System.Drawing.Size(308, 99);
            this.btnReadingList.TabIndex = 5;
            this.btnReadingList.Text = "Reading List";
            this.btnReadingList.UseVisualStyleBackColor = false;
            this.btnReadingList.Click += new System.EventHandler(this.btnReadingList_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 930);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(308, 99);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReadingList);
            this.Controls.Add(this.btnEntries);
            this.Controls.Add(this.btnNotes);
            this.Controls.Add(this.btnJournal);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Home_FormClosed);
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnJournal;
        private System.Windows.Forms.Button btnNotes;
        private System.Windows.Forms.Button btnEntries;
        private System.Windows.Forms.Button btnReadingList;
        private System.Windows.Forms.Button btnExit;
    }
}