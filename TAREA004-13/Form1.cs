using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TAREA004_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<int> lista = new List<int>();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            lista.Add(int.Parse(txtPalabra.Text));
            txtLista1.Clear();
            foreach (var item in lista)
            {
                txtLista1.AppendText(item.ToString() + Environment.NewLine);
            }
            txtPalabra.Clear();
            txtPalabra.Focus();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            txtLista2.Clear();

            for (int i = 0; i < lista.Count; i++)
            {
                int numero = lista[i];
                bool Duplicado = false;
                for (int j = i + 1; j < lista.Count; j++)
                {
                    if (numero == lista[j])
                    {
                        Duplicado = true;
                    }
                }
                if (Duplicado)
                {
                    txtLista2.AppendText(numero.ToString() + Environment.NewLine);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPalabra.Clear();
            txtLista1.Clear();
            txtLista2.Clear();
            lista.Clear();
            txtPalabra.Focus();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

