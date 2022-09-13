using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertir
{
    public class Fahrenheit
    {
        private double tempaturaFahrenheit;

        public Fahrenheit(double tempFahrenheit)
        {
            this.tempaturaFahrenheit = tempFahrenheit;
        }

        public double temperaturaFahren
        {
            get
            {
                return this.tempaturaFahrenheit;
            }
            set
            {
                tempaturaFahrenheit = value;
            }
        }

        public static implicit operator Fahrenheit(double temperatura)
        {
            return new Fahrenheit(temperatura);
        }

        public static explicit operator Celsius(Fahrenheit temperatura)
        {
            return new Celsius((temperatura.tempaturaFahrenheit - 32) * 5/9);
        }

        public static explicit operator Kelvin(Fahrenheit temperatura)
        {
            return new Kelvin((temperatura.temperaturaFahren - 32) * 5/9 + 273.15);
        }
    }
}
