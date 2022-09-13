using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monoplaza
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;

        private Competencia()
        {
            this.competidores = new List<AutoF1> ();
        }

        public Competencia(short cantidadCompetidores, short cantidadVueltas) :this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Cantidad de Competidores: {this.cantidadCompetidores}");
            sb.AppendLine($"cantidad de vueltas {this.cantidadVueltas}");
            sb.AppendLine($"Pilotos: ");

            foreach (AutoF1 piloto in this.competidores)
            {
                sb.AppendLine(piloto.MostrarDatos());
            }

            return sb.ToString();
        }

        public static bool operator +(Competencia c, AutoF1 a)
        {
            bool seAgrego = false;

            if (c.competidores.Count < c.cantidadCompetidores && c!=a)
            {
                c.competidores.Add(a);
                a.SetEnCompetencia(true);
                a.SetVueltasRestantes(c.cantidadVueltas);
                Random random = new Random();
                a.SetCantidadComBustible((short)(random.Next(15, 100)));
                seAgrego = true;
            }

            return seAgrego;
        }

        public static bool operator -(Competencia c, AutoF1 a)
        {
            bool seElimino = false; 

            if(c == a)
            {
                c.competidores.Remove(a);
                seElimino = true;
            }

            return seElimino;
        }

        public static bool operator !=(Competencia c, AutoF1 a)
        {
            bool sonDistintos = true;

            foreach (AutoF1 piloto in c.competidores)
            {
                if (piloto == a)
                {
                    sonDistintos = false;
                }
            }
            return sonDistintos;
        }

        public static bool operator ==(Competencia c, AutoF1 a)
        {
            bool sonDistintos = false;

            foreach (AutoF1 piloto in c.competidores)
            {
                if (piloto == a)
                {
                    sonDistintos = true;
                }
            }
            return sonDistintos;
        }
    }
}
