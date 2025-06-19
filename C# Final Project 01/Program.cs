using C__Final_Project_01.Controllers;
using C__Final_Project_01.Repositories;
//using C__Final_Project_01.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            DatabaseManager.InitializeDatabase();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            bool isLoggedIn = LoginController.CheckLogin("admin", "password123");
            if (isLoggedIn)
                Console.WriteLine("Login successful!");
            else
                Console.WriteLine("Login failed.");


        }
    }
    
}
