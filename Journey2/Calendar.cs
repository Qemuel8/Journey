using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JournalApp2
{
    public partial class Calendar : Form
    {
        int user_id;
        public Calendar(int id)
        {
            user_id = id;
            InitializeComponent();
        }

        private void Calendar_Load(object sender, EventArgs e)
        {

        }

        private void btnHome_Calendar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home(user_id).Show();
        }
    }
}
