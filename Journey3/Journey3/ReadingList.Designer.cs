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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReadingList));
            this.btnHomeReading = new System.Windows.Forms.Button();
            this.txtReading = new System.Windows.Forms.RichTextBox();
            this.txtTitle = new System.Windows.Forms.RichTextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.listBoxReadings = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDeleteReading = new System.Windows.Forms.Button();
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
            // txtReading
            // 
            this.txtReading.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtReading.Location = new System.Drawing.Point(33, 233);
            this.txtReading.Name = "txtReading";
            this.txtReading.Size = new System.Drawing.Size(943, 714);
            this.txtReading.TabIndex = 12;
            this.txtReading.Text = "";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTitle.Location = new System.Drawing.Point(140, 182);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(618, 47);
            this.txtTitle.TabIndex = 13;
            this.txtTitle.Text = "";
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.Maroon;
            this.lblTitle.Location = new System.Drawing.Point(33, 184);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(115, 45);
            this.lblTitle.TabIndex = 51;
            this.lblTitle.Text = "Title : ";
            // 
            // listBoxReadings
            // 
            this.listBoxReadings.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxReadings.FormattingEnabled = true;
            this.listBoxReadings.ItemHeight = 47;
            this.listBoxReadings.Location = new System.Drawing.Point(1015, 233);
            this.listBoxReadings.Name = "listBoxReadings";
            this.listBoxReadings.Size = new System.Drawing.Size(867, 709);
            this.listBoxReadings.TabIndex = 52;
            this.listBoxReadings.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBoxReadings_MouseClick);
            this.listBoxReadings.SelectedIndexChanged += new System.EventHandler(this.listBoxReadings_SelectedIndexChanged);
            this.listBoxReadings.DoubleClick += new System.EventHandler(this.listBoxReadings_DoubleClick);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.Maroon;
            this.btnSave.Location = new System.Drawing.Point(764, 162);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 67);
            this.btnSave.TabIndex = 53;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDeleteReading
            // 
            this.btnDeleteReading.Font = new System.Drawing.Font("Segoe Print", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteReading.ForeColor = System.Drawing.Color.Maroon;
            this.btnDeleteReading.Location = new System.Drawing.Point(864, 162);
            this.btnDeleteReading.Name = "btnDeleteReading";
            this.btnDeleteReading.Size = new System.Drawing.Size(112, 65);
            this.btnDeleteReading.TabIndex = 68;
            this.btnDeleteReading.Text = "Delete";
            this.btnDeleteReading.UseVisualStyleBackColor = true;
            this.btnDeleteReading.Click += new System.EventHandler(this.btnDeleteReading_Click);
            // 
            // ReadingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.btnDeleteReading);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.listBoxReadings);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtReading);
            this.Controls.Add(this.btnHomeReading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReadingList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReadingList";
            this.Load += new System.EventHandler(this.ReadingList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHomeReading;
        private RichTextBox txtReading;
        private RichTextBox txtTitle;
        private Label lblTitle;
        private ListBox listBoxReadings;
        private Button btnSave;
        private Button btnDeleteReading;
    }
}