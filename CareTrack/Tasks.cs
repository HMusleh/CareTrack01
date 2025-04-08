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
        private int caregiverId;
        private int caregiverplanId;
        private int careplanId;
        private DatabaseHelper db = new DatabaseHelper();
        private List<CheckBox> tasksCheckBoxes = new List<CheckBox>();

        public Tasks(int caregiverId)
        {
            InitializeComponent();

            this.caregiverId = caregiverId;


            careplanId = GetCarePlanId(caregiverId);
            if (caregiverId != -1)
            {
                LoadTasks(careplanId);
            }
            else
            {
                MessageBox.Show("No care plan for today.");
                button1.Enabled = false;
            }
            button1.Click += button1_Click;
        }


        //method for GetCarePlanId

        private int GetCarePlanId(int caregiverId)
        {
            string query = @"SELECT cp.PlanID FROM Shifts_Assignment sa INNER JOIN CarePlans cp ON
                            sa.ClientID = cp.ClientID WHERE sa.CaregiverID = @cid AND sa.shift_date = CAST(GETDATE() AS DATE)";

            using (var conn = db.OpenConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@cid", caregiverId);
                var result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : -1;
            }
        }

        //method for LoadTasks
        private void LoadTasks(int planId)
        {
            string query = @"SELECT t.TaskID, t.description FROM Care_Plan_Tasks cpt INNER JOIN Tasks t
                            ON cpt.TaskID = t.TaskID WHERE cpt.CareplanID = @careplanId";

            using (var conn = db.OpenConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@careplanId", planId);
                using (var planIdreader = cmd.ExecuteReader())
                {
                    int y = 150;
                    while (planIdreader.Read())
                    {
                        {
                            CheckBox cb = new CheckBox();
                            cb.Text = planIdreader["description"].ToString();
                            cb.Tag = planIdreader["TaskID"];
                            cb.Font = new Font("Century Gothic", 18);
                            cb.AutoSize = true;
                            cb.Location = new Point(700, y);
                            this.Controls.Add(cb);
                            tasksCheckBoxes.Add(cb);
                            y += 60;
                        }
                    }
                }

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            List<int> completedTaskIds = new List<int>();
            List<string> completedDescriptions = new List<string>();

            foreach (CheckBox cb in tasksCheckBoxes)
            {
                if (cb.Checked)
                {
                    completedTaskIds.Add((int)cb.Tag);
                    completedDescriptions.Add(cb.Text);
                }
            }
            if (completedTaskIds.Count > 0)
            {
                Signatures signature = new Signatures(caregiverId, careplanId, completedTaskIds, completedDescriptions);
                signature.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No tasks selected to complete.", "Info");
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
