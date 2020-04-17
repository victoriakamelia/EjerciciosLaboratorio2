using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio21
{
    class Program
    {
        static void Main(string[] args)
        {
            Fahrenheit unF = new Fahrenheit(1);
            Celsius unC = new Celsius(-17.22);
            Kelvin unK = new Kelvin(255.92);



            /*
            Console.WriteLine(((Kelvin)unF).GetCantidad());
            Console.WriteLine(((Celsius)unF).GetCantidad());
            Console.WriteLine(unF.GetCantidad());
            Console.ReadKey();

            Console.WriteLine(((Kelvin)unC).GetCantidad());
            Console.WriteLine(((Fahrenheit)unC).GetCantidad());
            Console.WriteLine(unC.GetCantidad());
            Console.ReadKey();


            Console.WriteLine(((Celsius)unK).GetCantidad());
            Console.WriteLine(((Fahrenheit)unK).GetCantidad());
            Console.WriteLine(unK.GetCantidad());*/
            

            Console.WriteLine(unK == unF);
           // Console.WriteLine(unC.GetCantidad());
           // Console.WriteLine(unK.GetCantidad());
           // Console.WriteLine(((Kelvin)unC).GetCantidad());
           // Console.WriteLine(((Celsius)unK).GetCantidad());
            Console.ReadKey();


        }
    }
}
