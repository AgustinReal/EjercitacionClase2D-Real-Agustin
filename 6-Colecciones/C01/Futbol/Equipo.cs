using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Futbol
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        public List<Jugador> jugadores;
        private string nombre;


        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(short cantidad, string nombre) : this()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            bool seAgrego = false;

            if(e is not null && e.jugadores.Count < e.cantidadDeJugadores && j is not null && !e.jugadores.Contains(j))
            {
                e.jugadores.Add(j);
                seAgrego = true;
            }

            return seAgrego;
        }
    }
}
