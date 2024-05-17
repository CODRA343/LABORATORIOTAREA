namespace TAREA003_2
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
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            txtLetra = new ComboBox();
            txtPalabras = new TextBox();
            txtFiltradas = new TextBox();
            btnFlitrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 22);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Elija la letra";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(393, 104);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 2;
            label3.Text = "Palabras filtradas";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 104);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 3;
            label2.Text = "Ingresa las palabras";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(349, 363);
            button1.Name = "button1";
            button1.Size = new Size(78, 22);
            button1.TabIndex = 4;
            button1.Text = "Limpiar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(640, 363);
            button2.Name = "button2";
            button2.Size = new Size(101, 22);
            button2.TabIndex = 5;
            button2.Text = "Salir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtLetra
            // 
            txtLetra.FormattingEnabled = true;
            txtLetra.Items.AddRange(new object[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "ñ", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" });
            txtLetra.Location = new Point(72, 55);
            txtLetra.Name = "txtLetra";
            txtLetra.Size = new Size(108, 23);
            txtLetra.TabIndex = 6;
            txtLetra.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtPalabras
            // 
            txtPalabras.Location = new Point(72, 134);
            txtPalabras.Multiline = true;
            txtPalabras.Name = "txtPalabras";
            txtPalabras.Size = new Size(294, 160);
            txtPalabras.TabIndex = 7;
            txtPalabras.TextChanged += textBox1_TextChanged;
            // 
            // txtFiltradas
            // 
            txtFiltradas.Location = new Point(393, 134);
            txtFiltradas.Multiline = true;
            txtFiltradas.Name = "txtFiltradas";
            txtFiltradas.ReadOnly = true;
            txtFiltradas.Size = new Size(303, 160);
            txtFiltradas.TabIndex = 8;
            // 
            // btnFlitrar
            // 
            btnFlitrar.Location = new Point(72, 363);
            btnFlitrar.Name = "btnFlitrar";
            btnFlitrar.Size = new Size(96, 22);
            btnFlitrar.TabIndex = 9;
            btnFlitrar.Text = "Filtrar";
            btnFlitrar.UseVisualStyleBackColor = true;
            btnFlitrar.Click += btnFlitrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFlitrar);
            Controls.Add(txtFiltradas);
            Controls.Add(txtPalabras);
            Controls.Add(txtLetra);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label2;
        private Button button1;
        private Button button2;
        private ComboBox txtLetra;
        private TextBox txtPalabras;
        private TextBox txtFiltradas;
        private Button btnFlitrar;
    }
}
