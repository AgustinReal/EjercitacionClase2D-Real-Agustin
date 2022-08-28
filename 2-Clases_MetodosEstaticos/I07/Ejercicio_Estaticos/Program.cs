using System;
using Biblioteca;

namespace Ejercicio_Estaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            double alturaIngresada;
            double baseIngresada;
            double resultadoCalculado;

            Console.WriteLine("Ingrese la altura del trinagulo: ");

            while(double.TryParse(Console.ReadLine(), out alturaIngresada) == false)
            {
                Console.WriteLine("Error. Ingrese la altura del trinagulo: ");
            }

            Console.WriteLine("Ingrese la base del trinagulo: ");

            while (double.TryParse(Console.ReadLine(), out baseIngresada) == false)
            {
                Console.WriteLine("Error. Ingrese la base del trinagulo: ");
            }

            resultadoCalculado  = AplicarTeoremaPitagoras.CalcularPitagoras(alturaIngresada, baseIngresada);

            Console.WriteLine($"El resultado es: {resultadoCalculado:N2}"+" cm");
        }
    }
}
