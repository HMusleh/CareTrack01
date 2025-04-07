using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CareTrack
{
    public partial class HomePage : Form
    {
        //passing username and caregiverId from login to homepage for future use in timekeeping
        private string currentUser;
        private int caregiverId;
        public HomePage(string username, int id)
        {
            InitializeComponent();
            //initializing components for username and id
            currentUser = username;
            caregiverId = id;

            //button 2 click
            button2.Click += button2_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Timekeeping tk = new Timekeeping(currentUser, caregiverId);
            tk.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 schedule = new Form1(currentUser, caregiverId);
            schedule.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
