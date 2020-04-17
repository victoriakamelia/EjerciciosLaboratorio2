using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio22
{
    public class NumeroDecimal
    {
        private double numero;

        private NumeroDecimal(double unNumero)
        {
            this.numero = unNumero;
        }

        public double GetNumero()
        {
               return this.numero;
       
        }
        public static implicit operator NumeroDecimal(double unNumero)
        {
                return new NumeroDecimal(unNumero);
        }

        public static explicit operator NumeroDecimal(NumeroBinario unBinario)
        {
           double auxBinario = Conversor.BinarioDecimal(unBinario.GetNumero());
           return new NumeroDecimal(auxBinario);
        }

        public static double operator +(NumeroDecimal unDecimal, NumeroBinario unBinario)
        {
            
            return (unDecimal.GetNumero() + ((NumeroDecimal)unBinario).GetNumero());

        }

        public static double operator -(NumeroDecimal unDecimal, NumeroBinario unBinario)
        {

            return (unDecimal.GetNumero() - ((NumeroDecimal)unBinario).GetNumero());

        }

        public static bool operator ==(NumeroDecimal unDecimal, NumeroBinario unBinario)
        {

            return (unDecimal.GetNumero() == ((NumeroDecimal)unBinario).GetNumero());

        }

        public static bool operator !=(NumeroDecimal unDecimal, NumeroBinario unBinario)
        {

            return !(unDecimal == unBinario);

        }



    }
}
