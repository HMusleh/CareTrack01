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
    public partial class Form1 : Form
    {
        //passing caregiveID and username from Homepage
        private string currentUser;
        private int caregiverId;

        //databasehelper
        private DatabaseHelper dbHelper = new DatabaseHelper();

        public Form1(string username, int id)
        {
            InitializeComponent();

            //current user and caregiverId
            currentUser = username;
            caregiverId = id;

            //where the caregiverId will be used.
            WeeklySchedule();

        }
        private void WeeklySchedule()
        {


            //each day to the label
            Dictionary<DayOfWeek, Label> dayLabels = new Dictionary<DayOfWeek, Label>
            {
            {DayOfWeek.Monday, labelMonday},
            { DayOfWeek.Tuesday, labelTuesday},
            { DayOfWeek.Wednesday, labelWednesday},
            { DayOfWeek.Thursday, labelThursday},
            { DayOfWeek.Friday, labelFriday},
            { DayOfWeek.Saturday, labelSaturday},
            { DayOfWeek.Sunday, labelSunday}
            };

            HashSet<DayOfWeek> scheduledDays = new HashSet<DayOfWeek>();

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
                using (SqlConnection conn = dbHelper.OpenConnection())
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
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
                        string ClientName = dataReader.GetString(4);


                        string shiftInfo = $"{shiftDate:dddd, MMM dd} {start:hh\\:mm} - {end:hh\\:mm}\n" + $"Client: {ClientName}\n" + $"Status: {status}";

                        if (dayLabels.TryGetValue(shiftDate.DayOfWeek, out Label label))
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
                        MessageBox.Show("No shifts found for this week.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Loading Scheduel: " + ex.Message);
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void labelMonday_Click(object sender, EventArgs e)
        {

        }

        private void labelTuesday_Click(object sender, EventArgs e)
        {

        }

        private void labelWednesday_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

