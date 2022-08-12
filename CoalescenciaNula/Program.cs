using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoalescenciaNula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Aula de Coalescencia Nula - OPERADOR DE COALESCENCIA NULA "??"
            // Evita valores Nulos, muito interessante para banco de dados, para nao gravar dados nulos (null)
            string nome = null;
            //int num = null; // Tipo int e nao anulavel, nao podemos colocar como null

            int? num = null; // Com o "?" e possivel colocar um tipo int como nulo
            int x = num ?? 989; // Isso e feito pois a variavel x nao ira receber o valor de num, pois quando temos int? ele entende que pode ser nulo
                                // Este valor de 989, somente sera atribuido a x se a variavel num for nula, caso contrario pegara o valor da variavel num

            Console.WriteLine($"A variavel nome tem valor nulo? {nome is null}");
            Console.WriteLine($"A variavel numero tem valor nulo? {num is null}");
            Console.WriteLine($"A variavel tem valor? {num.HasValue}");
            Console.WriteLine($" A variavel x recebeu o valor {x}");
            Console.ReadKey();
        }
    }
}
