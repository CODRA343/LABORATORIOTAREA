namespace TAREA004_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<int> lista1 = new List<int>();
        private List<int> lista2 = new List<int>();
        private void txtConjunto1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnA�adir1_Click(object sender, EventArgs e)
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

        private void btnA�adir2_Click(object sender, EventArgs e)
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

        private void btnRestar_Click(object sender, EventArgs e)
        {
            var lista3 = new List<int>();
            txtLista3.Clear();
            foreach (var item in lista1)
            {
                if (!lista2.Contains(item))
                {
                    lista3.Add(item);
                }
            }
            foreach (var item in lista3)
            {
                txtLista3.AppendText(item + Environment.NewLine);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtConjunto1.Clear();
            txtConjunto2.Clear();
            txtLista1.Clear();
            txtLista2.Clear();
            txtLista3.Clear();
            txtConjunto1.Focus();
            txtConjunto2.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
