namespace TAREA004_9
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
            txtCantidad = new TextBox();
            txtPalabra = new TextBox();
            txtLista1 = new TextBox();
            txtLista2 = new TextBox();
            btnAñadir = new Button();
            btnAnalizar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaption;
            label5.Location = new Point(156, 21);
            label5.Name = "label5";
            label5.Size = new Size(531, 15);
            label5.TabIndex = 18;
            label5.Text = "DEVOLVER LAS PALABRAS QUE TENGAS UNA CANTIDAD DE LETRA ESPECIFICADA POR EL USUARIO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(404, 203);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 17;
            label4.Text = "Palabras Filtradas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(404, 49);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 16;
            label3.Text = "Palabras Guardadas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 118);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 15;
            label2.Text = "Ingresa las palabras";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 49);
            label1.Name = "label1";
            label1.Size = new Size(158, 15);
            label1.TabIndex = 14;
            label1.Text = "Ingrese la Cantidad de Letras";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(35, 72);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(232, 23);
            txtCantidad.TabIndex = 19;
            // 
            // txtPalabra
            // 
            txtPalabra.Location = new Point(35, 146);
            txtPalabra.Name = "txtPalabra";
            txtPalabra.Size = new Size(232, 23);
            txtPalabra.TabIndex = 20;
            // 
            // txtLista1
            // 
            txtLista1.Location = new Point(404, 72);
            txtLista1.Multiline = true;
            txtLista1.Name = "txtLista1";
            txtLista1.Size = new Size(232, 111);
            txtLista1.TabIndex = 21;
            // 
            // txtLista2
            // 
            txtLista2.Location = new Point(404, 231);
            txtLista2.Multiline = true;
            txtLista2.Name = "txtLista2";
            txtLista2.Size = new Size(232, 138);
            txtLista2.TabIndex = 22;
            // 
            // btnAñadir
            // 
            btnAñadir.Location = new Point(35, 188);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(151, 23);
            btnAñadir.TabIndex = 23;
            btnAñadir.Text = "Añadir";
            btnAñadir.UseVisualStyleBackColor = true;
            btnAñadir.Click += btnAñadir_Click;
            // 
            // btnAnalizar
            // 
            btnAnalizar.Location = new Point(34, 403);
            btnAnalizar.Name = "btnAnalizar";
            btnAnalizar.Size = new Size(176, 23);
            btnAnalizar.TabIndex = 24;
            btnAnalizar.Text = "Analizar";
            btnAnalizar.UseVisualStyleBackColor = true;
            btnAnalizar.Click += btnFiltrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(326, 403);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(176, 23);
            btnLimpiar.TabIndex = 25;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(595, 403);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(176, 23);
            btnSalir.TabIndex = 26;
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
            Controls.Add(btnAnalizar);
            Controls.Add(btnAñadir);
            Controls.Add(txtLista2);
            Controls.Add(txtLista1);
            Controls.Add(txtPalabra);
            Controls.Add(txtCantidad);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Ejercicio 9";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtCantidad;
        private TextBox txtPalabra;
        private TextBox txtLista1;
        private TextBox txtLista2;
        private Button btnAñadir;
        private Button btnAnalizar;
        private Button btnLimpiar;
        private Button btnSalir;
    }
}
