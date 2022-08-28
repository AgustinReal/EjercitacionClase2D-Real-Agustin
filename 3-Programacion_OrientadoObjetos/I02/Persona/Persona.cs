using System;
using System.Text;

namespace Persona
{
    public class Persona
    {
        private string nombre;
        private DateTime fechaNacimiento;
        private int DNI;

        public Persona(string nombre, DateTime fechaNacimiento, int DNI)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            this.DNI = DNI;
        }

        //Setters

        public void SetNombre(string nombre)
        {
            if(!string.IsNullOrWhiteSpace(nombre))
            {
                this.nombre = nombre.Trim();
            }
        }

        public void SetFechaNacimineto(DateTime fechaNacimiento)
        {
            this.fechaNacimiento = fechaNacimiento;
        }

        public void SetDNI(int DNI)
        {
            if(DNI>10000000 && DNI<45000000)
            {
                this.DNI = DNI;
            }
        }

        //Getters
        public string GetNombre()
        {
            return nombre;
        }

        public DateTime GetFechaNacimiento()
        {
            return fechaNacimiento;
        }

        public int GetDNI()
        {
            return DNI;
        }

        private static int CalcularEdad(DateTime fechaNacimiento)
        {
            int edadEncontrada = 0;
            DateTime fechaActual = DateTime.Today;
            
            if(fechaNacimiento > fechaActual)
            {
                edadEncontrada = -1;
            }
            else
            {
                edadEncontrada = fechaActual.Year - fechaNacimiento.Year;

                if (fechaNacimiento.Month > fechaActual.Month)
                {
                    edadEncontrada--;
                }
            }

            return edadEncontrada;
        }

        private static string EsMayorEdad(DateTime fechaNacimiento)
        {
            string edadCalculada;
            int edadIngresada;

            edadIngresada = CalcularEdad(fechaNacimiento);

            if(edadIngresada >= 18)
            {
                edadCalculada = "Es mayor de edad";
            }
            else
            {
                edadCalculada = "Es menor de edad";
            }

            return edadCalculada;
        }

        public string Mostrar()
        {
            int edad;
            string esMayor;
            DateTime fecha;

            edad = CalcularEdad(GetFechaNacimiento());

            StringBuilder sb = new StringBuilder(" __________________________________________\n");
            sb.AppendLine("|               UTN AVELLANEDA             |");
            sb.AppendLine("|             INFORMACION ALUMNO           |");
            sb.AppendLine("|__________________________________________|");
            sb.AppendLine("|                                          |");
            sb.AppendFormat("| El titular es: {0, -10}                |\n", GetNombre());
            fecha = GetFechaNacimiento();
            sb.AppendFormat("| La fecha de nacimiento es: {0, -10}    |\n", fecha.ToShortDateString());
            sb.AppendFormat("| La edad es: {0, -10}                   |\n", edad);
            sb.AppendLine($"| El DNI es: {GetDNI()}                      |");
            esMayor = EsMayorEdad(GetFechaNacimiento());
            sb.AppendLine($"| {esMayor}                         |");
            sb.AppendLine("|__________________________________________|");
            return sb.ToString();
        }
    }
}
