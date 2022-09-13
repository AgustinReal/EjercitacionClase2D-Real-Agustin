using System;
using System.Text;

namespace Producto
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string marca, string codigoDeBarra, float precio)
        {
            this.marca = marca;
            this.precio = precio;
            this.codigoDeBarra = codigoDeBarra;
        }

        public string GetMarca()
        {
            return marca;
        }

        public float GetPrecio()
        {
            return precio;
        }

        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }

        public override string ToString()
        {
            return Producto.MostrarProducto(this);
        }
        public static string MostrarProducto(Producto p)
        {
            StringBuilder sb = new StringBuilder("\nInformacion producto: \n");

            sb.AppendFormat("La marca es {0, -10} \n", p.GetMarca());
            sb.AppendFormat("La precio es {0, -6} \n", p.GetPrecio());
            sb.AppendLine($"Codigo de barras: {p.codigoDeBarra}");

            return sb.ToString();
        }

        public static bool operator ==(Producto p, string marca)
        {
            return p.marca == marca;
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            bool sonIguales = false;

            if(p1 is not null && p2 is not null)
            {
                sonIguales = (p1.marca == p2.marca) && ((string)p1 == (string)p2);
            }
            return sonIguales;
        }

        public static bool operator !=(Producto p, string marca)
        {
            return !(p == marca);
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }
    }
}
