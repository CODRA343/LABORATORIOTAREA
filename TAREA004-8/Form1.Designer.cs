namespace TAREA004_8
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtPalabra = new TextBox();
            txtLista1 = new TextBox();
            txtLista2 = new TextBox();
            btnAñadir = new Button();
            btnEvaluar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaption;
            label5.Location = new Point(267, 21);
            label5.Name = "label5";
            label5.Size = new Size(229, 15);
            label5.TabIndex = 16;
            label5.Text = "DEVOLVER LAS PALABRAS PALÍNDROMOS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(426, 57);
            label3.Name = "label3";
            label3.Size = new Size(109, 15);
            label3.TabIndex = 15;
            label3.Text = "Palabras guardadas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 57);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 14;
            label2.Text = "Ingresa las Palabras";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 170);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 17;
            label1.Text = "Palabras Ingresadas";
            // 
            // txtPalabra
            // 
            txtPalabra.Location = new Point(50, 88);
            txtPalabra.Name = "txtPalabra";
            txtPalabra.Size = new Size(232, 23);
            txtPalabra.TabIndex = 18;
            // 
            // txtLista1
            // 
            txtLista1.Location = new Point(50, 200);
            txtLista1.Multiline = true;
            txtLista1.Name = "txtLista1";
            txtLista1.ReadOnly = true;
            txtLista1.Size = new Size(232, 163);
            txtLista1.TabIndex = 19;
            // 
            // txtLista2
            // 
            txtLista2.Location = new Point(426, 88);
            txtLista2.Multiline = true;
            txtLista2.Name = "txtLista2";
            txtLista2.ReadOnly = true;
            txtLista2.Size = new Size(232, 275);
            txtLista2.TabIndex = 20;
            // 
            // btnAñadir
            // 
            btnAñadir.Location = new Point(50, 128);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(146, 26);
            btnAñadir.TabIndex = 21;
            btnAñadir.Text = "Añadir";
            btnAñadir.UseVisualStyleBackColor = true;
            btnAñadir.Click += btnAñadir_Click;
            // 
            // btnEvaluar
            // 
            btnEvaluar.Location = new Point(50, 394);
            btnEvaluar.Name = "btnEvaluar";
            btnEvaluar.Size = new Size(169, 26);
            btnEvaluar.TabIndex = 22;
            btnEvaluar.Text = "Evaluar";
            btnEvaluar.UseVisualStyleBackColor = true;
            btnEvaluar.Click += btnEvaluar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(302, 394);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(169, 26);
            btnLimpiar.TabIndex = 23;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(548, 394);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(169, 26);
            btnSalir.TabIndex = 24;
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
            Controls.Add(btnEvaluar);
            Controls.Add(btnAñadir);
            Controls.Add(txtLista2);
            Controls.Add(txtLista1);
            Controls.Add(txtPalabra);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Form1";
            Text = "EJERCICIO 8";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtPalabra;
        private TextBox txtLista1;
        private TextBox txtLista2;
        private Button btnAñadir;
        private Button btnEvaluar;
        private Button btnLimpiar;
        private Button btnSalir;
    }
}
