using System;

namespace Formula
{
    public class Class1
    {
        public static int factorial(int numero)
        {
            int factorialUno = 1;

            if(numero!=0 && numero!=1 && numero>0)
            {
                factorialUno = numero * factorial( numero - 1);
            }

            return factorialUno;
        }
    }
}
