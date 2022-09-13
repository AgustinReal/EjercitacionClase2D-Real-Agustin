using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaIngresante;
using System.Windows.Forms;




namespace Ejercicio_WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Pais.Items.Add("Argentina");
            Pais.Items.Add("Chile");
            Pais.Items.Add("Uruaguay");
        }

        private string SelecionarGenero()
        {
            string generoIngresado = "";

            if(rdbMasculino.Checked == true)
            {
                generoIngresado = "Masculino";
            }

            if(rdbFemenino.Checked == true)
            {
                generoIngresado = "Femenino";
            }

            if(rdbNoBinario.Checked == true)
            {
                generoIngresado = "No binario";
            }

            return generoIngresado;
        }

        private string[] arrayCursos()
        {
            string[] arrayDeCursos = new string[3];

            if(checkBoxCsharp.Checked == true)
            {
                arrayDeCursos[0] = "C#";
            }
            if(checkBoxCMasMas.Checked == true)
            {
                arrayDeCursos[1] = "C++";
            }
            if(checkBoxJavaScript.Checked == true)
            {
                arrayDeCursos[2] = "JavaScript";
            }

            return arrayDeCursos;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            int edad = (int)edadNumeric.Value;
            string[] cursos = arrayCursos(); 

            Ingresante ingresante = new Ingresante(cursos, txtDireccion.Text, edad, SelecionarGenero(), txtNombre.Text, Pais.Text);
            MessageBox.Show(ingresante.Mostrar(), "", MessageBoxButtons.OK);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void edad_ValueChanged(object sender, EventArgs e)
        {

        }

        private void rdbMasculino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbFemenino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbNoBinario_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxJavaScript_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxCMasMas_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxCsharp_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
