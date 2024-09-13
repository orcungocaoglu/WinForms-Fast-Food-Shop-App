using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp3
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*
            string server = "localhost";
            string database = "pizza";
            string username = "root";
            string password = "";
            string constring = "SERVER="+server+";"+"DATABASE="+database+";"+"UID="+username+";"+"PASSWORD="+password+";";

            MySqlConnection conn = new MySqlConnection(constring);
            conn.Open();
            string query = "select * from staff";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            */


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new giris());
        }
    }
}
