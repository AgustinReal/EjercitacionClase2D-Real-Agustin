using System;

namespace I06
{
    class Program
    {
        static void Main(string[] args)
        {
            int anioInicial;
            int anioFinal;

            Console.WriteLine("Ingrese el anio inicial: ");
            int.TryParse(Console.ReadLine(), out anioInicial);

            Console.WriteLine("Ingrese el anio Final: ");
            int.TryParse(Console.ReadLine(), out anioFinal);

            Console.WriteLine($"Los anios bisiestos desde {anioInicial} hasta {anioFinal} son: ");

            //recorremos del anio inical hasta el anio final ingresados.
            for (int i = anioInicial; i <= anioFinal; i++)
            {
                if ((i % 4 == 0 && i % 100 == 0 && i % 400 == 0) || (i % 4 == 0 && i % 100 != 0))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
