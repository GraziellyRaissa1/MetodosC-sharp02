using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosCsharp
{
    internal class Exercicio08
    {
          public static void Main(string[] args)
    {
        double fahrenheit = ConvercaoCelsiusParaFahrenheit(55.0);
        Console.WriteLine($"Temperatura em Fahrenheit: {fahrenheit}");
    }

    static double ConvercaoCelsiusParaFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }
    }
}
