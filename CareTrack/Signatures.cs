using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
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
        private List<int>? taskIds;
        private List<string>? taskDescriptions;

        //collecting signatures. 
        private byte[]? clientSignatureData = null;
        private byte[]? caregiverSignatureData = null;
        private string caregiverSignatureType = "";
        private string caregiverTypedText = "";
        private string notes = "";
        private int shiftId;




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
                PopErrorForm errorPopup = new PopErrorForm("Please complete the assigned tasks before accessing the Notes and Signatures page.");
                errorPopup.ShowDialog();
                return;
            }
            Signatures s = new Signatures
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
            Login login = new Login();
            login.Show();

            //close
            this.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Timekeeping timekeeping = new Timekeeping(currentUser, caregiverId);
            timekeeping.Show();
            this.Hide();
        }



        //client signature
        private void btnClientSign_Click(object sender, EventArgs e)
        {
            using (ClientsSignatureForm clientSignature = new ClientsSignatureForm()) 
            {
                if (clientSignature.ShowDialog() == DialogResult.OK)
                {
                    clientSignatureData = clientSignature.SignatureData;
                }
            }
        }


        //caregiver signature
        private void btnCaregiverSign_Click_1(object sender, EventArgs e)
        {
            using (CaregiverSignatureForm caregiverSignature = new CaregiverSignatureForm()) 
            {
                if (caregiverSignature.ShowDialog() == DialogResult.OK)
                {
                    caregiverSignatureData = caregiverSignature.SignatureData;
                    caregiverSignatureType = caregiverSignature.SignatureType;
                    caregiverTypedText = caregiverSignature.TypedSignatureText;
                }
            }
        }

        //submit button
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (clientSignatureData == null)
            { 
                PopErrorForm errorPopup = new PopErrorForm("Client signature is missing");
                errorPopup.ShowDialog();
                return;
            }
            if (caregiverSignatureData == null)
            {
                PopErrorForm errorPopup = new PopErrorForm("Caregiver signature is missing.");
                errorPopup.ShowDialog();
                return;
            }
            notes = richTextBox1.Text.Trim();

            //set shiftId
            DatabaseHelper db = new DatabaseHelper();
            shiftId = GetOrCreateShiftId(db, AppState.clientId, caregiverId);

            SaveToDatabase();
            PopSuccessForm successPopup = new PopSuccessForm("Service log has been submitted!");
            successPopup.ShowDialog();
        }

        //method for GetOrCreateShiftId
        private int GetOrCreateShiftId(DatabaseHelper db, int clientId, int caregiverId)
        {
            using (SqlConnection conn = db.OpenConnection())
            {
                string GetOrCreateShiftIdQuery = "SELECT ShiftID FROM Shifts_Assignment WHERE ClientID = @ClientID AND CaregiverID = @CaregiverID";
                using (SqlCommand GetOrCreateShiftIdCmd = new SqlCommand(GetOrCreateShiftIdQuery, conn))
                {
                    GetOrCreateShiftIdCmd.Parameters.AddWithValue("@ClientID", AppState.clientId);
                    GetOrCreateShiftIdCmd.Parameters.AddWithValue("@CaregiverID", caregiverId);

                    object result = GetOrCreateShiftIdCmd.ExecuteScalar();
                    int existingShiftId;
                    if (result != null && int.TryParse(result.ToString(), out existingShiftId))
                    {
                        return existingShiftId;
                    }
                }
                string insertQuery = @"INSERT INTO Shifts_Assignment(ClientID, CaregiverID, shift_date,status)
                                    OUTPUT INSERTED.ShiftID VALUES (@ClientID, @CaregiverID, @Date, @Status)";

                using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                {
                insertCmd.Parameters.AddWithValue("@ClientID", AppState.clientId);
                insertCmd.Parameters.AddWithValue("@CaregiverID", caregiverId);
                insertCmd.Parameters.AddWithValue("@Date", DateTime.Today);
                insertCmd.Parameters.AddWithValue("@Status", "Scheduled");

                return (int)insertCmd.ExecuteScalar();
                }
        }
    }

        //method to save to database
        private void SaveToDatabase()
        {
            DatabaseHelper db = new DatabaseHelper();
            DateTime now = DateTime.Now;

            string tasksPerformed = string.Join(Environment.NewLine, taskDescriptions ?? new List<string>());


            using (SqlConnection conn = db.OpenConnection())
            {
                string SaveToDatabaseQuery = @"INSERT INTO Service_Logs (
                                             CaregiverID, ClientID, ShiftID, date_time, tasks_performed, notes,
                                             caregiver_signature, client_signature, SignedBy, SignatureType,
                                             TypedSignatureText, SignedDate
                                             ) VALUES (
                                             @CaregiverID, @ClientID, @ShiftID, @DateTime, @TasksPerformed, @Notes,
                                             @caregiver_signature, @client_signature, @SignedBy, @SignatureType,
                                             @TypedSignatureText, @SignedDate
                                             )";

                using (SqlCommand cmd = new SqlCommand(SaveToDatabaseQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@CaregiverID", caregiverId);
                    cmd.Parameters.AddWithValue("@ClientID", AppState.clientId);
                    cmd.Parameters.AddWithValue("@ShiftID", shiftId);
                    cmd.Parameters.AddWithValue("@DateTime", now);
                    cmd.Parameters.AddWithValue("@TasksPerformed", tasksPerformed);
                    cmd.Parameters.AddWithValue("@Notes", string.IsNullOrWhiteSpace(notes) ? "No additional notes." : notes);
                    cmd.Parameters.AddWithValue("@caregiver_signature", caregiverSignatureData);
                    cmd.Parameters.AddWithValue("@client_signature", clientSignatureData);
                    cmd.Parameters.AddWithValue("@SignedBy", "Caregiver");
                    cmd.Parameters.AddWithValue("@SignatureType", caregiverSignatureType);
                    cmd.Parameters.AddWithValue("@TypedSignatureText", (object?)caregiverTypedText ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@SignedDate", now);


                 
                    try
                    {
                        cmd.ExecuteNonQuery();
                        PopSuccessForm successPopup = new PopSuccessForm("Insert successful");
                        successPopup.ShowDialog();
                    }
                    catch (Exception ex) 
                    {
                        PopErrorForm errorPopup = new PopErrorForm("Insert failed: " + ex.Message);
                        errorPopup.ShowDialog();
                    }

                }
            }
        }
    }
}


        

