using System;
using CalcularFecha;

namespace Ejercicio_Estaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            string fecha;

            Console.WriteLine("Ingrese la fecha DD/MM/YYYY: ");

            fecha = Console.ReadLine();

            Console.WriteLine($"La cantidad de dias transcurrido desde la fecha ingresada {fecha} hasta la fecha actual {DateTime.Now,0:dd/MM/yyyy} es: {Class1.CalcularFechaIngresada(DateTime.ParseExact(fecha, "dd/mm/yyyy", null))}");
        }
    }
}
