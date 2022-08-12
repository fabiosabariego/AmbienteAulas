using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02A20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Trabalhando Com incremento e Decremento
            // Podemos escrever n += 1 como n++, ou n--
            int n1 = 6;
            int n2 = 9;
            int n3 = n1++;

            //n1++;
            //n2--;

            //++n1;
            //--n2;

            Console.WriteLine($"n1 vale {n1} e n2 vale {n2}, e n3 vale {n3}");
            Console.ReadKey();
        }
    }
}
