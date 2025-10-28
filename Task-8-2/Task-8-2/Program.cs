using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите координату x: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Введите координату y: ");
            double y = double.Parse(Console.ReadLine());

            bool result = IsPointInArea(x, y);
            Console.WriteLine(result);
        }
        static bool IsPointInArea(double x, double y)
        {
           
            return (x < -2) && (y > 1);
        }
    }
}
