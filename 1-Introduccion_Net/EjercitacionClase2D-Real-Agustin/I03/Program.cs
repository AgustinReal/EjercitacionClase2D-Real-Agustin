using System;

namespace I03
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            string salir = " ";
            bool validado;

            do
            {
                Console.WriteLine("Ingrese un numero: \n");

                validado = ValidarNumero(out numeroIngresado);

                if (validado && numeroIngresado > 0)
                {
                    for (int i = numeroIngresado; i > 0; i--)
                    {
                        if (EsPrimo(i))
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error no es un numero...");
                    Console.BackgroundColor = ConsoleColor.Black;
                }

                Console.WriteLine("\nsi desea terminar el programa, escriba salir: ");
                salir = Console.ReadLine();

            } while (salir != "salir");

            Environment.Exit(0);
        }

        public static bool ValidarNumero(out int numero)
        {
            return int.TryParse(Console.ReadLine(), out numero);
        }
        public static bool EsPrimo(int numero)
        {
            if (numero == 0 || numero == 1 || numero == 4)
            {
                return false;

            }
            for (int i = 2; i < numero / 2; i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
