using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class Conversor
    {
        public static string DecimalBinario(int numero)
        {
            string retorno= Convert.ToString(numero, 2);
            return retorno;
        }

        public static int BinarioDecimal(string numero)
        {
            int retorno = Convert.ToInt32(numero, 2);
            return retorno;

        }
    }
}
