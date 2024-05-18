namespace TAREA003_01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            cboContrato = new ComboBox();
            cboEspecialidad = new ComboBox();
            cboActividad = new ComboBox();
            cboAfiliacion = new ComboBox();
            txtResultado = new TextBox();
            btnCrear = new Button();
            btnMostrar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 12);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Código";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 80);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(280, 12);
            label3.Name = "label3";
            label3.Size = new Size(128, 15);
            label3.TabIndex = 2;
            label3.Text = "Condición de Contrato";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(280, 80);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 3;
            label4.Text = "Especialidad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(543, 12);
            label5.Name = "label5";
            label5.Size = new Size(99, 15);
            label5.TabIndex = 4;
            label5.Text = "Tipo de Actividad";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(543, 80);
            label6.Name = "label6";
            label6.Size = new Size(99, 15);
            label6.TabIndex = 5;
            label6.Text = "Tipo de Afiliación";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(38, 36);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(198, 23);
            txtCodigo.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(38, 108);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(198, 23);
            txtNombre.TabIndex = 7;
            // 
            // cboContrato
            // 
            cboContrato.DropDownStyle = ComboBoxStyle.DropDownList;
            cboContrato.FormattingEnabled = true;
            cboContrato.Items.AddRange(new object[] { "Estable", "Contratado" });
            cboContrato.Location = new Point(280, 36);
            cboContrato.Name = "cboContrato";
            cboContrato.Size = new Size(198, 23);
            cboContrato.TabIndex = 12;
            // 
            // cboEspecialidad
            // 
            cboEspecialidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEspecialidad.FormattingEnabled = true;
            cboEspecialidad.Items.AddRange(new object[] { "Estructuras", "Recursos Hídricos" });
            cboEspecialidad.Location = new Point(280, 108);
            cboEspecialidad.Name = "cboEspecialidad";
            cboEspecialidad.Size = new Size(198, 23);
            cboEspecialidad.TabIndex = 13;
            // 
            // cboActividad
            // 
            cboActividad.DropDownStyle = ComboBoxStyle.DropDownList;
            cboActividad.FormattingEnabled = true;
            cboActividad.Items.AddRange(new object[] { "Supervisión de Obras", "Supervisión de Vías" });
            cboActividad.Location = new Point(543, 36);
            cboActividad.Name = "cboActividad";
            cboActividad.Size = new Size(198, 23);
            cboActividad.TabIndex = 14;
            // 
            // cboAfiliacion
            // 
            cboAfiliacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAfiliacion.FormattingEnabled = true;
            cboAfiliacion.Items.AddRange(new object[] { "AFP", "SNP" });
            cboAfiliacion.Location = new Point(543, 108);
            cboAfiliacion.Name = "cboAfiliacion";
            cboAfiliacion.Size = new Size(198, 23);
            cboAfiliacion.TabIndex = 15;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(38, 149);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(703, 224);
            txtResultado.TabIndex = 16;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(36, 393);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(134, 23);
            btnCrear.TabIndex = 17;
            btnCrear.Text = "Crear Objeto";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(176, 393);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(213, 23);
            btnMostrar.TabIndex = 18;
            btnMostrar.Text = "Mostrar Información";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(395, 393);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(173, 23);
            btnLimpiar.TabIndex = 19;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(574, 393);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(173, 23);
            btnSalir.TabIndex = 20;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnMostrar);
            Controls.Add(btnCrear);
            Controls.Add(txtResultado);
            Controls.Add(cboAfiliacion);
            Controls.Add(cboActividad);
            Controls.Add(cboEspecialidad);
            Controls.Add(cboContrato);
            Controls.Add(txtNombre);
            Controls.Add(txtCodigo);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "EJERCICIO1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtCodigo;
        private TextBox txtNombre;
        private ComboBox cboContrato;
        private ComboBox cboEspecialidad;
        private ComboBox cboActividad;
        private ComboBox cboAfiliacion;
        private TextBox txtResultado;
        private Button btnCrear;
        private Button btnMostrar;
        private Button btnLimpiar;
        private Button btnSalir;
    }
}
