using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму сдачи");
            int n = int.Parse(Console.ReadLine());
            int count = 0;

            for (int a = 0; a <= n / 10; a++)
            {
                for (int b = 0; b <= (n - 10 * a) / 5; b++)
                {
                    for (int c = 0; c <= (n - 10 * a - 5 * b) / 2; c++)
                    {
                        int d = n - 10 * a - 5 * b - 2 * c;
                        Console.WriteLine($"10 руб: {a}, 5 руб: {b}, 2 руб: {c}, 1 руб: {d}");
                        count++;
                    }
                }
            }

            Console.WriteLine($"Всего способов: {count}");
        }
    }
}
