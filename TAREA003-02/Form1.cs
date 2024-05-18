namespace TAREA003_02
{
    public partial class Form1 : Form
    {
        Jefe jefe;
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            string dni = txtDNI.Text;
            string cargo = cboCargo.Text;
            string area = cboArea.Text;
            int años = int.Parse(txtAños.Text);

            jefe = new Jefe(codigo, dni, cargo, area, años);
            MessageBox.Show("Objeto Creado");
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            txtResultado.AppendText("Objeto Nro: " + Jefe.GetContador().ToString() + Environment.NewLine);
            txtResultado.AppendText("Codigo: " + jefe.Codigo + Environment.NewLine);
            txtResultado.AppendText("DNI: " + jefe.DNI + Environment.NewLine);
            txtResultado.AppendText("Cargo: " + jefe.Cargo + Environment.NewLine);
            txtResultado.AppendText("Area: " + jefe.Area + Environment.NewLine);
            txtResultado.AppendText("Años: " + jefe.Años + Environment.NewLine);
            txtResultado.AppendText("Sueldo Base: " + jefe.SueldoBase() + Environment.NewLine);
            txtResultado.AppendText("Bonificación: " + jefe.Bonificacion() + Environment.NewLine);
            txtResultado.AppendText("Porcentaje: " + jefe.Porcentaje() + Environment.NewLine);
            txtResultado.AppendText("Sueldo Final: " + jefe.SueldoFinal() + Environment.NewLine);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = string.Empty;
            txtDNI.Clear();
            txtResultado.Clear();
            txtAños.Clear();
            txtCodigo.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
