using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosCsharp
{
    internal class Exercicio05
    {
        public static void Main(string[] args)
        {
            int menor = MenorNumero(9, 2, 900);
            Console.WriteLine($"O menor número é: {menor}");
        }

        static int MenorNumero(int numero1, int numero2, int numero3)
        {
            return Math.Min(numero1, Math.Min(numero2, numero3));
        }
    }
}
