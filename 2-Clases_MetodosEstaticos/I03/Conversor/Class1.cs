using System;

namespace Aplicacion
{
    public class Conversor
    {
        public static string ConvertirDecimalABinario(int numeroEntero) 
        {
            string numeroConvertido = " ";

            while(numeroEntero>0)
            {

                if(numeroEntero % 2 == 0)
                {
                    numeroConvertido += 0;
                }
                else
                {
                    numeroConvertido += 1;
                }

                numeroEntero /= 2;
            }

            numeroConvertido = InvertirCadena(numeroConvertido);

            return numeroConvertido;
        }

        public static string InvertirCadena(string cadena)
        {
            string cadenaInvertida = "";
            // Recorrer cadena letra por letra
            foreach (char letra in cadena)
            {
                // Anteponer la letra a la cadena invertida
                cadenaInvertida = letra + cadenaInvertida;
            }
            return cadenaInvertida;
        }
        public static int ConvertirBinarioADecimal(int numeroEntero)
        {
            int retorno = 0;
            string stringRecibida = string.Empty + numeroEntero;
            int tam;

            tam = stringRecibida.Length;

            foreach (char caracter in stringRecibida)
            {
                tam--;
                if (caracter == '1')
                {
                    retorno += (int)Math.Pow(2, tam);
                }
            }

            return retorno;
        }
    }
}
