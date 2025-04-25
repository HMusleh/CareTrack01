using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CareTrack
{
    public partial class Help : Form
    {
        private string currentUser;
        private int caregiverId;
        private bool isAuthenticated = false;
        private bool isMenuExpanded = false;
        public Help()
        {
            InitializeComponent();
            BtnHelp.Enabled = false;
            BtnNotes.Enabled = false;
            CollapseMenu();
            
        }
        public Help(string username, int id)
        {
            InitializeComponent();
            CollapseMenu();
            isAuthenticated = true;
            currentUser = username;
            caregiverId = id;
           

        }
        private void CollapseMenu()
        {
            BtnHome.Visible = false;
            BtnTimeKeeping.Visible = false;
            BtnSchedule.Visible = false;
            BtnTasks.Visible = false;
            BtnNotes.Visible = false;
            BtnHelp.Visible = false;
            BtnLogOut.Visible = false;
            PanelMenu.Height = BtnDropDownMenu.Height;
            isMenuExpanded = false;

        }


        //method for expanding the menu
        private void ExpandMenu()
        {
            
            BtnHome.Visible = true;
            BtnTimeKeeping.Visible = true;
            BtnSchedule.Visible = true;
            BtnTasks.Visible = true;
            BtnNotes.Visible = true;
            BtnHelp.Visible = true;
            BtnLogOut.Visible = true;
            PanelMenu.Height = 888;
            isMenuExpanded = true;
        }
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
        
        
            private void BtnHome_Click(object sender, EventArgs e)
        {
            if (!isAuthenticated)
            {
                PopErrorForm popup = new("Please log in to access this page.");
                popup.ShowDialog();
                return;
            }

            HomePage home = new(currentUser, caregiverId);
            home.Show();
            this.Close();
        }

        
        private void BtnTimeKeeping_Click(object sender, EventArgs e)
        {
            if (!isAuthenticated)
            {
                PopErrorForm popup = new("Please log in to access this page.");
                popup.ShowDialog();
                return;
            }

            Timekeeping timekeeping = new(currentUser, caregiverId);
            timekeeping.Show();
            this.Close();
        }

        private void BtnSchedule_Click(object sender, EventArgs e)
        {
            if (!isAuthenticated)
            {
                PopErrorForm popup = new("Please log in to access this page.");
                popup.ShowDialog();
                return;
            }

            ShiftManagerForm schedule = new(currentUser, caregiverId);
            schedule.Show();
            this.Close();
        }

        private void BtnTasks_Click(object sender, EventArgs e)
        {
            if (!isAuthenticated)
            {
                PopErrorForm popup = new("Please log in to access this page.");
                popup.ShowDialog();
                return;
            }

            Tasks taskForm = new(caregiverId);
            taskForm.Show();
            this.Close();
        }

        private void BtnNotes_Click(object sender, EventArgs e)
        {
            if (!isAuthenticated)
            {
                PopErrorForm popup = new("Please log in to access this page.");
                popup.ShowDialog();
                return;
            }

            if (!AppState.TasksCompleted)
            {
                PopErrorForm errorPopup = new("Please complete all tasks before accessing the Notes and Signatures page.");
                errorPopup.ShowDialog();
                return;
            }

            Signatures signaturePage = new(
                AppState.caregiverId,
                AppState.careplanId,
                AppState.completedTaskId,
                AppState.completedDescriptions);
            signaturePage.Show();
            this.Close();
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            Help helpForm = new(currentUser, caregiverId);
            helpForm.Show();
            this.Close();
        }
        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            AppState.caregiverId = 0;
            AppState.careplanId = 0;
            AppState.TasksCompleted = false;
            AppState.completedTaskId?.Clear();
            AppState.completedDescriptions?.Clear();

            Login login = new();
            login.Show();
            this.Close();
        }
        private void ClockInLink_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://youtu.be/RBpK3BwQtF8") { UseShellExecute = true });
        }

        private void HomeTut_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://youtu.be/bINKcLX8bcE") { UseShellExecute = true });
        }

        private void TimekeepingTut_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://youtu.be/cicMfqwlsCE") { UseShellExecute = true });
        }

        private void ScheduleTut_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://youtu.be/ralKTtwimB4") { UseShellExecute = true });
        }

        private void TasksTut_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://youtu.be/Myi8wJo4NMI") { UseShellExecute = true });
        }

        private void SignatureTut_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://youtu.be/XJSqQvMxQLA") { UseShellExecute = true });
        }
       

        }


    }

