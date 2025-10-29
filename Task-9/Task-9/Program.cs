using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eneter argument");
            var x = double.Parse(Console.ReadLine());
            Console.WriteLine($"f({x:F2}) = {F(x):F2}");

        }
        static double F(double x)
        {
            if (x < -2)
                return Math.Log10(Math.Pow(x, 2));
            else if (-2 <= x && x <= 1)
                return Math.Exp(x);
            else
                return Math.Cos(x);


        }
    }
}
