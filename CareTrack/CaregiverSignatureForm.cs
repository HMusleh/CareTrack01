using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace CareTrack
{
    public partial class CaregiverSignatureForm : Form
    {
        public CaregiverSignatureForm()
        {
            InitializeComponent();
        }

        private bool isDrawing = false;
        private List<List<Point>> strokes = [];
        private List<Point>? currentStroke = null;

        //added
        public byte[]? SignatureData { get; private set; }
        public string SignatureType => radioDraw.Checked ? "Drawn" : "Typed";

        public string TypedSignatureText => txtTypedSignature.Text.Trim();

        private void btnSaveSignature_Click(object sender, EventArgs e)
        {
            bool isDrawSelected = radioDraw.Checked;
            bool isTypeSelected = radioType.Checked;
            byte[]? signatureData = null;

            if (isDrawSelected)
            {
                if (strokes.Count == 0 || strokes.All(s => s.Count < 2))
                {
                    PopWarning warningPopup = new("Please sign here before saving.");
                    warningPopup.ShowDialog();
                    return;
                }

                Bitmap signatureBitmap = GetSignatureBitmap();
                signatureData = ImageToByteArray(signatureBitmap);
            }
            else if (isTypeSelected)
            {
                if (string.IsNullOrWhiteSpace(txtTypedSignature.Text))
                {
                    PopWarning warningPopup = new("Please sign here before saving.");
                    warningPopup.ShowDialog();
                    return;
                }

                signatureData = ConvertTypedSignatureToImage(txtTypedSignature.Text);
            }

            SignatureData = signatureData;

            PopSuccessForm successPopup = new("Signature saved successfully!");
            DialogResult result = successPopup.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            strokes.Clear();
            txtTypedSignature.Text = string.Empty;
            signaturePanel.Invalidate();
        }

        private void radioDraw_CheckedChanged(object sender, EventArgs e)
        {
            if (radioDraw.Checked)
            {
                signaturePanel.Visible = true;
                txtTypedSignature.Visible = false;
            }
        }

        private void radioType_CheckedChanged(object sender, EventArgs e)
        {
            if (radioType.Checked)
            {
                signaturePanel.Visible = false;
                txtTypedSignature.Visible = true;
            }
        }

        private void signaturePanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (radioDraw.Checked)
            {
                isDrawing = true;
                currentStroke = [e.Location];
                strokes.Add(currentStroke);
            }
        }

        private void signaturePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing && currentStroke != null)
            {
                currentStroke.Add(e.Location);
                signaturePanel.Invalidate();
            }
        }

        private void signaturePanel_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
            currentStroke = null;
        }

        private void signaturePanel_Paint(object sender, PaintEventArgs e)
        {
            using Pen pen = new(Color.Black, 2);
            foreach (var stroke in strokes)
            {
                if (stroke.Count > 1)
                {
                    e.Graphics.DrawLines(pen, stroke.ToArray());
                }
            }
        }

        private Bitmap GetSignatureBitmap()
        {
            Bitmap bmp = new(signaturePanel.Width, signaturePanel.Height);
            signaturePanel.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
            return bmp;
        }

        private static byte[] ImageToByteArray(Image image)
        {
            using MemoryStream ms = new();
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();
        }

        private byte[] ConvertTypedSignatureToImage(string text)
        {
            using Bitmap bitmap = new(signaturePanel.Width, signaturePanel.Height);
            using Graphics g = Graphics.FromImage(bitmap);
            using Font font = new("Times New Roman", 24, FontStyle.Italic | FontStyle.Underline);
            using SolidBrush brush = new(Color.Black);
            using MemoryStream ms = new();
            g.Clear(Color.White);
            SizeF textSize = g.MeasureString(text, font);
            PointF location = new((bitmap.Width - textSize.Width) / 2, (bitmap.Height - textSize.Height) / 2);
            g.DrawString(text, font, brush, location);
            bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();
        }

        //again removed what wasn't neccessary anymore because of signatures page but just dashed them out
        //so you could view if you wanted to.
        //private void SaveSignatureToDatabase(byte[]? caregiverSignature)
       // {
        //    //simplified connection string
        //    DatabaseHelper db = new DatabaseHelper();

            //added more columns since combined tables
       //     int clientId = 1;
       //     int caregiverId = 1;
       //     int shiftId = GetOrCreateShiftId(db, clientId, caregiverId);
        //    string tasksPerformed = GetTasksFromCarePlan(db, clientId);
        //    string notes = 
        //    DateTime signedDate = DateTime.Now;
         //   String SignatureType = radioDraw.Checked ? "Drawn" : "Typed";
         //   String signedBy = "Caregiver Name"; 
         //   String? typedSignatureText = radioType.Checked ? txtTypedSignature.Text.Trim() : null;



        //    using (SqlConnection connection = db.O
          //  {
          //      connection.Open();

          //      string query = "INSERT INTO Signatures (ClientID, CaregiverID, ShiftID, CaregiverSignature, SignatureTime) " +
           //                    "VALUES (@ClientID, @CaregiverID, @ShiftID, @CaregiverSignature, GETDATE())";
        //
            //    using (SqlCommand command = new SqlCommand(query, connection))
            //    {
             //       command.Parameters.AddWithValue("@ClientID", clientId);
             //       command.Parameters.AddWithValue("@CaregiverID", caregiverId);
             ///       command.Parameters.AddWithValue("@ShiftID", shiftId);
             //       command.Parameters.AddWithValue("@CaregiverSignature", (object?)caregiverSignature ?? DBNull.Value);
             //
             //       command.ExecuteNonQuery();
              //  }
            //}
       // }

        // private int GetOrCreateShiftId(string connectionString, int clientId, int caregiverId)
        //  {
        //    using (SqlConnection conn = new SqlConnection(connectionString))
        //   {
        //         conn.Open();

        //      string checkQuery = "SELECT ShiftID FROM Shifts_Assignment WHERE ClientID = @ClientID AND CaregiverID = @CaregiverID";
        //      using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
        //      {
        //        checkCmd.Parameters.AddWithValue("@ClientID", clientId);
        //       checkCmd.Parameters.AddWithValue("@CaregiverID", caregiverId);

        //       object result = checkCmd.ExecuteScalar();
        //      if (result != null && int.TryParse(result.ToString(), out int existingShiftId))
        //     {
        //         return existingShiftId;
        //     }
       //  }

       // string insertQuery = "INSERT INTO Shifts_Assignment (ClientID, CaregiverID, shift_date, status) " +
       //                     "OUTPUT INSERTED.ShiftID " +
       //                     "VALUES (@ClientID, @CaregiverID, @Date, @Status)";

       // using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
       // {
       //       insertCmd.Parameters.AddWithValue("@ClientID", clientId);
       //       insertCmd.Parameters.AddWithValue("@CaregiverID", caregiverId);
       //     insertCmd.Parameters.AddWithValue("@Date", DateTime.Today);
       //    insertCmd.Parameters.AddWithValue("@Status", "Scheduled");

       //     return (int)insertCmd.ExecuteScalar();
       //   }
       //   }
       // }
    }
}