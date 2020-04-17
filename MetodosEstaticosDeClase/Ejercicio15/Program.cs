using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            int resultado;
            string operador = "";
            string seguir = "";

           do
            {
                Console.WriteLine("Ingrese el primer numero:");
                Int32.TryParse(Console.ReadLine(), out numero1);

                Console.WriteLine("Ingrese el operador(+,-,*,/):");
                operador = Console.ReadLine();

                Console.WriteLine("Ingrese el segundo numero:");
                Int32.TryParse(Console.ReadLine(), out numero2);



                resultado = Calculadora.Calcular(numero1, numero2, operador);
                if(resultado == 0 && operador == "/")
                {
                    Console.WriteLine("No se puede dividir por cero.");
                }
                else
                {
                    Console.WriteLine("{0} {1} {2} = {3}", numero1, operador, numero2, resultado);
                }


                Console.WriteLine("¿Desea continuar? S/N:");
                seguir = Console.ReadLine(); 

            } while (seguir == "s" || seguir == "S");

           
        }
    }
}
