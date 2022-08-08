using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02A10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float nota1 = 0;
            float nota2 = 0;

            // Entrando com dados no Console
            Console.Write("Nota 1: ");
            float.TryParse(Console.ReadLine(), out nota1);
            Console.Write("Nota 2: ");
            float.TryParse(Console.ReadLine(), out nota2);

            // Calculando a media e Situacoes
            float media = (nota1 + nota2) / 2;
            bool sit1 = media < 4.0;
            bool sit2 = media >= 4 && media < 7.0;
            bool sit3 = media >= 7 && media <= 10;
            

            // Mostrando os Resultados
            Console.WriteLine($" Para as notas {nota1} e {nota2}, a media e {media}");
            Console.WriteLine($" Aluno Reprovado? {sit1}");
            Console.WriteLine($" Aluno Recuperacao? {sit2}");
            Console.WriteLine($" Aluno Aprovado? {sit3}");

            Console.ReadKey();
        }
    }
}
