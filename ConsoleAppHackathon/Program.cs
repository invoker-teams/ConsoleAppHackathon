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
            string useSQL = "n";
            Console.WriteLine("Use SQL? Y - yes, N - no");
            useSQL = Console.ReadLine();


                /*Создаем объект подключения к бд objSQL. В конструктор передаем параметры подключения */
                DB_MySQL objSQL = new DB_MySQL("sql7.freesqldatabase.com", 3306, "sql7338923", "sql7338923", "bc9vSYmu5u");

                /*Открываем сессию передачи данных в бд */ 
                objSQL.openSessionMySQL();

                /*Проверяем доступность к бд */
                objSQL.statusOpenSession();

                /* Создавал объект для внесения данных */
                DateTime dt = new DateTime(2000, 2, 3, 10, 20, 30);

                /*
                 * Ниже пример внесения данных в бд
                 */
                //objSQL.CreatingNewRowTimetable(dt.Date, dt.TimeOfDay, 721, 555, "d", "772", "109w", "Terminal F", "Aeroflot");

                /*
                 * Ниже пример удаления данных из бд
                 */
                // objSQL.DeletRow_id(3, "Timetable");

                objSQL.getTimeTimetable(555);
            



            /*
             * Алгоритм Дейкстры
             *
            int[,] graph = new int[,] {
                                  { 0, 4, 0, 0, 0, 0, 0, 8, 0 },
                                  { 4, 0, 8, 0, 0, 0, 0, 11, 0 },
                                  { 0, 8, 0, 7, 0, 4, 0, 0, 2 },
                                  { 0, 0, 7, 0, 9, 14, 0, 0, 0 },
                                  { 0, 0, 0, 9, 0, 10, 0, 0, 0 },
                                  { 0, 0, 4, 14, 10, 0, 2, 0, 0 },
                                  { 0, 0, 0, 0, 0, 2, 0, 1, 6 },
                                  { 8, 11, 0, 0, 0, 0, 1, 0, 7 },
                                  { 0, 0, 2, 0, 0, 0, 6, 7, 0 }
            };

            Dijkstra t = new Dijkstra();

            int[] u = t.serch_ways(3, graph);
            for (int i = 0; i < graph.GetLength(0); i++)
                Console.Write(i + " \t\t " + u[i] + "\n");

               */
            Console.ReadKey();
        }
    }
}