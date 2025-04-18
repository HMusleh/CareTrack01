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

        private bool isMenuExpanded = false;
        
        public Timekeeping(string username, int id)
        {
            InitializeComponent();
            btnTimeKeeping.Enabled = false;
            CollapseMenu();
            
            //initializing the username and id components
            currentUser = username;
            caregiverId = id;

            
        }

        //Methods for the drop down menu
        //method for collapseing the menu
        private void CollapseMenu()
        {
            btnHome.Visible = false;
            btnTasks.Visible = false;
            btnTimeKeeping.Visible = false;
            btnNotes.Visible = false;
            btnLogOut.Visible = false;

            panelMenu.Height = btnDropDownMenu.Height;

            isMenuExpanded = false;

        }


        //method for expanding the menu
        private void ExpandMenu()
        {
            btnHome.Visible = true;
            btnTasks.Visible = true;
            btnTimeKeeping.Visible = true;
            btnNotes.Visible = true;
            btnLogOut.Visible = true;


            panelMenu.Height = 888;
            isMenuExpanded = true;
        }

        //now the buttons 
        //button drop down menu
        private void btnDropDownMenu_Click(object sender, EventArgs e)
        {
            if (isMenuExpanded)
            {
                CollapseMenu();
            }
            else
            {
                ExpandMenu();
            }
        }

        //homepage button on dropdown menu
        private void btnHome_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage(currentUser, caregiverId);
            home.Show();
            this.Hide();
        }
        //tasks button on dropdown menu
        private void btnTasks_Click(object sender, EventArgs e)
        {
            Tasks task = new Tasks(caregiverId);
            task.Show();
            this.Hide();
        }

        private void btnTimeKeeping_Click(object sender, EventArgs e)
        {
            Timekeeping timekeeping = new Timekeeping(currentUser, caregiverId);
            timekeeping.Show();
            this.Hide();
        }

        private void btnNotes_Click(object sender, EventArgs e)
        {
            if (!AppState.TasksCompleted)
            {
                PopErrorForm errorPopup = new PopErrorForm("Please complete the assigned tasks before accessing the Notes and Signatures page.");
                errorPopup.ShowDialog();
                return;
            }
            Signatures s = new Signatures
                (AppState.caregiverId,
                AppState.careplanId,
                AppState.completedTaskId,
                AppState.completedDescriptions);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            //ends session with a clean slate
            AppState.caregiverId = 0;
            AppState.careplanId = 0;
            AppState.TasksCompleted = false;
            AppState.completedTaskId?.Clear();
            AppState.completedDescriptions?.Clear();

            //back to login page
            Login login = new Login();
            login.Show();

            //close
            this.Close();


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
                PopSuccessForm successPopup = new PopSuccessForm($"Clock-In at {now}");
                successPopup.Show();
            }
            catch (Exception ex)
            {
                PopErrorForm errorPopup = new PopErrorForm("Clock-In Failed: " + ex.Message);
                errorPopup.ShowDialog();
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
                        PopSuccessForm successPopup = new PopSuccessForm($"Clock-Out at {now}");
                        successPopup.ShowDialog();
                    }
                    else
                    {
                        PopErrorForm errorPopup = new PopErrorForm("No Clock-In Found to Clock-Out.");
                        errorPopup.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                PopErrorForm errorPopup = new PopErrorForm("Clock-Out Failed: " + ex.Message);
                errorPopup.ShowDialog();
            }
        }
    }
}
