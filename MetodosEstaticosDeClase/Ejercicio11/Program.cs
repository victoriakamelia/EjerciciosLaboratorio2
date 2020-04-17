using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int minimo=default;
            int maximo=default;
            int acumulador=0;
            bool esNumerico, esValido;
           

            for(int i = 0; i<10; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                esNumerico = Int32.TryParse(Console.ReadLine(), out numero);
                esValido = Validacion.Validar(numero, -100, 100);
                
                while (!esNumerico || !esValido)
                {
                    Console.WriteLine("Ingrese valor unicamente numerico entre -100 y 100: ");
                    esNumerico= Int32.TryParse(Console.ReadLine(), out numero);
                    esValido = Validacion.Validar(numero, -100, 100);
                }



                if (i==0)
                {
                    minimo = numero;
                    maximo = numero; 
                }

                acumulador = acumulador + numero;
                if (numero<minimo)
                {
                    minimo = numero;
                }
                if (numero > maximo)
                {
                    maximo = numero;
                }

            }

            Console.WriteLine("El valor minimo ingresado fue: {0}", minimo);
            Console.WriteLine("El valor maximo ingresado fue: {0}",maximo);
            Console.WriteLine("El promedio de los numeros ingresados fue: {0}", acumulador/10);
            Console.ReadKey();
        }
    }
}
