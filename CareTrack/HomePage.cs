using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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

        //menu state flag
        private bool isMenuExpanded = false;
        public HomePage(string username, int id)
        {
            InitializeComponent();

            //initializing components for username and id
            currentUser = username;
            caregiverId = id;

            //collapse menu
            CollapseMenu();
            btnHome.Enabled = false;
            btnNotes.Enabled = false;
        }

        //main action buttons
        //btnviewtimekeeping
        private void btnClockInOut_Click(object sender, EventArgs e)
        {
            Timekeeping tk = new(currentUser, caregiverId);
            tk.Show();
            this.Hide();
        }
        //btn view tasks
        private void btnViewTasks_Click(object sender, EventArgs e)
        {
            Tasks task = new(caregiverId);
            task.Show();
            this.Hide();
        }
        //btn view schedule 
        private void btnViewSchedule_Click(object sender, EventArgs e)
        {
            ShiftManagerForm schedule = new(currentUser, caregiverId);
            schedule.Show();
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Help helpForm = new();
            helpForm.ShowDialog();
        }


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
        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help helpForm = new(currentUser, caregiverId);
            helpForm.ShowDialog();
        }
        

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            ShiftManagerForm scheduleForm = new(currentUser, caregiverId);
            scheduleForm.Show();
            this.Hide();
        }

        

    }
}
