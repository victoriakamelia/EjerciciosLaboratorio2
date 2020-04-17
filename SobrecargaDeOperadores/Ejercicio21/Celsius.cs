using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio21
{
     class Celsius
    {
        private double cantidad;

        public Celsius(double cantidad)
        {
            this.cantidad = Math.Round(cantidad);
        }


        public double GetCantidad()
        {
            return Math.Round(this.cantidad);
        }

        public static explicit operator Fahrenheit(Celsius gradosCelsius)
        {
            double resultado = (gradosCelsius.GetCantidad() * (9.0f / 5.0f) + 32.0f);

            return new Fahrenheit(Math.Round(resultado));
        }

        public static explicit operator Kelvin(Celsius gradosCelsius)
        {

            double auxiliar = ((Fahrenheit)gradosCelsius).GetCantidad();
            double resultado = (auxiliar + 459.670f) * (5.0f / 9.0f);

            return new Kelvin(Math.Round(resultado));
        }

        public static implicit operator Celsius(double cantidad)
        {
            return new Celsius(Math.Round(cantidad));
        }
        public static bool operator ==(Celsius gradosCelsius, Fahrenheit gradosFahrenheit)
        {
            return (gradosFahrenheit == gradosCelsius);
        }
        public static bool operator !=(Celsius gradosCelsius, Fahrenheit gradosFahrenheit)
        {
            return !(gradosFahrenheit == gradosCelsius);
        }

        public static bool operator ==(Celsius gradosCelsius, Kelvin gradosKelvin)
        {
            return (gradosKelvin == gradosCelsius);
        }
        public static bool operator !=(Celsius gradosCelsius, Kelvin gradosKelvin)
        {
            return !(gradosCelsius == gradosKelvin);
        }


        public static Celsius operator +(Celsius gradosCelsius, Kelvin gradosKelvin)
        {
            return new Celsius(gradosCelsius.GetCantidad() + ((Celsius)gradosKelvin).GetCantidad());

        }

        public static Celsius operator +(Celsius gradosCelsius, Fahrenheit gradosFahrenheit)
        {
            return new Celsius(gradosCelsius.GetCantidad() + ((Celsius)gradosFahrenheit).GetCantidad());

        }

        public static Celsius operator -(Celsius gradosCelsius, Kelvin gradosKelvin)
        {
            return new Celsius(gradosCelsius.GetCantidad() - ((Celsius)gradosKelvin).GetCantidad());

        }

        public static Celsius operator -(Celsius gradosCelsius, Fahrenheit gradosFahrenheit)
        {
            return new Celsius(gradosCelsius.GetCantidad() - ((Celsius)gradosFahrenheit).GetCantidad());

        }


    }
}
