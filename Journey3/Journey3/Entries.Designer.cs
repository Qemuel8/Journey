namespace Journey2
{
    partial class Entries
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entries));
            this.listBoxEntry = new System.Windows.Forms.ListBox();
            this.btnHomePE = new System.Windows.Forms.Button();
            this.listBoxTitle = new System.Windows.Forms.ListBox();
            this.listBoxEntryId = new System.Windows.Forms.ListBox();
            this.btnDeleteEntry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxEntry
            // 
            this.listBoxEntry.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxEntry.FormattingEnabled = true;
            this.listBoxEntry.ItemHeight = 47;
            this.listBoxEntry.Location = new System.Drawing.Point(382, 334);
            this.listBoxEntry.Name = "listBoxEntry";
            this.listBoxEntry.Size = new System.Drawing.Size(1510, 615);
            this.listBoxEntry.TabIndex = 16;
            this.listBoxEntry.SelectedIndexChanged += new System.EventHandler(this.listBoxEntry_SelectedIndexChanged);
            this.listBoxEntry.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxEntry_MouseDoubleClick);
            // 
            // btnHomePE
            // 
            this.btnHomePE.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHomePE.ForeColor = System.Drawing.Color.Maroon;
            this.btnHomePE.Location = new System.Drawing.Point(12, 12);
            this.btnHomePE.Name = "btnHomePE";
            this.btnHomePE.Size = new System.Drawing.Size(128, 82);
            this.btnHomePE.TabIndex = 14;
            this.btnHomePE.Text = "Home";
            this.btnHomePE.UseVisualStyleBackColor = true;
            this.btnHomePE.Click += new System.EventHandler(this.btnHomePE_Click);
            // 
            // listBoxTitle
            // 
            this.listBoxTitle.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxTitle.FormattingEnabled = true;
            this.listBoxTitle.ItemHeight = 47;
            this.listBoxTitle.Location = new System.Drawing.Point(95, 334);
            this.listBoxTitle.Name = "listBoxTitle";
            this.listBoxTitle.Size = new System.Drawing.Size(281, 615);
            this.listBoxTitle.TabIndex = 15;
            this.listBoxTitle.SelectedIndexChanged += new System.EventHandler(this.listBoxTitle_SelectedIndexChanged);
            // 
            // listBoxEntryId
            // 
            this.listBoxEntryId.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxEntryId.FormattingEnabled = true;
            this.listBoxEntryId.ItemHeight = 47;
            this.listBoxEntryId.Location = new System.Drawing.Point(12, 334);
            this.listBoxEntryId.Name = "listBoxEntryId";
            this.listBoxEntryId.Size = new System.Drawing.Size(77, 615);
            this.listBoxEntryId.TabIndex = 17;
            this.listBoxEntryId.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBoxEntryId_MouseClick);
            this.listBoxEntryId.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBoxEntryId.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxEntryId_MouseDoubleClick);
            // 
            // btnDeleteEntry
            // 
            this.btnDeleteEntry.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteEntry.ForeColor = System.Drawing.Color.Maroon;
            this.btnDeleteEntry.Location = new System.Drawing.Point(146, 12);
            this.btnDeleteEntry.Name = "btnDeleteEntry";
            this.btnDeleteEntry.Size = new System.Drawing.Size(128, 82);
            this.btnDeleteEntry.TabIndex = 18;
            this.btnDeleteEntry.Text = "Delete";
            this.btnDeleteEntry.UseVisualStyleBackColor = true;
            this.btnDeleteEntry.Click += new System.EventHandler(this.btnDeleteEntry_Click);
            // 
            // Entries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.btnDeleteEntry);
            this.Controls.Add(this.listBoxEntryId);
            this.Controls.Add(this.listBoxEntry);
            this.Controls.Add(this.listBoxTitle);
            this.Controls.Add(this.btnHomePE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Entries";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entries";
            this.Load += new System.EventHandler(this.Entries_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxEntry;
        private System.Windows.Forms.Button btnHomePE;
        private ListBox listBoxTitle;
        private ListBox listBoxEntryId;
        private Button btnDeleteEntry;
    }
}