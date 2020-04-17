using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            double numeroDoble;
            double cubo;
            double cuadrado;
            string numeroIngresado;
            

            Console.WriteLine("* * * * * * * * * * * * * * * *");
            Console.WriteLine("Ingrese un numero mayor a cero: ");
            numeroIngresado = Console.ReadLine();
            Int32.TryParse(numeroIngresado, out numero);

            while (numero <= 0  )
            {
                Console.WriteLine("* * * * * * * * * * * * * * * *");
                Console.WriteLine("El numero ingresado debe ser mayor a cero, reintente: ");
                numeroIngresado = Console.ReadLine();
                Int32.TryParse(numeroIngresado, out numero);
            }
            numeroDoble = numero;
            cuadrado = Math.Sqrt(numeroDoble);
            cubo = Math.Pow(numeroDoble, 2);

            Console.WriteLine("* * * * * * * * * * * * * * * *");
            Console.WriteLine("El cuadrado del numero ingresado es : {0}", cuadrado);
            Console.WriteLine("* * * * * * * * * * * * * * * *");
            Console.WriteLine("El cubo del numero ingresado es : {0}", cubo);
            Console.ReadKey();



        }
    }
}
