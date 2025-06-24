using C__Final_Project_01.Models;
using C__Final_Project_01.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace C__Final_Project_01.Controllers
{
    internal class StudentController
    {

        /*public Task<List<Student>> GetAllAsync()
        {
            return Task.FromResult(new List<Student>());
        }
        public Task AddAsync(Student s)
        {
            return Task.CompletedTask;
        }
        public Task UpdateAsync(Student s)
        {
            return Task.CompletedTask;
        }
        public Task DeleteAsync(int id)
        {
            return Task.CompletedTask;
        }*/

        /*public string AddStudent(Student student)
        {
            var conn = DatabaseManager.GetConnection();
            string addStudentQuary = "INSERT INTO Students (StudentID,Name,DateOfbirth,Email) VALUES (@studentid,@name,@dateOfBirth,@email)";
            SQLiteCommand insertStudentCommand = new SQLiteCommand(addStudentQuary, conn);
            insertStudentCommand.Parameters.AddWithValue("@studentid", student.StudentID);
            insertStudentCommand.Parameters.AddWithValue("@name", student.Name);
            insertStudentCommand.Parameters.AddWithValue("@dateOfBirth", student.DateOfbirth);
            insertStudentCommand.Parameters.AddWithValue("@email", student.Email);
            insertStudentCommand.ExecuteNonQuery();
            return "Student Added Successfully!";
        }*/


         public void AddStudent(Student student)
         {

              var conn = DatabaseManager.GetConnection();
              //string password = "password@123";
              //string role = "Student";


              // long userId = conn.LastInsertRowId;

              string insertStudent = @"INSERT INTO Students (StudentName, StudentID, Dateofbirth, Email)
                                         VALUES (@studentname, @studentid, @dateofbirth, @email)";
              using (var stuCmd = new SQLiteCommand(insertStudent, conn))
              {
                  stuCmd.Parameters.AddWithValue("@studentname", student.StudentName);
                  stuCmd.Parameters.AddWithValue("@studentid", student.StudentID);
                  stuCmd.Parameters.AddWithValue("@dateofbirth", student.DateOfbirth );
                  stuCmd.Parameters.AddWithValue("@email",student.Email);
                  stuCmd.ExecuteNonQuery();
              }




         }

/*         public void UpdateStudent(int studentid, string studentname, int dateofbirth, string email)
         {



                 var conn = DatabaseManager.GetConnection();
                 string query = @"UPDATE Students 
                                  SET StudentName = @studentname, StudentID = @studentid, Dateofbirth = @dateofbirth, Email = @email
                                  WHERE StudentID = @studentid";
                 using (var cmd = new SQLiteCommand(query, conn))
                 {
                     cmd.Parameters.AddWithValue("@studentname", StudentName);
                     cmd.Parameters.AddWithValue("@studentid", StudentID);
                     cmd.Parameters.AddWithValue("@dateofbirth", Dateofbirth);
                     cmd.Parameters.AddWithValue("@email", Email);

                     cmd.Parameters.AddWithValue("@id", id);
                     cmd.ExecuteNonQuery();
                 }



         }

         public static bool DeleteStudent(int studentId, out string error)
         {



              var conn = DatabaseManager.GetConnection();
              string query = "DELETE FROM Students WHERE StudentID = @id";
              using (var cmd = new SQLiteCommand(query, conn))
              {
                  cmd.Parameters.AddWithValue("@id", studentId);
                  cmd.ExecuteNonQuery();
              }



         }*/
    }
}
