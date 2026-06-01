using System;
using RectangleStruct;

namespace RectangleStruct.ConsoleApp
{
    internal class Program
    {
        private static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            var rectangle = new Rectangle(2.3451, 1.002);

            Console.WriteLine("Исходный прямоугольник:");
            Console.WriteLine(rectangle);
            Console.WriteLine($"Площадь: {rectangle.Area}");
            Console.WriteLine($"Периметр: {rectangle.Perimeter}");

            Console.WriteLine();
            Console.WriteLine("Растяжение прямоугольника в 2 раза:");
            Rectangle biggerRectangle = 2 * rectangle;
            Console.WriteLine(biggerRectangle);
            Console.WriteLine($"Площадь: {biggerRectangle.Area}");
            Console.WriteLine($"Периметр: {biggerRectangle.Perimeter}");

            Console.WriteLine();
            Console.WriteLine("Проверка равенства:");
            var sameRectangle = new Rectangle(2.3451, 1.002);
            var anotherRectangle = new Rectangle(3.0, 1.002);

            Console.WriteLine($"rectangle == sameRectangle: {rectangle == sameRectangle}");
            Console.WriteLine($"rectangle == anotherRectangle: {rectangle == anotherRectangle}");

            Console.ReadKey();
        }
    }
}
