using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st number");
            int m=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            int n=int.Parse(Console.ReadLine());

            int remainder = m % n;

            remainder *= 10;
            int tenth = remainder / n;
            remainder %= n;

            remainder *= 10;
            int hundredth = remainder / n;
            remainder %= n;

            remainder *= 10;
            int thousandth = remainder / n;

            Console.WriteLine($"Десятые: {tenth}");
            Console.WriteLine($"Сотые: {hundredth}");
            Console.WriteLine($"Тысячные: {thousandth}");
        }
    }
}
