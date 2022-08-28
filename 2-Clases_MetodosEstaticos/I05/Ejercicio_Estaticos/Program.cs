using System;
using System.Text;
using Biblioteca;

namespace Ejercicio_Estaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string tabla;

            Console.Write("Ingrese un numero para mostrar su tabla de multiplicacion: ");
            int.TryParse(Console.ReadLine(), out numero);

            tabla = tablaMultiplicacion.tablaSelecionadaPorElUsuario(numero);

            Console.WriteLine(tabla);
        }
    }
}
