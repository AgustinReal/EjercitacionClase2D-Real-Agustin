using System;

namespace Biblioteca
{
    public class Calculadora
    {
        public static decimal Calcular(decimal operadorUno, decimal operadorDos, string operacion)
        {
            decimal resultado = 0;

            if (operacion == "+")
            {
                resultado = operadorUno + operadorDos;
            }
            else if (operacion == "-")
            {
                resultado = operadorUno - operadorDos;
            }
            else if (operacion == "*")
            {
                resultado = operadorUno * operadorDos;
            }
            else if (operacion == "/")
            {
                if (Validar(operadorDos))
                {
                    resultado = operadorUno / operadorDos;
                }
            }

            return resultado;
        }

        private static bool Validar(decimal segundoOperador)
        {
            bool validado = false;

            if (segundoOperador != 0)
            {
                validado = true;
            }

            return validado;
        }
        public static bool Salir(string opcion)
        {
            bool salir = false;

            if(opcion=="N" || opcion == "n")
            {
                salir = true;
            }

            return salir;
        }
        public static string aplicarSignoMatematico(string signo)
        {        
            switch (signo)
            {
                case "+":
                    signo = "Suma";
                    break;
                case "-":
                    signo = "Resta";
                    break;
                case "/":
                    signo = "Division";
                    break;
                case "*":
                    signo = "Multiplicacion";
                    break;
            }

            return signo;
        }
    }
}
