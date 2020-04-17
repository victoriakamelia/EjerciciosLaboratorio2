using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio22
{
    class Program
    {
        static void Main(string[] args)
        {
            NumeroBinario prueB = "1001";
            NumeroDecimal prueD = 9;

            Console.WriteLine(prueD == prueB);
            Console.WriteLine(prueD != prueB);
            Console.WriteLine(prueD + prueB);
            Console.WriteLine(prueD - prueB);

            Console.WriteLine(prueB == prueD);
            Console.WriteLine(prueB != prueD);
            Console.WriteLine(prueB + prueD);
            Console.WriteLine(prueB - prueD);


            Console.ReadKey();
        }

    }
}
