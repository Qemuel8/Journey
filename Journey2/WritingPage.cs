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
    public partial class WritingPage : Form
    {
        int user_id;
        string date = DateTime.Now.ToString();
        public WritingPage(int id)
        {
            user_id = id;
            InitializeComponent();
        }
        private NpgsqlConnection conn;
        string connstring = String.Format("Server={0};Port={1};" + "User Id={2};Password={3};Database={4};", "localhost", "5432", "postgres", "salamence1", "postgres");
        private NpgsqlCommand cmd;
        private string sql = null;

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"select * from create_entry(:_date,:_mood,:_tags,:_entry_title,:_entry_text,:_user_id)";
                cmd = new NpgsqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("_date", date);
                cmd.Parameters.AddWithValue("_mood", txtMood.Text);
                cmd.Parameters.AddWithValue("_tags", txtTag.Text);
                cmd.Parameters.AddWithValue("_entry_title", txtTitle.Text);
                cmd.Parameters.AddWithValue("_entry_text", txtEntry.Text);
                cmd.Parameters.AddWithValue("_user_id", user_id);

                int result = (int)cmd.ExecuteScalar();
                conn.Close();

                if (result == 1)//success
                {
                    MessageBox.Show("Entry Saved! ", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }

        }

        private void WritingPage_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }

        private void txtEntry_TextChanged(object sender, EventArgs e)
        {

        }



        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home(user_id).Show();
        }
    }
}
