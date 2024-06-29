using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosCsharp
{
    internal class Exercicio02
    {
        public static void Main(string[] args)
        {
            ExibirQuadrado(9);
        }

        static void ExibirQuadrado(int numero)
        {
            Console.WriteLine($"O quadrado de {numero} é: {numero * numero}");
        }
    }
}
