using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            double lado= default;
            double lado1= default;
            double radio;
            double resultado;

            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Calcular area de un cuadrado.");
            Console.WriteLine("2. Calcular area de un triángulo.");
            Console.WriteLine("3. Calcular area de un círculo.");
            Console.WriteLine("4. Salir.");
            

            Int32.TryParse(Console.ReadLine(), out opcion);

            switch(opcion)
            {
                case 1:
                    Console.WriteLine("Ingrese el lado: ");
                    Double.TryParse(Console.ReadLine(), out lado);

                    resultado = CalculoDeArea.CalcularCuadrado(lado);
                    Console.WriteLine("El area del cuadrado es de: {0}", resultado);
                    break;
                case 2:
                    Console.WriteLine("Ingrese el lado 1: ");
                    Double.TryParse(Console.ReadLine(), out lado);

                    Console.WriteLine("Ingrese el lado 2: ");
                    Double.TryParse(Console.ReadLine(), out lado1);

                    resultado = CalculoDeArea.CalcularTriangulo(lado, lado1);
                    Console.WriteLine("El area del triangulo es de: {0}", resultado);
                    break;
                case 3:
                    Console.WriteLine("Ingrese el radio: ");
                    Double.TryParse(Console.ReadLine(), out radio);

                    resultado = CalculoDeArea.CalcularCirculo(radio);
                    Console.WriteLine("El area del circulo es de: {0}", resultado);
                    break;
                case 4:
                    Console.WriteLine("Presione cualquier tecla para salir...");
                    break;


            }
            Console.ReadKey();
        }
    }
}
