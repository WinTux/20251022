namespace MiAppGrafica
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
            txtNumero1 = new TextBox();
            label2 = new Label();
            txtNumero2 = new TextBox();
            button1 = new Button();
            lblResultado = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            txtPostfix = new TextBox();
            button5 = new Button();
            txtInfix = new TextBox();
            label3 = new Label();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            label4 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 19);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Numero 1:";
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(123, 16);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(100, 23);
            txtNumero1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 65);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 0;
            label2.Text = "Numero 2:";
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(123, 62);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(100, 23);
            txtNumero2.TabIndex = 1;
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ActiveCaption;
            button1.Location = new Point(45, 101);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "SUMAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(45, 160);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(62, 15);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "Resultado:";
            // 
            // button2
            // 
            button2.Location = new Point(148, 101);
            button2.Name = "button2";
            button2.Size = new Size(93, 23);
            button2.TabIndex = 4;
            button2.Text = "RESTAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += restar;
            // 
            // button3
            // 
            button3.Location = new Point(45, 130);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 5;
            button3.Text = "DIVIDIR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += unMetodo;
            // 
            // button4
            // 
            button4.Location = new Point(148, 130);
            button4.Name = "button4";
            button4.Size = new Size(93, 23);
            button4.TabIndex = 6;
            button4.Text = "MULTIPLICAR los numeros";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(247, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(537, 532);
            tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(txtPostfix);
            tabPage1.Controls.Add(button5);
            tabPage1.Controls.Add(txtInfix);
            tabPage1.Controls.Add(label3);
            tabPage1.Cursor = Cursors.Cross;
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(529, 504);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Infix a postfix";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtPostfix
            // 
            txtPostfix.Location = new Point(273, 76);
            txtPostfix.Name = "txtPostfix";
            txtPostfix.Size = new Size(232, 23);
            txtPostfix.TabIndex = 3;
            // 
            // button5
            // 
            button5.Location = new Point(40, 76);
            button5.Name = "button5";
            button5.Size = new Size(123, 23);
            button5.TabIndex = 2;
            button5.Text = "Convertir";
            button5.UseVisualStyleBackColor = true;
            button5.Click += convertirApostfix;
            // 
            // txtInfix
            // 
            txtInfix.Location = new Point(169, 26);
            txtInfix.Name = "txtInfix";
            txtInfix.Size = new Size(336, 23);
            txtInfix.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 31);
            label3.Name = "label3";
            label3.Size = new Size(126, 15);
            label3.TabIndex = 0;
            label3.Text = "Ingrese expresión infix:";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(529, 504);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(529, 504);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(169, 79);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 4;
            label4.Text = "Expresión postfix:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 556);
            Controls.Add(tabControl1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(lblResultado);
            Controls.Add(button1);
            Controls.Add(txtNumero2);
            Controls.Add(txtNumero1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Ejemplos actuales";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumero1;
        private Label label2;
        private TextBox txtNumero2;
        private Button button1;
        private Label lblResultado;
        private Button button2;
        private Button button3;
        private Button button4;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TextBox txtPostfix;
        private Button button5;
        private TextBox txtInfix;
        private Label label3;
        private Label label4;
    }
}
