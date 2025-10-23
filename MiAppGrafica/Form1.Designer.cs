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
            tabPage2 = new TabPage();
            tabControl1.SuspendLayout();
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
            tabControl1.Location = new Point(247, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(537, 532);
            tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(529, 504);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(192, 72);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
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
    }
}
