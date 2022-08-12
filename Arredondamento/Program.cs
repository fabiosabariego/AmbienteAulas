using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arredondamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num = 9.53f;
            Console.WriteLine($"Valor Real Digitado: {num}");
            Console.WriteLine($"Usando Ceiling - Arredonda para Cima: {Math.Ceiling(num)}");
            Console.WriteLine($"Usando Floor - Arredonda para Baixo: {Math.Floor(num)}");
            Console.WriteLine($"Usando Truncate - Corta a parte Decimal: {Math.Truncate(num)}");
            Console.WriteLine($"Usando Round - Arredonda Aritimetico: {Math.Round(num)}");
            Console.ReadKey();
        }
    }
}
