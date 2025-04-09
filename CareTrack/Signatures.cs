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
    public partial class Signatures : Form
    {

        private bool isMenuExpanded = false;

        private string currentUser;
        private int caregiverId;
        private int careplanId;
        private List<int> taskIds;
        private List<string> taskDescriptions;

        public Signatures(int caregiverId, int careplanId, List<int> taskIds, List<string> taskDescriptions)
        {
            InitializeComponent();

            this.caregiverId = caregiverId;
            this.careplanId = careplanId;
            this.taskIds = taskIds;
            this.taskDescriptions = taskDescriptions;

            btnNotes.Enabled = false;
            CollapseMenu();

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
                MessageBox.Show("Please complete the assigned tasks before accessing the Notes and Signatures page.", "Access Denied");
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
