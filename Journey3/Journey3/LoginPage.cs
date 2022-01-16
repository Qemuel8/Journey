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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        private NpgsqlConnection conn;
        string connstring = String.Format("Server={0};Port={1};" + "User Id={2};Password={3};Database={4};", "localhost", "5432", "postgres", "salamence1", "postgres");
        private NpgsqlCommand cmd;
        private string sql = null;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //new Home(txtEmail.Text).Show();


            try
            {
                conn.Open();
                sql = @"select * from user_login(:_email,:_password)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_email", txtEmail.Text);
                cmd.Parameters.AddWithValue("_password", txtPassword.Text);
                int result = (int)cmd.ExecuteScalar();
                conn.Close();

                if(result > 1)//login
                {
                    this.Hide();
                    new Home(result).Show();
                }
                else
                {
                    MessageBox.Show("Please check your username or password", "Login Fail", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    return;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "Something went wrong", MessageBoxButtons.OK,MessageBoxIcon.Error);
                conn.Close();
            }
        }
          private void btnCreate_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelEmail_Click(object sender, EventArgs e)
        {

        }
        private void labelPassword_Click(object sender, EventArgs e)
        {

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCreate_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new CreatePage().Show();


        }
    }
}
