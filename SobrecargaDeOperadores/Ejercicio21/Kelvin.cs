using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio21
{
    class Kelvin
    {
        private double cantidad;

        public Kelvin(double cantidad)
        {
            this.cantidad = Math.Round(cantidad);
        }


        public double GetCantidad()
        {
            return Math.Round(this.cantidad);
        }

        public static explicit operator Celsius(Kelvin gradosKelvin)
        {
            double auxiliar = ((Fahrenheit)gradosKelvin).GetCantidad();
            double resultado = (auxiliar - 32.0f) * (5.0f / 9.0f);

            return new Celsius(Math.Round(resultado));
        }

        public static explicit operator Fahrenheit(Kelvin gradosKelvin)
        {
            double resultado = gradosKelvin.GetCantidad() * (9.0f/5.0f) -459.67f;

            return new Fahrenheit(Math.Round(resultado));
        }

        public static implicit operator Kelvin(double cantidad)
        {
            return new Kelvin(Math.Round(cantidad));
        }

        public static bool operator ==(Kelvin gradosKelvin, Fahrenheit gradosFahrenheit)
        {
            return (gradosFahrenheit == gradosKelvin);
        }

        public static bool operator !=(Kelvin gradosKelvin, Fahrenheit gradosFahrenheit)
        {
            return !(gradosFahrenheit == gradosKelvin);
        }

        public static bool operator ==(Kelvin gradosKelvin, Celsius gradosCelsius)
        {
            return (gradosKelvin.GetCantidad() == ((Kelvin)gradosCelsius).GetCantidad());
        }

        public static bool operator !=(Kelvin gradosKelvin, Celsius gradosCelsius)
        {
            return !(gradosKelvin == gradosCelsius);
        }

        public static Kelvin operator +(Kelvin gradosKelvin, Fahrenheit gradosFahrenheit)
        {
            return new Kelvin(gradosKelvin.GetCantidad() + ((Kelvin)gradosFahrenheit).GetCantidad());

        }

        public static Kelvin operator +(Kelvin gradosKelvin, Celsius gradosCelsius)
        {
            return new Kelvin(gradosKelvin.GetCantidad() + ((Kelvin)gradosCelsius).GetCantidad());

        }

        public static Kelvin operator -(Kelvin gradosKelvin, Fahrenheit gradosFahrenheit)
        {
            return new Kelvin(gradosKelvin.GetCantidad() - ((Kelvin)gradosFahrenheit).GetCantidad());

        }

        public static Kelvin operator -(Kelvin gradosKelvin, Celsius gradosCelsius)
        {
            return new Kelvin(gradosKelvin.GetCantidad() - ((Kelvin)gradosCelsius).GetCantidad());

        }

    }


}
