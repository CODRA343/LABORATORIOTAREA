namespace TAREA004_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<int> lista1 = new List<int>();
        private List<int> lista2 = new List<int>();
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnAñadir1_Click(object sender, EventArgs e)
        {
            lista1.Add(int.Parse(txtConjunto1.Text));
            txtLista1.Clear();
            foreach (var item in lista1)
            {
                txtLista1.AppendText(item.ToString() + Environment.NewLine);
            }
            txtConjunto1.Clear();
            txtConjunto1.Focus();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            lista2.Add(int.Parse(txtConjunto2.Text));
            txtLista2.Clear();
            foreach (var item in lista2)
            {
                txtLista2.AppendText(item.ToString() + Environment.NewLine);
            }
            txtConjunto2.Clear();
            txtConjunto2.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var lista3 = new List<int>();
            txtLista3.Clear();
            foreach (var item in lista2)
            {
                if (!lista1.Contains(item))
                {
                    lista3.Add(item);
                }
            }
            foreach (var item in lista3)
            {
                txtLista3.AppendText(item + Environment.NewLine);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtConjunto1.Clear();
            txtConjunto2.Clear();
            txtLista1.Clear();
            txtLista2.Clear();
            txtLista3.Clear();
            lista1.Clear();
            lista2.Clear();
            txtConjunto1.Focus();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void txtConjunto2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
