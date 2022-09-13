using System;

namespace Convertir
{
    public class Celsius
    {
        private double temperaturaCelsius;

        public Celsius(double tempCelsius)
        {
            this.temperaturaCelsius = tempCelsius;
        }

        public double temperaturaCel
        {
            get
            {
                return this.temperaturaCelsius;
            }
        }

        public static explicit operator Fahrenheit(Celsius temperatura)
        {
            return new Fahrenheit(temperatura.temperaturaCel * 9 / 5 + 32);
        }

        public static implicit operator Celsius(double temperatura)
        {
            return new Celsius(temperatura);
        }

        public static explicit operator Kelvin(Celsius temperatura)
        {
            return new Kelvin(temperatura.temperaturaCelsius + 273.15)
        }
    }
}
