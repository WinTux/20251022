namespace MiAppGrafica.Ventanas
{
    partial class Ventana1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            lblResultado = new Label();
            button2 = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button4 = new Button();
            button3 = new Button();
            txtContenido = new TextBox();
            tabPage2 = new TabPage();
            label3 = new Label();
            txtFormNombre = new TextBox();
            label4 = new Label();
            txtformEdad = new TextBox();
            label5 = new Label();
            txtFormEmail = new TextBox();
            button5 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(167, 15);
            label1.TabIndex = 0;
            label1.Text = "Haga clic acá para abrir Form1";
            // 
            // button1
            // 
            button1.Location = new Point(185, 7);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Abrir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(393, 33);
            label2.Name = "label2";
            label2.Size = new Size(255, 15);
            label2.TabIndex = 2;
            label2.Text = "El resultado del módulo de los dos números es:";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(393, 61);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(38, 15);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "label3";
            // 
            // button2
            // 
            button2.Location = new Point(395, 7);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "calcular";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 104);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 334);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(txtContenido);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 306);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(620, 160);
            button4.Name = "button4";
            button4.Size = new Size(115, 23);
            button4.TabIndex = 2;
            button4.Text = "Recuperar texto";
            button4.UseVisualStyleBackColor = true;
            button4.Click += leer_texto_plano;
            // 
            // button3
            // 
            button3.Location = new Point(495, 160);
            button3.Name = "button3";
            button3.Size = new Size(110, 23);
            button3.TabIndex = 1;
            button3.Text = "Guardar texto";
            button3.UseVisualStyleBackColor = true;
            button3.Click += guardar_texto_plano;
            // 
            // txtContenido
            // 
            txtContenido.Location = new Point(29, 23);
            txtContenido.Multiline = true;
            txtContenido.Name = "txtContenido";
            txtContenido.ScrollBars = ScrollBars.Both;
            txtContenido.Size = new Size(706, 119);
            txtContenido.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button5);
            tabPage2.Controls.Add(txtFormEmail);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(txtformEdad);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(txtFormNombre);
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 306);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 21);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 0;
            label3.Text = "Nombre:";
            // 
            // txtFormNombre
            // 
            txtFormNombre.Location = new Point(127, 18);
            txtFormNombre.Name = "txtFormNombre";
            txtFormNombre.Size = new Size(100, 23);
            txtFormNombre.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 64);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 2;
            label4.Text = "Edad:";
            // 
            // txtformEdad
            // 
            txtformEdad.Location = new Point(127, 61);
            txtformEdad.Name = "txtformEdad";
            txtformEdad.Size = new Size(100, 23);
            txtformEdad.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(71, 107);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 4;
            label5.Text = "Email:";
            // 
            // txtFormEmail
            // 
            txtFormEmail.Location = new Point(127, 104);
            txtFormEmail.Name = "txtFormEmail";
            txtFormEmail.Size = new Size(100, 23);
            txtFormEmail.TabIndex = 5;
            // 
            // button5
            // 
            button5.Location = new Point(152, 147);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 6;
            button5.Text = "Guardar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Ventana1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(button2);
            Controls.Add(lblResultado);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Ventana1";
            Text = "Nueva ventana ...";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label2;
        private Label lblResultado;
        private Button button2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox txtContenido;
        private TabPage tabPage2;
        private Button button3;
        private Button button4;
        private Label label3;
        private Button button5;
        private TextBox txtFormEmail;
        private Label label5;
        private TextBox txtformEdad;
        private Label label4;
        private TextBox txtFormNombre;
    }
}