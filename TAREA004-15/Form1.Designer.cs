namespace TAREA004_15
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
            btnSalir = new Button();
            btnLimpiar = new Button();
            btnFiltrar = new Button();
            btnAñadir = new Button();
            txtPalabra = new TextBox();
            txtLista2 = new TextBox();
            txtLista1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaption;
            label5.Location = new Point(216, 18);
            label5.Name = "label5";
            label5.Size = new Size(381, 15);
            label5.TabIndex = 26;
            label5.Text = "DEVOLVER LOS NÚMEROS PRIMOS ORDENADOS DE MENOR A MAYOR";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(666, 407);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(97, 22);
            btnSalir.TabIndex = 25;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click_1;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(363, 407);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(121, 22);
            btnLimpiar.TabIndex = 24;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(37, 407);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(165, 22);
            btnFiltrar.TabIndex = 23;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // btnAñadir
            // 
            btnAñadir.Location = new Point(37, 135);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(91, 22);
            btnAñadir.TabIndex = 22;
            btnAñadir.Text = "Añadir";
            btnAñadir.UseVisualStyleBackColor = true;
            btnAñadir.Click += btnAñadir_Click;
            // 
            // txtPalabra
            // 
            txtPalabra.Location = new Point(37, 89);
            txtPalabra.Name = "txtPalabra";
            txtPalabra.Size = new Size(239, 23);
            txtPalabra.TabIndex = 21;
            // 
            // txtLista2
            // 
            txtLista2.Location = new Point(406, 239);
            txtLista2.Multiline = true;
            txtLista2.Name = "txtLista2";
            txtLista2.ReadOnly = true;
            txtLista2.Size = new Size(273, 134);
            txtLista2.TabIndex = 20;
            // 
            // txtLista1
            // 
            txtLista1.Location = new Point(406, 72);
            txtLista1.Multiline = true;
            txtLista1.Name = "txtLista1";
            txtLista1.ReadOnly = true;
            txtLista1.Size = new Size(273, 120);
            txtLista1.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(406, 212);
            label4.Name = "label4";
            label4.Size = new Size(257, 15);
            label4.TabIndex = 17;
            label4.Text = "Números Primos Ordenados de Menor a Mayor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(406, 49);
            label3.Name = "label3";
            label3.Size = new Size(116, 15);
            label3.TabIndex = 16;
            label3.Text = "Números Guardados";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 62);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 15;
            label2.Text = "Ingresa los Números";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnFiltrar);
            Controls.Add(btnAñadir);
            Controls.Add(txtPalabra);
            Controls.Add(txtLista2);
            Controls.Add(txtLista1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Form1";
            Text = "EJERCICIO 15";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Button btnSalir;
        private Button btnLimpiar;
        private Button btnFiltrar;
        private Button btnAñadir;
        private TextBox txtPalabra;
        private TextBox txtLista2;
        private TextBox txtLista1;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}
