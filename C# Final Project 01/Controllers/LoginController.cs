using C__Final_Project_01.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Final_Project_01.Controllers
{
    public class LoginController
    {
        public static string Login(string username, string password)
        {
            using (var conn = DbConfig.GetConnection())
            {
                string query = "SELECT Role FROM Users WHERE Username=@username AND Password=@password";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    var result = cmd.ExecuteScalar();
                    return result?.ToString(); // returns role or null
                }
            }
        }
    }   
}
