using System;

namespace Biblioteca
{
    public class CalculadoraDeArea 
    {
        public static double CalcularAreaCuadrado(double longitudLado) 
        {
            return longitudLado = Math.Pow(longitudLado, 2);
        }

        public static double CalcularAreaTriangulo(double baseUno, double altura)
        {
            return (baseUno * altura) / 2;
        }

        public static double CalcularAreaCirculo(double radio) 
        { 
            return radio = Math.PI *(Math.Pow(radio, 2));
        }
    }
}
