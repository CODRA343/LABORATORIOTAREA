﻿namespace TAREA004_5
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(458, 60);
            label6.Name = "label6";
            label6.Size = new Size(131, 15);
            label6.TabIndex = 48;
            label6.Text = "Union de los Conjuntos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(248, 60);
            label1.Name = "label1";
            label1.Size = new Size(123, 30);
            label1.TabIndex = 47;
            label1.Text = "Ingrese los numeros\r\ndel segundo conjunto\r\n";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaption;
            label5.Location = new Point(218, 25);
            label5.Name = "label5";
            label5.Size = new Size(371, 15);
            label5.TabIndex = 46;
            label5.Text = "RESTA DE CONJUNTOS (PRIMER CONJUNTO - SEGUNDO CONJUNTO)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(248, 170);
            label4.Name = "label4";
            label4.Size = new Size(107, 15);
            label4.TabIndex = 45;
            label4.Text = "Numeros divisibles";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 170);
            label3.Name = "label3";
            label3.Size = new Size(116, 15);
            label3.TabIndex = 44;
            label3.Text = "Numeros Guardados";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 60);
            label2.Name = "label2";
            label2.Size = new Size(113, 30);
            label2.TabIndex = 43;
            label2.Text = "Ingrese los numeros\r\ndel primer conjunto";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(46, 103);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(154, 23);
            textBox1.TabIndex = 49;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(248, 103);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(154, 23);
            textBox2.TabIndex = 50;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(458, 103);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(236, 277);
            textBox3.TabIndex = 51;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(46, 204);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(154, 176);
            textBox4.TabIndex = 52;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(248, 204);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(154, 176);
            textBox5.TabIndex = 53;
            // 
            // button1
            // 
            button1.Location = new Point(46, 139);
            button1.Name = "button1";
            button1.Size = new Size(122, 23);
            button1.TabIndex = 54;
            button1.Text = "Añadir";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(248, 139);
            button2.Name = "button2";
            button2.Size = new Size(122, 23);
            button2.TabIndex = 55;
            button2.Text = "Añadir";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(45, 406);
            button3.Name = "button3";
            button3.Size = new Size(154, 23);
            button3.TabIndex = 56;
            button3.Text = "Restar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(324, 406);
            button4.Name = "button4";
            button4.Size = new Size(149, 23);
            button4.TabIndex = 57;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(591, 406);
            button5.Name = "button5";
            button5.Size = new Size(129, 23);
            button5.TabIndex = 58;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Form1";
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
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}
