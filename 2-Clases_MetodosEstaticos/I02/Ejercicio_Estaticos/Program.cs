using System;
using Validacion;

namespace Ejercicio_Estaticos
{
//    Consigna
//Realizar un programa que sume números enteros hasta que el usuario lo determine por medio de un mensaje
//"¿Desea continuar? (S/N)".

//Crear la clase Validador y el método estático ValidarRespuesta, que validará el ingreso de respuestas.

//El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si
//se ingresó cualquier otro valor.
    class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int acumuladorNumerosIngresados = 0;
            string respuesta = " ";

            do
            {
                Console.WriteLine("Ingrese un numero: ");
 
                while(int.TryParse(Console.ReadLine(), out numeroIngresado)==false)
                {
                    Console.WriteLine("Error. Ingrese un numero: ");
                }

                acumuladorNumerosIngresados += numeroIngresado;

                Console.WriteLine("Desea continuar (s/n): ");
                respuesta = Console.ReadLine();

            } while(Validar.ValidarRespuesta(respuesta));

            Console.WriteLine($"La suma de los numeros ingresados es: {acumuladorNumerosIngresados}");
        }
    }
}
