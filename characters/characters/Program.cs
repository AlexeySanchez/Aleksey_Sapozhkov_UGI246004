using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double result = calculate(1+calculate(2+calculate(3+Math.Sqrt(5))));
            double result_3 = Math.Round(result, 3);
            Console.WriteLine($"{result_3}");
            Console.ReadKey();
        }
        static double calculate(double x)
        {
            return 1 / x;
        }
    }
}
