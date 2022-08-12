using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnaliseArredondamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Trabalhando com algumas funcoes do Math

            int n1 = 8;
            int n2 = 10;

            Console.WriteLine($"O maior valor entre {n1} e {n2} e {Math.Max(n1, n2)}");
            Console.WriteLine($"O menor valor entre {n1} e {n2} e {Math.Min(n1, n2)}");


            // Para validacao usar float valid = Math.Clamp(nota, 0, 10);
        }
    }
}
