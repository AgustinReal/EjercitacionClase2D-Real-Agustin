using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice2 = new Punto(vertice3.GetX(), vertice1.GetY());
            this.vertice3 = vertice3;
            this.vertice4 = new Punto(vertice1.GetY(), vertice3.GetX());
            perimetro = 0;
            area = 0;
        }

        public float GetArea()
        {
            if(this.area == 0)
            {
                float baseRectangulo;
                float alturaRectangulo;

                baseRectangulo = vertice1.GetX() - vertice3.GetX();
                alturaRectangulo = vertice1.GetY() - vertice3.GetY();
                baseRectangulo = Math.Abs(baseRectangulo);
                alturaRectangulo = Math.Abs(alturaRectangulo);

                this.area = baseRectangulo * alturaRectangulo;
            }

            return area;
        }

        public float GetPerimetro()
        {
            if(this.perimetro == 0)
            {
                float baseRectangulo;
                float alturaRectangulo;

                baseRectangulo = vertice1.GetX() - vertice3.GetX();
                alturaRectangulo = vertice1.GetY() - vertice3.GetY();
                baseRectangulo = Math.Abs(baseRectangulo);
                alturaRectangulo = Math.Abs(alturaRectangulo);

                this.perimetro =(baseRectangulo + alturaRectangulo) / 2;
            }

            return perimetro;
        }
    }
}
