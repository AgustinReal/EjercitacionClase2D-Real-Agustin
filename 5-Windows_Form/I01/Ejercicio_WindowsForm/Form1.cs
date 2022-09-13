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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string titulo = "¡Hola, windows form!";
            string mensaje = $"Soy {txtNombre.Text} {txtApellido.Text} y mi materia favorita es {cmbMaterias.Text}";

            if(validarTextoIngresado()==true)
            {
                FrmSaludar Saludo = new FrmSaludar(titulo, mensaje);
                Saludo.ShowDialog();
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] valoresMateriasCheckBox = new string[11];

            valoresMateriasCheckBox[0] = "Sistemas procesamientos de datos";
            valoresMateriasCheckBox[1] = "Matematicas I";
            valoresMateriasCheckBox[2] = "Ingles I";
            valoresMateriasCheckBox[3] = "Programacion I";
            valoresMateriasCheckBox[4] = "Laboratorio I";
            valoresMateriasCheckBox[5] = "Ingles II";
            valoresMateriasCheckBox[6] = "Metodologia de la investigacion";
            valoresMateriasCheckBox[7] = "Programacion II";
            valoresMateriasCheckBox[8] = "Laboratorio II";
            valoresMateriasCheckBox[9] = "Estadistica";
            valoresMateriasCheckBox[10] = "Arquitectura en sistemas operativos";

            cmbMaterias.DataSource = valoresMateriasCheckBox;
            cmbMaterias.SelectedItem =valoresMateriasCheckBox[7];
        }

        private bool validarTextoIngresado()
        {
            bool campoIngresado = true;
            StringBuilder sb = new StringBuilder("Se deben completar los siguientes campos: \n");

            if(string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                campoIngresado = false;
                sb.AppendLine("Nombre");
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                campoIngresado = false;
                sb.AppendLine("Apellido");
            }

            if(campoIngresado == false)
            {
                MessageBox.Show(sb.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return campoIngresado;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
