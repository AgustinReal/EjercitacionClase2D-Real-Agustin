using System;

namespace Boligrafo
{
    public class Boligrafo
    {
        private const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.color = color;
            this.tinta = tinta;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return tinta;
        }

        private void SetTinta(short tinta)
        {
            short auxTinta = (short)(this.tinta + tinta);// 80 = 10

            if (auxTinta >= 0 && auxTinta <= cantidadTintaMaxima)
            {
                this.tinta = auxTinta;
            }

        }

        private void Recargar()
        {
            this.tinta = cantidadTintaMaxima; 
        }

        public  bool Pintar(short gasto, out string dibujo)
        {
            gasto *= -1;
            bool retorno = false;
            dibujo = " ";

            if(gasto <= this.tinta)
            {
                Console.ForegroundColor = color;

                for(int i = 0; i < gasto; i++)//recorro hasta el gasto 
                {
                    dibujo += $"{i + 1}*\n";// i + numero con el *
                }
                
                SetTinta((short)(gasto * -1));// resto la tinta

                retorno = true;
            }

            return retorno;
        }
    }
}
