using System;

namespace I01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumeros = new int[5];
            string respuesta;
            int valorMaximo;
            int flagMayorNumero = 0;
            int flagMenorNumero = 0;
            int valorMinimo;
            float promedio;
            int sumaNumeros = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero: " + (i + 1));

                respuesta = Console.ReadLine();

                arrayNumeros[i] = int.Parse(respuesta);

                sumaNumeros += arrayNumeros[i];
            }

            foreach (int numero in arrayNumeros)
            {
                Console.Write($"\n{numero} ");
            }

            valorMaximo = arrayNumeros[0];

            for (int i = 0; i < 5; i++)
            {
                if (flagMayorNumero == 0 || valorMaximo < arrayNumeros[i])
                {
                    valorMaximo = arrayNumeros[i];
                    flagMayorNumero = 1;
                }
            }

            valorMinimo = arrayNumeros[0];

            for (int i = 0; i < 5; i++)
            {
                if (flagMenorNumero == 0 || valorMinimo > arrayNumeros[i])
                {
                    valorMinimo = arrayNumeros[i];
                    flagMenorNumero = 1;
                }
            }

            promedio = (float)sumaNumeros / 5;

            Console.WriteLine($"\n\nEl valor maximo es: {valorMaximo} \n");
            Console.WriteLine($"El valor minimo es: {valorMinimo} \n");
            Console.WriteLine($"El promedio de los numeros es: {promedio} \n");
      
        }
    }
}
