using System;

namespace Ejercicio_Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayDeNumeros = new int[20];

            Console.WriteLine("Numeros del array Random");
            CargarArrayNumerosRandom(arrayDeNumeros, -100, 100);
            MostrarNumerosArray(arrayDeNumeros);

            Console.WriteLine("Numeros negativos Ascendente");
            OrdenarNumerosNegativosAsc(arrayDeNumeros);

            Console.WriteLine("Numeros positivos Descendente");
            OrdenarNumerosPositivosDes(arrayDeNumeros);

        }

        public static void CargarArrayNumerosRandom(int []arrayNumeros, int min, int max)
        {
            Random random = new Random();

            for (int i = 0; i < arrayNumeros.Length; i++)
            {
                arrayNumeros[i] = random.Next(min, max);

                while(arrayNumeros[i]==0)
                {
                    arrayNumeros[i] = random.Next(min, max);
                }
            }
        }
        public static void MostrarNumerosArray(int []arrayNumeros)
        {
            for (int i = 0; i < arrayNumeros.Length; i++)
            {
                Console.WriteLine("EL indice: {0,-2} y el numero: {1,3}", i+1, arrayNumeros[i]);
            }

            Console.WriteLine("\n\n");
        }

        public static void OrdenarNumerosPositivosDes(int[] arrayNumeros)
        {
            Array.Sort(arrayNumeros, delegate (int x, int y) // ordenar el array Des
            {
                return  y - x;
            });

            for (int i = 0; i < arrayNumeros.Length; i++)
            {
                if (arrayNumeros[i] > 0)
                {
                    Console.WriteLine("EL indice: {0,-2} y el numero: {1,3}", i + 1, arrayNumeros[i]);
                }
            }

            Console.WriteLine("\n\n");

        }

        public static void OrdenarNumerosNegativosAsc(int[] arrayNumeros)
        {
            Array.Sort(arrayNumeros);

            for (int i = 0; i < arrayNumeros.Length; i++)
            {
                if(arrayNumeros[i]<0)
                {
                    Console.WriteLine("EL indice: {0,-2} y el numero: {1,3}", i + 1, arrayNumeros[i]);
                }
            }

            Console.WriteLine("\n\n");

        }
    }
}
