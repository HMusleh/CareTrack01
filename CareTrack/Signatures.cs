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
using Azure.Identity;

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

        public string Username { get; private set; }

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

            HomePage home = new(Username, caregiverId);
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
            Timekeeping timekeeping = new(Username, caregiverId);
            timekeeping.Show();
            this.Hide();
        }
        private void BtnHelp_Click(object sender, EventArgs e)
        {
            Help helpForm = new(Username, caregiverId);
            helpForm.ShowDialog();
        }

        private void BtnSchedule_Click(object sender, EventArgs e)
        {
            ShiftManagerForm scheduleForm = new(Username, caregiverId);
            scheduleForm.Show();
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
            Signatures s = new                (AppState.caregiverId,
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

        private void Button1_Click(object sender, EventArgs e)
        {
            Timekeeping timekeeping = new(Username, caregiverId);
            timekeeping.Show();
            this.Hide();
        }



        //client signature
        private void BtnClientSign_Click(object sender, EventArgs e)
        {
            using ClientsSignatureForm clientSignature = new();
            if (clientSignature.ShowDialog() == DialogResult.OK)
            {
                clientSignatureData = clientSignature.SignatureData;
            }
        }


        //caregiver signature
        private void BtnCaregiverSign_Click_1(object sender, EventArgs e)
        {
            using CaregiverSignatureForm caregiverSignature = new();
            if (caregiverSignature.ShowDialog() == DialogResult.OK)
            {
                caregiverSignatureData = caregiverSignature.SignatureData;
                caregiverSignatureType = caregiverSignature.SignatureType;
                caregiverTypedText = caregiverSignature.TypedSignatureText;
            }
        }

        //submit button
        private void BtnSubmit_Click(object? sender, EventArgs e)
        {
            if (clientSignatureData == null)
            {
                PopErrorForm errorPopup = new("Client signature is missing");
                errorPopup.ShowDialog();
                return;
            }
            if (caregiverSignatureData == null)
            {
                PopErrorForm errorPopup = new("Caregiver signature is missing.");
                errorPopup.ShowDialog();
                return;
            }
            notes = richTextBox1.Text.Trim();

            if (AppState.clientId <= 0)
            {
                PopErrorForm errorPopup = new("Client ID is missing or invalid. Please ensure a valid shift exists.");
                if (errorPopup.ShowDialog() == DialogResult.OK)
                {
                    Timekeeping clockOut = new(Username, caregiverId);
                    clockOut.Show();
                    this.Close();
                }
                return;
            }

            //set shiftId
            DatabaseHelper db = new();
            shiftId = GetOrCreateShiftId(db, AppState.clientId, caregiverId);

            if (shiftId <= 0)
            {
                using (PopErrorForm errorPopup = new("Unable to determine shift. Please check client and caregiver assignment."))
                {
                    if (errorPopup.ShowDialog() == DialogResult.OK)
                    {
                        // After user clicks OK, move to Clock Out
                        Timekeeping clockOut = new(Username, caregiverId);
                        clockOut.Show();
                        this.Close();
                    }
                }
                return;
            }


            SaveToDatabase();
            using (PopSuccessForm successPopup = new("Service log has been submitted!"))
            {
                if (successPopup.ShowDialog() == DialogResult.OK)
                {
                    Timekeeping clockOut = new(Username, caregiverId);
                    clockOut.Show();
                    this.Close();
                }
            }

        }

        //method for GetOrCreateShiftId
        private static int GetOrCreateShiftId(DatabaseHelper db, int clientId, int caregiverId)
        {
            using SqlConnection conn = db.OpenConnection();
            // Try to find existing ShiftID
            string selectQuery = @"SELECT ShiftID FROM Shifts_Assignment 
                               WHERE ClientID = @ClientID AND CaregiverID = @CaregiverID 
                               AND shift_date = CAST(GETDATE() AS DATE)";
            using (SqlCommand cmd = new(selectQuery, conn))
            {
                cmd.Parameters.AddWithValue("@ClientID", clientId);
                cmd.Parameters.AddWithValue("@CaregiverID", caregiverId);

                object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int existingId))
                {
                    return existingId;
                }
            }

            // Insert new Shift if not found
            string insertQuery = @"INSERT INTO Shifts_Assignment (ClientID, CaregiverID, shift_date, status) 
                               OUTPUT INSERTED.ShiftID 
                               VALUES (@ClientID, @CaregiverID, GETDATE(), 'Scheduled')";
            using SqlCommand insertCmd = new(insertQuery, conn);
            insertCmd.Parameters.AddWithValue("@ClientID", clientId);
            insertCmd.Parameters.AddWithValue("@CaregiverID", caregiverId);

            object insertedId = insertCmd.ExecuteScalar();
            return insertedId != null ? Convert.ToInt32(insertedId) : -1;
        }


        //method to save to database
        private void SaveToDatabase()
        {
            DatabaseHelper db = new();
            DateTime now = DateTime.Now;

            string tasksPerformed = string.Join(Environment.NewLine, taskDescriptions ?? []);


            using SqlConnection conn = db.OpenConnection();
            string SaveToDatabaseQuery = @"INSERT INTO Service_Logs (
                                             CaregiverID, ClientID, ShiftID, date_time, tasks_performed, notes,
                                             caregiver_signature, client_signature, SignedBy, SignatureType,
                                             TypedSignatureText, SignedDate
                                             ) VALUES (
                                             @CaregiverID, @ClientID, @ShiftID, @DateTime, @TasksPerformed, @Notes,
                                             @caregiver_signature, @client_signature, @SignedBy, @SignatureType,
                                             @TypedSignatureText, @SignedDate
                                             )";

            using SqlCommand cmd = new(SaveToDatabaseQuery, conn);
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
                
            }
            catch (Exception ex)
            {
                PopErrorForm errorPopup = new("Insert failed: " + ex.Message);
                errorPopup.ShowDialog();
            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Help helpForm = new();
            helpForm.ShowDialog();
        }
    }
}


        

