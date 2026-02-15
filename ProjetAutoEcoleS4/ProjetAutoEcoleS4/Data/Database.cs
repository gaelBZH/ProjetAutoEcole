using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace ProjetAutoEcoleS4.Data
{
    public class Database
    {
        private static string connectionString =
            "server=localhost;database=AutoEcole;uid=root;pwd=;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
