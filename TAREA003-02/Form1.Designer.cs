namespace TAREA003_02
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
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtCodigo = new TextBox();
            txtDNI = new TextBox();
            txtAños = new TextBox();
            cboCargo = new ComboBox();
            cboArea = new ComboBox();
            txtResultado = new TextBox();
            btnCrear = new Button();
            btnMostrar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(527, 18);
            label5.Name = "label5";
            label5.Size = new Size(103, 15);
            label5.TabIndex = 9;
            label5.Text = "Años de Actividad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(264, 77);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 8;
            label4.Text = "Área";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(264, 18);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 7;
            label3.Text = "Cargo";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 77);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 6;
            label2.Text = "DNI";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 18);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 5;
            label1.Text = "Código";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(22, 43);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(204, 23);
            txtCodigo.TabIndex = 10;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(20, 104);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(204, 23);
            txtDNI.TabIndex = 11;
            // 
            // txtAños
            // 
            txtAños.Location = new Point(527, 43);
            txtAños.Name = "txtAños";
            txtAños.Size = new Size(204, 23);
            txtAños.TabIndex = 14;
            // 
            // cboCargo
            // 
            cboCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCargo.FormattingEnabled = true;
            cboCargo.Items.AddRange(new object[] { "Gerente", "Subgerente" });
            cboCargo.Location = new Point(264, 43);
            cboCargo.Name = "cboCargo";
            cboCargo.Size = new Size(206, 23);
            cboCargo.TabIndex = 15;
            // 
            // cboArea
            // 
            cboArea.DropDownStyle = ComboBoxStyle.DropDownList;
            cboArea.FormattingEnabled = true;
            cboArea.Items.AddRange(new object[] { "Contabilidad", "Planificación" });
            cboArea.Location = new Point(264, 104);
            cboArea.Name = "cboArea";
            cboArea.Size = new Size(206, 23);
            cboArea.TabIndex = 16;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(20, 155);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(709, 234);
            txtResultado.TabIndex = 17;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(20, 400);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(147, 27);
            btnCrear.TabIndex = 18;
            btnCrear.Text = "Crear Objeto";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(173, 400);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(250, 27);
            btnMostrar.TabIndex = 19;
            btnMostrar.Text = "Mostrar Información";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(429, 400);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(147, 27);
            btnLimpiar.TabIndex = 20;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(582, 400);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(147, 27);
            btnSalir.TabIndex = 21;
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
            Controls.Add(cboArea);
            Controls.Add(cboCargo);
            Controls.Add(txtAños);
            Controls.Add(txtDNI);
            Controls.Add(txtCodigo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "EJERCICIO2";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtCodigo;
        private TextBox txtDNI;
        private TextBox txtAños;
        private ComboBox cboCargo;
        private ComboBox cboArea;
        private TextBox txtResultado;
        private Button btnCrear;
        private Button btnMostrar;
        private Button btnLimpiar;
        private Button btnSalir;
    }
}
