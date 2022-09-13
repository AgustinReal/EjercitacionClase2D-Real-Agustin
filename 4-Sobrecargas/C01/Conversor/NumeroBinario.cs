using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor
{
    public class NumeroBinario
    {
        private string numeroBinario;

        private NumeroBinario(string numero)
        {
            this.numeroBinario = numero;
        }

        public string numeroBin
        {
            get
            {
                return numeroBinario;
            }
        }

        public static string operator +(NumeroBinario b, NumeroDecimal d)
        {
            double aux = ((NumeroDecimal)b).numeroDec + d.numeroDec;
            return Conversor.ConvertirDecimalABinario(aux);
        }

        public static string operator -(NumeroBinario b, NumeroDecimal d)
        {
            double aux = ((NumeroDecimal)b).numeroDec - d.numeroDec;
            return Conversor.ConvertirDecimalABinario(aux);
        }

        public static bool operator ==(NumeroBinario b, NumeroDecimal d)
        {
            return b.numeroBin == ((NumeroBinario)d).numeroBin;
        }

        public static bool operator !=(NumeroBinario b, NumeroDecimal d)
        {
            return !(b == d);
        }

        public static implicit operator NumeroBinario(string numero)
        {
            return new NumeroBinario(numero);
        }

        public static explicit operator string(NumeroBinario numero)
        {
            return numero.numeroBin;
        }
        
        public static explicit operator NumeroDecimal(NumeroBinario numero)
        {
            return (NumeroDecimal)Conversor.ConvertirBinarioADecimal(Convert.ToDouble(numero.numeroBin));
        }
    }
}
