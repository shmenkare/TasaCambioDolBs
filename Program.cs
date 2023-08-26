using System;
using System.Collections.Generic;
using System.Text;

namespace TasaCambioDolBs
{
    class Program
    {
        static void Main(string[] args)
        {
            float bol, dol, tasa = 1.0f;

            Console.WriteLine("Ingrese el tasa de cambio del dia");
            tasa = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad en Dolares");
            dol = Convert.ToSingle(Console.ReadLine());

            bol = tasa * dol;

            Console.WriteLine("{0} $ equivalen a {1} Bs.", dol, bol);

            Console.ReadKey();








        }
    }
}
