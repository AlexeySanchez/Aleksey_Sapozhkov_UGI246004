using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculating_task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///вариант 18
            Console.WriteLine("Введите длину первого катета");
            var a=Console.ReadLine();
            var x =double.Parse(a);
            Console.WriteLine("Введите длину второго катета");
            var b =Console.ReadLine();
            var y=double.Parse(b);
            Console.WriteLine("Произвожу расчет длины высоты, опущенной из вершины прямого угла на гипотенузу");
            double c = Math.Abs(x * y) /Math.Sqrt((Math.Pow(x, 2)) + (Math.Pow(y, 2)));
            Console.WriteLine("Высота равна: " + c);
            Console.ReadKey();
        }
    }
}
