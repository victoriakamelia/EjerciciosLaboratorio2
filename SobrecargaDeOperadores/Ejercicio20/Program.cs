using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billetes;

namespace Ejercicio20
{
    class Program
    {
        static void Main(string[] args)
        {
            Dolar unDolar = new Dolar(1);
            Euro unEuro = new Euro(1.16);
            Peso unPeso = new Peso(38.33);

            Dolar auxDolar = unDolar + unPeso+ unEuro;

            Console.WriteLine(auxDolar.getCantidad());
            Console.ReadKey();

           




        }
    }
}
