using System;
using Banco;

namespace Ejercio_OrientadoObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta NewCuenta = new Cuenta("Lucia", 1500);
            Console.WriteLine(NewCuenta.Mostrar());
            
            NewCuenta.Ingresar(400);
            Console.WriteLine(NewCuenta.Mostrar());

            NewCuenta.Retirar(200);
            Console.WriteLine(NewCuenta.Mostrar());
        }
    }
}
