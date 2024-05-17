namespace TAREA004_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<string> lista = new List<string>();
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
            int letra = int.Parse(txtCantidad.Text);
            var lista2 = new List<string>();

            txtLista2.Clear();

            foreach (var item in lista)
            {
                if (item.Length == letra)
                {
                    lista2.Add(item);
                }
            }

            foreach (var item in lista2)
            {
                txtLista2.AppendText(item + Environment.NewLine);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCantidad.Clear();
            txtPalabra.Clear();
            txtLista1.Clear();
            txtLista2.Clear();
            txtCantidad.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
