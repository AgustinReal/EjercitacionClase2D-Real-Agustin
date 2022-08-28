using System;
using System.Text;

namespace Camion
{
    public class Camioneros
    {
        private string nombre;
        private int[] kilometros = new int[7];

        public Camioneros(string nombre, int[] kilometros)
        {
            this.nombre = nombre;
            this.kilometros = kilometros;
        }

        public string GetNombre()
        {
            return nombre;
        }

        
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder(" _______________________________________ \n");
            sb.AppendLine("|                                       |");
            sb.AppendLine("|                                       |");
            sb.AppendLine("|       UTN AVELLANEDA TRANSPORTE       |");
            sb.AppendLine("|          FICHA DE RECORRIDOS          |");
            sb.AppendLine("|                                       |");
            sb.AppendLine("|_______________________________________|");
            sb.AppendLine("|                                       |");
            sb.AppendFormat("| El nombre del conductor:  {0, -10}  |\n", GetNombre());
            sb.AppendLine("|_______________________________________|");
            sb.AppendLine("|                 |                     |");
            sb.AppendLine("|      DIAS       |      KILOMETROS     |");
            sb.AppendLine("|_________________|_____________________|");
            sb.AppendLine("|                 |                     |");
            for (int i = 0; i < kilometros.Length; i++)
            {
                sb.AppendFormat("|        {0, -5}    |         {1, -5}       |\n", i+1, kilometros[i]);
            }
            sb.AppendLine("|_________________|_____________________|");
            return sb.ToString();
        }

        public int contadorKilometrosPorDia(int cantidadDias)
        {
            int acumuladorKilometrosPorSemana = 0;

            for (int i = 0; i < cantidadDias; i++)
            {
                acumuladorKilometrosPorSemana += kilometros[i];
            }

            return acumuladorKilometrosPorSemana;
        }

        public static string conductorConMasKmPorSemana(Camioneros []arrayConductores)
        {
            string conductorMaskmPorSemana="";
            int flagConductorMasKmPorSemana = 0;
            int mayorCantidadKm = 0;

            for (int i = 0; i < arrayConductores.Length; i++)
            {
                if(flagConductorMasKmPorSemana == 0 || arrayConductores[i].contadorKilometrosPorDia(7) > mayorCantidadKm)
                {
                    mayorCantidadKm = arrayConductores[i].contadorKilometrosPorDia(7);
                    conductorMaskmPorSemana = arrayConductores[i].nombre;
                    flagConductorMasKmPorSemana = 1;
                }
            }

            return conductorMaskmPorSemana;
        }

        public static string conductorConMasKmPor3Dias(Camioneros[] arrayConductores)
        {
            string conductorMaskmPor3Dias = "";
            int flagConductorMasKmPor3Dias = 0;
            int mayorCantidadKm = 0;

            for (int i = 0; i < arrayConductores.Length; i++)
            {
                if (flagConductorMasKmPor3Dias == 0 || arrayConductores[i].kilometros[2] > mayorCantidadKm)
                {
                    mayorCantidadKm = arrayConductores[i].kilometros[2];
                    conductorMaskmPor3Dias = arrayConductores[i].nombre;
                    flagConductorMasKmPor3Dias = 1;
                }
            }

            return conductorMaskmPor3Dias;
        }

        public static string conductorConMasKmPor5Dias(Camioneros[] arrayConductores)
        {
            string conductorMaskmPor5Dias = "";
            int flagConductorMasKmPor5Dias = 0;
            int mayorCantidadKm = 0;

            for (int i = 0; i < arrayConductores.Length; i++)
            {
                if (flagConductorMasKmPor5Dias == 0 || arrayConductores[i].kilometros[4] > mayorCantidadKm)
                {
                    mayorCantidadKm = arrayConductores[i].kilometros[4];
                    conductorMaskmPor5Dias = arrayConductores[i].nombre;
                    flagConductorMasKmPor5Dias = 1;
                }
            }

            return conductorMaskmPor5Dias;
        }
    }
}
