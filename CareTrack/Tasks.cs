using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Azure.Identity;
using Microsoft.Data.SqlClient;

namespace CareTrack
{
    public partial class Tasks : Form
    {
        private  string? currentUser;
        private int caregiverId;
      
        private int careplanId;
        private DatabaseHelper db = new();
        private List<CheckBox> tasksCheckBoxes = [];


        private bool isMenuExpanded = false;

        public string Username { get; private set; }

        public Tasks(int caregiverId)
        {
            InitializeComponent();
            btnTasks.Enabled = false;

            //dropdown 
            CollapseMenu();
            this.currentUser = Username;
            this.caregiverId = caregiverId;


            careplanId = GetCarePlanId(caregiverId);
            if (caregiverId != -1)
            {
                LoadTasks(careplanId);
            }
            else
            {
                PopWarning warningPopup = new("No care plan for today.");
                warningPopup.ShowDialog();
                button1.Enabled = false;
            }
            
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
            HomePage home = new(Username, caregiverId);
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
        private void btnSchedule_Click(object sender, EventArgs e)
        {
            ShiftManagerForm scheduleForm = new(Username, caregiverId);
            scheduleForm.Show();
            this.Hide();
        }


        private void btnTimeKeeping_Click(object sender, EventArgs e)
        {
            Timekeeping timekeeping = new(Username, caregiverId);
            timekeeping.Show();
            this.Hide();
        }

        
            private void BtnNotes_Click(object sender, EventArgs e)
        {
            List<int> completedTaskIds = [];
            List<string> completedDescriptions = [];

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
            }

            if (allCompleted )
            {
                AppState.TasksCompleted = true;
                AppState.completedTaskId = completedTaskIds;
                AppState.completedDescriptions = completedDescriptions;

                Signatures s = new(caregiverId, careplanId, completedTaskIds, completedDescriptions);
                s.Show();
                this.Hide();
            }
            else
            {
                ReasonPopup reasonPopup = new();
                DialogResult result = reasonPopup.ShowDialog();

                if (result == DialogResult.OK)
                {
                    AppState.TasksCompleted = true;
                    AppState.completedTaskId = completedTaskIds;
                    AppState.completedDescriptions = completedDescriptions;

                    Signatures s = new(caregiverId, careplanId, completedTaskIds, completedDescriptions);
                    s.Show();
                    this.Hide();
                }
            }
        }


        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help helpForm = new(Username, caregiverId);
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



        //method for GetCarePlanId

        private int GetCarePlanId(int caregiverId)
        {
            string query = @"SELECT cp.PlanID, cp.ClientID FROM Shifts_Assignment sa INNER JOIN CarePlans cp ON
                            sa.ClientID = cp.ClientID WHERE sa.CaregiverID = @cid AND sa.shift_date = CAST(GETDATE() AS DATE)";

            using var conn = db.OpenConnection();
            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@cid", caregiverId);
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                AppState.clientId = Convert.ToInt32(reader["ClientID"]);
                return Convert.ToInt32(reader["PlanID"]);
            }
            return -1;
        }

        //method for LoadTasks
        private void LoadTasks(int planId)

        {

            //local list
            List<(int TaskID, string Description)> taskList = [];

            //aquire completed tasks first
            HashSet<int> completedTaskId = [];


            //the query that tells the app to pull the completed tasks from previous sessions
            string completedQuery = @"SELECT TaskID FROM completed_tasks WHERE
                                        CaregiverID = @cid and PlanId = @pid AND Completed = 1";

            using (var conn = db.OpenConnection())
            using (var cmd = new SqlCommand(completedQuery, conn))
            {
                cmd.Parameters.AddWithValue("@cid", caregiverId);
                cmd.Parameters.AddWithValue("@pid", planId);

                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    completedTaskId.Add(Convert.ToInt32(reader["TaskID"]));
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
#pragma warning disable CS8620 // Argument cannot be used for parameter due to differences in the nullability of reference types.
                            taskList.Add((taskId, description));
#pragma warning restore CS8620 // Argument cannot be used for parameter due to differences in the nullability of reference types.



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
                foreach (var (TaskID, Description) in taskList)
                {
                    CheckBox cb = new()
                    {
                        Text = Description,
                        Tag = TaskID,
                        Checked = completedTaskId.Contains(TaskID),
                        Font = new Font("Century Gothic", 14),
                        AutoSize = true,
                        Margin = new Padding(10, 5, 10, 5)
                    };

                    TableTasks.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    TableTasks.Controls.Add(cb, 0, rowIndex++);
                    tasksCheckBoxes.Add(cb);

                }

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            List<int> completedTaskIds = [];
            List<string> completedDescriptions = [];


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

                using SqlCommand cmd = new(query, db.OpenConnection());
                cmd.Parameters.AddWithValue("@cid", caregiverId);
                cmd.Parameters.AddWithValue("@pid", careplanId);
                cmd.Parameters.AddWithValue("@tid", taskId);
                cmd.Parameters.AddWithValue("@completed", isChecked);
                cmd.ExecuteNonQuery();
            }

            if (allCompleted)
            {
                AppState.TasksCompleted = true;
                AppState.completedTaskId = completedTaskIds;
                AppState.completedDescriptions = completedDescriptions;

                Signatures signature = new(caregiverId, careplanId, completedTaskIds, completedDescriptions);
                signature.Show();
                this.Hide();
            }
            else
            {
                ReasonPopup reasonPopup = new();
                DialogResult result = reasonPopup.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string reason = reasonPopup.SelectedReason;

                    // Optional: Log the reason or show it if needed
                    Console.WriteLine("Reason selected: " + reason);

                    AppState.TasksCompleted = true;
                    AppState.completedTaskId = completedTaskIds;
                    AppState.completedDescriptions = completedDescriptions;

                    Signatures signature = new(caregiverId, careplanId, completedTaskIds, completedDescriptions);
                    signature.Show();
                    this.Hide();
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Help helpForm = new();
            helpForm.ShowDialog();
        }
        
    }
}
