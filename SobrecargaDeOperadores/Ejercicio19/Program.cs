using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {

            Sumador sum1 = new Sumador();

            Console.WriteLine(sum1.Sumar(8,2));
            Console.WriteLine(sum1.Sumar("b", "b"));


            Sumador sum2 = new Sumador();

            Console.WriteLine(sum2.Sumar(1, 2));
            Console.WriteLine(sum2.Sumar("a", "b"));

            long sumara = sum1 + sum2;

            Console.WriteLine(sum1 | sum2);


            Console.ReadKey();

        }
    }
}
