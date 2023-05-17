using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectMysql
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string server = "localhost";
                string database = "sample";
                string username = "root";
                string password = "Pass";
                string constring = "SERVER = " + server + ";" + "DATABASE = " + database + ";" +
                    "UID = " + username + ";" + "PASSWORD = " + password + ";";

                //string constring = "server=localhost;uid=root;password=Pass;database=sample;";

                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = constring;

                conn.Open();

                string query = "select * from student";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine(reader["Roll_no"]);
                    Console.WriteLine(reader["Name"]);
                    Console.WriteLine(reader["City"]);
                }
            } catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
