using System;

namespace I05
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int sumaAnteriorAlCentro = 0;
            int sumaDespuesDelCentro = 0;

            Console.WriteLine("Ingrese un numero: ");

            while (int.TryParse(Console.ReadLine(), out numeroIngresado))
            {
                //Recorro desde el 1 hasta el valor ingresado por el usuario.
                for (int centro = 1; centro < numeroIngresado; centro++)
                {
                    //Sumo los numeros inferiores al centro.
                    sumaAnteriorAlCentro = 0;
                    for (int i = 0; i < centro; i++)
                    {
                        sumaAnteriorAlCentro += i;
                    }
                    //Sumo los numeros superiores al centro.
                    sumaDespuesDelCentro = 0;
                    for (int j = centro + 1; j < numeroIngresado; j++)
                    {
                        if ((sumaAnteriorAlCentro == sumaDespuesDelCentro) || (sumaDespuesDelCentro > sumaAnteriorAlCentro))
                        {
                            break;
                        }
                        else
                        {
                            sumaDespuesDelCentro += j;
                        }
                    }
                    //Verifico si encontro el centro por el break;
                    if (sumaAnteriorAlCentro == sumaDespuesDelCentro)
                    {
                        Console.WriteLine("Es un centro este numero {0}", centro);
                    }
                }
            }
            Console.WriteLine("Error. No es un numero..");
        }
    }
}
