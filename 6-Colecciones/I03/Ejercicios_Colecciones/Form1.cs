using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 

namespace Ejercicios_Colecciones
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

        private void rtbPalabras_TextChanged(object sender, EventArgs e)
        {
                        
        }

        private Dictionary<string, int> ObtenerContadorDePalabras()
        {
            string texto = rtbPalabras.Text;
            string[] palabras = texto.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> contadorPalabras = new Dictionary<string, int>();

            foreach (string palabra in palabras)
            {
                if(contadorPalabras.ContainsKey(palabra))
                {
                    int contadorPalabrasRepetidas = contadorPalabras[palabra];
                    contadorPalabrasRepetidas++;
                    contadorPalabras[palabra] = contadorPalabrasRepetidas;
                }
                else
                {
                    contadorPalabras.Add(palabra, 1);
                }
            }

            return contadorPalabras;
        }

        private List<KeyValuePair<string, int>> ObtenerPodio(Dictionary<string, int> contadorPalabras)
        {
            List<KeyValuePair<string, int>> podio = contadorPalabras.ToList();

            podio.Sort(delegate (KeyValuePair<string, int> elementoUno, KeyValuePair<string, int> elementoDos)
            {
                return elementoDos.Value - elementoUno.Value;
            });

            return podio;
        }

        private void MostrarPodio(List<KeyValuePair<string, int>> podio)
        {
            StringBuilder sb = new StringBuilder();

            if(podio.Count == 0)
            {
                sb.AppendLine("No se ingresaron palabras.");
            }
            else
            {
                for (int i = 0; i < 3 && i < podio.Count; i++)
                {
                    KeyValuePair<string, int> par = podio[i];
                    sb.AppendLine($"Palabra: {par.Key} - Cantidad: {par.Value}");
                }
            }

            MessageBox.Show(sb.ToString(), "Podio");
        }

        //hola hola hola hola chau que que programacion segunda adios chau chau
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> contadorPalabras = ObtenerContadorDePalabras();
            List<KeyValuePair<string, int>> podio = ObtenerPodio(contadorPalabras);
            MostrarPodio(podio);
        }
    }
}
