using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio22
{
    public class Conversor
    {
        public static string DecimalBinario(double numero)
        {
            int auxInt=Convert.ToInt32(numero);
            string retorno = Convert.ToString(auxInt, 2);
            Convert.ToInt32(numero);
            return retorno;
        }

        public static double BinarioDecimal(string numero)
        {
            double retorno = Convert.ToInt32(numero, 2);
            return retorno;

        }
    }
}
