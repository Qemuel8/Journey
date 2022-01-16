using JournalApp2;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Journey2
{
    public partial class Notes : Form
    {
        int user_id;
        string date = DateTime.Now.ToString();
        public Notes(int id)
        {
            user_id = id;
            InitializeComponent();
        }
        private NpgsqlConnection conn;
        string connstring = String.Format("Server={0};Port={1};" + "User Id={2};Password={3};Database={4};", "localhost", "5432", "postgres", "salamence1", "postgres");
        private NpgsqlCommand cmd;
        private string sql = null;

        private void Notes_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            conn.Open();
            sql = @"select note_title from note_entry where user_id = :_user_id";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("_user_id", user_id);
            NpgsqlDataReader da = cmd.ExecuteReader();
            while(da.Read())
            {
                listBoxNotes.Items.Add(da.GetValue(0).ToString());
                listBoxNotes.Text = "";
            }
            conn.Close();

            conn.Open();
            sql = @"select note_text from note_entry where user_id = :_user_id";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("_user_id", user_id);
            NpgsqlDataReader da1 = cmd.ExecuteReader();
            while (da1.Read())
            {
                listBoxNotes2.Items.Add(da1.GetValue(0).ToString());
                listBoxNotes2.Text = "";
            }
            conn.Close();

            conn.Open();
            sql = @"select note_id from note_entry where user_id = :_user_id";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("_user_id", user_id);
            NpgsqlDataReader da2 = cmd.ExecuteReader();
            while (da2.Read())
            {
                listBoxNotesId.Items.Add(da2.GetValue(0).ToString());
                listBoxNotesId.Text = "";
            }
            conn.Close();

            conn.Open();
            sql = @"select date from todo_list where user_id = :_user_id";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("_user_id", user_id);
            NpgsqlDataReader da3 = cmd.ExecuteReader();
            while (da3.Read())
            {
                listBoxTasks.Items.Add(da3.GetValue(0).ToString());
                listBoxTasks.Text = "";
            }
            conn.Close();


            conn.Open();
            sql = @"select todo_text from todo_list where user_id = :_user_id";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("_user_id", user_id);
            NpgsqlDataReader da4 = cmd.ExecuteReader();
            while (da4.Read())
            {
                listBoxTasks2.Items.Add(da4.GetValue(0).ToString());
                listBoxTasks.Text = "";
            }
            conn.Close();

            conn.Open();
            sql = @"select todo_id from todo_list where user_id = :_user_id";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("_user_id", user_id);
            NpgsqlDataReader da5 = cmd.ExecuteReader();
            while (da5.Read())
            {
                listBoxTasksId.Items.Add(da5.GetValue(0).ToString());
                listBoxTasksId.Text = "";
            }
            conn.Close();


        }

        private void btnHomeToDo_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home(user_id).Show();
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"select * from create_note(:_date,:_title,:_note,:_user_id)";
                cmd = new NpgsqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("_date", date);
                cmd.Parameters.AddWithValue("_title", txtNoteTitle.Text);
                cmd.Parameters.AddWithValue("_note", txtNote.Text);
                cmd.Parameters.AddWithValue("_user_id", user_id);

                int result = (int)cmd.ExecuteScalar();
                conn.Close();

                if (result == 1)//success
                {
                    MessageBox.Show("Note Saved! ", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }

        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"select * from create_task(:_date,:_task,:_user_id)";
                cmd = new NpgsqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("_date", date);
                cmd.Parameters.AddWithValue("_task", txtTask.Text);
                cmd.Parameters.AddWithValue("_user_id", user_id);

                int result = (int)cmd.ExecuteScalar();
                conn.Close();

                if (result == 1)//success
                {
                    MessageBox.Show("Task Saved! ", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void listBoxNotes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerNotes_ValueChanged(object sender, EventArgs e)
        {
            date = dateTimePickerNotes.Value.ToString("yyyy-MM-dd");
        }

        int noteId = 0;
        int taskId = 0;
        

        private void listBoxNotesId_MouseClick(object sender, MouseEventArgs e)
        {
            

            if (listBoxNotesId.SelectedItem != null)
            {

                noteId = Convert.ToInt32(listBoxNotesId.SelectedItem);

            }
        }

        private void listBoxTasksId_MouseClick(object sender, MouseEventArgs e)
        {
            if (listBoxNotesId.SelectedItem != null)
            {

                taskId = Convert.ToInt32(listBoxTasksId.SelectedItem);

            }

        }

        private void btnDeleteNote_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"DELETE from note_entry where user_id = :_user_id and note_id = :_note_id";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_user_id", user_id);
                cmd.Parameters.AddWithValue("_note_id", noteId);
                cmd.ExecuteScalar();
            }
            finally
            {
                MessageBox.Show("Note Deleted! ", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }

        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"DELETE from todo_list where user_id = :_user_id and todo_id = :_todo_id";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_user_id", user_id);
                cmd.Parameters.AddWithValue("_todo_id", taskId);
                cmd.ExecuteScalar();
            }
            finally
            {
                MessageBox.Show("Task Deleted! ", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
        }
    }
}
