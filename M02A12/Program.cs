using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02A12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 27;
            Console.WriteLine($"O numero {n} corresponde a {Convert.ToString(n, toBase:2)} em binario");
            Console.WriteLine($"O numero {n} corresponde a {Convert.ToString(n, toBase: 16)} em Hexadecimal \n");

            // O mesmo tambem funciona ao contrario

            int n1 = 0b_10010; // Numero Binario
            int n2 = 0x_1b;    // Numero Hexadecimal
            Console.WriteLine($"O valor da variavel e {n1} convertido de binario");
            Console.WriteLine($"o valor da variavel e {n2} convertido de Hexadecimal");
            Console.ReadKey();
        }
    }
}
