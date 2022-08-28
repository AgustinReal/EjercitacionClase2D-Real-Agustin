using System;
using Geometria;

namespace Ejercicio_OrientadoObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo rectanguloIngresado = new Rectangulo(new Punto(4, 3), new Punto(8, 9));

            Console.WriteLine($"El area del rectangulo es: {rectanguloIngresado.GetArea()}");

            Console.WriteLine($"El perimetro del rectangulo es: {rectanguloIngresado.GetPerimetro()}");

        }
        
       
    }
}
