namespace TAREA004_7
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
            label6 = new Label();
            label5 = new Label();
            txtLista1 = new Label();
            label2 = new Label();
            txtPalabras = new TextBox();
            txtLista3 = new TextBox();
            txtLista2 = new TextBox();
            btnAnalizar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            btnAñadir = new Button();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(408, 65);
            label6.Name = "label6";
            label6.Size = new Size(114, 15);
            label6.TabIndex = 46;
            label6.Text = "Palabras Anagramas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaption;
            label5.Location = new Point(271, 27);
            label5.Name = "label5";
            label5.Size = new Size(211, 15);
            label5.TabIndex = 45;
            label5.Text = "ENCONTRAR PALABRAS ANAGRAMAS";
            // 
            // txtLista1
            // 
            txtLista1.AutoSize = true;
            txtLista1.Location = new Point(29, 175);
            txtLista1.Name = "txtLista1";
            txtLista1.Size = new Size(110, 15);
            txtLista1.TabIndex = 44;
            txtLista1.Text = "Palabras Ingresadas";
            txtLista1.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 65);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 43;
            label2.Text = "Ingrese las Palabras";
            // 
            // txtPalabras
            // 
            txtPalabras.Location = new Point(31, 92);
            txtPalabras.Name = "txtPalabras";
            txtPalabras.Size = new Size(270, 23);
            txtPalabras.TabIndex = 47;
            txtPalabras.TextChanged += txtPalabras_TextChanged;
            // 
            // txtLista3
            // 
            txtLista3.Location = new Point(31, 205);
            txtLista3.Multiline = true;
            txtLista3.Name = "txtLista3";
            txtLista3.Size = new Size(270, 165);
            txtLista3.TabIndex = 48;
            // 
            // txtLista2
            // 
            txtLista2.Location = new Point(408, 92);
            txtLista2.Multiline = true;
            txtLista2.Name = "txtLista2";
            txtLista2.Size = new Size(299, 278);
            txtLista2.TabIndex = 49;
            // 
            // btnAnalizar
            // 
            btnAnalizar.Location = new Point(31, 403);
            btnAnalizar.Name = "btnAnalizar";
            btnAnalizar.Size = new Size(143, 25);
            btnAnalizar.TabIndex = 50;
            btnAnalizar.Text = "Analizar";
            btnAnalizar.UseVisualStyleBackColor = true;
            btnAnalizar.Click += btnAnalizar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(298, 403);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(143, 25);
            btnLimpiar.TabIndex = 51;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(564, 403);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(143, 25);
            btnSalir.TabIndex = 52;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnAñadir
            // 
            btnAñadir.Location = new Point(31, 134);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(143, 25);
            btnAñadir.TabIndex = 53;
            btnAñadir.Text = "Añadir";
            btnAñadir.UseVisualStyleBackColor = true;
            btnAñadir.Click += btnAñadir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAñadir);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAnalizar);
            Controls.Add(txtLista2);
            Controls.Add(txtLista3);
            Controls.Add(txtPalabras);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtLista1);
            Controls.Add(label2);
            Name = "Form1";
            Text = "EJERCICIO 7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private Label txtLista1;
        private Label label2;
        private TextBox txtPalabras;
        private TextBox txtLista3;
        private TextBox txtLista2;
        private Button btnAnalizar;
        private Button btnLimpiar;
        private Button btnSalir;
        private Button btnAñadir;
    }
}
