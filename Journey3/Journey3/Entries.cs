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

namespace Journey2
{
    public partial class Entries : Form
    {
        int user_id;
        public Entries(int id)
        {
            user_id = id;
            InitializeComponent();
        }
        private NpgsqlConnection conn;
        string connstring = String.Format("Server={0};Port={1};" + "User Id={2};Password={3};Database={4};", "localhost", "5432", "postgres", "salamence1", "postgres");
        private NpgsqlCommand cmd;
        private string sql = null;

        private void Entries_Load(object sender, EventArgs e)
        {
            
            conn = new NpgsqlConnection(connstring);

            conn.Open();
            sql = @"select entry_title from journal_entry where user_id = :_user_id";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("_user_id", user_id);
            NpgsqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                listBoxTitle.Items.Add(da.GetValue(0).ToString());
                listBoxTitle.Text = "";
            }
            conn.Close();

            conn.Open();
            sql = @"select entry_text from journal_entry where user_id = :_user_id";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("_user_id", user_id);
            NpgsqlDataReader da1 = cmd.ExecuteReader();
            while (da1.Read())
            {
                listBoxEntry.Items.Add(da1.GetValue(0).ToString());
                listBoxEntry.Text = "";
            }
            conn.Close();



            conn.Open();
            sql = @"select entry_id from journal_entry where user_id = :_user_id";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("_user_id", user_id);
            NpgsqlDataReader da2 = cmd.ExecuteReader();
            while (da2.Read())
            {
                listBoxEntryId.Items.Add(da2.GetValue(0).ToString());
                listBoxEntryId.Text = "";
            }
            conn.Close();

        }

        private void btnHomePE_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home(user_id).Show();
        }

        private void listBoxTitle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxEntry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxEntry_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxEntryId_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int readingId = 0;
            string readingText = "Error: Entry Not Found.";
            
            if (listBoxEntryId.SelectedItem != null)
            {

                readingId = Convert.ToInt32(listBoxEntryId.SelectedItem);


            }

            conn.Open();
            sql = @"select entry_text from journal_entry where user_id = :_user_id and entry_id = :_reading_id";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("_user_id", user_id);
            cmd.Parameters.AddWithValue("_reading_id", readingId);
            NpgsqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                readingText = da.GetString(0);
            }
            conn.Close();
            new Reading(user_id, readingText).Show();
        }

        int entryId = 0;
        private void listBoxEntryId_MouseClick(object sender, MouseEventArgs e)
        {
            if (listBoxEntryId.SelectedItem != null)
            {

                entryId = Convert.ToInt32(listBoxEntryId.SelectedItem);

            }
        }

        private void btnDeleteEntry_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"DELETE from journal_entry where user_id = :_user_id and entry_id = :_entry_id";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_user_id", user_id);
                cmd.Parameters.AddWithValue("_entry_id", entryId);
                cmd.ExecuteScalar();
            }
            finally
            {
                MessageBox.Show("Entry Deleted! ", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
        }

       
    }
}
