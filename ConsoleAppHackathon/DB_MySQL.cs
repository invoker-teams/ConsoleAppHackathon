using System;
using MySql.Data.MySqlClient;

namespace ConsoleAppHackathon
{
    public class DB_MySQL
    {
        String connString;
        string host;
        int port;
        string database;
        string username;
        string password;
        MySqlConnection obj;

        public DB_MySQL(string Host, int Port, string Database, string Username, string Password)
        {
            host = Host;
            port = Port;
            database = Database;
            username = Username;
            password = Password;
        }

        public void openSessionMySQL()
        {
            connString = "Server=" + host + ";Database=" + database + ";port=" + port + ";User Id=" + username + ";password=" + password;
            obj = new MySqlConnection(connString);
            try
            {
                Console.WriteLine("Try open session");
                obj.Open();
            }
            catch
            {
                Console.WriteLine("Error. Session not open!");
            }
        }

        public void statusOpenSession()
        {
            Console.WriteLine("Server is alive ? " + obj.Ping());
        }
    }
}
