using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02A11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Estudando Operadores Condicionais
            // Nesta Aula veremos o Operador ?
            float altura = 0f;
            Console.Write("Qual sua altura em metros: ");
            float.TryParse(Console.ReadLine(), out altura);

            // Verificando o Status
            string status = (altura <= 1.70) ? "Baixa" : "Alta";
            Console.WriteLine($"Voce se enquadra como uma pessoa {status:F2}");
            Console.ReadKey();
        }
    }
}
