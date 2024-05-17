namespace TAREA003_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFlitrar_Click(object sender, EventArgs e)
        {
            string letra = txtLetra.Text.ToUpper();
            string palabras = txtPalabras.Text;

            string[] filtros = palabras.Split(' ');

            List<string> filtradas = new List<string>();

            foreach (string filtro in filtros)
            {
                if (filtro.StartsWith(letra))
                {
                    filtradas.Add(filtro);
                }
            }
            txtFiltradas.Text = string.Join(", ", filtradas);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
