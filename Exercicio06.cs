using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosCsharp
{
    internal class Exercicio06
    {
       public static void Main(string[] args)
        {
            bool resultado = Primo(7);
            Console.WriteLine($"O número é primo? {resultado}");
        }

        static bool Primo(int numero)
        {
            if (numero <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0) return false;
            }
            return true;
        }
    }
}
