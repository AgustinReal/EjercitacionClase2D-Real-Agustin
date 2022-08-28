using System;
using Cliente;
namespace Ejercicio_OrientadoObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Mascota unaMascota1 = new Mascota("Perro", "Sasha", "4/6/2005");
            Cliente1 unCliente = new Cliente1("Miguel", "black", "Palermo 750", "1582382888");
            unCliente.CantidadDeMascotas(1);
            unCliente.AsociarMascotas(unaMascota1);

            Console.WriteLine(unCliente.Mostrar());

        }
    }
}
