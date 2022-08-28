using System;
using System.Text.RegularExpressions;
using Biblioteca;

namespace Ejercicio_Estaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal numeroIngresadoUno;
            decimal numeroIngresadoDos;
            string operacion;
            decimal resultado;
            string salir = "";

            do
            {
                Console.WriteLine("Ingrese el numero uno: ");
                decimal.TryParse(Console.ReadLine(), out numeroIngresadoUno);

                Console.WriteLine("Ingrese el numero dos: ");
                decimal.TryParse(Console.ReadLine(), out numeroIngresadoDos);

                Console.WriteLine("Ingrese una operacion (+, -, /, *): ");
                operacion = Console.ReadLine();

                if(Regex.IsMatch(operacion, @"^[+*/ \\-]$"))
                {
                    resultado = Calculadora.Calcular(numeroIngresadoUno, numeroIngresadoDos, operacion);

                    if (operacion == "/" && numeroIngresadoDos == 0)
                    {
                        Console.WriteLine("\nNo se puede dividir por 0...");
                    }
                    else
                    {
                        operacion = Calculadora.aplicarSignoMatematico(operacion);
                        Console.WriteLine($"\nLa operacion que eligio fue {operacion} y el resultado es: {resultado:N2}");
                    }
                }
                else
                {
                    Console.WriteLine("\nError. Solo se puede ingresar una operacion (+, -, /, *): ");
                }

                Console.WriteLine("\nDeseas salir del menu s/n: ");
                salir = Console.ReadLine();       

            } while(Calculadora.Salir(salir));
        }
    }
}
