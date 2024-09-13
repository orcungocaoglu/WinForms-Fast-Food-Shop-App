using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace WindowsFormsApp3
{
    public class DatabaseHelper
    {
        private string server = "localhost";
        private string database = "pizza";
        private string username = "root";
        private string password = "";
        private string constring;

        public DatabaseHelper()
        {
            constring = $"SERVER={server};DATABASE={database};UID={username};PASSWORD={password};";
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(constring);
        }

        public DataTable GetStaff()
        {
            DataTable dataTable = new DataTable();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM staff";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }
                }
            }
            return dataTable;
        }
    }
}
