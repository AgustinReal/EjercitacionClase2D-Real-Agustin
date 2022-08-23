using System;

namespace I02
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            bool convertido;
            double respuestaUno;
            double respuestaDos;

            Console.WriteLine("Ingrese un numero: ");
            convertido = int.TryParse(Console.ReadLine(), out numero);

            if (numero > 0 && convertido)
            {
                respuestaUno = Math.Pow(numero, 2);
                respuestaDos = Math.Pow(numero, 3);

                Console.WriteLine($"El numero ingresado es: {numero}");
                Console.WriteLine($"El cuadrado del numero ingresado es: {respuestaUno}");
                Console.WriteLine($"El cubo del numero ingresado es: {respuestaDos}");
            }
            else
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
            }
        }
    }
}
