using System;
using Conversor;

namespace Ejercicio_Sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            NumeroBinario numeroBin = "1000";
            NumeroDecimal numeroDec = 4;

            Console.WriteLine($"El numero binario: {numeroBin.numeroBin} y el otro numero decimal es: {numeroDec.numeroDec}");
            Console.WriteLine($"La suma es: {numeroBin + numeroDec}");
            Console.WriteLine($"La resta es: {numeroBin - numeroDec}");

            Console.WriteLine($"El numero decimal: {numeroDec.numeroDec} y el otro numero binario es: {numeroBin.numeroBin}");
            Console.WriteLine($"La suma es: {numeroDec + numeroBin}");
            Console.WriteLine($"La resta es: {numeroDec - numeroBin}");

            Console.WriteLine($"Son igaules: {numeroDec == numeroBin}");
        }
    }
}
