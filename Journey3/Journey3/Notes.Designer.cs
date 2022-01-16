namespace Journey2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notes));
            this.dateTimePickerNotes = new System.Windows.Forms.DateTimePicker();
            this.lblTask = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.txtTask = new System.Windows.Forms.RichTextBox();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.txtNoteTitle = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddNote = new System.Windows.Forms.Button();
            this.txtNote = new System.Windows.Forms.RichTextBox();
            this.btnHomeToDo = new System.Windows.Forms.Button();
            this.listBoxTasks = new System.Windows.Forms.ListBox();
            this.listBoxNotes = new System.Windows.Forms.ListBox();
            this.listBoxNotes2 = new System.Windows.Forms.ListBox();
            this.listBoxTasks2 = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.listBoxNotesId = new System.Windows.Forms.ListBox();
            this.listBoxTasksId = new System.Windows.Forms.ListBox();
            this.btnDeleteNote = new System.Windows.Forms.Button();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePickerNotes
            // 
            this.dateTimePickerNotes.Location = new System.Drawing.Point(1187, 137);
            this.dateTimePickerNotes.Name = "dateTimePickerNotes";
            this.dateTimePickerNotes.Size = new System.Drawing.Size(419, 23);
            this.dateTimePickerNotes.TabIndex = 59;
            this.dateTimePickerNotes.ValueChanged += new System.EventHandler(this.dateTimePickerNotes_ValueChanged);
            // 
            // lblTask
            // 
            this.lblTask.AutoSize = true;
            this.lblTask.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTask.ForeColor = System.Drawing.Color.Maroon;
            this.lblTask.Location = new System.Drawing.Point(1076, 172);
            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(105, 45);
            this.lblTask.TabIndex = 57;
            this.lblTask.Text = "Task :";
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDueDate.ForeColor = System.Drawing.Color.Maroon;
            this.lblDueDate.Location = new System.Drawing.Point(999, 119);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(182, 45);
            this.lblDueDate.TabIndex = 56;
            this.lblDueDate.Text = "Due Date :";
            // 
            // txtTask
            // 
            this.txtTask.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTask.Location = new System.Drawing.Point(1187, 171);
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(419, 46);
            this.txtTask.TabIndex = 55;
            this.txtTask.Text = "";
            // 
            // btnAddTask
            // 
            this.btnAddTask.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddTask.ForeColor = System.Drawing.Color.Maroon;
            this.btnAddTask.Location = new System.Drawing.Point(1612, 119);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(106, 98);
            this.btnAddTask.TabIndex = 48;
            this.btnAddTask.Text = "Add";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.Control;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.Maroon;
            this.lblTitle.Location = new System.Drawing.Point(160, 120);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(108, 47);
            this.lblTitle.TabIndex = 53;
            this.lblTitle.Text = "Title :";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.BackColor = System.Drawing.SystemColors.Control;
            this.lblNote.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNote.ForeColor = System.Drawing.Color.Maroon;
            this.lblNote.Location = new System.Drawing.Point(151, 170);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(115, 45);
            this.lblNote.TabIndex = 52;
            this.lblNote.Text = "Note :";
            // 
            // txtNoteTitle
            // 
            this.txtNoteTitle.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNoteTitle.Location = new System.Drawing.Point(272, 116);
            this.txtNoteTitle.Name = "txtNoteTitle";
            this.txtNoteTitle.Size = new System.Drawing.Size(380, 46);
            this.txtNoteTitle.TabIndex = 51;
            this.txtNoteTitle.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(411, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 45);
            this.label2.TabIndex = 50;
            this.label2.Text = "Notes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(1288, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 45);
            this.label1.TabIndex = 49;
            this.label1.Text = "To-Do List";
            // 
            // btnAddNote
            // 
            this.btnAddNote.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddNote.ForeColor = System.Drawing.Color.Maroon;
            this.btnAddNote.Location = new System.Drawing.Point(658, 120);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Size = new System.Drawing.Size(106, 102);
            this.btnAddNote.TabIndex = 47;
            this.btnAddNote.Text = "Add";
            this.btnAddNote.UseVisualStyleBackColor = true;
            this.btnAddNote.Click += new System.EventHandler(this.btnAddNote_Click);
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNote.Location = new System.Drawing.Point(272, 169);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(380, 46);
            this.txtNote.TabIndex = 45;
            this.txtNote.Text = "";
            // 
            // btnHomeToDo
            // 
            this.btnHomeToDo.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHomeToDo.ForeColor = System.Drawing.Color.Maroon;
            this.btnHomeToDo.Location = new System.Drawing.Point(9, 20);
            this.btnHomeToDo.Name = "btnHomeToDo";
            this.btnHomeToDo.Size = new System.Drawing.Size(128, 82);
            this.btnHomeToDo.TabIndex = 44;
            this.btnHomeToDo.Text = "Home";
            this.btnHomeToDo.UseVisualStyleBackColor = true;
            this.btnHomeToDo.Click += new System.EventHandler(this.btnHomeToDo_Click);
            // 
            // listBoxTasks
            // 
            this.listBoxTasks.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listBoxTasks.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxTasks.FormattingEnabled = true;
            this.listBoxTasks.ItemHeight = 47;
            this.listBoxTasks.Location = new System.Drawing.Point(1094, 246);
            this.listBoxTasks.Name = "listBoxTasks";
            this.listBoxTasks.Size = new System.Drawing.Size(188, 709);
            this.listBoxTasks.TabIndex = 60;
            this.listBoxTasks.SelectedIndexChanged += new System.EventHandler(this.listBoxNotes_SelectedIndexChanged);
            // 
            // listBoxNotes
            // 
            this.listBoxNotes.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listBoxNotes.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxNotes.FormattingEnabled = true;
            this.listBoxNotes.ItemHeight = 47;
            this.listBoxNotes.Location = new System.Drawing.Point(95, 246);
            this.listBoxNotes.Name = "listBoxNotes";
            this.listBoxNotes.Size = new System.Drawing.Size(188, 709);
            this.listBoxNotes.TabIndex = 61;
            this.listBoxNotes.SelectedIndexChanged += new System.EventHandler(this.listBoxNotes_SelectedIndexChanged);
            // 
            // listBoxNotes2
            // 
            this.listBoxNotes2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listBoxNotes2.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxNotes2.FormattingEnabled = true;
            this.listBoxNotes2.ItemHeight = 47;
            this.listBoxNotes2.Location = new System.Drawing.Point(289, 246);
            this.listBoxNotes2.Name = "listBoxNotes2";
            this.listBoxNotes2.Size = new System.Drawing.Size(640, 709);
            this.listBoxNotes2.TabIndex = 62;
            // 
            // listBoxTasks2
            // 
            this.listBoxTasks2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listBoxTasks2.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxTasks2.FormattingEnabled = true;
            this.listBoxTasks2.ItemHeight = 47;
            this.listBoxTasks2.Location = new System.Drawing.Point(1288, 246);
            this.listBoxTasks2.Name = "listBoxTasks2";
            this.listBoxTasks2.Size = new System.Drawing.Size(604, 709);
            this.listBoxTasks2.TabIndex = 63;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(707, 20);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(419, 23);
            this.dateTimePicker1.TabIndex = 64;
            // 
            // listBoxNotesId
            // 
            this.listBoxNotesId.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listBoxNotesId.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxNotesId.FormattingEnabled = true;
            this.listBoxNotesId.ItemHeight = 47;
            this.listBoxNotesId.Location = new System.Drawing.Point(9, 246);
            this.listBoxNotesId.Name = "listBoxNotesId";
            this.listBoxNotesId.Size = new System.Drawing.Size(80, 709);
            this.listBoxNotesId.TabIndex = 65;
            this.listBoxNotesId.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBoxNotesId_MouseClick);
            // 
            // listBoxTasksId
            // 
            this.listBoxTasksId.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listBoxTasksId.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxTasksId.FormattingEnabled = true;
            this.listBoxTasksId.ItemHeight = 47;
            this.listBoxTasksId.Location = new System.Drawing.Point(1008, 246);
            this.listBoxTasksId.Name = "listBoxTasksId";
            this.listBoxTasksId.Size = new System.Drawing.Size(80, 709);
            this.listBoxTasksId.TabIndex = 66;
            this.listBoxTasksId.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBoxTasksId_MouseClick);
            // 
            // btnDeleteNote
            // 
            this.btnDeleteNote.Font = new System.Drawing.Font("Segoe Print", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteNote.ForeColor = System.Drawing.Color.Maroon;
            this.btnDeleteNote.Location = new System.Drawing.Point(770, 120);
            this.btnDeleteNote.Name = "btnDeleteNote";
            this.btnDeleteNote.Size = new System.Drawing.Size(106, 102);
            this.btnDeleteNote.TabIndex = 67;
            this.btnDeleteNote.Text = "Delete";
            this.btnDeleteNote.UseVisualStyleBackColor = true;
            this.btnDeleteNote.Click += new System.EventHandler(this.btnDeleteNote_Click);
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.Font = new System.Drawing.Font("Segoe Print", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteTask.ForeColor = System.Drawing.Color.Maroon;
            this.btnDeleteTask.Location = new System.Drawing.Point(1724, 120);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(106, 98);
            this.btnDeleteTask.TabIndex = 68;
            this.btnDeleteTask.Text = "Delete";
            this.btnDeleteTask.UseVisualStyleBackColor = true;
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
            // 
            // Notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.btnDeleteTask);
            this.Controls.Add(this.btnDeleteNote);
            this.Controls.Add(this.listBoxTasksId);
            this.Controls.Add(this.listBoxNotesId);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.listBoxTasks2);
            this.Controls.Add(this.listBoxNotes2);
            this.Controls.Add(this.listBoxNotes);
            this.Controls.Add(this.listBoxTasks);
            this.Controls.Add(this.dateTimePickerNotes);
            this.Controls.Add(this.lblTask);
            this.Controls.Add(this.lblDueDate);
            this.Controls.Add(this.txtTask);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.txtNoteTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddNote);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.btnHomeToDo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Notes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notes";
            this.Load += new System.EventHandler(this.Notes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerNotes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTask;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.RichTextBox txtTask;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.RichTextBox txtDueDate;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.RichTextBox txtNoteTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddNote;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox txtNote;
        private System.Windows.Forms.Button btnHomeToDo;
        private System.Windows.Forms.ListBox listBoxTasks;
        private System.Windows.Forms.ListBox listBoxNotes;
        private System.Windows.Forms.ListBox listBoxNotes2;
        private System.Windows.Forms.ListBox listBoxTasks2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private ListBox listBoxNotesId;
        private ListBox listBoxTasksId;
        private Button btnDeleteNote;
        private Button btnDeleteTask;
    }
}