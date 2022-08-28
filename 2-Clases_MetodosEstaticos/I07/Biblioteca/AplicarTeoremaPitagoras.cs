using System;

namespace Biblioteca
{
    public class AplicarTeoremaPitagoras
    {
        public static double CalcularPitagoras(double altura, double UnaBase)
        {
            double resultado = 0;
            double suma;

            if(altura>0 && UnaBase>0)
            {
                altura = Math.Pow(altura, 2);

                UnaBase = Math.Pow(UnaBase, 2);

                suma = altura + UnaBase;

                resultado = Math.Sqrt(suma);
            }
            return resultado;
        }
    }
}
