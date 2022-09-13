using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conversor;

namespace FormConvertorBinario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBinToDec_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtBinario.Text))
            {
                NumeroBinario numeroVerificado = txtBinario.Text;

                txtResultadoDec.Text = ((NumeroDecimal)numeroVerificado).numeroDec.ToString();
            }
            else
            {
                MessageBox.Show("Error");
                this.Focus();
            }
        }

        private void btnDecToBin_Click(object sender, EventArgs e)
        {
            int numeroIngresado;

            if(int.TryParse(txtDecimal.Text, out numeroIngresado))
            {
                NumeroDecimal numeroVerificado = numeroIngresado;

                txtResultadoBin.Text = ((NumeroBinario)numeroVerificado).numeroBin.ToString();
            }
            else
            {
                MessageBox.Show("Error");
                this.Focus();
            }
        }
    }
}
