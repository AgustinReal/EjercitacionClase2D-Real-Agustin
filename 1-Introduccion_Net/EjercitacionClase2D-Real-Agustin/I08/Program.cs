using System;

namespace I08
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

            trianguloEscalar(alturaIngresada);
        }

        public static void trianguloEscalar(int numero)
        {
            string caracter = " ";

            for (int i = 0; i < numero; i++)
            {
                if (i == 0) // si es 1 solo va *.
                {
                    caracter = "*";
                    Console.WriteLine(caracter);
                }
                else // si es mayor que 1 se le suma 2 (**) por cada numero superior a 1.
                {
                    caracter += "**";
                    Console.WriteLine(caracter);
                }
            }
        }
    }
}
