using System;
using Monoplaza;

namespace Ejercicios_Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoF1 monoplazaUno = new AutoF1(17, "McClaren-Honda");
            AutoF1 monoplazaDos = new AutoF1(2, "Red Bull");
            AutoF1 monoplazaTres = new AutoF1(2, "Red Bull");
            AutoF1 monoplazaCuatro = new AutoF1(4, "Mercedes-benz");
            AutoF1 monoplazaCinco = new AutoF1(7, "Ferrari");

            Competencia circuito = new Competencia(5, 65);

            if(circuito + monoplazaUno)
            {
                Console.WriteLine(circuito.MostrarDatos());
            }
            else
            {
                Console.WriteLine("No se agrego");
            }

            if (circuito + monoplazaDos)
            {
                Console.WriteLine(circuito.MostrarDatos());
            }
            else
            {
                Console.WriteLine("No se agrego");
            }

            if (circuito + monoplazaTres)
            {
                Console.WriteLine(circuito.MostrarDatos());
            }
            else
            {
                Console.WriteLine("No se agrego");
            }

            if (circuito + monoplazaCuatro)
            {
                Console.WriteLine(circuito.MostrarDatos());
            }
            else
            {
                Console.WriteLine("No se agrego");
            }

            if (circuito + monoplazaCinco)
            {
                Console.WriteLine(circuito.MostrarDatos());
            }
            else
            {
                Console.WriteLine("No se agrego");
            }
        }
    }
}
