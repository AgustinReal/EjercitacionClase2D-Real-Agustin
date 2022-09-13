using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercio
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        public Cliente Cliente
        {
            get
            {
                return clientes.Dequeue();
            }
            set
            {
                _ = this + value;
            }
        }

        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
        }

        public Negocio(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public static bool operator ==(Negocio n, Cliente c)
        {
            bool enElNegocio = false;

            foreach (Cliente cliente in n.clientes)
            {
                if (cliente == c)
                {
                    enElNegocio = true;
                }
            }

            return enElNegocio;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            bool estaEnLsita = false;

            if(n!=c)
            {
                n.clientes.Enqueue(c);
                estaEnLsita = true;
            }

            return estaEnLsita;
        }

        public static bool operator ~(Negocio n)
        {

            if(n.clientes.Count < 0)
            {
                return n.caja.Atender(n.Cliente);
            }

            return false;
        }

        public int ClientesPendientes
        {
            get
            {
                return this.clientes.Count;
            }
        }
    }
}
