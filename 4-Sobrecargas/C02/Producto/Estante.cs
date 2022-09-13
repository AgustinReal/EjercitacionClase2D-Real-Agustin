using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producto
{
     public class Estante
    {
        private Producto[] productosArray;
        private int ubicacionEstante;


        private Estante(int capacidad)
        {
            productosArray = new Producto [capacidad];
        }
        public Estante(int capaciadad, int ubicacion):this(capaciadad)
        {
            this.ubicacionEstante = ubicacion;
        }

        public Producto[] GetProductos
        {
            get
            {
                return this.productosArray;
            }
        }
        
        public static string MostrarEstante(Estante e)
        {
            int i = 0;
            StringBuilder sb = new StringBuilder("Informacion estante: ");
            sb.AppendFormat("La ubicacion del estante: {0, -2}\n", e.ubicacionEstante);

            foreach (Producto unProducto in e.GetProductos)
            {
                i++;
                sb.AppendFormat("N° {0, -1} y el producto es: {1, 40}\n", i + 1, unProducto.ToString());
            }

            return sb.ToString();
        }
        
        public static bool operator ==(Estante e, Producto p)
        {
            bool productoAsignado = false;

            foreach (Producto unProducto in e.GetProductos)
            {
                if (unProducto is not null)
                {
                    if(unProducto == p)
                    {
                        productoAsignado = true;
                        break;
                    }
                }
            }

            return productoAsignado;
        }

        public static bool operator !=(Estante e, Producto p)
        {
            return !(e==p);
        }

        public static bool operator -(Estante e, Producto p)
        {
            bool seQuito = false;

            if(e==p)
            {
                for (int i = 0; i < e.GetProductos.Length; i++)
                {
                    if(e.GetProductos[i]==p)// si el producto esta en el estante
                    {
                        e.GetProductos[i] = null;// saco la referencia del producto
                        seQuito = true;
                    }    
                }
            }

            return seQuito;
        }
        public static bool operator +(Estante e, Producto p)
        {
            bool seAgrego = false;

            if (e != p)
            { 
                for (int i = 0; i < e.productosArray.Length; i++)
                {
                    if(e.productosArray[i] is null)
                    {
                        e.GetProductos[i] = p;//Agrego el producto al array del estante
                        seAgrego = true;
                        break;
                    }
                }
            }

            return seAgrego;
        }
    }
}
