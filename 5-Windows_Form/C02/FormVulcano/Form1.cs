using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Convertir;
namespace FormVulcano
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double temperaturaIngresada;
            if(double.TryParse(txtCelsius.Text, out temperaturaIngresada))
            {
                Celsius temperaturaCelsius = temperaturaIngresada;
                txtCelsiusAFahrenhit.Text = ((Fahrenheit)temperaturaCelsius).temperaturaFahren.ToString();
                txtCelsiusACelsius.Text = temperaturaCelsius.temperaturaCel.ToString();
                txtCelsiusAKelvin.Text = ((Kelvin)temperaturaCelsius).temperaturaKel.ToString();
            }
            else
            {
                MessageBox.Show("Error");
                this.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double temperaturaIngresada;

            if(double.TryParse(txtFahrenhit.Text, out temperaturaIngresada))
            {
                Fahrenheit temperaturaEnFahrenhit = temperaturaIngresada;
                txtFahrenhitAFahrenhit.Text = temperaturaEnFahrenhit.temperaturaFahren.ToString();
                txtFahrenhitACelsius.Text = ((Celsius)temperaturaEnFahrenhit).temperaturaCel.ToString();
                txtFahremhitAKelvin.Text = ((Kelvin)temperaturaEnFahrenhit).temperaturaKel.ToString();
            }
            else
            {
                MessageBox.Show("Error");
                this.Focus();
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConvertKelvin_Click(object sender, EventArgs e)
        {
            double temperaturaIngresada;

            if(double.TryParse(txtKelvin.Text, out temperaturaIngresada))
            {
                Kelvin temperaturaKelvin = temperaturaIngresada;
                txtKelvinAFahrenhit.Text = ((Fahrenheit)temperaturaKelvin).temperaturaFahren.ToString();
                txtKelvinACelsius.Text = ((Celsius)temperaturaKelvin).temperaturaCel.ToString();
                txtKelvinAKelvin.Text = temperaturaKelvin.temperaturaKel.ToString();
            }
            else
            {
                MessageBox.Show("Error");
                this.Focus();
            }
        }
    }
}
