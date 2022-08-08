using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02A04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 3;
            int n2 = 6;

            Console.WriteLine($"{n1} = {n2}? {n1 == n2}");
            Console.WriteLine($"{n1} != {n2}? {n1 != n2}");
            Console.WriteLine($"{n1} > {n2}? {n1 > n2}");
            Console.WriteLine($"{n1} >= {n2}? {n1 >= n2}");
            Console.WriteLine($"{n1} < {n2}? {n1 < n2}");
            Console.WriteLine($"{n1} <= {n2}? {n1 <= n2}");
            Console.WriteLine($"{n1} e inteiro? {n1 is int}");
            Console.WriteLine($"{n1} e float? {n1 is float}");
            Console.ReadKey();
        }
    }
}
