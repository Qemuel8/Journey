
namespace JournalApp2
{
    partial class WritingPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WritingPage));
            this.txtTitle = new System.Windows.Forms.RichTextBox();
            this.txtEntry = new System.Windows.Forms.RichTextBox();
            this.txtMood = new System.Windows.Forms.RichTextBox();
            this.txtTag = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTags = new System.Windows.Forms.Label();
            this.lblMood = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(468, 81);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(459, 39);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.Text = "";
            // 
            // txtEntry
            // 
            this.txtEntry.Location = new System.Drawing.Point(82, 150);
            this.txtEntry.Name = "txtEntry";
            this.txtEntry.Size = new System.Drawing.Size(1728, 879);
            this.txtEntry.TabIndex = 1;
            this.txtEntry.Text = " ";
            this.txtEntry.TextChanged += new System.EventHandler(this.txtEntry_TextChanged);
            // 
            // txtMood
            // 
            this.txtMood.Location = new System.Drawing.Point(1080, 84);
            this.txtMood.Name = "txtMood";
            this.txtMood.Size = new System.Drawing.Size(68, 39);
            this.txtMood.TabIndex = 2;
            this.txtMood.Text = "";
            // 
            // txtTag
            // 
            this.txtTag.Location = new System.Drawing.Point(468, 23);
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(459, 39);
            this.txtTag.TabIndex = 3;
            this.txtTag.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.Maroon;
            this.btnSave.Location = new System.Drawing.Point(1764, 30);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 82);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.Maroon;
            this.lblTitle.Location = new System.Drawing.Point(377, 84);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(85, 32);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Title : ";
            // 
            // lblTags
            // 
            this.lblTags.AutoSize = true;
            this.lblTags.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTags.ForeColor = System.Drawing.Color.Maroon;
            this.lblTags.Location = new System.Drawing.Point(376, 30);
            this.lblTags.Name = "lblTags";
            this.lblTags.Size = new System.Drawing.Size(86, 32);
            this.lblTags.TabIndex = 6;
            this.lblTags.Text = "Tags : ";
            // 
            // lblMood
            // 
            this.lblMood.AutoSize = true;
            this.lblMood.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMood.ForeColor = System.Drawing.Color.Maroon;
            this.lblMood.Location = new System.Drawing.Point(971, 88);
            this.lblMood.Name = "lblMood";
            this.lblMood.Size = new System.Drawing.Size(103, 32);
            this.lblMood.TabIndex = 8;
            this.lblMood.Text = "Mood : ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(948, 39);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.Color.Maroon;
            this.btnHome.Location = new System.Drawing.Point(12, 23);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(128, 82);
            this.btnHome.TabIndex = 10;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // WritingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblMood);
            this.Controls.Add(this.lblTags);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTag);
            this.Controls.Add(this.txtMood);
            this.Controls.Add(this.txtEntry);
            this.Controls.Add(this.txtTitle);
            this.Name = "WritingPage";
            this.Text = "WritingPage";
            this.Load += new System.EventHandler(this.WritingPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtTitle;
        private System.Windows.Forms.RichTextBox txtEntry;
        private System.Windows.Forms.RichTextBox txtMood;
        private System.Windows.Forms.RichTextBox txtTag;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTags;
        private System.Windows.Forms.Label lblMood;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnHome;
    }
}