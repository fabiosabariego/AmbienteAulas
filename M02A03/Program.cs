using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02A03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 7;
            int num2 = 3;
            float res;

            Console.WriteLine($"O calculo {num1} / {num2} = {res = num1 / num2}");
            Console.WriteLine($"Com Float Atibuido temos {num1} / {num2} = {res = (float) num1 / num2:F2}");
            Console.ReadKey();
        }
    }
}
