using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio22
{
    public class NumeroBinario
    {
        private string numero;

        private NumeroBinario(string unNumero)
        {
            this.numero = unNumero;
        }
        public string GetNumero()
        {
            return this.numero;
        }

        public static implicit operator NumeroBinario(string unNumero)
        {
            return new NumeroBinario(unNumero);
        }

        public static explicit operator NumeroBinario(NumeroDecimal unDecimal)
        {
            string auxDecimal = Conversor.DecimalBinario(unDecimal.GetNumero());
            return new NumeroBinario(auxDecimal);
        }

        public static string operator +(NumeroBinario unBinario, NumeroDecimal unDecimal)
        {

            return Conversor.DecimalBinario(unDecimal + unBinario);

        }

        public static string operator -(NumeroBinario unBinario, NumeroDecimal unDecimal)
        {

            return Conversor.DecimalBinario(unDecimal - unBinario);

        }

        public static bool operator ==(NumeroBinario unBinario, NumeroDecimal unDecimal)
        {

            return(unDecimal == unBinario);

        }

        public static bool operator !=(NumeroBinario unBinario, NumeroDecimal unDecimal)
        {

            return !(unDecimal == unBinario);

        }
    }
}
