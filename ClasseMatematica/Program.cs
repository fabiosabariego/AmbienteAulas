using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseMatematica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Utilizando Classes Matematicas para Calcular Exponencial
            int bas = 5;
            int pot = 2;
            double quad = Math.Pow(bas, pot);
            Console.WriteLine($"O valor de {bas}^{pot} é {quad} \n");


            // Utilizando Classes Matematicas para Calcular Raiz Quadrada
            int val = 6;
            double raizQuadrada = Math.Sqrt(val);       // Existe a Possibilidade de Usar o MathF para que serja um float, porem nao existe nessa versao!
            Console.WriteLine($"A Raiz de {val} e {raizQuadrada :F2}");
            Console.ReadKey();
        }
    }
}
