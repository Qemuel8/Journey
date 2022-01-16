using JournalApp2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Journey3
{
    public partial class Reading : Form
    {
        int user_id;
        string readingText;


        public Reading(int id, string text)
        {
            readingText = text;
            user_id = id;
            InitializeComponent();
        }

        private void Reading_Load(object sender, EventArgs e)
        {
            txtReading.Text = readingText;
        }

        private void Reading_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            new Home(user_id).Show();
        }

        private void lblReading_Click(object sender, EventArgs e)
        {

        }


        private void txtReading_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
