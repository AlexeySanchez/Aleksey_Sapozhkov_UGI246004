using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число m: ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Введите целое число n: ");
            int n = int.Parse(Console.ReadLine());

            bool result = CheckCondition(m, n);

            Console.WriteLine($"\nРезультат проверки: {result}");

        }
        static bool CheckCondition(int m, int n)
        {
            return ((m + n) % 2 == 0) && ((m * n) % 3 == 0);
        }
    }
}
