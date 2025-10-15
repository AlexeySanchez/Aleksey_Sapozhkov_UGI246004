using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concatenation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "саксофон";
            Console.WriteLine(word.Remove(0, 7) + word.Remove(0, 4).Remove(1, 3) + word.Remove(0, 3).Remove(2, 3) + word.Remove(0, 2).Remove(1, 5));
            Console.WriteLine(word.Remove(0, 5).Remove(1, 2) + word.Remove(0,1).Remove(1, 1).Remove(3, 2));

            Console.ReadKey();
        }
    }
}
