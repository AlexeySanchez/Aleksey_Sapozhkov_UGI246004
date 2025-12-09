using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = 0;
            int n = 0;
            while (true)
            {
                Console.WriteLine("Enter two natural numbers separated by a space");
                Console.WriteLine("Enter - refusal");

                var input = Console.ReadLine();

                if (input == string.Empty)
                {
                    return;
                }
                var strings = input.Split();

                if (strings.Length == 2 && int.TryParse(strings[0], out m) && int.TryParse(strings[1], out n) && 5 <= m && m <= 20 && 5 <= n && n <= 20)
                {
                    break;
                }

                else
                {
                    Console.WriteLine("Error");
                    continue;
                }
            }
            var matrix = new int[m, n];
            var rnd = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = rnd.Next(0, 100);

            PrintMatrix(matrix);
        }
        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write($"{matrix[i, j],2} ");

                Console.WriteLine();
            }
        }
    }
}
