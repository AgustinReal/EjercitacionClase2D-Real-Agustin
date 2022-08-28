using System;
using Camion;

namespace Ejercicio_OrientadoObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] kmPrimerConductor = { 70, 24, 168, 0, 185, 0, 0 };
            Camioneros primerConductor = new Camioneros("Clarke", kmPrimerConductor);

            int[] kmSegundoConductor = { 270, 324, 18, 0, 525, 0, 0 };
            Camioneros segundoConductor = new Camioneros("Octavia", kmSegundoConductor);

            int[] kmTerceroConductor = { 120, 324, 18, 0, 425, 0, 0 };
            Camioneros terceroConductor = new Camioneros("Homero", kmTerceroConductor);

            

            Camioneros[] arrayDeConductores = { primerConductor, segundoConductor, terceroConductor };

            foreach (Camioneros unConductor in arrayDeConductores)
            {
                Console.WriteLine(unConductor.Mostrar());
            }

            Console.WriteLine("Informes Km recorridos por dias: ");
            Console.WriteLine($"El conductor que hizo más km en esa semana es: {Camioneros.conductorConMasKmPorSemana(arrayDeConductores)}");
            Console.WriteLine($"El conductor que hizo más km el día 3 es : {Camioneros.conductorConMasKmPor3Dias(arrayDeConductores)}");
            Console.WriteLine($"El conductor que hizo más km el día 5 es : {Camioneros.conductorConMasKmPor5Dias(arrayDeConductores)}");
        }
    }
}
