using System;
using Biblioteca;

namespace Ejercicios_Encapsulamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro = new Libro();
            libro[0] = "Star wars I";
            libro[1] = "Star wars II";

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(libro[i]);
            }

            libro[1] = "Star wars III";

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(libro[i]);
            }
        }
    }
}
