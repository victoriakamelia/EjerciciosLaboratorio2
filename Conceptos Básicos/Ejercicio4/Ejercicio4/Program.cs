using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numerosPerfectos = 0;
            int acumulador;

            for (int i = 1; numerosPerfectos < 4; i++)
            {
                acumulador = 0;

                for (int j = i - 1; j > 0; j--)
                {

                    if (i % j == 0)
                    {
                        acumulador += j;


                    }




                }
                if (acumulador == i)
                {
                    Console.WriteLine("* {0} *", i);
                    numerosPerfectos++;

                }


            }
            Console.ReadKey();

        }
    }
}
