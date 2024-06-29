using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosCsharp
{
    internal class Exercicio04
    {
        public static void Main(string[] args)
        {
            double perimetro = CalcularPerimetroCirculo(9.0);
            Console.WriteLine($"O perímetro do círculo é: {perimetro}");
        }

        static double CalcularPerimetroCirculo(double raio)
        {
            return 2 * Math.PI * raio;
        }
    }
}
