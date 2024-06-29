using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosCsharp
{
    internal class Exercicio10
    {
       public static void Main(string[] args)
        {
            double hipotenusa = CalculoHipotenusa(8.0, 40.0);
            Console.WriteLine($"A hipotenusa é: {hipotenusa}");
        }

        static double CalculoHipotenusa(double cateto1, double cateto2)
        {
            return Math.Sqrt(cateto1 * cateto1 + cateto2 * cateto2);
        }
    }
}
