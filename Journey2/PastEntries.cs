using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JournalApp2
{
    public partial class PastEntries : Form
    {
        int user_id;
        public PastEntries(int id)
        {
            user_id = id;
            InitializeComponent();
        }

        private void PastEntries_Load(object sender, EventArgs e)
        {

        }

        private void BtnHomePE_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home(user_id).Show();
        }
    }
}
