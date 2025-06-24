using C__Final_Project_01.Controllers;
using C__Final_Project_01.Repositories;
//using C__Final_Project_01.Views;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace C__Final_Project_01
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DatabaseManager.CreateTables();

            // Add default users only if needed (e.g., first run)
            //DatabaseManager.AddUser("admin", "password123", "Admin");
            //DatabaseManager.AddUser("staff1", "staffpass", "Staff");
            //DatabaseManager.AddUser("student1", "studentpass", "Student");
            //DatabaseManager.AddUser("lecturer1", "lecturerpass", "Lecturer");

            // The following lines will not execute until LoginForm is closed.
            //---------------------------------------------------------------
            //string role = LoginController.Login("admin", "password123");
            //if (!string.IsNullOrEmpty(role))
                //Console.WriteLine("Login successful!");
            //else
                //Console.WriteLine("Login failed.");
            //---------------------------------------------------------------

            //DatabaseManager.InitializeDatabase();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());


            


        }
    }
    
}
