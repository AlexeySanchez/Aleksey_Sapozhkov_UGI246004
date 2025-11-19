using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во n");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите a0");
            int prev = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Введите a{i}");
                int current = int.Parse(Console.ReadLine());
                Console.Write($"a{i-1} + a{i} = {prev + current} \n"); 
                prev = current;
            }
        }
    }
}
