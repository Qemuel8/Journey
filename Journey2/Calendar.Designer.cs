namespace JournalApp2
{
    partial class Calendar
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
            this.btnHome_Calendar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHome_Calendar
            // 
            this.btnHome_Calendar.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHome_Calendar.ForeColor = System.Drawing.Color.Maroon;
            this.btnHome_Calendar.Location = new System.Drawing.Point(12, 12);
            this.btnHome_Calendar.Name = "btnHome_Calendar";
            this.btnHome_Calendar.Size = new System.Drawing.Size(128, 82);
            this.btnHome_Calendar.TabIndex = 11;
            this.btnHome_Calendar.Text = "Home";
            this.btnHome_Calendar.UseVisualStyleBackColor = true;
            this.btnHome_Calendar.Click += new System.EventHandler(this.btnHome_Calendar_Click);
            // 
            // Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btnHome_Calendar);
            this.Name = "Calendar";
            this.Text = "Calendar";
            this.Load += new System.EventHandler(this.Calendar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHome_Calendar;
    }
}