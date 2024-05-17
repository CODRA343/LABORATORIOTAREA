namespace TAREA004_6
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
            label1 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtConjunto1 = new TextBox();
            txtConjunto2 = new TextBox();
            txtLista1 = new TextBox();
            txtLista2 = new TextBox();
            txtLista3 = new TextBox();
            btnAñadir1 = new Button();
            btnAñadir2 = new Button();
            btnRestar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(466, 72);
            label6.Name = "label6";
            label6.Size = new Size(107, 15);
            label6.TabIndex = 54;
            label6.Text = "Resta de conjuntos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(256, 57);
            label1.Name = "label1";
            label1.Size = new Size(123, 30);
            label1.TabIndex = 53;
            label1.Text = "Ingrese los numeros\r\ndel segundo conjunto\r\n";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaption;
            label5.Location = new Point(226, 22);
            label5.Name = "label5";
            label5.Size = new Size(371, 15);
            label5.TabIndex = 52;
            label5.Text = "RESTA DE CONJUNTOS (SEGUNDO CONJUNTO - PRIMER CONJUNTO)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(256, 171);
            label4.Name = "label4";
            label4.Size = new Size(107, 15);
            label4.TabIndex = 51;
            label4.Text = "Segundo Conjunto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 170);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 50;
            label3.Text = "Primer Conjunto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 57);
            label2.Name = "label2";
            label2.Size = new Size(113, 30);
            label2.TabIndex = 49;
            label2.Text = "Ingrese los numeros\r\ndel primer conjunto";
            label2.Click += label2_Click;
            // 
            // txtConjunto1
            // 
            txtConjunto1.Location = new Point(54, 90);
            txtConjunto1.Name = "txtConjunto1";
            txtConjunto1.Size = new Size(167, 23);
            txtConjunto1.TabIndex = 55;
            // 
            // txtConjunto2
            // 
            txtConjunto2.Location = new Point(256, 90);
            txtConjunto2.Name = "txtConjunto2";
            txtConjunto2.Size = new Size(167, 23);
            txtConjunto2.TabIndex = 56;
            txtConjunto2.TextChanged += txtConjunto2_TextChanged;
            // 
            // txtLista1
            // 
            txtLista1.Location = new Point(54, 198);
            txtLista1.Multiline = true;
            txtLista1.Name = "txtLista1";
            txtLista1.ReadOnly = true;
            txtLista1.Size = new Size(167, 172);
            txtLista1.TabIndex = 57;
            // 
            // txtLista2
            // 
            txtLista2.Location = new Point(256, 198);
            txtLista2.Multiline = true;
            txtLista2.Name = "txtLista2";
            txtLista2.ReadOnly = true;
            txtLista2.Size = new Size(167, 172);
            txtLista2.TabIndex = 58;
            // 
            // txtLista3
            // 
            txtLista3.Location = new Point(466, 90);
            txtLista3.Multiline = true;
            txtLista3.Name = "txtLista3";
            txtLista3.ReadOnly = true;
            txtLista3.Size = new Size(240, 280);
            txtLista3.TabIndex = 59;
            // 
            // btnAñadir1
            // 
            btnAñadir1.Location = new Point(54, 129);
            btnAñadir1.Name = "btnAñadir1";
            btnAñadir1.Size = new Size(105, 26);
            btnAñadir1.TabIndex = 60;
            btnAñadir1.Text = "Añadir";
            btnAñadir1.UseVisualStyleBackColor = true;
            btnAñadir1.Click += btnAñadir1_Click;
            // 
            // btnAñadir2
            // 
            btnAñadir2.Location = new Point(256, 129);
            btnAñadir2.Name = "btnAñadir2";
            btnAñadir2.Size = new Size(105, 26);
            btnAñadir2.TabIndex = 61;
            btnAñadir2.Text = "Añadir";
            btnAñadir2.UseVisualStyleBackColor = true;
            btnAñadir2.Click += button2_Click;
            // 
            // btnRestar
            // 
            btnRestar.Location = new Point(48, 396);
            btnRestar.Name = "btnRestar";
            btnRestar.Size = new Size(159, 26);
            btnRestar.TabIndex = 62;
            btnRestar.Text = "Restar";
            btnRestar.UseVisualStyleBackColor = true;
            btnRestar.Click += button3_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(297, 396);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(159, 26);
            btnLimpiar.TabIndex = 63;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += button4_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(537, 396);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(159, 26);
            btnSalir.TabIndex = 64;
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
            Controls.Add(btnRestar);
            Controls.Add(btnAñadir2);
            Controls.Add(btnAñadir1);
            Controls.Add(txtLista3);
            Controls.Add(txtLista2);
            Controls.Add(txtLista1);
            Controls.Add(txtConjunto2);
            Controls.Add(txtConjunto1);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Form1";
            Text = "EJERCICIO 6";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtConjunto1;
        private TextBox txtConjunto2;
        private TextBox txtLista1;
        private TextBox txtLista2;
        private TextBox txtLista3;
        private Button btnAñadir1;
        private Button btnAñadir2;
        private Button btnRestar;
        private Button btnLimpiar;
        private Button btnSalir;
    }
}
