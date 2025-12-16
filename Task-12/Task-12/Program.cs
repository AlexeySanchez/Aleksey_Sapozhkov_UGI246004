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
            Console.Write("Введите m и n (от 5 до 20) через пробел: ");
            var parts = Console.ReadLine().Split();
            int m = int.Parse(parts[0]);
            int n = int.Parse(parts[1]);

            int[,] matrix = new int[m, n];
            Random rnd = new Random();
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    matrix[i, j] = rnd.Next(0, 100);

            PrintMatrix(matrix);
            Console.WriteLine();

            Console.Write("Введите число K: ");
            int k = int.Parse(Console.ReadLine());

            var (found, row, col) = FindGreaterThan(matrix, k);

            if (found)
                Console.WriteLine($"В матрице есть элемент > {k} по индексу ({row}, {col}) со значением {matrix[row, col]}");
            else
                Console.WriteLine($"Элемента больше {k} в матрице нет.");
            Console.WriteLine();

            double[] averages = ColumnAverages(matrix);

            Console.WriteLine("Средние арифметические по столбцам:");
            for (int j = 0; j < averages.Length; j++)
                Console.WriteLine($"Столбец {j}: {averages[j]:F2}");
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
        static (bool found, int row, int col) FindGreaterThan(int[,] matrix, int value)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    if (matrix[i, j] > value)
                        return (true, i, j);

            return (false, -1, -1);
        }
        static double[] ColumnAverages(int[,] matrix)
        {
            double[] result = new double[matrix.GetLength(1)]; //колонки

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                double sum = 0;
                for (int i = 0; i < matrix.GetLength(0); i++)
                    sum += matrix[i, j];

                result[j] = sum / matrix.GetLength(0); //строки
            }

            return result;
        }
    }
}
