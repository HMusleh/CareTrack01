using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace CareTrack
{
    public partial class ClientsSignatureForm : Form
    {
        public ClientsSignatureForm()
        {
            InitializeComponent();
        }

        private bool isDrawing = false;
        private List<List<Point>> strokes = new List<List<Point>>();
        private List<Point>? currentStroke = null;

        //added
        public byte[]? SignatureData { get; private set; }

        private void btnSaveSignature_Click(object sender, EventArgs e)
        {
            bool isDrawSelected = radioDraw.Checked;
            bool isTypeSelected = radioType.Checked;

            byte[]? signatureData = null;

            if (isDrawSelected)
            {
                if (strokes.Count == 0 || strokes.All(s => s.Count < 2))
                {
                    MessageBox.Show("Please sign here before saving.", "Missing Signature", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Bitmap signatureBitmap = GetSignatureBitmap();
                signatureData = ImageToByteArray(signatureBitmap);
            }
            else if (isTypeSelected)
            {
                if (string.IsNullOrWhiteSpace(txtTypedSignature.Text))
                {
                    MessageBox.Show("Please sign here before saving.", "Missing Signature", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                signatureData = ConvertTypedSignatureToImage(txtTypedSignature.Text);
            }

            //changed this section
            SignatureData = signatureData;

            MessageBox.Show("Signature saved successfully!");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            strokes.Clear();
            txtTypedSignature.Text = string.Empty;
            signaturePanel.Invalidate();
        }

        private void radioDraw_CheckedChanged(object sender, EventArgs e)
        {
            signaturePanel.Visible = radioDraw.Checked;
            txtTypedSignature.Visible = !radioDraw.Checked;
        }

        private void radioType_CheckedChanged(object sender, EventArgs e)
        {
            signaturePanel.Visible = !radioType.Checked;
            txtTypedSignature.Visible = radioType.Checked;
        }

        private void signaturePanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (radioDraw.Checked)
            {
                isDrawing = true;
                currentStroke = new List<Point> { e.Location };
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
            using (Pen pen = new Pen(Color.Black, 2))
            {
                foreach (var stroke in strokes)
                {
                    if (stroke.Count > 1)
                    {
                        e.Graphics.DrawLines(pen, stroke.ToArray());
                    }
                }
            }
        }

        private Bitmap GetSignatureBitmap()
        {
            Bitmap bmp = new Bitmap(signaturePanel.Width, signaturePanel.Height);
            signaturePanel.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
            return bmp;
        }

        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private byte[] ConvertTypedSignatureToImage(string text)
        {
            using (Bitmap bitmap = new Bitmap(signaturePanel.Width, signaturePanel.Height))
            using (Graphics g = Graphics.FromImage(bitmap))
            using (Font font = new Font("Times New Roman", 24, FontStyle.Italic | FontStyle.Underline))
            using (SolidBrush brush = new SolidBrush(Color.Black))
            using (MemoryStream ms = new MemoryStream())
            {
                g.Clear(Color.White);
                SizeF textSize = g.MeasureString(text, font);
                PointF location = new PointF((bitmap.Width - textSize.Width) / 2, (bitmap.Height - textSize.Height) / 2);
                g.DrawString(text, font, brush, location);
                bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }


     //Since signature page is taking care of the database portion these two are removed. I dashed them out 
     //just in case you would still like to see what they were previously and commented what I changed.
       // private void SaveSignatureToDatabase(byte[]? signatureData)
        //{
         //   string connectionString = "Data Source=JAYLIN\\SQLEXPRESS;Initial Catalog=CareTrack Database;Integrated Security=True;TrustServerCertificate=True";
        //    int clientId = 1;
        //    int caregiverId = 1;
       //     int shiftId = GetOrCreateShiftId(connectionString, clientId, caregiverId);

       //     using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
         //       connection.Open();
          //      string query = "INSERT INTO Signatures (ClientID, CaregiverID, ShiftID, ClientSignature, SignatureTime) " +
          //                     "VALUES (@ClientID, @CaregiverID, @ShiftID, @ClientSignature, GETDATE())";

           //     using (SqlCommand command = new SqlCommand(query, connection))
           //     {
            //        command.Parameters.AddWithValue("@ClientID", clientId);
            //        command.Parameters.AddWithValue("@CaregiverID", caregiverId);
             //       command.Parameters.AddWithValue("@ShiftID", shiftId);
             //       command.Parameters.AddWithValue("@ClientSignature", signatureData);
             //       command.ExecuteNonQuery();
             //   }
           // }
       // }



        //private int GetOrCreateShiftId(string connectionString, int clientId, int caregiverId)
        //{
          //  using (SqlConnection conn = new SqlConnection(connectionString))
            //{
              //  conn.Open();

                //string checkQuery = "SELECT ShiftID FROM Shifts_Assignment WHERE ClientID = @ClientID AND CaregiverID = @CaregiverID";
                //using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                //{
                  //  checkCmd.Parameters.AddWithValue("@ClientID", clientId);
                    //checkCmd.Parameters.AddWithValue("@CaregiverID", caregiverId);

                    //object result = checkCmd.ExecuteScalar();
                    //if (result != null && int.TryParse(result.ToString(), out int existingShiftId))
                    //{
                      //  return existingShiftId;
                    //}
                //}

                //string insertQuery = "INSERT INTO Shifts_Assignment (ClientID, CaregiverID, shift_date, status) " +
                  //                   "OUTPUT INSERTED.ShiftID VALUES (@ClientID, @CaregiverID, @Date, @Status)";

                //using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                //{
                  //  insertCmd.Parameters.AddWithValue("@ClientID", clientId);
                    //insertCmd.Parameters.AddWithValue("@CaregiverID", caregiverId);
                    //insertCmd.Parameters.AddWithValue("@Date", DateTime.Today);
                    //insertCmd.Parameters.AddWithValue("@Status", "Scheduled");

                    //return (int)insertCmd.ExecuteScalar();
                //}
            //}
       // }
    }
}