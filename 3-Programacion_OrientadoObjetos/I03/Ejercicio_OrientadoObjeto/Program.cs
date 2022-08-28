using System;
using Estudiante;

namespace Ejercicio_OrientadoObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante.Estudiante Eduardo = new Estudiante.Estudiante("Eduardo", "Segovia", "11721");
            Estudiante.Estudiante Luciana = new Estudiante.Estudiante("Luciana", "Gonzalez", "11821");
            Estudiante.Estudiante Agustin = new Estudiante.Estudiante("Agustin", "Real", "11117");

            Eduardo.SetNotaPrimerParcial(8);
            Eduardo.SetNotaSegundoParcial(8);
            Luciana.SetNotaPrimerParcial(9);
            Luciana.SetNotaSegundoParcial(9);
            Agustin.SetNotaPrimerParcial(2);
            Agustin.SetNotaSegundoParcial(4);

            Console.WriteLine(Eduardo.Mostrar());
            Console.WriteLine(Luciana.Mostrar());
            Console.WriteLine(Agustin.Mostrar());
        }
    }
}
