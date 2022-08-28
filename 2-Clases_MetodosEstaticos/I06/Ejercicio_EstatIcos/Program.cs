using System;
using Biblioteca;

namespace Ejercicio_EstatIcos
{
    class Program
    {
        static void Main(string[] args)
        {
            double areaCuadradoIngresada;
            double baseIngresada;
            double alturaIngresada;
            double radioIngresado;

            Console.WriteLine("Ingrese un lado del cuadrado para calcular el area: ");

            while(double.TryParse(Console.ReadLine(), out areaCuadradoIngresada) ==false)
            {
                Console.WriteLine("Error. Ingrese un lado del cuadrado para calcular el area: ");
            }

            areaCuadradoIngresada = CalculadoraDeArea.CalcularAreaCuadrado(areaCuadradoIngresada);

            Console.WriteLine($"\nEl area del cuadrado es: {areaCuadradoIngresada}\n\n");

            Console.WriteLine("Ingrese la altura del triangulo para calcular el area: ");

            while (double.TryParse(Console.ReadLine(), out alturaIngresada) == false)
            {
                Console.WriteLine("Error. Ingrese la altura del triangulo para calcular el area: ");
            }

            Console.WriteLine("Ingrese la base del triangulo para calcular el area: ");

            while (double.TryParse(Console.ReadLine(), out baseIngresada) == false)
            {
                Console.WriteLine("Error. Ingrese la base del triangulo para calcular el area: ");
            }

            baseIngresada = CalculadoraDeArea.CalcularAreaTriangulo(baseIngresada, alturaIngresada);

            Console.WriteLine($"\nEl area del triangulo es: {baseIngresada}\n\n");

            Console.WriteLine("Ingrese el radio del circulo para calcular el area: ");

            while (double.TryParse(Console.ReadLine(), out radioIngresado) == false)
            {
                Console.WriteLine("Error. Ingrese el radio del circulo para calcular el area: ");
            }

            radioIngresado = CalculadoraDeArea.CalcularAreaCirculo(radioIngresado);

            Console.WriteLine($"\nEl area del circulo es: {radioIngresado:N2}\n\n");
        }
    }
}
