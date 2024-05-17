using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Laboratorio8
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
            button1 = new Button();
            txtNumero = new TextBox();
            btnAgregarNumero = new Button();
            txtLista1 = new TextBox();
            txtLista2 = new TextBox();
            btnPrimos = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(22, 22);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 25);
            button1.TabIndex = 0;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(227, 24);
            txtNumero.Margin = new Padding(3, 2, 3, 2);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(110, 23);
            txtNumero.TabIndex = 1;
            txtNumero.TextChanged += txtNumero_TextChanged;
            // 
            // btnAgregarNumero
            // 
            btnAgregarNumero.Location = new Point(227, 57);
            btnAgregarNumero.Margin = new Padding(3, 2, 3, 2);
            btnAgregarNumero.Name = "btnAgregarNumero";
            btnAgregarNumero.Size = new Size(115, 27);
            btnAgregarNumero.TabIndex = 2;
            btnAgregarNumero.Text = "Agregar Numero";
            btnAgregarNumero.UseVisualStyleBackColor = true;
            btnAgregarNumero.Click += btnAgregarNumero_Click;
            // 
            // txtLista1
            // 
            txtLista1.Location = new Point(393, 22);
            txtLista1.Margin = new Padding(3, 2, 3, 2);
            txtLista1.Multiline = true;
            txtLista1.Name = "txtLista1";
            txtLista1.Size = new Size(252, 120);
            txtLista1.TabIndex = 3;
            txtLista1.TextChanged += txtLista1_TextChanged;
            // 
            // txtLista2
            // 
            txtLista2.Location = new Point(393, 173);
            txtLista2.Margin = new Padding(3, 2, 3, 2);
            txtLista2.Multiline = true;
            txtLista2.Name = "txtLista2";
            txtLista2.Size = new Size(252, 120);
            txtLista2.TabIndex = 5;
            txtLista2.TextChanged += txtLista2_TextChanged;
            // 
            // btnPrimos
            // 
            btnPrimos.Location = new Point(227, 208);
            btnPrimos.Margin = new Padding(3, 2, 3, 2);
            btnPrimos.Name = "btnPrimos";
            btnPrimos.Size = new Size(115, 22);
            btnPrimos.TabIndex = 4;
            btnPrimos.Text = "Buscar Primos";
            btnPrimos.UseVisualStyleBackColor = true;
            btnPrimos.Click += btnPrimos_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(txtLista2);
            Controls.Add(btnPrimos);
            Controls.Add(txtLista1);
            Controls.Add(btnAgregarNumero);
            Controls.Add(txtNumero);
            Controls.Add(button1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtNumero;
        private Button btnAgregarNumero;
        private TextBox txtLista1;
        private TextBox txtLista2;
        private Button btnPrimos;
    }
}

