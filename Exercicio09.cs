using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosCsharp
{
    internal class Exercicio09
    {
        public static void Main(string[] args)
        {
            string invertida = InverterString("Olá Pessoas");
            Console.WriteLine($"String invertida: {invertida}");
        }

        static string InverterString(string texto)
        {
            char[] array = texto.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
    }
}
