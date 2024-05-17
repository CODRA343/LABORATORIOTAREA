namespace TAREA004_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<int> lista = new List<int>();
        static bool EsPrimo(int numero)
        {
            for (int i = 2; i < numero; i++)
            {
                if ((numero % i) == 0)
                {
                    return false;
                }
            }
            return true;
        }
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
            var lista2 = new List<int>();
            txtLista2.Clear();
            foreach (var item in lista)
            {
                var p = EsPrimo(item);
                if (p)
                {
                    lista2.Add(item);
                }
            }
            lista2.Sort();
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
            lista.Clear();
            txtPalabra.Focus();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
