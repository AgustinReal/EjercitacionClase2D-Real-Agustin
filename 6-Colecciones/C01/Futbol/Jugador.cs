using System;
using System.Text;

namespace Futbol
{
    public class Jugador
    {
        private int DNI;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int golesTotales;


        public float GetPromedio()
        {
             return this.golesTotales/this.partidosJugados;        
        }
        private Jugador():this(0,"Sin Asignar", 0, 0)
        {

        }
        public Jugador(int DNI, string nombre):this(DNI, nombre, 0, 0)
        {

        }
        public Jugador(int DNI, string nombre, int totalGoles, int totalPartidos)
        {
            this.DNI = DNI;
            this.nombre = nombre;
            this.partidosJugados = totalPartidos;
            this.golesTotales = totalGoles;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"DNI: {this.DNI}");
            sb.AppendLine($"Partidos jugados: {this.partidosJugados}");
            sb.AppendLine($"Goles marcados: {this.golesTotales}");
            sb.AppendLine($"Promedio de goles por partido: {GetPromedio()}");

            return sb.ToString();
        }
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return (j1.DNI == j2.DNI);
        }
        public static bool operator !=(Jugador j1 , Jugador j2)
        {
            return !(j1.DNI == j2.DNI);
        }

    }
}
