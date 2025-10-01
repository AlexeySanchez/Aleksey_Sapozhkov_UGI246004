using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = InputInteger("Enter 1st coordinate");
            var y = InputInteger("Enter 2nd coordinate");

            Console.WriteLine("Point ("+x+","+y+") ");
        }
        static int InputInteger(string message)
        {

            Console.WriteLine(message);
            return int.Parse(Console.ReadLine());
        }
    }
}
