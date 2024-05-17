namespace TAREA004_3
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
            btnSalir = new Button();
            btnLimpiar = new Button();
            btnFiltrar = new Button();
            btnAñadir = new Button();
            txtNumero = new TextBox();
            txtLista2 = new TextBox();
            txtLista1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            txtDivisor = new TextBox();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(666, 413);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(97, 22);
            btnSalir.TabIndex = 24;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click_1;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(363, 413);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(121, 22);
            btnLimpiar.TabIndex = 23;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(37, 413);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(165, 22);
            btnFiltrar.TabIndex = 22;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // btnAñadir
            // 
            btnAñadir.Location = new Point(37, 220);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(91, 22);
            btnAñadir.TabIndex = 21;
            btnAñadir.Text = "Añadir";
            btnAñadir.UseVisualStyleBackColor = true;
            btnAñadir.Click += btnAñadir_Click;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(37, 174);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(239, 23);
            txtNumero.TabIndex = 20;
            txtNumero.TextChanged += txtNumero_TextChanged;
            // 
            // txtLista2
            // 
            txtLista2.Location = new Point(406, 254);
            txtLista2.Multiline = true;
            txtLista2.Name = "txtLista2";
            txtLista2.Size = new Size(273, 134);
            txtLista2.TabIndex = 19;
            // 
            // txtLista1
            // 
            txtLista1.Location = new Point(406, 87);
            txtLista1.Multiline = true;
            txtLista1.Name = "txtLista1";
            txtLista1.Size = new Size(273, 120);
            txtLista1.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(406, 227);
            label4.Name = "label4";
            label4.Size = new Size(107, 15);
            label4.TabIndex = 16;
            label4.Text = "Numeros divisibles";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(406, 64);
            label3.Name = "label3";
            label3.Size = new Size(116, 15);
            label3.TabIndex = 15;
            label3.Text = "Numeros Guardados";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 147);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 14;
            label2.Text = "Ingrese los numeros";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 64);
            label1.Name = "label1";
            label1.Size = new Size(140, 15);
            label1.TabIndex = 13;
            label1.Text = "Ingrese el número divisor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaption;
            label5.Location = new Point(157, 23);
            label5.Name = "label5";
            label5.Size = new Size(528, 15);
            label5.TabIndex = 25;
            label5.Text = "DEVOLVER LAS NÚMEROS QUE SON DIVISIBLES POR UN NÚMERO ESPECIFICADO POR EL USUARIO";
            // 
            // txtDivisor
            // 
            txtDivisor.Location = new Point(37, 96);
            txtDivisor.Name = "txtDivisor";
            txtDivisor.Size = new Size(239, 23);
            txtDivisor.TabIndex = 26;
            txtDivisor.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtDivisor);
            Controls.Add(label5);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnFiltrar);
            Controls.Add(btnAñadir);
            Controls.Add(txtNumero);
            Controls.Add(txtLista2);
            Controls.Add(txtLista1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalir;
        private Button btnLimpiar;
        private Button btnFiltrar;
        private Button btnAñadir;
        private TextBox txtNumero;
        private TextBox txtLista2;
        private TextBox txtLista1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private TextBox txtDivisor;
    }
}
