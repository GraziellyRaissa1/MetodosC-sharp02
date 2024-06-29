using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosCsharp
{
    internal class Exercicio03
    {
        public static void Main(string[] args)
        {
            double area = CalculoDaAreaRetangulo(5.0, 3.0);
            Console.WriteLine($"A área do retângulo é: {area}");
        }

        static double CalculoDaAreaRetangulo(double largura, double altura)
        {
            return largura * altura;
        }
    }
}
