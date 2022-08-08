using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02A16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Trabalhando com operadores de Deslocamento
            // Right Shift >>
            // Left Shift <<

            int binario = 0b_01011010;
            Console.WriteLine($"Valor inicial: {Convert.ToString(binario, toBase: 2)}");
            int desl1 = binario >> 1;
            Console.WriteLine($"direita: {Convert.ToString(desl1, toBase: 2)}");
            int desl2 = binario << 1;
            Console.WriteLine($"Esquerda: {Convert.ToString(desl2, toBase: 2)}");
            Console.ReadKey();

        }
    }
}
