using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, suma;        
            char unChar;
            bool continuar;

            do
            {
                Console.WriteLine("Ingrese 1er numero: ");
                Int32.TryParse(Console.ReadLine(), out numero1);
                Console.WriteLine("Ingrese 2do numero: ");
                Int32.TryParse(Console.ReadLine(), out numero2);
                suma = numero1 + numero2;
                Console.WriteLine("RESULTADO SUMA:{0} ", suma);
                Console.WriteLine("¿Continuar? (S/N)");
                unChar = Console.ReadKey().KeyChar;

                continuar = ValidarRespuesta.ValidaS_N(unChar);


            } while (continuar);
            Console.ReadKey();
        }
    }
}
