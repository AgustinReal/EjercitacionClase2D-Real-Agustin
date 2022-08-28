using System;
using System.Text;

namespace Biblioteca
{
    public class tablaMultiplicacion
    {
        public static string tablaSelecionadaPorElUsuario(int numero)
        {

            StringBuilder sb = new StringBuilder();
            int resultado;

            sb.AppendFormat($"\nTabla de multiplicar del número {numero}: ");
            sb.AppendLine();

            for (int i = 1; i < 10; i++)
            {
                resultado = numero * i;
                sb.AppendFormat($"{numero} x {i} = {resultado} \n");
            }

            return sb.ToString();
        }
    }
}
