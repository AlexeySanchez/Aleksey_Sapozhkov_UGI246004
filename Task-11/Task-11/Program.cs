using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите n (n <= 20): ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введите лямбду: ");
            double lambda = double.Parse(Console.ReadLine());

            double[] a = new double[n];

            for (int i = 0; i < n; i++)
            {
                int k = i + 1;
                a[i] = Math.Pow(lambda, k) / Fact(k) * Math.Exp(-lambda);
            }

            PrintArray(a);
            Console.WriteLine("\n");

            // 2. Сумма с первого по текущий
            Console.WriteLine("Сумма с первого элемента по i");
            PrefixSum(a);
            PrintArray(a);
            Console.WriteLine("\n");

            // 3. Сумма модулей разностей соседних элементов
            double s = SumAbsDiff(a);
            Console.WriteLine($"Сумма модулей разностей: {s:F3}");

            // 4. Массив разностей каждого элемента и числа a
            Console.Write("Введите число a: ");
            double c = double.Parse(Console.ReadLine());

            double[] diffs = Differences(a, c);
            PrintArray(diffs);
        }

        static int Fact(int k)
        {
            int f = 1;
            for (int i = 2; i <= k; i++)
                f *= i;
            return f;
        }

        static void PrintArray(double[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write($"{arr[i]:F3} ");
        }

        //сумма с первого по текущий
        static void PrefixSum(double[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                arr[i] = sum;
            }
        }

        //сумма модулей разностей соседних элементов
        static double SumAbsDiff(double[] arr)
        {
            double s = 0;
            for (int i = 0; i < arr.Length - 1; i++)
                s += Math.Abs(arr[i + 1] - arr[i]);
            return s;
        }

        //массив разностей элемента и числа c 
        static double[] Differences(double[] arr, double c)
        {
            double[] res = new double[arr.Length];
            for (int i = 0; i < arr.Length; i++)
                res[i] = arr[i] - c;
            return res;
        }
    }
}