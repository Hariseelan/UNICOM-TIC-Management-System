using C__Final_Project_01.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace C__Final_Project_01.Repositories
{
    internal static class DatabaseManager
    {
        public static SQLiteConnection GetConnection()
        {
            return DbConfig.GetConnection();
        }

        public static void CreateTables()
        {
            using (var getDbConn = DbConfig.GetConnection())
            {
                //connection.Open();
                string[] createTableStatements = new string[]
                {
                    @"CREATE TABLE IF NOT EXISTS Users (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Username TEXT NOT NULL UNIQUE,
                        Password TEXT NOT NULL,
                        Role TEXT NOT NULL
                    );",


                    @"CREATE TABLE IF NOT EXISTS Courses (
                        CourseId INTEGER PRIMARY KEY AUTOINCREMENT,
                        CourseName TEXT NOT NULL
                    );",


                    @"CREATE TABLE IF NOT EXISTS Subjects (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        SubjectName TEXT NOT NULL,
                        CourseId INTEGER,
                        FOREIGN KEY(CourseId) REFERENCES Courses(Id)
                    );",


                    @"CREATE TABLE IF NOT EXISTS Students (
                        StudentID INTEGER PRIMARY KEY AUTOINCREMENT,
                        StudentName TEXT NOT NULL,
                        DateOfbirth TEXT,
                        Email TEXT,
                        CourseId INTEGER,
                        FOREIGN KEY(CourseId) REFERENCES Courses(Id)
                    );",


                    @"CREATE TABLE IF NOT EXISTS Exams (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        ExamName TEXT NOT NULL,
                        SubjectId INTEGER,
                        ExamDate TEXT,
                        FOREIGN KEY(SubjectId) REFERENCES Subjects(Id)
                    );",


                    @"CREATE TABLE IF NOT EXISTS Marks (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        StudentId INTEGER,
                        ExamId INTEGER,
                        Score INTEGER,
                        FOREIGN KEY(StudentId) REFERENCES Students(Id),
                        FOREIGN KEY(ExamId) REFERENCES Exams(Id)
                    );",


                    @"CREATE TABLE IF NOT EXISTS Rooms (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        RoomName TEXT NOT NULL,
                        RoomType TEXT NOT NULL
                    );",


                    @"CREATE TABLE IF NOT EXISTS Timetables (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        SubjectId INTEGER,
                        Lecturer TEXT,
                        RoomId INTEGER,
                        TimeSlot TEXT,
                        FOREIGN KEY(SubjectId) REFERENCES Subjects(Id),
                        FOREIGN KEY(RoomId) REFERENCES Rooms(Id)
                    );"
                };
                foreach (var sql in createTableStatements)
                {
                    using (var command = new SQLiteCommand(sql, getDbConn))
                    {
                        command.ExecuteNonQuery();
                        //DatabaseManager.AddUser("Admin", "admin123", "admin");
                        DatabaseManager.AddUserIfNotExists("Admin", "admin123", "admin");


                    }
                }

                MessageBox.Show("Successfully Tables Created!!!");
            }
        }
        // Add a new user to the Users table (plain text password as per assignment)


        /*public static void AddUser(string username, string password, string role)
        {
            using (var conn = DbConfig.GetConnection())
            {
                
                string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username = @username";
                using (var checkCmd = new SQLiteCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@username", username);
                    long count = (long)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show($"User '{username}' already exists.");
                        return;
                    }
                }

                string query = "INSERT INTO Users (Username, Password,Role) VALUES (@username, @password,@role)";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@role", role);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("User added successfully!");
                    }
                    catch (SQLiteException ex)
                    {
                        MessageBox.Show("Error adding user: " + ex.Message);
                    }
                }
               
            }
            

        }*/
        public static void AddUserIfNotExists(string username, string password, string role)
        {
            using (var conn = DbConfig.GetConnection())
            {
                //conn.Open();

                // Check if user already exists (case-insensitive)
                string checkQuery = "SELECT COUNT(*) FROM Users WHERE LOWER(Username) = LOWER(@username)";
                using (var checkCmd = new SQLiteCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@username", username);
                    long count = (long)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        // User exists, silently ignore without message
                        return;
                    }
                }

                // User not found, insert new record
                string insertQuery = "INSERT INTO Users (Username, Password, Role) VALUES (@username, @password, @role)";
                using (var insertCmd = new SQLiteCommand(insertQuery, conn))
                {
                    insertCmd.Parameters.AddWithValue("@username", username);
                    insertCmd.Parameters.AddWithValue("@password", password);
                    insertCmd.Parameters.AddWithValue("@role", role);

                    try
                    {
                        insertCmd.ExecuteNonQuery();
                        MessageBox.Show("User added successfully!");
                    }
                    catch (SQLiteException ex)
                    {
                        MessageBox.Show("Error adding user: " + ex.Message);
                    }
                }
            }
        }




    }
}
