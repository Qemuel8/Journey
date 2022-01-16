using JournalApp2;
using Journey2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JournalApp2
{
    public partial class Home : Form
    {
        int user_id;
        public Home(int id)
        {
            user_id = id;
            InitializeComponent();
        }

        

        private void Home_Load(object sender, EventArgs e)
        {
            lblUser.Text = lblUser.Text + user_id;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnJournal_Click(object sender, EventArgs e)
        {
            this.Hide();
            new WritingPage(user_id).Show();
        }

        private void btnNotes_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Notes(user_id).Show();
        }

        private void btnEntries_Click(object sender, EventArgs e)
        {
           this.Hide();
            new Entries(user_id).Show();
        }

        private void btnToDoList_Click(object sender, EventArgs e)
        {

        }

        private void btnReadingList_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ReadingList(user_id).Show();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
