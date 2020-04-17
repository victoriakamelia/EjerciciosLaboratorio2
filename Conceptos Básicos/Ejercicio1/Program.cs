using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string entradaNumero;
            int acumulador = 0;
            int minimo = 0;
            int maximo = 0;

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                entradaNumero = Console.ReadLine();

                bool esNumero = Int32.TryParse(entradaNumero, out numero);

                if(esNumero)
                {
                    acumulador = numero + acumulador; 
                    if(i==0)
                    {
                        minimo = numero;
                        maximo = numero;
                    }else if(numero > maximo)
                    {
                        maximo = numero;
                    }else if (numero < minimo)
                    {
                        minimo = numero;
                    }
                }
            }
            
            Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * * * ");
            Console.WriteLine("El mayor numero ingresado fue : {0}", maximo);
            Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * * * ");
            Console.WriteLine("El menor numero ingresado fue : {0}", minimo);
            Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * * * ");
            Console.WriteLine("El promedio de los numeros ingresados fue : {0}", acumulador/5);
            Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * * * ");
            Console.ReadLine();
        }
    }
}
