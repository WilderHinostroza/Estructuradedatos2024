using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PalabrasComienzanConApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnFiltrarPalabras_Click(object sender, EventArgs e)
        {
            string inputText = txtPalabras.Text;
            string[] palabras = inputText.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            char letra = txtLetra.Text.Trim().ToLower()[0]; // Convertir a minúscula y obtener la primera letra

            HashSet<string> palabrasConLetra = FiltrarPalabrasPorLetra(palabras, letra);

            MessageBox.Show("Palabras que comienzan con '" + letra + "': " + string.Join(", ", palabrasConLetra));
        }

        private HashSet<string> FiltrarPalabrasPorLetra(string[] palabras, char letra)
        {
            HashSet<string> palabrasConLetra = new HashSet<string>();

            foreach (string palabra in palabras)
            {
                if (!string.IsNullOrEmpty(palabra) && palabra.ToLower()[0] == letra)
                {
                    palabrasConLetra.Add(palabra);
                }
            }

            return palabrasConLetra;
        }
    }
}
