using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int anioComienzo, anioFin;

            Console.Write("\nIngrese un año de comiezo: ");
            int.TryParse(Console.ReadLine(), out anioComienzo);

            Console.Write("\nIngrese un año de fin: ");
            int.TryParse(Console.ReadLine(), out anioFin);


            for (int i = anioComienzo; i < anioFin; i++)
            {
                if (((i % 100 == 0) && (i % 400 == 0)) || i % 4 == 0)
                {


                    Console.Write("\n{0} es un año bisiesto. ", i);
                }


            }

            Console.ReadKey();

        }
    }
}
