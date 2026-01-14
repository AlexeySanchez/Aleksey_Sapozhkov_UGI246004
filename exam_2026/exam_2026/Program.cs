using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_2026
{
    internal class Program
    {
        static int Kaprekar(int n, int digits)
        {
            int[] arr = new int[digits]; //например, [4]
            for (int i = digits - 1; i >= 0 && n > 0; i--)
            {
                arr[i] = n % 10; //6174%10 = 4  
                n /= 10; //6174/10 = 617
            }

            //Сортируем по убыванию и вычисляем число
            //[7,6,4,1] собираем число: 7*10+6 = 76*10+4 + 764*10+1 = 7641
            int upper = 0;
            foreach (var d in arr.OrderByDescending(x => x))
                upper = upper * 10 + d;

            //Сортируем по возрастанию и вычисляем число
            //[1,4,6,7] собираем число аналогично
            int lower = 0;
            foreach (var d in arr.OrderBy(x => x))
                lower = lower * 10 + d;

            return upper - lower;
        }

        static void Main()
        {
            for (int m = 3; m <= 8; m++)
            {
                Console.WriteLine($"\nДля {m}-значных чисел");

                //Находим все m-значные числа и используем их для цикла

                int start = (int)Math.Pow(10, m - 1); //10^3 = 1000
                int end = (int)Math.Pow(10, m) - 1; //(10^4)-1 = 9999


                for (int n = start; n <= end; n++)
                {
                    int kn = Kaprekar(n, m);

                    if (kn == n)
                    {
                        Console.WriteLine($"K({n}) = {kn}");
                    }
                }
            }

        }
    }
}
