using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine($"{k} * {i} = {k * i}");
            }
        }
    }
}
