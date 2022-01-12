using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JournalApp2
{
    public partial class ReadingList : Form
    {
        int user_id;
        public ReadingList(int id)
        {
            user_id = id;
            InitializeComponent();
        }

        private void ReadingList_Load(object sender, EventArgs e)
        {

        }

        private void btnHomeReading_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home(user_id).Show();
        }
    }
}
