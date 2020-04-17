using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    class CalculoDeArea
    {
        public static double CalcularCuadrado(double numero)
        {
            double area = numero * numero;
            return area;
        }

        public static double CalcularTriangulo(double numero1, double numero2)
        {
            double area = (numero1 * numero2) / 2;
            return area;
        }

        public static double CalcularCirculo(double numero)
        {
            double area = (numero * numero) * (Math.PI);
            return area;
        }

    }
}
