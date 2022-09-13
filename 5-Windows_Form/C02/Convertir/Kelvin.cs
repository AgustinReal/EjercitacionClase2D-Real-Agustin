using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertir
{
    public class Kelvin
    {
        private double temperaturaKelvin;

        public Kelvin(double tempKelvin)
        {
            this.temperaturaKelvin = tempKelvin;
        }

        public double temperaturaKel
        {
            get
            {
                return this.temperaturaKelvin;
            }
        }

        public static implicit operator Kelvin(double temperatura)
        {
            return new Kelvin(temperatura);
        }

        public static explicit operator Celsius(Kelvin temperatura)
        {
            return new Celsius(temperatura.temperaturaKelvin - 273.15);
        }
        public static explicit operator Fahrenheit(Kelvin temperatura)
        {
            return new Fahrenheit(temperatura.temperaturaKelvin * 9/5 - 459.67);
        }
    }
}
