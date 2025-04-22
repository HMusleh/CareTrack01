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
    public partial class Tasks : Form
    {
        private string currentUser;
        private int caregiverId;
        private int caregiverplanId;
        private int careplanId;
        private DatabaseHelper db = new DatabaseHelper();
        private List<CheckBox> tasksCheckBoxes = new List<CheckBox>();


        private bool isMenuExpanded = false;


        public Tasks(int caregiverId)
        {
            InitializeComponent();
            btnTasks.Enabled = false;
            //dropdown 
            CollapseMenu();

            this.caregiverId = caregiverId;


            careplanId = GetCarePlanId(caregiverId);
            if (caregiverId != -1)
            {
                LoadTasks(careplanId);
            }
            else
            {
                PopWarning warningPopup = new PopWarning("No care plan for today.");
                warningPopup.ShowDialog();
                button1.Enabled = false;
            }
            button1.Click += button1_Click;
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



        //method for GetCarePlanId

        private int GetCarePlanId(int caregiverId)
        {
            string query = @"SELECT cp.PlanID, cp.ClientID FROM Shifts_Assignment sa INNER JOIN CarePlans cp ON
                            sa.ClientID = cp.ClientID WHERE sa.CaregiverID = @cid AND sa.shift_date = CAST(GETDATE() AS DATE)";

            using (var conn = db.OpenConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@cid", caregiverId);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        AppState.clientId = Convert.ToInt32(reader["ClientID"]);
                        return Convert.ToInt32(reader["PlanID"]);
                    }
                }
            }
            return -1;
        }

        //method for LoadTasks
        private void LoadTasks(int planId)

        {

            //local list
            List<(int TaskID, string Description)> taskList = new List<(int TaskID, string Description)>();

            //aquire completed tasks first
            HashSet<int> completedTaskId = new HashSet<int>();


            //the query that tells the app to pull the completed tasks from previous sessions
            string completedQuery = @"SELECT TaskID FROM completed_tasks WHERE
                                        CaregiverID = @cid and PlanId = @pid AND Completed = 1";

            using (var conn = db.OpenConnection())
            using (var cmd = new SqlCommand(completedQuery, conn))
            {
                cmd.Parameters.AddWithValue("@cid", caregiverId);
                cmd.Parameters.AddWithValue("@pid", planId);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        completedTaskId.Add(Convert.ToInt32(reader["TaskID"]));
                    }
                }
            }

            //load all tasks query
            string taskQuery = @"SELECT t.TaskID, t.description FROM Care_Plan_Tasks cpt INNER JOIN Tasks t
                            ON cpt.TaskID = t.TaskID WHERE cpt.CareplanID = @careplanId";

            using (var conn = db.OpenConnection())
            using (var cmd = new SqlCommand(taskQuery, conn))
            {
                cmd.Parameters.AddWithValue("@careplanId", planId);
                using (var planIdreader = cmd.ExecuteReader())
                {
                    int y = 150;
                    while (planIdreader.Read())
                    {
                        {
                            int taskId = Convert.ToInt32(planIdreader["TaskID"]);

                            string description = planIdreader["description"].ToString();
                            taskList.Add((taskId, description));



                        }
                    }
                }

                //clearing the table format
                TableTasks.Controls.Clear();
                TableTasks.RowStyles.Clear();
                TableTasks.ColumnStyles.Clear();

                TableTasks.ColumnCount = 1;
                TableTasks.RowCount = taskList.Count;

                TableTasks.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));

                //checkbox time

                int rowIndex = 0;
                foreach (var task in taskList)
                {
                    CheckBox cb = new CheckBox();
                    cb.Text = task.Description;
                    cb.Tag = task.TaskID;
                    cb.Checked = completedTaskId.Contains(task.TaskID);
                    cb.Font = new Font("Century Gothic", 14);
                    cb.AutoSize = true;
                    cb.Margin = new Padding(10, 5, 10, 5);

                    TableTasks.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    TableTasks.Controls.Add(cb, 0, rowIndex++);
                    tasksCheckBoxes.Add(cb);

                }

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            List<int> completedTaskIds = new List<int>();
            List<string> completedDescriptions = new List<string>();


            //to make sure that all check boxes are clicked
            bool allCompleted = tasksCheckBoxes.All(cb => cb.Checked);

            foreach (CheckBox cb in tasksCheckBoxes)
            {
                int taskId = (int)cb.Tag;
                bool isChecked = cb.Checked;

                if (isChecked)
                {
                    completedTaskIds.Add(taskId);
                    completedDescriptions.Add(cb.Text);
                }
                //query to make it work

                string query = @" MERGE completed_tasks AS target USING
                                (SELECT @CID AS CaregiverID, @pid AS PlanID, @tid AS TaskID) AS source ON target.CaregiverID = source.CaregiverID AND target.PlanID
                                    = source.PlanID AND target.TaskID = source.TaskID WHEN MATCHED THEN 
                                    UPDATE SET Completed = @completed, CompletionTime = GETDATE()
                                    WHEN NOT MATCHED THEN 
                                    INSERT (CaregiverID, PlanID, TaskID, Completed, CompletionTime)
                                    VALUES (@cid, @pid, @tid, @completed, GETDATE());";

                using (SqlCommand cmd = new SqlCommand(query, db.OpenConnection()))
                {
                    cmd.Parameters.AddWithValue("@cid", caregiverId);
                    cmd.Parameters.AddWithValue("@pid", careplanId);
                    cmd.Parameters.AddWithValue("@tid", taskId);
                    cmd.Parameters.AddWithValue("@completed", isChecked);
                    cmd.ExecuteNonQuery();
                }
            }

            if (allCompleted)
            {
                Signatures signature = new Signatures(caregiverId, careplanId, completedTaskIds, completedDescriptions);
                signature.Show();
                this.Hide();
            }
            else
            {
                PopWarning warningPopup = new PopWarning("Progress has been saved. Must complete all tasks to continue to notes and signature page.");
                warningPopup.ShowDialog();
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Tasks_Load(object sender, EventArgs e)
        {

        }
    }
}
