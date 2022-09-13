using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Comercio
{
    public class PuestoAtencion
    {
        public enum Puesto
        {
            Caja1,
            Caja2
        }

        private static int numeroActual;
        private Puesto puesto;

        static PuestoAtencion()
        {
            numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }

        public bool Atender(Cliente cli)
        {
            bool seAtendio = false; 

            if(cli is not null)
            {
                Thread.Sleep(2000);
                seAtendio = true; 
            }

            return seAtendio;
        }

        public static int NumeroActual
        {
            get
            {
                return numeroActual+=1;
            }
        }
    }
}
