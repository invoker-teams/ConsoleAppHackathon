using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ConsoleApplication1
{
   
    class Program
    {          

        static void Main(string[] args)
        {
            string host = "sql7.freesqldatabase.com";
            int port = 3306;
            string database = "sql7338923";
            string username = "sql7338923";
            string password = "bc9vSYmu5u";

            try
            {
                String connString = "Server=" + host + ";Database=" + database
                + ";port=" + port + ";User Id=" + username + ";password=" + password;
                MySqlConnection conn = new MySqlConnection(connString);

               conn.Open();
                Console.WriteLine(conn.Ping());
            }
            catch
            {
                Console.WriteLine("Error ");
            }

            

            Console.ReadLine();
        }
    }
}