namespace TAREA004_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<string> lista = new List<string>();
        private bool Palindromo(string palabra)
        {
            palabra = palabra.ToLower();
            int izquierda = 0;
            int derecha = palabra.Length - 1;
            while (izquierda < derecha)
            {
                if (palabra[izquierda] != palabra[derecha])
                {
                    return false;
                }
                izquierda++;
                derecha--;
            }

            return true;
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

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            var lista2 = new List<string>();

            foreach (var item in lista)
            {
                if (Palindromo(item))
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
            lista.Clear();
            txtPalabra.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
