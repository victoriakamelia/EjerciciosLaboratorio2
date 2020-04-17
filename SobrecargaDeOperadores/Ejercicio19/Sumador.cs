using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    class Sumador
    {
        private int cantidadSumas;

        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        public Sumador()
            :this (0)
        {          
        }
        
        public long Sumar(long numero1, long numero2)          
        {
            long retorno = numero1 + numero2;
            this.cantidadSumas++;
            return retorno;
        }

        public string Sumar(string String1, string String2)
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendFormat(String1);
            retorno.AppendFormat(String2);
            this.cantidadSumas++;
            return retorno.ToString();
        }

        public static explicit operator int (Sumador unSumador)
        {
            return unSumador.cantidadSumas; 
        }

        public static long operator +(Sumador s1, Sumador s2)
        {
            return (s1.cantidadSumas + s2.cantidadSumas);
        }

        public static bool operator |(Sumador s1, Sumador s2)
        {
            if (s1.cantidadSumas == s2.cantidadSumas)
            {
                return true;
            }else
            {
                return false;
            }
        }
    }
}
