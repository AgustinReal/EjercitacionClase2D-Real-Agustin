using System;
using Formula;

namespace Ejercicio_Estaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;

            Console.WriteLine("Ingrese el numero para calcular su factorial: ");
            int.TryParse(Console.ReadLine(), out numeroIngresado);

            if(numeroIngresado>0)
            {
                numeroIngresado = Class1.factorial(numeroIngresado);

                Console.Write($"\nEl factorial del numero ingresado es: {numeroIngresado}");
            }
            else
            {
                Console.WriteLine("No se puede calcular el factorial de un numero negativo...");
            }
        }
    }
}
