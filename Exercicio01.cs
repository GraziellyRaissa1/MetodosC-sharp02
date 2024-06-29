using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosCsharp
{
    internal class Exercicio01
    {
        public static void Main(string[] args)
        {
            MostrarHoraAtual();
        }

        static void MostrarHoraAtual()
        {
            Console.WriteLine(DateTime.Now.ToString("HH:mm"));
        }
    }
}
