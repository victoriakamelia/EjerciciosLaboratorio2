using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int acumulador1 = 0;
            int acumulador2 = 0;

            Console.Write("\nIngrese un número: ");
            if(int.TryParse(Console.ReadLine(), out numeroIngresado))
            {
                for(int centro = 2; centro < numeroIngresado; centro++)
                {
                    acumulador1 = 0;
                    for(int i = 0; i < centro; i++)
                    {
                        acumulador1 = acumulador1 + i;
                    }

                    acumulador2 = 0;
                    for(int i = centro + 1; acumulador2 < acumulador1; i++)
                    {
                        acumulador2 = acumulador2 + i;
                    }

                    if(acumulador1 == acumulador2)
                    {
                        Console.WriteLine("{0}", centro);
                    }
                }
                Console.ReadKey();
            }
        }
    }
}
