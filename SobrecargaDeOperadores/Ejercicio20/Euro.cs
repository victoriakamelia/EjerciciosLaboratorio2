using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    class Euro
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Euro()
        {

            cotizRespectoDolar = 1.16;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizacion)
            : this(cantidad)
        {
            cotizRespectoDolar = cantidad;
        }

        public double getCantidad()
        {
            return this.cantidad;
        }

        public static double getCotizacion()
        {
            return cotizRespectoDolar;
        }

        public static explicit operator Dolar(Euro e)
        {
            Dolar retorno = new Dolar((e.cantidad / cotizRespectoDolar));
            return retorno;
        }

        public static explicit operator Peso(Euro e)
        {
            Peso retorno = new Peso((e.cantidad / cotizRespectoDolar) * Peso.getCotizacion());
            return retorno;
        }

        public static implicit operator Euro(double e)
        {
            Euro retorno = new Euro(e);
            return retorno;
        }
        public static bool operator ==(Euro e, Peso p)
        {
            return ((Dolar)e.cantidad == (Dolar)p.getCantidad());

        }

        public static bool operator !=(Euro e, Peso p)
        {
            return !((Dolar)e.cantidad == (Dolar)p.getCantidad());
        }

        public static bool operator ==(Euro e, Dolar d)
        {
            return !((Dolar)e.cantidad == (Dolar)d.getCantidad());

        }

        public static bool operator !=(Euro e, Dolar d)
        {
            return !((Dolar)e.cantidad == (Dolar)d.getCantidad());
        }

        public static bool operator ==(Euro e1, Euro e2)
        {
            return (e1.cantidad == e2.cantidad);

        }

        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1.cantidad == e2.cantidad);
        }

        public static Euro operator -(Euro e, Dolar d)
        {
            Dolar auxEurooaDolar = (Dolar)e;
            double resultado = auxEurooaDolar.getCantidad() - d.getCantidad();

            Dolar retorno = new Dolar(resultado);
            return (Euro)retorno;

        }

        public static Euro operator +(Euro e, Dolar d)
        {
            Dolar auxEurooaDolar = (Dolar)e;
            double resultado = auxEurooaDolar.getCantidad() + d.getCantidad();

            Dolar retorno = new Dolar(resultado);
            return (Euro)retorno;

        }

        public static Euro operator -(Euro e, Peso p)
        {
            Dolar auxEuroaDolar = (Dolar)e;
            Dolar auxPesoaDolar = (Dolar)p;
            double resultado = auxPesoaDolar.getCantidad() - auxEuroaDolar.getCantidad();

            Dolar retorno = new Dolar(resultado);
            return (Euro)retorno;

        }

        public static Euro operator +(Euro e, Peso p)
        {
            Dolar auxEuroaDolar = (Dolar)e;
            Dolar auxPesoaDolar = (Dolar)p;
            double resultado = auxPesoaDolar.getCantidad() + auxEuroaDolar.getCantidad();

            Dolar retorno = new Dolar(resultado);
            return (Euro)retorno;

        }


    }
}
