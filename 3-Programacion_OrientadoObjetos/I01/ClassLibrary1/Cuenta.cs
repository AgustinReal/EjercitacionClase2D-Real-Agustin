using System;
using System.Text;

namespace Banco
{
    public class Cuenta
    {
        private string titular;
        private int cantidad;

        public Cuenta(string titular, int cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        //getters
        public string getTitular()
        {
            return this.titular;
        }

        public int getCantidad()
        {
            return this.cantidad;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder("Info user: \n");

            sb.AppendLine($"Titular de la cuenta es: {getTitular()}");
            sb.AppendLine($"La cantidad: {cantidad}");

            return sb.ToString();
        }

        public void Ingresar(int saldo)
        {
            if (saldo >= 0)
            {
                this.cantidad += saldo;
            }
        }

        public void Retirar(int saldo)
        {
            if (saldo >= 0)
            {
                this.cantidad -= saldo;
            }
        }
    }
}
