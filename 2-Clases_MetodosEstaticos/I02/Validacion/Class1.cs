using System;

namespace Validacion
{
    public class Validar
    {
        public static bool ValidarRespuesta(string respuesta)
        {
            bool validado = false;

            if(respuesta == "S" || respuesta == "s")
            {
                validado = true;
            }

            return validado;
        }
    }
}
