namespace JournalApp2
{
    partial class PhotosAlbum
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
            this.btnHomePhotos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHomePhotos
            // 
            this.btnHomePhotos.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHomePhotos.ForeColor = System.Drawing.Color.Maroon;
            this.btnHomePhotos.Location = new System.Drawing.Point(12, 12);
            this.btnHomePhotos.Name = "btnHomePhotos";
            this.btnHomePhotos.Size = new System.Drawing.Size(128, 82);
            this.btnHomePhotos.TabIndex = 11;
            this.btnHomePhotos.Text = "Home";
            this.btnHomePhotos.UseVisualStyleBackColor = true;
            this.btnHomePhotos.Click += new System.EventHandler(this.btnHomePhotos_Click);
            // 
            // PhotosAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btnHomePhotos);
            this.Name = "PhotosAlbum";
            this.Text = "PhotosAlbum";
            this.Load += new System.EventHandler(this.PhotosAlbum_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHomePhotos;
    }
}