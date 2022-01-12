namespace JournalApp2
{
    partial class Notes
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
            this.btnHomeNotes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHomeNotes
            // 
            this.btnHomeNotes.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHomeNotes.ForeColor = System.Drawing.Color.Maroon;
            this.btnHomeNotes.Location = new System.Drawing.Point(12, 12);
            this.btnHomeNotes.Name = "btnHomeNotes";
            this.btnHomeNotes.Size = new System.Drawing.Size(128, 82);
            this.btnHomeNotes.TabIndex = 11;
            this.btnHomeNotes.Text = "Home";
            this.btnHomeNotes.UseVisualStyleBackColor = true;
            this.btnHomeNotes.Click += new System.EventHandler(this.btnHomeNotes_Click);
            // 
            // Notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btnHomeNotes);
            this.Name = "Notes";
            this.Text = "Notes";
            this.Load += new System.EventHandler(this.Notes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHomeNotes;
    }
}