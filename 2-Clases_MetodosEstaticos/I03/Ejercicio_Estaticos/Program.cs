using System;
using Aplicacion;

namespace Ejercicio_Estaticos
{
    //    Consigna
    //Desarollar una clase llamada Conversor que posea dos métodos de clase(estáticos):

    //El método ConvertirDecimalABinario que convierte un número entero del sistema decimal al sistema binario.

    //public string ConvertirDecimalABinario(int numeroEntero) { }

    //El método ConvertirBinarioADecimal que convierte un número entero del sistema binario al sistema decimal.

    //public int ConvertirBinarioADecimal(int numeroEntero) { }
    class Program
    {
        static void Main(string[] args)
        {

            int numero = 109;


            Console.WriteLine(Conversor.ConvertirDecimalABinario(numero));

            Console.WriteLine(Conversor.ConvertirBinarioADecimal(1101101));
        }
    }
}
