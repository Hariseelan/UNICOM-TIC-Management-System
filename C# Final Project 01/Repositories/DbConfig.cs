using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Final_Project_01.Repositories
{
    internal static class DbConfig
    {
        private static string connectionString = $"Data Source=UnicomTICDB.db;Version=3;";

        public static SQLiteConnection GetConnection()
        {
            var conn = new SQLiteConnection(connectionString) ;
            conn.Open();
            return conn;
        }
    }
}
