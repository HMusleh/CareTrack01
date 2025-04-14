using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;


namespace CareTrack
{
    public partial class Form1 : Form
    {
        private string connectionString = "Server=HALIMEH\\SQLEXPRESS01;Database=CareTrack Database;Trusted_Connection=True;TrustServerCertificate=True;";


        public Form1()
        {
            InitializeComponent();
        }

        private void btnTestRead_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT TOP 1 * FROM Signatures";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string id = reader["SignatureId"].ToString() ?? "";
                        MessageBox.Show("Signature found. ID: " + id, "Success");
                    }
                    else
                    {
                        MessageBox.Show("No data found in the Signatures table.", "Info");
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error");
            }
        }
    }
}
