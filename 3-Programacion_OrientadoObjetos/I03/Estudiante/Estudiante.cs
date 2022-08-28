using System;
using System.Text;

namespace Estudiante
{

    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        static Estudiante()
        {
            random = new Random();
        }

        public Estudiante(string nombre, string apellido, string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        //Setters

        public void SetNotaPrimerParcial(int notaPrimerParcial)
        {
            if(notaPrimerParcial>=0 && notaPrimerParcial<=10)
            {
                this.notaPrimerParcial = notaPrimerParcial;
            }
        }

        public void SetNotaSegundoParcial(int notaSegundoParcial)
        {
            if (notaSegundoParcial >= 0 && notaSegundoParcial <= 10)
            {
                this.notaSegundoParcial = notaSegundoParcial;
            }
        }

        private float CalcularPromedio(int notaPrimerParcial, int notaSegundoParcial)
        {
            return ((float)(notaPrimerParcial + notaSegundoParcial) / 2);
        }

        private double CalcularNotaFinal()
        {
            double notaFinal = -1;

            if(notaPrimerParcial >= 4 && notaSegundoParcial >= 4)
            {
                notaFinal = Estudiante.random.Next(6, 11);//el ultimo valor (11) es escluyente, se tomara del 6 al 10. 
            }

            return notaFinal;
        }

        public string Mostrar()
        {
            float promedio = CalcularPromedio(notaPrimerParcial, notaSegundoParcial);
            double notaFinal = CalcularNotaFinal();
            string desaprobado = "Alumno desaprobado";

            StringBuilder sb = new StringBuilder(" __________________________________________\n");
            sb.AppendLine("|               UTN AVELLANEDA             |");
            sb.AppendLine("|             INFORMACION ALUMNO           |");
            sb.AppendLine("|__________________________________________|");
            sb.AppendLine("|                                          |");
            sb.AppendFormat("| Nombre: {0, -10}                       |\n", nombre);
            sb.AppendFormat("| Apellido: {0, -10}                     |\n", apellido);
            sb.AppendFormat("| Legajo: {0, -10}                       |\n", legajo);
            sb.AppendFormat("| Promedio: {0, -10:N2}                     |\n", promedio);
            if(notaFinal>=6)
            {
                sb.AppendFormat("| Nota Final: {0, -20}         |\n", notaFinal);
            }
            else
            {
                sb.AppendFormat("| Nota Final: {0, -20}         |\n", desaprobado);
            }
            sb.AppendLine("|__________________________________________|");

            return sb.ToString();
        }
    }
}
