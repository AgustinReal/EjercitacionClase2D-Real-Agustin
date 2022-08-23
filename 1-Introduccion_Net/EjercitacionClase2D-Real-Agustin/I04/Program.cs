using System;

namespace I04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        static double numerosPerfectos(double numero)
        {
            numero = Math.Pow(2, (numero - 1)) * (Math.Pow(2, numero) - 1);

            return numero;
        }
    }
}
