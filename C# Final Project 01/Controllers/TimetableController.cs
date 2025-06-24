using C__Final_Project_01.Models;
using C__Final_Project_01.Repositories;
using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace C__Final_Project_01.Controllers
{
    internal class TimetableController
    {
        public static DataTable GetAllTimetables()
        {
            var conn = DatabaseManager.GetConnection();
            string query = @"SELECT 
                                t.TimetableID, 
                                s.SubjectName, 
                                r.RoomName,                   
                            FROM Timetables t
                            JOIN Subjects s ON t.SubjectID = s.SubjectID
                            JOIN Rooms r ON t.RoomID = r.RoomID";
            try
            {
                using (var adapter = new SQLiteDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Timetable load error: " + ex.Message);
                return null;
            }
        }

        public static bool AddTimetable(Timetable timetable, out string error)
        {
            error = "";
            try
            {
                var conn = DatabaseManager.GetConnection();
                string insert = @"INSERT INTO Timetables (SubjectID, RoomID, TimeSlot) 
                                  VALUES (@subjectId, @roomId, @timeSlot)";
                using (var cmd = new SQLiteCommand(insert, conn))
                {
                    cmd.Parameters.AddWithValue("@subjectId", timetable.subjectID);
                    cmd.Parameters.AddWithValue("@roomId", timetable.roomID);
                    
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                error = "Error adding timetable: " + ex.Message;
                return false;
            }
        }
    }
}
