using System.Collections;
using System.Collections.Generic;

namespace TAREA004_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<string> lista = new List<string>();
        private bool Anagrama(string palabra1, string palabra2)
        {
            palabra1 = palabra1.ToLower();
            palabra2 = palabra2.ToLower();
            if (palabra1.Length != palabra2.Length)
            {
                return false;
            }

            var charCounts = new Dictionary<char, int>();
            foreach (char c in palabra1)
            {
                if (!charCounts.ContainsKey(c))
                {
                    charCounts[c] = 0;
                }
                charCounts[c]++;
            }

            foreach (char c in palabra2)
            {
                if (!charCounts.ContainsKey(c) || charCounts[c] == 0)
                {
                    return false;
                }
                charCounts[c]--;
            }

            return true;
        }
            private void btnAñadir_Click(object sender, EventArgs e)
        {
            string palabra = txtPalabras.Text.ToLower();
            lista.Add(palabra);
            txtLista3.Clear();
            foreach (var item in lista)
            {
                txtLista3.AppendText(item.ToString() + Environment.NewLine);
            }
            txtPalabras.Clear();
            txtPalabras.Focus();
        }

        private void btnAnalizar_Click(object sender, EventArgs e)
        {
            string palabra = txtPalabras.Text.ToLower();
            var lista2 = new List<string>();
            txtLista2.Clear();

            foreach (var item in lista)
            {
                if (Anagrama(palabra, item)) // Check for anagrams
                {
                    lista2.Add(item);
                }
            }

            // Display anagrams in txtLista2
            foreach (var item in lista2)
            {
                txtLista2.AppendText(item + Environment.NewLine);
            }
            txtLista2.Clear();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPalabras.Clear();
            txtLista3.Clear();
            txtLista2.Clear();
            txtPalabras.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPalabras_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
