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

namespace CareTrack
{
    public partial class ShiftManagerForm : Form
    {
        //passing caregiveID and username from Homepage
        private string currentUser;
        private int caregiverId;

        //databasehelper
        private DatabaseHelper dbHelper = new();


        private bool isMenuExpanded = false;
        public ShiftManagerForm(string username, int id)
        {
            InitializeComponent();
            btnSchedule.Enabled = false;
            btnNotes.Enabled = false;
            //dropdown 
            CollapseMenu();

            //current user and caregiverId
            currentUser = username;
            caregiverId = id;

            //where the caregiverId will be used.
            WeeklySchedule();


        }

        //Methods for the drop down menu
        //method for collapseing the menu
        private void CollapseMenu()
        {
            btnHome.Visible = false;
            btnTimeKeeping.Visible = false;
            btnSchedule.Visible = false;
            btnTasks.Visible = false;
            btnNotes.Visible = false;
            btnHelp.Visible = false;
            btnLogOut.Visible = false;

            panelMenu.Height = btnDropDownMenu.Height;

            isMenuExpanded = false;

        }


        //method for expanding the menu
        private void ExpandMenu()
        {
            btnHome.Visible = true;
            btnTimeKeeping.Visible = true;
            btnSchedule.Visible = true;
            btnTasks.Visible = true;
            btnNotes.Visible = true;
            btnHelp.Visible = true;
            btnLogOut.Visible = true;


            panelMenu.Height = 1019;
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
            HomePage home = new(currentUser, caregiverId);
            home.Show();
            this.Hide();
        }
        //tasks button on dropdown menu
        private void btnTasks_Click(object sender, EventArgs e)
        {
            Tasks task = new(caregiverId);
            task.Show();
            this.Hide();
        }

        private void btnTimeKeeping_Click(object sender, EventArgs e)
        {
            Timekeeping timekeeping = new(currentUser, caregiverId);
            timekeeping.Show();
            this.Hide();
        }

        private void btnNotes_Click(object sender, EventArgs e)
        {
            if (!AppState.TasksCompleted)
            {
                PopErrorForm errorPopup = new("Please complete the assigned tasks before accessing the Notes and Signatures page.");
                errorPopup.ShowDialog();
                return;
            }
            Signatures s = new                
                (AppState.caregiverId,
                AppState.careplanId,
                AppState.completedTaskId,
                AppState.completedDescriptions);
            s.Show();
            this.Hide();
        }
        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help helpForm = new(currentUser, caregiverId);
            helpForm.ShowDialog();
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
            Login login = new();
            login.Show();

            //close
            this.Close();


        }


        private void WeeklySchedule()
        {


            //each day to the label
            Dictionary<DayOfWeek, Label> dayLabels = new()
            {
            {DayOfWeek.Monday, labelMonday},
            { DayOfWeek.Tuesday, labelTuesday},
            { DayOfWeek.Wednesday, labelWednesday},
            { DayOfWeek.Thursday, labelThursday},
            { DayOfWeek.Friday, labelFriday},
            { DayOfWeek.Saturday, labelSaturday},
            { DayOfWeek.Sunday, labelSunday}
            };

            HashSet<DayOfWeek> scheduledDays = [];

            foreach (var label in dayLabels.Values)
            {
                label.Text = "";
            }
            //query to get schedule
            string query = @"SELECT sa.shift_date, sa.start_time, sa.end_time, sa.status, c.name AS ClientName FROM dbo.Shifts_Assignment sa 
                            INNER JOIN dbo.Clients c ON sa.ClientID = c.ClientID WHERE 
                            sa.CaregiverID = @caregiverId AND sa.shift_date >= CAST
                            (GETDATE() AS DATE) AND sa.shift_date < DATEADD(DAY, 7, CAST(GETDATE() AS DATE)) ORDER BY sa.Shift_date, sa.start_time;";
            //database connection

            try
            {
                using SqlConnection conn = dbHelper.OpenConnection();
                SqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@caregiverId", caregiverId);

                SqlDataReader dataReader = cmd.ExecuteReader();

                bool found = false;

                while (dataReader.Read())
                {
                    found = true;
                    DateTime shiftDate = dataReader.GetDateTime(0);
                    TimeSpan start = dataReader.GetTimeSpan(1);
                    TimeSpan end = dataReader.GetTimeSpan(2);
                    string status = dataReader.GetString(3);
                    string ClientName = dataReader.IsDBNull(4) ? "Unknown Client" : dataReader.GetString(4);



                    string shiftInfo = $"{shiftDate:dddd, MMM dd} {start:hh\\:mm} - {end:hh\\:mm}\n" + $"Client: {ClientName}\n" + $"Status: {status}";

                    if (dayLabels.TryGetValue(shiftDate.DayOfWeek, out var label) && label != null)
                    {
                        if (!string.IsNullOrWhiteSpace(label.Text))
                            label.Text += "\n\n";
                        label.Text += shiftInfo;
                    }
                    scheduledDays.Add(shiftDate.DayOfWeek);
                }
                dataReader.Close();

                foreach (var entry in dayLabels)
                {
                    if (!scheduledDays.Contains(entry.Key))
                    {
                        entry.Value.Text = " Not Scheduled";
                        entry.Value.ForeColor = Color.Gray;
                    }
                }

                if (!found)
                {
                    PopErrorForm errorPopup = new("No shifts found for this week.");
                    errorPopup.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                PopErrorForm errorPopup = new("Error Loading Scheduel: " + ex.Message);
                errorPopup.ShowDialog();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Help helpForm = new();
            helpForm.ShowDialog();
        }
    }
}

