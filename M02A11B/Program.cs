using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02A11B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Entrando com Valores no Sistema
            float num = 0;
            Console.Write("Digite um Numero: ");
            float.TryParse(Console.ReadLine(), out num);

            // Verificando se o Numero colocado e par ou impar
            string valor = (num % 2 == 0) ? "PAR" : "IMPAR";
            Console.WriteLine($"O numero digitado e {valor}");
            Console.ReadKey();
        }
    }
}
