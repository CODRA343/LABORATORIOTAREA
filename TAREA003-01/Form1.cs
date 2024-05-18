namespace TAREA003_01
{
    public partial class Form1 : Form
    {
        Arquitecto arquitecto;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            string nombre = txtNombre.Text;
            string contrato = cboContrato.Text;
            string especialidad = cboEspecialidad.Text;
            string actividad = cboActividad.Text;
            string afiliacion = cboAfiliacion.Text;

            arquitecto = new Arquitecto(codigo, nombre, contrato, especialidad, actividad, afiliacion);
            MessageBox.Show("Objeto Creado");
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            txtResultado.AppendText("Objeto Nro: " + Arquitecto.GetContador().ToString() + Environment.NewLine);
            txtResultado.AppendText("Codigo: " + arquitecto.Codigo + Environment.NewLine);
            txtResultado.AppendText("Nombre: " + arquitecto.Nombre + Environment.NewLine);
            txtResultado.AppendText("Contrato: " + arquitecto.Contrato + Environment.NewLine);
            txtResultado.AppendText("Especialidad: " + arquitecto.Especialidad + Environment.NewLine);
            txtResultado.AppendText("Actividad: " + arquitecto.Actividad + Environment.NewLine);
            txtResultado.AppendText("Afiliacion: " + arquitecto.Afiliacion + Environment.NewLine);
            txtResultado.AppendText("Sueldo Base: " + arquitecto.SueldoBase() + Environment.NewLine);
            txtResultado.AppendText("Bonificacion: " + arquitecto.Bonificacion() + Environment.NewLine);
            txtResultado.AppendText("Descuento: " + arquitecto.Descuento() + Environment.NewLine);
            txtResultado.AppendText("Sueldo Bruto: " + arquitecto.SueldoBruto() + Environment.NewLine);
            txtResultado.AppendText("Sueldo Neto: " + arquitecto.SueldoNeto() + Environment.NewLine);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = string.Empty;
            txtNombre.Clear();
            txtResultado.Clear();
            txtCodigo.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
