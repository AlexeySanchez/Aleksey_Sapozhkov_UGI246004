using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число n");
            double n = int.Parse(Console.ReadLine());
            double m = 0;

            while (true)
            {
                double result = Math.Pow(m,3) + m + 1;
             
                if (result > n)
                {
                    Console.WriteLine($"{m}^3 + {m} + 1 = {result} - наименьшее превосходящее");
                    break;
                }
                else Console.WriteLine($"{m}^3 + {m} + 1 = {result}");
                m++;
            }
        }
    }
}
