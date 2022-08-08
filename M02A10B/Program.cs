using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02A10B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = 0;

            // Entrada de Dados do Sistema
            Console.Write("Digite sua Idade: ");
            int.TryParse(Console.ReadLine(), out idade);

            // Calculando a idade para Votar
            bool sit1 = idade < 16;
            bool sit2 = idade >= 16 && idade < 18 || idade >=65;
            bool sit3 = idade >= 18 && idade < 65;

            // Mostrando valores na Tela
            Console.WriteLine($"Com {idade} anos, votar e impossivel? {sit1}");
            Console.WriteLine($"Com {idade} anos, votar e Opicional? {sit2}");
            Console.WriteLine($"Com {idade} anos, votar e Obrigatorio? {sit3}");
            Console.ReadKey();
        }
    }
}
