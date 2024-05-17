namespace TAREA004_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<int> lista = new List<int>();

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            lista.Add(int.Parse(txtNumero.Text));
            txtLista1.Clear();
            foreach (var item in lista)
            {
                txtLista1.AppendText(item.ToString() + Environment.NewLine);
            }
            txtNumero.Clear();
            txtNumero.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            int divisor = int.Parse(txtDivisor.Text);
            var lista2 = new List<int>();
            foreach (var item in lista)
            {
                if (item % divisor == 0)
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
            txtDivisor.Clear();
            txtNumero.Clear();
            txtLista1.Clear();
            txtLista2.Clear();
            txtNumero.Focus();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

