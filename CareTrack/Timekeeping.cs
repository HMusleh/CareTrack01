using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Data;
using Azure.Identity;

namespace CareTrack
{
   
    public partial class Timekeeping : Form
    {

        //passing caregiver id and username from homepage to timekeeping
        private string currentUser;
        private int caregiverId;

        
        public Timekeeping(string username, int id)
        {
            InitializeComponent();
            
            //initializing the username and id components
            currentUser = username;
            caregiverId = id;

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        //clock in button
        private void button1_Click(object sender, EventArgs e)
        {
            //realtime and date
            DateTime now = DateTime.Now;
            string query = "INSERT INTO TimePunches (CaregiverID, clock_in) VALUES (@CaregiverId, @ClockIn)";

            //database connector
            try
            {
                DatabaseHelper db = new DatabaseHelper();
                using (SqlConnection conn = db.OpenConnection())
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CaregiverId", caregiverId);
                    cmd.Parameters.AddWithValue("@ClockIn", now);
                    cmd.ExecuteNonQuery();
                }
                //message box for successful clocking in with time
                MessageBox.Show($"Clock-In at {now}", "Successful Clock-In");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Clock-In Failed: ", ex.Message);
            }
        }

        //clock out button
        private void button2_Click(object sender, EventArgs e)
        {
           
            //realtime date
            DateTime now = DateTime.Now;
            string query = @"UPDATE TimePunches SET clock_out = @ClockOut WHERE CaregiverID = @CaregiverId AND clock_out IS NULL";

            //db connection
            try
            {
                DatabaseHelper db = new DatabaseHelper();
                using (SqlConnection conn = db.OpenConnection())
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CaregiverId", caregiverId);
                    cmd.Parameters.AddWithValue("@ClockOut", now);


                    int rowsAffected = cmd.ExecuteNonQuery();

                    //pop up for clock out
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"Clock-Out at {now}", "Clock-Out Successful");
                    }
                    else
                    {
                        MessageBox.Show("No Clock-In Found to Clock-Out.", "Clock-Out Unsuccessful");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Clock-Out Failed: " + ex.Message);
            }
        }
    }
}
