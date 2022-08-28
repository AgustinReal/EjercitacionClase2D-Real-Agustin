using System;

namespace Ejercicio_OrientadoObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Boligrafo.Boligrafo boligrafoAzul = new Boligrafo.Boligrafo(100, ConsoleColor.Blue);
            Boligrafo.Boligrafo boligrafoRojo = new Boligrafo.Boligrafo(50, ConsoleColor.Red);

            boligrafoAzul.Pintar(-75, out string dibujo);
            Console.WriteLine(dibujo);
            Console.WriteLine($"Tinta Disponible: {boligrafoAzul.GetTinta()}\n\n");

            boligrafoRojo.Pintar(-30, out dibujo);
            Console.WriteLine(dibujo);
            Console.WriteLine($"Tinta Disponible: {boligrafoRojo.GetTinta()}");

        }
    }
}
