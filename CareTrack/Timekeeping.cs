using Microsoft.Data.SqlClient;
using Timer = System.Windows.Forms.Timer;


namespace CareTrack
{

    public partial class Timekeeping : Form
    {

        //passing caregiver id and username from homepage to timekeeping
        private string currentUser;
        private int caregiverId;
        private System.Windows.Forms.Timer inactivityTimer;
        private bool isMenuExpanded = false;

        public Timekeeping(string username, int id)
        {
            InitializeComponent();
            btnTimeKeeping.Enabled = false;
            btnNotes.Enabled = false;
            CollapseMenu();

            //initializing the username and id components
            currentUser = username;
            caregiverId = id;
            inactivityTimer = new System.Windows.Forms.Timer
            {
                Interval = 60000
            };
            inactivityTimer.Tick += InactivityTimer_Tick;

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


            panelMenu.Height = 888;
            isMenuExpanded = true;
        }

        //now the buttons 
        //button drop down menu
        private void BtnDropDownMenu_Click(object sender, EventArgs e)
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
        private void BtnHome_Click(object sender, EventArgs e)
        {
            HomePage home = new(currentUser, caregiverId);
            home.Show();
            this.Hide();
        }
        //tasks button on dropdown menu
        private void BtnTasks_Click(object sender, EventArgs e)
        {
            Tasks task = new(caregiverId);
            task.Show();
            this.Hide();
        }

        private void BtnTimeKeeping_Click(object sender, EventArgs e)
        {
            Timekeeping timekeeping = new(currentUser, caregiverId);
            timekeeping.Show();
            this.Hide();
        }

        private void BtnNotes_Click(object sender, EventArgs e)
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

        private void BtnLogOut_Click(object sender, EventArgs e)
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
        //clock in button
        private async void Button1_Click(object sender, EventArgs e)
        {
            //realtime and date
            DateTime now = DateTime.Now;
            string query = "INSERT INTO TimePunches (CaregiverID, clock_in) VALUES (@CaregiverId, @ClockIn)";

            //database connector
            try
            {
                DatabaseHelper db = new();
                using (SqlConnection conn = db.OpenConnection())
                using (SqlCommand cmd = new(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CaregiverId", caregiverId);
                    cmd.Parameters.AddWithValue("@ClockIn", now);
                    cmd.ExecuteNonQuery();
                }
                lblClockInTime.Text = now.ToString("hh:mm tt"); // show actual clock-in time
                SetShiftEndTime(now); // load and show scheduled shift end time
                //message box for successful clocking in with time
                PopSuccessForm successPopup = new($"Clock-In at {now}");
                successPopup.Show();

                await Task.Delay(3000);
                DialogResult toTasks = MessageBox.Show("Do you want to go to the Tasks page?", "Next Step", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (toTasks == DialogResult.Yes)
                {
                    Tasks taskForm = new(caregiverId);
                    taskForm.Show();
                    this.Hide();
                }
                else
                {
                    DialogResult logout = MessageBox.Show("Do you want to logout of the app?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (logout == DialogResult.Yes)
                    {
                        Login login = new();
                        login.Show();
                        this.Close();
                    }
                    else
                    {
                        inactivityTimer.Start();
                    }
                }
            }
            catch (Exception ex)
            {
                PopErrorForm errorPopup = new("Clock-In Failed: " + ex.Message);
                errorPopup.ShowDialog();
            }
        }

        //clock out button
        private void Button2_Click(object sender, EventArgs e)
        {

            //realtime date
            DateTime now = DateTime.Now;
            string query = @"UPDATE TimePunches SET clock_out = @ClockOut WHERE CaregiverID = @CaregiverId AND clock_out IS NULL";

            //db connection
            try
            {
                DatabaseHelper db = new();
                using SqlConnection conn = db.OpenConnection();
                using SqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@CaregiverId", caregiverId);
                cmd.Parameters.AddWithValue("@ClockOut", now);


                int rowsAffected = cmd.ExecuteNonQuery();

                //pop up for clock out
                if (rowsAffected > 0)
                {
                    // Show pop-up with Clock-Out time
                    PopSuccessForm successPopup = new($"Clock-Out at {now}");
                    successPopup.ShowDialog(); // Wait for popup to close

                    // Ask: View Schedule?
                    DialogResult viewSchedule = MessageBox.Show("Do you want to view your schedule?", "View Schedule", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (viewSchedule == DialogResult.Yes)
                    {
                        ShiftManagerForm scheduleForm = new(currentUser, caregiverId);
                        scheduleForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        // Ask: Logout?
                        DialogResult logout = MessageBox.Show("Do you want to logout of the app?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (logout == DialogResult.Yes)
                        {
                            Login loginForm = new();
                            loginForm.Show();
                            this.Close();
                        }
                        else
                        {
                            // Wait 10 seconds, then auto-logout and exit
                            Timer autoLogoutTimer = new()
                            {
                                Interval = 10000 // 10 seconds
                            };
                            autoLogoutTimer.Tick += (s, args) =>
                            {
                                autoLogoutTimer.Stop();
                                Application.Exit();
                            };
                            autoLogoutTimer.Start();
                        }
                    }
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                PopErrorForm errorPopup = new("Clock-Out Failed: " + ex.Message);
            }
        }



        private void BtnSchedule_Click(object sender, EventArgs e)
        {
            ShiftManagerForm scheduleForm = new(currentUser, caregiverId);
            scheduleForm.Show();
            this.Hide();
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            Help helpForm = new(currentUser, caregiverId);
            helpForm.ShowDialog();
        }
        private void SetShiftEndTime(DateTime clockIn)
        {
            string query = @"SELECT end_time FROM Shifts_Assignment 
                     WHERE CaregiverID = @CaregiverId AND shift_date = @ShiftDate";

            try
            {
                DatabaseHelper db = new();
                using SqlConnection conn = db.OpenConnection();
                using SqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@CaregiverId", caregiverId);
                cmd.Parameters.AddWithValue("@ShiftDate", clockIn.Date);

                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    TimeSpan shiftEnd = (TimeSpan)result;
                    lblShiftEndTime.Text = shiftEnd.ToString(@"hh\:mm");
                }
                else
                {
                    lblShiftEndTime.Text = "Not found";
                }
            }
            catch (Exception ex)
            {
                PopErrorForm errorPopup = new("Failed to load shift end time: " + ex.Message);
                errorPopup.ShowDialog();
            }
        }

        private void InactivityTimer_Tick(object? sender, EventArgs e)
        {
            inactivityTimer.Stop(); // Stop the timer
            Application.Exit(); // Exit the app
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Help helpForm = new();
            helpForm.ShowDialog();
        }
    }
}
