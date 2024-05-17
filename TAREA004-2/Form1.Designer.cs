namespace TAREA004_2
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
            cboPalabra = new ComboBox();
            txtLista1 = new TextBox();
            txtLista2 = new TextBox();
            txtPalabra = new TextBox();
            btnAñadir = new Button();
            btnFiltrar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 47);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese la letra";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 130);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 1;
            label2.Text = "Ingresa las palabras";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(387, 47);
            label3.Name = "label3";
            label3.Size = new Size(109, 15);
            label3.TabIndex = 2;
            label3.Text = "Palabras guardadas";
            label3.Click += this.label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(387, 210);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 3;
            label4.Text = "Palabras Filtradas";
            label4.Click += this.label4_Click;
            // 
            // cboPalabra
            // 
            cboPalabra.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPalabra.FormattingEnabled = true;
            cboPalabra.Items.AddRange(new object[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "ñ", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" });
            cboPalabra.Location = new Point(18, 81);
            cboPalabra.Name = "cboPalabra";
            cboPalabra.Size = new Size(121, 23);
            cboPalabra.TabIndex = 5;
            cboPalabra.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtLista1
            // 
            txtLista1.Location = new Point(387, 70);
            txtLista1.Multiline = true;
            txtLista1.Name = "txtLista1";
            txtLista1.ReadOnly = true;
            txtLista1.Size = new Size(273, 120);
            txtLista1.TabIndex = 6;
            txtLista1.TextChanged += this.txtLista1_TextChanged;
            // 
            // txtLista2
            // 
            txtLista2.Location = new Point(387, 237);
            txtLista2.Multiline = true;
            txtLista2.Name = "txtLista2";
            txtLista2.ReadOnly = true;
            txtLista2.Size = new Size(273, 134);
            txtLista2.TabIndex = 7;
            txtLista2.TextChanged += this.txtLista2_TextChanged;
            // 
            // txtPalabra
            // 
            txtPalabra.Location = new Point(18, 157);
            txtPalabra.Name = "txtPalabra";
            txtPalabra.Size = new Size(239, 23);
            txtPalabra.TabIndex = 8;
            txtPalabra.TextChanged += txtPalabra_TextChanged;
            // 
            // btnAñadir
            // 
            btnAñadir.Location = new Point(18, 203);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(91, 22);
            btnAñadir.TabIndex = 9;
            btnAñadir.Text = "Añadir";
            btnAñadir.UseVisualStyleBackColor = true;
            btnAñadir.Click += button1_Click;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(18, 405);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(165, 22);
            btnFiltrar.TabIndex = 10;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += button2_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(344, 405);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(121, 22);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += button3_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(647, 405);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(97, 22);
            btnSalir.TabIndex = 12;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaption;
            label5.Location = new Point(139, 19);
            label5.Name = "label5";
            label5.Size = new Size(480, 15);
            label5.TabIndex = 13;
            label5.Text = "DEVOLVER LAS PALABRAS QUE INICIEN CON UNA LETRA ESPECIFICADA POR EL USUARIO";
            label5.Click += label5_Click;
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
            Controls.Add(cboPalabra);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "EJERCICIO 2";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cboPalabra;
        private TextBox txtLista1;
        private TextBox txtLista2;
        private TextBox txtPalabra;
        private Button btnAñadir;
        private Button btnFiltrar;
        private Button btnLimpiar;
        private Button btnSalir;
        private Label label5;
    }
}
