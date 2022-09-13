using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Billetes;

namespace FormCotizador
{
    public partial class Form1 : Form
    {
        bool estadoBloqueado = false;
        public Form1()
        {
            InitializeComponent();
            btnBloquear.BackgroundImage = imageList1.Images[0];
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCotizador_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           if(estadoBloqueado==false)
           {
                btnBloquear.BackgroundImage = imageList1.Images[0];
                txtCotizacionDolar.Enabled = false;
                txtCotizacionEuro.Enabled = false;
                txtCotizacionPeso.Enabled = false;
                estadoBloqueado = true;
           }
           else if (estadoBloqueado == true)
           {
                btnBloquear.BackgroundImage = imageList1.Images[1];

                txtCotizacionDolar.Enabled = true;
                txtCotizacionEuro.Enabled = true;
                txtCotizacionPeso.Enabled = true;
                estadoBloqueado = false;
           }

                this.Refresh();
        }

        private void btnConvertDolar_Click(object sender, EventArgs e)
        {
            double cantidadIngresadaDolar;

            if(double.TryParse(txtCotizacionDolar.Text, out _) && double.TryParse(txtDolar.Text, out cantidadIngresadaDolar))
            {
                Dolar dolarVerificado = cantidadIngresadaDolar;
                
                txtDolarAEuro.Text = ((Euro)dolarVerificado).GetCantidad().ToString();
                txtDolarADolar.Text = dolarVerificado.GetCantidad().ToString();
                txtDolarAPeso.Text = ((Peso)dolarVerificado).GetCantidad().ToString();
            }
            else
            {
                MessageBox.Show("No calculado");
                txtDolar.Focus();
            }
        }

        private void btnConvertEuro_Click(object sender, EventArgs e)
        {
            double cantidadIngresadaEuro;
            double cotizacionEuro;

            if(double.TryParse(txtCotizacionEuro.Text, out cotizacionEuro) && double.TryParse(txtEuro.Text, out cantidadIngresadaEuro))
            {
                Euro euroVerificado = cantidadIngresadaEuro;
                Euro.SetCotizacion(cotizacionEuro);
                txtEuroAEuro.Text = euroVerificado.GetCantidad().ToString();
                txtEuroADolar.Text = ((Dolar)euroVerificado).GetCantidad().ToString();
                txtEuroAPeso.Text = ((Peso)euroVerificado).GetCantidad().ToString();
            }
            else
            {
                MessageBox.Show("No calculado");
                txtEuro.Focus();
            }
        }

        private void btnConvertPeso_Click(object sender, EventArgs e)
        {
            double cantidadIngresadaPeso;
            double cotizacionPeso;

            if(double.TryParse(txtCotizacionPeso.Text, out cotizacionPeso) && double.TryParse(txtPeso.Text, out cantidadIngresadaPeso))
            {
                Peso pesoVerificado = cantidadIngresadaPeso;
                Peso.SerCotizacion(cotizacionPeso);
                txtPesoAEuro.Text = ((Euro)pesoVerificado).GetCantidad().ToString();
                txtPesoADolar.Text = ((Dolar)pesoVerificado).GetCantidad().ToString();
                txtPesoAPeso.Text = pesoVerificado.GetCantidad().ToString();
            }
            else
            {
                MessageBox.Show("No calculo");
                txtPeso.Focus();
            }
        }
    }
}
