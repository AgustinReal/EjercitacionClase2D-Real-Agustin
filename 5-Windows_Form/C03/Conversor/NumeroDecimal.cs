using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor
{
     public class NumeroDecimal
    {
        private double numeroDecimal;

        private NumeroDecimal(double numero)
        {
            this.numeroDecimal = numero;
        }    
        
        public double numeroDec
        {
            get
            {
                return numeroDecimal;
            }
        }

        public static double operator +(NumeroDecimal d, NumeroBinario b)
        {
            return d.numeroDecimal + ((NumeroDecimal)b).numeroDecimal;
        }

        public static double operator -(NumeroDecimal d, NumeroBinario b)
        {
            return d.numeroDecimal - ((NumeroDecimal)b).numeroDec;
        }        

        public static bool operator ==(NumeroDecimal d, NumeroBinario b)
        {
            return d.numeroDecimal == ((NumeroDecimal)b).numeroDec;
        }

        public static bool operator !=(NumeroDecimal d, NumeroBinario b)
        {
            return !(d == b);
        }

        public static implicit operator NumeroDecimal(double numero)
        {
            return new NumeroDecimal(numero);
        }

        public static explicit operator double(NumeroDecimal numDecimal)
        {
            return numDecimal.numeroDec;
        }

        public static explicit operator NumeroBinario(NumeroDecimal numero)
        {
            return (NumeroBinario)Conversor.ConvertirDecimalABinario(numero.numeroDec);
        }
    }
}
