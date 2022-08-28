using System;
using Persona;
namespace Ejercicio_OrientadoObjeto
{
    class Program
    {
        static void Main(string[] args)
        {

            Persona.Persona uno = new Persona.Persona("Lucia", Convert.ToDateTime("27/10/1994"), 40521418);
            Persona.Persona dos = new Persona.Persona("Agustin", Convert.ToDateTime("04/07/2001"), 43521418);
            Persona.Persona tres = new Persona.Persona("Ramon", Convert.ToDateTime("23/11/2012"), 20521418);

            Console.WriteLine(uno.Mostrar());
            Console.WriteLine(dos.Mostrar());
            Console.WriteLine(tres.Mostrar());
        }
    }
}
