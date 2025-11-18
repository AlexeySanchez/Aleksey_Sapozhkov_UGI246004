using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Увеличение площади посева");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Увеличение сбора урожая");
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine("Кол-во тонн");
            double n = double.Parse(Console.ReadLine());

            double area = 10;
            double barley = 2; ///2 тонны = 20 центнеров 
            double totalHarvest = 0;
            int year = 1;

            while (true)
            {
                totalHarvest += area * barley;
                Console.WriteLine($"Тонн за все года: {totalHarvest:F2}");

                if (totalHarvest > n)
                {
                    area *= 1 + x / 100;
                    Console.WriteLine($"Площадь посева в га = {area:F2}");
                    barley *= 1 + y / 100;
                    Console.WriteLine($"Тонн ячменя за этот год = {barley * area:F2}");

                    Console.WriteLine($"Год {year}");
                    break;
                }
                else
                {
                    area *= 1 + x / 100;
                    Console.WriteLine($"Площадь посева в га = {area:F2}");
                    barley *= 1 + y / 100;
                    Console.WriteLine($"Тонн ячменя за этот год = {barley*area:F2}");

                    Console.WriteLine($"Год {year}");
                }
                year++;
            }
        }
    }
}
