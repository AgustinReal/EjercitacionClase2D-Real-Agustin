using System;
using Validacion;

namespace Ejercicio_Estaticos
{
    //    Consigna
    //Realizar una clase llamada Validador que posea un método estático llamado Validar con
    //la siguiente firma:

    //bool Validar(int valor, int min, int max)

    //valor: dato a validar.
    //min: mínimo valor incluido.
    //max: máximo valor incluido.
    //Pedir al usuario que ingrese 10 números enteros.Validar con el método desarrollado
    //anteriormente que estén dentro del rango -100 y 100.

    //Terminado el ingreso mostrar el valor mínimo ingresado, valor máximo ingresado y el promedio.
    class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int flagMayorNumero = 0;
            int mayorNumero=0;
            int flagMenorNumero = 0;
            int menorNumero=0;
            int acumuladorNumerosIngresados = 0;
            int cantidadIngresada = 0;
            float promedio;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un numero entre 100 o -100. Numero "+ (i+1)+ ":");
                
                while(int.TryParse(Console.ReadLine(), out numeroIngresado)==false)
                {
                    Console.WriteLine("Error. Ingrese un numero entre 100 o -100. Numero " + (i + 1) + ":");
                }

                if(Class1.Validar(numeroIngresado, -100, 100))
                {
                    cantidadIngresada++;

                    if (flagMayorNumero == 0 || numeroIngresado > mayorNumero)
                    {
                        mayorNumero = numeroIngresado;
                        flagMayorNumero = 1;
                    }

                    if (flagMenorNumero == 0 || numeroIngresado < menorNumero)
                    {
                        menorNumero = numeroIngresado;
                        flagMenorNumero = 1;
                    }

                    acumuladorNumerosIngresados += numeroIngresado;
                }
                else
                {
                    Console.WriteLine("Error. Ingrese un numero entre 100 o - 100.Numero "+ (i+1)+ ":");
                }
            }

            Console.WriteLine($"El numero mayor ingresado es: {mayorNumero}");
            Console.WriteLine($"El numero menor ingresado es: {menorNumero}");

            if(acumuladorNumerosIngresados>0)
            {
                promedio = (float)acumuladorNumerosIngresados / cantidadIngresada;
                Console.WriteLine($"El promedio de los numero ingresados es: {promedio}");
            }
            else 
            {
                Console.WriteLine("No se pudo calcular el promedio...");
            }  
        }
    }
}
