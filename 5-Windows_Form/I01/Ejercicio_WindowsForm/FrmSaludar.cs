using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_WindowsForm
{
    public partial class FrmSaludar : Form
    {
        private string titulo;
        private string saludar;
        public FrmSaludar(string titulo, string saludar)
        {
            this.titulo = titulo;
            this.saludar = saludar;
            InitializeComponent();
        }

        private void FrmSaludar_Load(object sender, EventArgs e)// antes de mostrar el formulario por pantalla
        {
            lblTitulo.Text = this.titulo;
            lblMensaje.Text = this.saludar;
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void lblMensaje_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
