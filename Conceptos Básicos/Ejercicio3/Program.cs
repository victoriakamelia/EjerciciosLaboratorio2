using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            Console.WriteLine("Ingrese un numero: ");
            int num = Convert.ToInt32(Console.ReadLine());
            

            for (int i = 2; i <= num; i++)
            {
                for(int j=2; j <= i; j++)
                {   
                    if(i%j == 0)
                    {
                        contador++;                                     
                    }                
                }
                if (contador == 1)
                {
                    Console.WriteLine("{0} - ", i);
                }
                contador = 0;
            }
               
            Console.ReadKey();
        }
    }
}
