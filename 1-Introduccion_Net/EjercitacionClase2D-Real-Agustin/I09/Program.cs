using System;

namespace I09
{
    class Program
    {
        static void Main(string[] args)
        {
            int alturaIngresada;

            Console.WriteLine("Ingrese la altura del triangulo: ");
            int.TryParse(Console.ReadLine(), out alturaIngresada);

            while (alturaIngresada <= 0)
            {
                Console.WriteLine("Error. Ingrese la altura del triangulo mayor a 0: ");
                int.TryParse(Console.ReadLine(), out alturaIngresada);
            }

            formulaTriangular(alturaIngresada);
        }

        public static void formulaTriangular(int numero)
        {
            for (int i = 1; i < numero + 1; i++)
            {
                for (int j = 1; j <= numero - i; j++)// espacio IZQ
                {
                    Console.Write(" ");
                }
                for (int k = 1; k < i * 2; k++)// MEDIO
                {
                    Console.Write("*");
                }
                Console.WriteLine("");// espacio DER
            }
        }
    }
}
