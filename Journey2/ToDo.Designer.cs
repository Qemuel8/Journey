namespace JournalApp2
{
    partial class ToDo
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
            this.btnHomeToDo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHomeToDo
            // 
            this.btnHomeToDo.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHomeToDo.ForeColor = System.Drawing.Color.Maroon;
            this.btnHomeToDo.Location = new System.Drawing.Point(12, 12);
            this.btnHomeToDo.Name = "btnHomeToDo";
            this.btnHomeToDo.Size = new System.Drawing.Size(128, 82);
            this.btnHomeToDo.TabIndex = 11;
            this.btnHomeToDo.Text = "Home";
            this.btnHomeToDo.UseVisualStyleBackColor = true;
            this.btnHomeToDo.Click += new System.EventHandler(this.btnHomeToDo_Click);
            // 
            // ToDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btnHomeToDo);
            this.Name = "ToDo";
            this.Text = "ToDo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHomeToDo;
    }
}