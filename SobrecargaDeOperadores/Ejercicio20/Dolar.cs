using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Billetes
{
    class Dolar
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Dolar()
        {
            cotizRespectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, double cotizacion)
            : this(cantidad)
        {
            cotizRespectoDolar = cotizacion;
        }

        public double getCantidad()
        {
            return this.cantidad;
        }

        public static double getCotizacion()
        {
            return cotizRespectoDolar;
        }
        public static explicit operator Peso(Dolar d)
        {
            Peso retorno = new Peso(d.cantidad * Peso.getCotizacion());
            return retorno;
        }

        public static explicit operator Euro(Dolar d)
        {
            Euro retorno = new Euro(d.cantidad * Euro.getCotizacion());
            return retorno;
        }

        public static implicit operator Dolar(double d)
        {
            Dolar retorno = new Dolar(d);
            return retorno;
        }

        public static bool operator ==(Dolar d, Euro e)
        {
            return ((Dolar)d.cantidad == (Dolar)e.getCantidad());
         
        }

        public static bool operator !=(Dolar d, Euro e)
        {
            return !((Dolar)d.cantidad == (Dolar)e.getCantidad());
        }

        public static bool operator ==(Dolar d, Peso p)
        {
            return ((Dolar)d.cantidad == (Dolar)p.getCantidad());

        }

        public static bool operator !=(Dolar d, Peso p)
        {
            return !((Dolar)d.cantidad == (Dolar)p.getCantidad());
        }

        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return (d1.cantidad == d2.cantidad);

        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1.cantidad == d2.cantidad);
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            Dolar auxEuroaDolar = (Dolar)e;
            double resultado =d.getCantidad() - auxEuroaDolar.getCantidad();

            Dolar retorno = new Dolar(resultado);
            return retorno;

        }

        public static Dolar operator +(Dolar d, Euro e)
        {
            Dolar auxEuroaDolar = (Dolar)e;
            double resultado = d.getCantidad() + auxEuroaDolar.cantidad;

            Dolar retorno = new Dolar(resultado);
            return retorno;

        }

        public static Dolar operator -(Dolar d, Peso p)
        {
            Dolar auxPesoaDolar = (Dolar)p;
            double resultado = d.getCantidad() - auxPesoaDolar.getCantidad();

            Dolar retorno = new Dolar(resultado);
            return retorno;

        }

        public static Dolar operator +(Dolar d, Peso p)
        {
            Dolar auxPesoaDolar = (Dolar)p;
            double resultado = d.getCantidad() + auxPesoaDolar.getCantidad();

            Dolar retorno = new Dolar(resultado);
            return retorno;

        }


    }
}
