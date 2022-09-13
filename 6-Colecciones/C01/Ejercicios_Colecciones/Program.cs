using System;
using Futbol;

namespace Ejercicios_Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Jugador jugadorUno = new Jugador(43725055, "Matias", 400, 400);
            Jugador jugadorDos = new Jugador(95768450, "Eduardo", 1000, 2);

            Console.WriteLine(jugadorUno.MostrarDatos());
            Console.WriteLine(jugadorDos.MostrarDatos());

            Equipo equipoUno = new Equipo(2 ,"Liverpool Fc");

            Console.WriteLine(equipoUno + jugadorDos);
            Console.WriteLine(equipoUno + jugadorDos);
            Console.WriteLine(equipoUno + jugadorUno);
            Console.Write("\n");

            foreach ( Jugador nombres in equipoUno.jugadores)
            {
                Console.WriteLine(nombres.MostrarDatos());
            }
        }
    }
}
