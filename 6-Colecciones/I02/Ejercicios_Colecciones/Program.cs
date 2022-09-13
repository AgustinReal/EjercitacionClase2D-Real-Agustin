using System;
using System.Collections.Generic;

namespace Ejercicios_Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lista
            List<int> listaEnteros = new List<int>();
            List<int> listaEnterosNeg = new List<int>();
            List<int> listaEnterosPos = new List<int>();

            Stack<int> stackEnteros = new Stack<int>();
            Stack<int> stackEnterosPositivos = new Stack<int>();
            Stack<int> stackEnterosNegativos = new Stack<int>();

            Queue<int> queueEnteros = new Queue<int>();
            Queue<int> queueEnterosPositivos = new Queue<int>();
            Queue<int> queueEnterosNegativos = new Queue<int>();



            Console.WriteLine("Numeros Cargados");
            CargarListaNumerosRandoms(listaEnteros, -100, 100);
            MostrarLista(listaEnteros);

            Console.WriteLine("Numeros Positivos");
            listaEnterosPos = OrdenamientoNumerosPositivosDes(listaEnteros);
            MostrarLista(listaEnterosPos);

            Console.WriteLine("Numeros Negativos");
            listaEnterosNeg = OrdenamientoNumerosNegativosAsc(listaEnteros);
            MostrarLista(listaEnterosNeg);



            Console.WriteLine("Numeros Cargados");
            CargarNumerosRandomStack(stackEnteros, -100, 100);
            MostrarStackNumeros(stackEnteros);

            Console.WriteLine("Numeros Positivos");
            stackEnterosPositivos = OrdenamientoStackNumerosPositivosDes(stackEnteros);
            MostrarStackNumeros(stackEnterosPositivos);

            Console.WriteLine("Numeros Negativos");
            stackEnterosNegativos = OrdenamientoStackNumerosNegativosAsc(stackEnteros);
            MostrarStackNumeros(stackEnterosNegativos);



            Console.WriteLine("Numeros Cargados");
            CargarNumerosRandomQueue(queueEnteros, -100, 100);
            MostrarQueueNumeros(queueEnteros);

            Console.WriteLine("Numeros Positivos");
            queueEnterosPositivos = OrdenamientoQueueNumerosPositivosDes(queueEnteros);
            MostrarQueueNumeros(queueEnterosPositivos);

            Console.WriteLine("Numeros Negativos");
            queueEnterosNegativos = OrdenamientoQueueNumerosNegativosAsc(queueEnteros);
            MostrarQueueNumeros(queueEnterosNegativos);
        }

        #region List
        public static void CargarListaNumerosRandoms(List<int> lista, int min, int max)
        {
            //int tam = lista.Count;
            Random random = new Random();

            for (int i = 0; i < 20; i++)
            {
                lista.Add(random.Next(min, max));

                while (lista[i] == 0)
                {
                    lista.Add(random.Next(min, max));
                }
            }
        }

        public static void MostrarLista(List<int> lista)
        {
            int contador = 0;
            foreach (int item in lista)
            {
                contador++;
                Console.WriteLine("Indice: {0,-1}, Numero: {1, -2}", contador, item);
            }

            Console.WriteLine("\n\n");
        }

        public static List<int> OrdenamientoNumerosPositivosDes(List<int> lista)
        {
            List<int> auxLista = new List<int>();

            lista.Sort();

            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] > 0)
                {
                    auxLista.Add(lista[i]);
                }
            }

            return auxLista;
        }

        public static List<int> OrdenamientoNumerosNegativosAsc(List<int> lista)
        {
            List<int> auxLista = new List<int>();

            lista.Sort(delegate (int x, int y)
            {
                return x - y;
            });

            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] < 0)
                {
                    auxLista.Add(lista[i]);
                }
            }

            return auxLista;
        }

        #endregion

        #region Stack
        public static void CargarNumerosRandomStack(Stack<int> stackLista, int min, int max)
        {
            Random random = new Random();

            for (int i = 0; i < 20; i++)
            {
                stackLista.Push(random.Next(min, max));

                while (stackLista.Peek() == 0)
                {
                    max++;
                    stackLista.Push(random.Next(min, max));
                }
            }
        }

        public static void MostrarStackNumeros(Stack<int> stackLista)
        {
            int contador = 0;

            foreach (int numero in stackLista)
            {
                contador++;
                Console.WriteLine("Indice: {0,-1}, Numero: {1, -2}", contador, numero);
            }

            Console.WriteLine("\n\n");
        }

        public static Stack<int> OrdenamientoStackNumerosPositivosDes(Stack<int> stackLista)
        {
            Stack<int> auxLIsta = new Stack<int>();
            List<int> auxNumeros = new List<int>();


            foreach (int numero in stackLista)
            {
                if (numero > 0)
                {
                    auxNumeros.Add(numero);
                }
            }

            auxNumeros.Sort();

            foreach (int numero in auxNumeros)
            {
                auxLIsta.Push(numero);
            }

            return auxLIsta;
        }

        public static Stack<int> OrdenamientoStackNumerosNegativosAsc(Stack<int> stackLista)
        {
            Stack<int> auxLIsta = new Stack<int>();
            List<int> auxNumeros = new List<int>();


            foreach (int numero in stackLista)
            {
                if (numero < 0)
                {
                    auxNumeros.Add(numero);
                }
            }

            auxNumeros.Sort(delegate (int x, int y)
            {
                return y - x;
            });

            foreach (int numero in auxNumeros)
            {
                auxLIsta.Push(numero);
            }

            return auxLIsta;
        }

        #endregion

        #region Queue
        public static void CargarNumerosRandomQueue(Queue<int> listaQueve, int min, int max)
        {
            Random random = new Random();

            for (int i = 0; i < 20; i++)
            {
                listaQueve.Enqueue(random.Next(min, max));

                while(listaQueve.Peek()==0)
                {
                    max++;
                    listaQueve.Enqueue(random.Next(min, max));
                }
            }
        }

        public static void MostrarQueueNumeros(Queue<int> queueLista)
        {
            int contador = 0;

            foreach (int numero in queueLista)
            {
                contador++;
                Console.WriteLine("Indice: {0,-1}, Numero: {1, -2}", contador, numero);
            }

            Console.WriteLine("\n\n");
        }

        public static Queue<int> OrdenamientoQueueNumerosPositivosDes(Queue<int> queueLista)
        {
            Queue<int> auxLista = new Queue<int>();
            List<int> lista = new List<int>();

            foreach (int numero in queueLista)
            {
                if(numero > 0)
                {
                    lista.Add(numero);
                }
            }

            lista.Sort();

            foreach (int numero in lista)
            {
                auxLista.Enqueue(numero);
            }

            return auxLista;
        }

        public static Queue<int> OrdenamientoQueueNumerosNegativosAsc(Queue<int> queueLista)
        {
            Queue<int> auxLista = new Queue<int>();
            List<int> lista = new List<int>();

            foreach (int numero in queueLista)
            {
                if (numero < 0)
                {
                    lista.Add(numero);
                }
            }

            lista.Sort(delegate (int x, int y)
            {
                return y - x;
            });

            foreach (int numero in lista)
            {
                auxLista.Enqueue(numero);
            }

            return auxLista;
        }
        #endregion
    }
}
