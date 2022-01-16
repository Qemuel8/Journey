using JournalApp2;
using Journey3;
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

namespace JournalApp2
{
    public partial class ReadingList : Form
    {
        string date = DateTime.Now.ToString();
        int user_id;
        public ReadingList(int id)
        {
            user_id = id;
            InitializeComponent();
        }
        private NpgsqlConnection conn;
        string connstring = String.Format("Server={0};Port={1};" + "User Id={2};Password={3};Database={4};", "localhost", "5432", "postgres", "salamence1", "postgres");
        private NpgsqlCommand cmd;
        private string sql = null;

        private void ReadingList_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            conn.Open();
            sql = @"select reading_title from reading_list where user_id = :_user_id";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("_user_id", user_id);
            NpgsqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                listBoxReadings.Items.Add(da.GetValue(0).ToString());
                listBoxReadings.Text = "";
            }
            conn.Close();
        }

        private void btnHomeReading_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home(user_id).Show();
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"select * from create_reading(:_date,:_title,:_text,:_user_id)";
                cmd = new NpgsqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("_date", date);
                cmd.Parameters.AddWithValue("_title", txtTitle.Text);
                cmd.Parameters.AddWithValue("_text", txtReading.Text);
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

        private void listBoxReadings_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxReadings_DoubleClick(object sender, EventArgs e)
        {
            string readingTitle = "text";
            string readingText = "Error: Entry Not Found.";
            if (listBoxReadings.SelectedItem != null)
            {
               
                    readingTitle = listBoxReadings.SelectedItem.ToString();
                
            }
            
                conn.Open();
                sql = @"select reading_text from reading_list where user_id = :_user_id and reading_title = :_reading_title";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_user_id", user_id);
                cmd.Parameters.AddWithValue("_reading_title", readingTitle);
                NpgsqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                readingText = da.GetString(0);
                }
                conn.Close();
            new Reading(user_id, readingText).Show();




        }
        string readingTitle = "Nope";
        private void listBoxReadings_MouseClick(object sender, MouseEventArgs e)
        {
            if (listBoxReadings.SelectedItem != null)
            {

                readingTitle = listBoxReadings.SelectedItem.ToString();

            }
        }

        private void btnDeleteReading_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"DELETE from reading_list where user_id = :_user_id and reading_title = :_reading_title";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_user_id", user_id);
                cmd.Parameters.AddWithValue("_reading_title", readingTitle);
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
