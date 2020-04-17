using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio21
{
    class Fahrenheit
    {
        private double cantidad;

        #region Constructores
        public Fahrenheit(double cantidad)
        {
            this.cantidad = Math.Round(cantidad);
        }

        #endregion

        #region Getters
        public double GetCantidad()
        {
            return Math.Round(this.cantidad);
        }

        #endregion

        #region Conversiones Explícitas
        public static explicit operator Celsius(Fahrenheit gradosFahrenheit)
        {
            double resultado = (gradosFahrenheit.GetCantidad() - 32.0f) * (5.0f / 9.0f);

            return new Celsius(Math.Round(resultado));
        }

        public static explicit operator Kelvin(Fahrenheit gradosFahrenheit)
        {
            double resultado = (gradosFahrenheit.GetCantidad() + 459.67f) * (5.0f / 9.0f);

            return new Kelvin(Math.Round(resultado));
        }
        #endregion

        #region Conversiones Implícitas
        public static implicit operator Fahrenheit(double cantidad)
        {
            return new Fahrenheit(Math.Round(cantidad));
        }
        #endregion

        #region Sobrecarga Operadores
        public static bool  operator ==(Fahrenheit gradosFahrenheit, Celsius gradosCelsius)
         {
            return (gradosFahrenheit.GetCantidad() == ((Fahrenheit)gradosCelsius).GetCantidad());
         }

        public static bool operator !=(Fahrenheit gradosFahrenheit, Celsius gradosCelsius)
        {
            return !(gradosFahrenheit == gradosCelsius);
        }

        public static bool operator ==(Fahrenheit gradosFahrenheit, Kelvin gradosKelvin)
        {
            return (gradosFahrenheit.GetCantidad() == ((Fahrenheit)gradosKelvin).GetCantidad());
        }

        public static bool operator !=(Fahrenheit gradosFahrenheit, Kelvin gradosKelvin)
        {
            return !(gradosFahrenheit == gradosKelvin);
        }

        public static Fahrenheit operator +(Fahrenheit gradosFahrenheit, Kelvin gradosKelvin)
        {
            return new Fahrenheit(gradosFahrenheit.GetCantidad() + ((Fahrenheit)gradosKelvin).GetCantidad());

        }

        public static Fahrenheit operator +(Fahrenheit gradosFahrenheit, Celsius gradosCelsius)
        {
            return new Fahrenheit(gradosFahrenheit.GetCantidad() + ((Fahrenheit)gradosCelsius).GetCantidad());

        }

        public static Fahrenheit operator -(Fahrenheit gradosFahrenheit, Kelvin gradosKelvin)
        {
            return new Fahrenheit(gradosFahrenheit.GetCantidad() - ((Fahrenheit)gradosKelvin).GetCantidad());

        }

        public static Fahrenheit operator -(Fahrenheit gradosFahrenheit, Celsius gradosCelsius)
        {
            return new Fahrenheit(gradosFahrenheit.GetCantidad() - ((Fahrenheit)gradosCelsius).GetCantidad());

        }
        #endregion

    }
}
