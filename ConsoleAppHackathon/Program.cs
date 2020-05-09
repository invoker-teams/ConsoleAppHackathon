using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ConsoleAppHackathon
{
   
    class Program
    {
        
        static void Main(string[] args)
        {

            DB_MySQL objSQL = new DB_MySQL("sql7.freesqldatabase.com", 3306, "sql7338923", "sql7338923", "bc9vSYmu5u");


            objSQL.openSessionMySQL();

            objSQL.statusOpenSession();

            Console.ReadKey();
        }
    }
}