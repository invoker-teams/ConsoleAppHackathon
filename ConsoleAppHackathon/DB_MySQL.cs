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

        //Объект для подключения к БД
        MySqlConnection obj;
        //Объект для выполнения SQL-запроса
        MySqlCommand objComand;

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

        public void CreatingNewRecordTimetable(DateTime FlightDate, TimeSpan ScheduledTime, int AirlineCode, int FlightNumber, string FlagArrivalDeparture, string TypeAircraft, string AParking, string ParkingSector, string NameAirline)
        {
            try
            {
                // запрос
                string sql = "INSERT INTO `Timetable`  (`FlightDate`, `ScheduledTime`, `AirlineCode`, `FlightNumber`, `FlagArrivalDeparture`, `TypeAircraft`, `AParking`,`ParkingSector`,`NameAirline`) VALUES ('" + FlightDate + "', '" + ScheduledTime + "', '" + AirlineCode + "', '" + FlightNumber + "', '" + FlagArrivalDeparture + "', '" + TypeAircraft + "', '" + AParking + "', '" + ParkingSector + "', '" + NameAirline + "')";
                MySqlCommand command = new MySqlCommand(sql, obj);
                // выполняем запрос 
                command.ExecuteScalar();
            }
            catch
            {
                Console.WriteLine("Error. The add request was not executed");
            }
        }
    }
}
