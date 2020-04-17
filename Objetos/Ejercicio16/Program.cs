using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {

            Alumno alumno1 = new Alumno();
            Alumno alumno2 = new Alumno();
            Alumno alumno3 = new Alumno();

            alumno1.apellido = "Juan Uno";
            alumno2.apellido = "Juan Dos";
            alumno3.apellido = "Juan Tres";

            alumno1.legajo = 001;
            alumno2.legajo = 002;
            alumno3.legajo = 003;

            alumno1.Estudiar(1, 3);
            alumno2.Estudiar(8, 7);
            alumno3.Estudiar(10, 10);

            Console.WriteLine(alumno1.Mostrar());
            Console.WriteLine(alumno2.Mostrar());
            Console.WriteLine(alumno3.Mostrar());


            Console.ReadKey();


        }
    }
}
