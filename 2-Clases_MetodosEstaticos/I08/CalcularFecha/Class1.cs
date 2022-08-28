using System;

namespace CalcularFecha
{
    public class Class1
    {

        public static int CalcularFechaIngresada(DateTime fecha)
        {
            int fechaTranscurrida = 0;
            int flagFechaEncontrada = 0;
            DateTime fechaNow = DateTime.Now;
            TimeSpan fechaDiferencia = fechaNow - fecha;

            fechaTranscurrida = fechaDiferencia.Days;

            for(int i = fecha.Year+1; i <= fechaNow.Year; i++)
            {
                if(flagFechaEncontrada==0 && fecha.Month<3)
                {
                    fechaTranscurrida++;
                }

                flagFechaEncontrada = 1;

                if(DateTime.IsLeapYear(i) && flagFechaEncontrada == 1)
                {
                    fechaTranscurrida++;
                }

            }

            return fechaTranscurrida;
        }
    }
}
