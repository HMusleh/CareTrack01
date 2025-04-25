using Microsoft.Data.SqlClient;

namespace CareTrack
{
    internal static class SignaturesHelpers
    {

        //method for GetOrCreateShiftId
        private static int GetOrCreateShiftId(DatabaseHelper db, int caregiverId, int clientId)
        {
            using SqlConnection conn = db.OpenConnection();
            string GetOrCreateShiftIdQuery = "SELECT ShiftID FROM Shifts_Assignment WHERE ClientID = @ClientID AND CaregiverID = @CaregiverID";
            using (SqlCommand GetOrCreateShiftIdCmd = new(GetOrCreateShiftIdQuery, conn))
            {
                GetOrCreateShiftIdCmd.Parameters.AddWithValue("@ClientID", AppState.clientId);
                GetOrCreateShiftIdCmd.Parameters.AddWithValue("@CaregiverID", caregiverId);

                object result = GetOrCreateShiftIdCmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int existingShiftId))
                {
                    return existingShiftId;
                }
            }
            string insertQuery = @"INSERT INTO Shifts_Assignment(ClientID, CaregiverID, shift_date,status)
                                    OUTPUT INSERTED.ShiftID VALUES (@ClientID, @CaregiverID, @Date, @Status)";

            using SqlCommand insertCmd = new(insertQuery, conn);
            insertCmd.Parameters.AddWithValue("@ClientID", AppState.clientId);
            insertCmd.Parameters.AddWithValue("@CaregiverID", caregiverId);
            insertCmd.Parameters.AddWithValue("@Date", DateTime.Today);
            insertCmd.Parameters.AddWithValue("@Status", "Scheduled");

            return (int)insertCmd.ExecuteScalar();
        }
    }
}