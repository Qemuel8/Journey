namespace JournalApp2
{
    partial class PastEntries
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
            this.btnHomePE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHomePE
            // 
            this.btnHomePE.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHomePE.ForeColor = System.Drawing.Color.Maroon;
            this.btnHomePE.Location = new System.Drawing.Point(12, 12);
            this.btnHomePE.Name = "btnHomePE";
            this.btnHomePE.Size = new System.Drawing.Size(128, 82);
            this.btnHomePE.TabIndex = 11;
            this.btnHomePE.Text = "Home";
            this.btnHomePE.UseVisualStyleBackColor = true;
            this.btnHomePE.Click += new System.EventHandler(this.BtnHomePE_Click);
            // 
            // PastEntries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btnHomePE);
            this.Name = "PastEntries";
            this.Text = "PastEntries";
            this.Load += new System.EventHandler(this.PastEntries_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHomePE;
    }
}