using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class myGraph
    {
        public static int[] d = new int[10];
        public static int[] post = new int[10];
        public static bool[] t = new bool[10];
        public static int i, j, p, k, minras;

        public void poisk(int[,] a)
        {
            //начальные установк
            minras = 0;
            for (i = 0; i < 4; i++)
            {
                post[i] = 0;
                t[i] = true;
                d[i] = a[0, i];
            }
            t[0] = false;
            post[0] = 0;
            for (i = 0; i < 3; i++)
            {
                // поиск вершины k
                minras = 1000;
                for (j = 0; j < 9; j++)
                    if ((t[j] == true) && (minras > d[j]))
                    {
                        minras = d[j]; k = j;
                    }
                // поиск маршрутов и минимальных расстояний через вершину k
                t[k] = false;
                for (j = 0; j < 4; j++)
                    if ((t[j] == true) && (d[j] > d[k] + a[k, j]))
                    {
                        d[j] = d[k] + a[k, j];
                        post[j] = k;
                    }
            }
        }

        public void print(int[,] a)
        {
            // печать матрицы смежности
            Console.WriteLine("Print result matrix: ");
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 4; j++)
                    Console.Write("\t" + a[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine();
            // печать массива минимальных расстояний
            for (i = 0; i < 4; i++) Console.Write("\t" + i);
            Console.WriteLine();
            for (i = 0; i < 4; i++) Console.Write("\t" + d[i]);
            Console.WriteLine();
            // печать массива маршрутов
            for (i = 0; i < 4; i++) Console.Write("\t" + post[i]);
            Console.WriteLine();

        }
    }
    class Program
    {
        public static int[,] a = new int[4, 4]
        {
      {0,500, 700, 1000},
      {500,0,200,500},
      {700,200,0,650},
      {1000,500,650,0},
        };

        
        static void Main(string[] args)
        {
            myGraph obj = new myGraph();

            obj.poisk(a);
            obj.print(a);
            Console.ReadLine();
        }
    }
}