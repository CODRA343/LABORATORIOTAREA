namespace TAREA004_4
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
            txtConjunto1 = new TextBox();
            txtLista2 = new TextBox();
            txtLista1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnAñadir2 = new Button();
            txtConjunto2 = new TextBox();
            label1 = new Label();
            txtLista3 = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaption;
            label5.Location = new Point(327, 21);
            label5.Name = "label5";
            label5.Size = new Size(132, 15);
            label5.TabIndex = 38;
            label5.Text = "UNIÓN DE CONJUNTOS";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(666, 409);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(97, 22);
            btnSalir.TabIndex = 37;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(363, 409);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(121, 22);
            btnLimpiar.TabIndex = 36;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click_1;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(37, 409);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(165, 22);
            btnFiltrar.TabIndex = 35;
            btnFiltrar.Text = "Unión";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click_1;
            // 
            // btnAñadir
            // 
            btnAñadir.Location = new Point(37, 131);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(91, 22);
            btnAñadir.TabIndex = 34;
            btnAñadir.Text = "Añadir";
            btnAñadir.UseVisualStyleBackColor = true;
            btnAñadir.Click += btnAñadir_Click_1;
            // 
            // txtConjunto1
            // 
            txtConjunto1.Location = new Point(37, 102);
            txtConjunto1.Name = "txtConjunto1";
            txtConjunto1.Size = new Size(127, 23);
            txtConjunto1.TabIndex = 33;
            // 
            // txtLista2
            // 
            txtLista2.Location = new Point(239, 196);
            txtLista2.Multiline = true;
            txtLista2.Name = "txtLista2";
            txtLista2.Size = new Size(149, 184);
            txtLista2.TabIndex = 32;
            // 
            // txtLista1
            // 
            txtLista1.Location = new Point(37, 196);
            txtLista1.Multiline = true;
            txtLista1.Name = "txtLista1";
            txtLista1.Size = new Size(127, 184);
            txtLista1.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(239, 170);
            label4.Name = "label4";
            label4.Size = new Size(107, 15);
            label4.TabIndex = 30;
            label4.Text = "Numeros divisibles";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 170);
            label3.Name = "label3";
            label3.Size = new Size(116, 15);
            label3.TabIndex = 29;
            label3.Text = "Numeros Guardados";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 60);
            label2.Name = "label2";
            label2.Size = new Size(113, 30);
            label2.TabIndex = 28;
            label2.Text = "Ingrese los numeros\r\ndel primer conjunto";
            // 
            // btnAñadir2
            // 
            btnAñadir2.Location = new Point(239, 131);
            btnAñadir2.Name = "btnAñadir2";
            btnAñadir2.Size = new Size(91, 22);
            btnAñadir2.TabIndex = 41;
            btnAñadir2.Text = "Añadir";
            btnAñadir2.UseVisualStyleBackColor = true;
            btnAñadir2.Click += btnAñadir2_Click;
            // 
            // txtConjunto2
            // 
            txtConjunto2.Location = new Point(239, 102);
            txtConjunto2.Name = "txtConjunto2";
            txtConjunto2.Size = new Size(149, 23);
            txtConjunto2.TabIndex = 40;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(239, 60);
            label1.Name = "label1";
            label1.Size = new Size(123, 30);
            label1.TabIndex = 39;
            label1.Text = "Ingrese los numeros\r\ndel segundo conjunto\r\n";
            label1.Click += label1_Click;
            // 
            // txtLista3
            // 
            txtLista3.Location = new Point(449, 83);
            txtLista3.Multiline = true;
            txtLista3.Name = "txtLista3";
            txtLista3.Size = new Size(274, 297);
            txtLista3.TabIndex = 43;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(449, 60);
            label6.Name = "label6";
            label6.Size = new Size(131, 15);
            label6.TabIndex = 42;
            label6.Text = "Unión de los Conjuntos";
            label6.Click += label6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtLista3);
            Controls.Add(label6);
            Controls.Add(btnAñadir2);
            Controls.Add(txtConjunto2);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnFiltrar);
            Controls.Add(btnAñadir);
            Controls.Add(txtConjunto1);
            Controls.Add(txtLista2);
            Controls.Add(txtLista1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Ejercicio 4";
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
        private TextBox txtConjunto1;
        private TextBox txtLista2;
        private TextBox txtLista1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnAñadir2;
        private TextBox txtConjunto2;
        private Label label1;
        private TextBox txtLista3;
        private Label label6;
    }
}
