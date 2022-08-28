using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente
{
    public class Mascota
    {
        private string especie;
        private string nombre;
        private string fechaNacimiento;
        public string historial;

        public Mascota(string especie, string nombre, string fechaNacimiento)
        {
            this.especie = especie;
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            this.historial = "";

        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder("Informacion de la mascota\n");

            sb.AppendLine($"Especie: {this.especie}");
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Fecha de nacimiento: {this.fechaNacimiento}");
            if (historial == "")
            {
                sb.AppendLine("No hay ningun historial que mostrar ya que la mascota no tiene ninguna vacuna");
            }
            else
            {
                sb.AppendLine($"{this.historial}");
            }

            return sb.ToString();
        }
        public void AgregarVacuna(string vacuna)
        {
            if (historial == "")
            {
                historial += $"Historial de vacunacion:\n- {vacuna}";
            }
            else
            {
                historial += $"\n- {vacuna}";
            }
        }
    }
}
