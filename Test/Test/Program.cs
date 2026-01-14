using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3 };
            Console.WriteLine(arr1[arr1.Length - 3]); //1

            int[][] ma = new int[2][];
            ma[ma.Length - 1] = new int[] {1,2};
            ma[ma.Length - 2] = new int[] { 3, 4, 5 };
            Console.WriteLine(ma[ma.Length-1][ma.Length-2]); //1
        }
    }
}
