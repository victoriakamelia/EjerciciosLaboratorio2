using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Billetes
{
    class Peso
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Peso()
        {
            cotizRespectoDolar = 38.33;
        }

        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Peso(double cantidad, double cotizacion)
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

        public static explicit operator Dolar(Peso p)
        {
            Dolar retorno = new Dolar((p.cantidad / cotizRespectoDolar));
            return retorno;
        }

  
        public static explicit operator Euro(Peso p)
        {
            Euro retorno = new Euro(((p.cantidad/cotizRespectoDolar) * Euro.getCotizacion()));
            return retorno;
        }

        public static implicit operator Peso(double p)
        {
            Peso retorno = new Peso(p);
            return retorno;
        }

        public static bool operator ==(Peso p, Euro e)
        {
            return ((Dolar)p.cantidad == (Dolar)e.getCantidad());

        }

        public static bool operator !=(Peso p, Euro e)
        {
            return !((Dolar)p.cantidad == (Dolar)e.getCantidad());
        }

        public static bool operator ==(Peso p, Dolar d)
        {
            return !((Dolar)p.cantidad == (Dolar)d.getCantidad());

        }

        public static bool operator !=(Peso p, Dolar d)
        {
            return !((Dolar)p.cantidad == (Dolar)d.getCantidad());
        }

        public static bool operator ==(Peso p1, Peso p2)
        {
            return (p1.cantidad == p2.cantidad);

        }

        public static bool operator !=(Peso p1, Peso p2)
        {
            return !(p1.cantidad == p2.cantidad);
        }

        public static Peso operator -(Peso p, Dolar d)
        {
            Dolar auxPesoaDolar = (Dolar)p;
            double resultado = p.getCantidad() - d.getCantidad();

            Dolar retorno = new Dolar(resultado);
            return (Peso)retorno;

        }

        public static Peso operator +(Peso p, Dolar d)
        {
            Dolar auxPesoaDolar = (Dolar)p;
            double resultado = auxPesoaDolar.getCantidad() + d.getCantidad();

            Dolar retorno = new Dolar(resultado);
            return (Peso)retorno;

        }

        public static Peso operator -(Peso p, Euro e)
        {
            Dolar auxPesoaDolar = (Dolar)p;
            Dolar auxEuroaDolar = (Dolar)e;
            double resultado = auxPesoaDolar.getCantidad() - auxEuroaDolar.getCantidad();

            Dolar retorno = new Dolar(resultado);
            return (Peso)retorno;

        }

        public static Peso operator +(Peso p, Euro e)
        {
            Dolar auxPesoaDolar = (Dolar)p;
            Dolar auxEuroaDolar = (Dolar)e;
            double resultado = auxPesoaDolar.getCantidad() + auxEuroaDolar.getCantidad();

            Dolar retorno = new Dolar(resultado);
            return (Peso)retorno;

        }

    }
}
