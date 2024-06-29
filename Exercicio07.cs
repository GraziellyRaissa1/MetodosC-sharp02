using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosCsharp
{
    internal class Exercicio07
    {
        public static void Main(string[] args)
        {
            int numeroAleatorio = GerarNumeroAleatorio();
            Console.WriteLine($"Número aleatório: {numeroAleatorio}");
        }

        static int GerarNumeroAleatorio()
        {
            Random random = new Random();
            return random.Next(10, 111);
        }
    }
}
