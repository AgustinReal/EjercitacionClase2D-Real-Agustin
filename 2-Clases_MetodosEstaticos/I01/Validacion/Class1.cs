using System;

namespace Validacion
{
    public class Class1
    {
        public static bool Validar(int valor, int min, int max)
        {
            bool validado = true;

            if (min < max)
            {
                if(valor < min || valor > max)
                {
                    validado = false;
                }
            }
            return validado;
        }
    } 
}
