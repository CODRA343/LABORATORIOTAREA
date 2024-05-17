namespace TAREA004_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<string> lista = new List<string>();

        private void cboPalabra_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            string palabra = txtPalabra.Text.ToLower();
            lista.Add(palabra);
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
            string letra = cboPalabra.Text.ToLower();
            var lista2 = new List<string>();

            foreach (var item in lista)
            {
                if (item.ToLower().Contains(letra))
                {
                    lista2.Add(item);
                }
            }

            txtLista2.Clear();
            foreach (var item in lista2)
            {
                txtLista2.AppendText(item + Environment.NewLine);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPalabra.Clear();
            txtLista1.Clear();
            txtLista2.Clear();
            txtPalabra.Focus();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
