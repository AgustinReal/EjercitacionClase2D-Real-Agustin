using System;
using System.Text;

namespace Monoplaza
{
    public class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public AutoF1(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
        }

        public void SetCantidadComBustible(short cantidadCombustible)
        {
            this.cantidadCombustible = cantidadCombustible;
        }

        public short GetCantidadCombustible()
        {
            return this.cantidadCombustible;
        }

        public void SetEnCompetencia(bool enCompetencia)
        {
            this.enCompetencia = enCompetencia;
        }

        public bool GetEnCompetencia()
        {
            return this.enCompetencia;
        }

        public void SetVueltasRestantes(short vueltasRestantes)
        {
            this.vueltasRestantes = vueltasRestantes;
        }

        public short GetVueltasRestantes()
        {
            return this.vueltasRestantes;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Numero: {this.numero}");
            sb.AppendLine($"Escuderia: {this.escuderia}");
            sb.AppendLine($"Competencia: {GetEnCompetencia()}");
            sb.AppendLine($"Vueltas restantes: {GetVueltasRestantes()}");
            sb.AppendLine($"Combustible: {GetCantidadCombustible()}");

            return sb.ToString();
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return (a1.escuderia == a2.escuderia && a1.numero == a2.numero);
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1==a2);
        }
    }
}
