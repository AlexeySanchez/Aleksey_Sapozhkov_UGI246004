using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение x: ");
            double x = double.Parse(Console.ReadLine());

            double result = calculation(x);

            Console.WriteLine($"{result}");
        }

        static double calculation(double x)
        {
            double first = 2 + 1 / (Math.Pow(x, 2) + 1);
            double second = 3 + first / (Math.Pow(x, 2) + 2);
            return second/(Math.Pow(x, 2) + 3);
            
        }
    }
}
