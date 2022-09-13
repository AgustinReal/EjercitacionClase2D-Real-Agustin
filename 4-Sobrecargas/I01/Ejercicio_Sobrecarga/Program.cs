using System;
using Sumador;

namespace Ejercicio_Sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {

            Sumador.Sumador sumaUno = new Sumador.Sumador();
            Sumador.Sumador sumaDos = new Sumador.Sumador();

            Console.WriteLine(sumaUno.Sumar(23, 2));
            Console.WriteLine(sumaUno.Sumar("JAHA", " are you Okey?" + "\n\n") );
            Console.WriteLine(sumaUno.Sumar(4, 2));

            sumaDos.Sumar(24,5);
            sumaDos.Sumar("Agua", "en tu oyo");

            Console.WriteLine(("La cantidad suma que tiene Suma 1 es: " + (int)sumaUno));
            Console.WriteLine(("\n\nLa cantidad suma que tiene Suma 2 es: " + (int)sumaDos));
            Console.WriteLine("\n\nLa acumulacion total de las 2 operaciones es :" + ( sumaUno + sumaDos ) );
            Console.WriteLine("\n\nLas sumas poseen el mismo valor: " + (sumaUno | sumaDos));


        }
    }
}
