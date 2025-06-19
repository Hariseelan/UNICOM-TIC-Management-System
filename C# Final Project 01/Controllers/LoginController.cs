using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Final_Project_01.Controllers
{
    public class LoginController
    {
        private static Dictionary<string, string> users = new Dictionary<string, string>
    {

        { "admin", "password123" },
        { "user", "password" }


        public static bool Login(string username, string password)
        {
            return users.ContainsKey(username) && users[username] == password;
        }
    }

    }
}
