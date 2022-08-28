using System;
using System.Text;

namespace Cliente
{
    public class Cliente1
    {
        private string nombre;
        private string apellido;
        private string domicilio;
        private string telefono;
        private Mascota[] mascotasDelCliente;
        private int contador = 0;

        public Cliente1(string nombre, string apellido, string domicilio, string telefono)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.domicilio = domicilio;
        }

        public void CantidadDeMascotas(int cantidad)
        {
            mascotasDelCliente = new Mascota[cantidad];
        }

        public void AsociarMascotas(Mascota unaMascotaParaAsociar)
        {
            if(contador<mascotasDelCliente.Length)
            {
                mascotasDelCliente[contador] = unaMascotaParaAsociar;
                contador++;
            }
        }
       

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder("Informacion del cliente");

            sb.AppendLine($"\nDomicilio: {this.domicilio}");
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Apellido: {this.apellido}");
            sb.AppendLine($"Telefono: {this.telefono}");
            sb.AppendLine($"Mascotas asociadas:");
            foreach(Mascota mascota in mascotasDelCliente)
            {
                if(mascota is not null)
                {
                    sb.Append(mascota.Mostrar());
                }
      
            }

            return sb.ToString();
        }

    }
}
