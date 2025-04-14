using System;
using Microsoft.Data.SqlClient;
using System.Data;

namespace CareTrack
{
    public class DatabaseHelper
    {
        // Retrieve the connection string from Settings
        private string connectionString = "Server=localhost\\SQLEXPRESS01;Database=CareTrackDatabase;Trusted_Connection=True;TrustServerCertificate=True;";


        // Method to open a database connection
        public SqlConnection OpenConnection()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Console.WriteLine("Error: " + ex.Message);
                throw;
            }
            return conn;
        }

        // Method to close the database connection
        public void CloseConnection(SqlConnection conn)
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        // Example method to execute a query
        public void ExecuteQuery(string query)
        {
            using (SqlConnection conn = OpenConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Example method to retrieve data from the database
        public DataTable GetData(string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = OpenConnection())
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.Fill(dt);
                }
            }
            return dt;
        }
    }
}
