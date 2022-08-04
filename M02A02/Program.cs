using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02A02
{
    internal class Program
    {
        static void Main(string[] args)
        {
         // Exemplo de operadores aritiméticos]

            int op1 = 5;
            int op2 = 2;
            
            // Lendo os valores no Console
            Console.WriteLine($"Calculando +{op1} = {+op1}");
            Console.WriteLine($"Calculando -{op1} = {-op1}");
            Console.WriteLine($"Calculando {op1} + {op2} = {op1 + op2}");
            Console.WriteLine($"Calculando {op1} * {op2} = {op1 * op2}");
            Console.WriteLine($"Calculando {op1} / {op2} = {op1 / op2}");
            Console.WriteLine($"Calculando {op1} resto {op2} = {op1 % op2}");
            Console.ReadKey();
        }
    }
}
