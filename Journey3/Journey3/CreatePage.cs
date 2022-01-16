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
    public partial class CreatePage : Form
    {
        public CreatePage()
        {
            InitializeComponent();
        }
        private NpgsqlConnection conn;
        string connstring = String.Format("Server={0};Port={1};" + "User Id={2};Password={3};Database={4};", "localhost", "5432", "postgres", "salamence1", "postgres");
        private NpgsqlCommand cmd;
        private string sql = null;



        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"select * from create_user(:_username, :_password , :_email)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_username", txtUsername.Text);
                cmd.Parameters.AddWithValue("_password", txtPassword.Text);
                cmd.Parameters.AddWithValue("_email", txtEmail.Text);

                int result = (int)cmd.ExecuteScalar();
                conn.Close();
                if (result == 1)
                {
                    MessageBox.Show("Account Successfully Created ", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(result == 0)
                {
                    MessageBox.Show("Email already exists!" + now , "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }
        string now = (string)DateTime.Today.ToString("yyyy-MM-dd");
        private void CreatePage_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginPage().Show();
        }

    }
    }
