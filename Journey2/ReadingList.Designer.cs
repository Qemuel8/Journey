namespace JournalApp2
{
    partial class ReadingList
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
            this.btnHomeReading = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHomeReading
            // 
            this.btnHomeReading.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHomeReading.ForeColor = System.Drawing.Color.Maroon;
            this.btnHomeReading.Location = new System.Drawing.Point(12, 12);
            this.btnHomeReading.Name = "btnHomeReading";
            this.btnHomeReading.Size = new System.Drawing.Size(128, 82);
            this.btnHomeReading.TabIndex = 11;
            this.btnHomeReading.Text = "Home";
            this.btnHomeReading.UseVisualStyleBackColor = true;
            this.btnHomeReading.Click += new System.EventHandler(this.btnHomeReading_Click);
            // 
            // ReadingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btnHomeReading);
            this.Name = "ReadingList";
            this.Text = "ReadingList";
            this.Load += new System.EventHandler(this.ReadingList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHomeReading;
    }
}