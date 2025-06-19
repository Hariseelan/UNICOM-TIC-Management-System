using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Final_Project_01.Repositories
{
    public static class DatabaseManager
    {
        private static readonly string dbFile = "unicomtic.db";
        private static string connectionString = $"Data Source={dbFile};Version=3;";   //------ Connect the SQLite db file ------

        public static void InitializeDatabase()
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                CreateTable(connection, "Users",
                    @"CREATE TABLE IF NOT EXISTS Users (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Username TEXT NOT NULL UNIQUE,
                        Password TEXT NOT NULL,
                        Role TEXT NOT NULL
                    );");

                CreateTable(connection, "Courses",
                    @"CREATE TABLE IF NOT EXISTS Courses (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        CourseName TEXT NOT NULL
                    );");

                CreateTable(connection, "Subjects",
                    @"CREATE TABLE IF NOT EXISTS Subjects (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        SubjectName TEXT NOT NULL,
                        CourseId INTEGER,
                        FOREIGN KEY(CourseId) REFERENCES Courses(Id)
                    );");

                CreateTable(connection, "Students",
                    @"CREATE TABLE IF NOT EXISTS Students (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL,
                        CourseId INTEGER,
                        FOREIGN KEY(CourseId) REFERENCES Courses(Id)
                    );");

                CreateTable(connection, "Exams",
                    @"CREATE TABLE IF NOT EXISTS Exams (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        ExamName TEXT NOT NULL,
                        SubjectId INTEGER,
                        ExamDate TEXT,
                        FOREIGN KEY(SubjectId) REFERENCES Subjects(Id)
                    );");

                CreateTable(connection, "Marks",
                    @"CREATE TABLE IF NOT EXISTS Marks (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        StudentId INTEGER,
                        ExamId INTEGER,
                        Score INTEGER,
                        FOREIGN KEY(StudentId) REFERENCES Students(Id),
                        FOREIGN KEY(ExamId) REFERENCES Exams(Id)
                    );");

                CreateTable(connection, "Rooms",
                    @"CREATE TABLE IF NOT EXISTS Rooms (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        RoomName TEXT NOT NULL,
                        RoomType TEXT NOT NULL
                    );");

                CreateTable(connection, "Timetables",
                    @"CREATE TABLE IF NOT EXISTS Timetables (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        SubjectId INTEGER,
                        Lecturer TEXT,
                        RoomId INTEGER,
                        TimeSlot TEXT,
                        FOREIGN KEY(SubjectId) REFERENCES Subjects(Id),
                        FOREIGN KEY(RoomId) REFERENCES Rooms(Id)
                    );");
            }
        }

        private static void CreateTable(SQLiteConnection connection, string tableName, string createSql)
        {
            using (var command = new SQLiteCommand(createSql, connection))
            {
                command.ExecuteNonQuery();
                Console.WriteLine($"{tableName} table created successfully.");
            }
        }
        

    }
}
