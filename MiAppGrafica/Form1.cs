namespace MiAppGrafica
{
    public partial class Form1 : Form
    {
        private Point posicionPoligono = new Point(200, 200);
        public Form1()
        {
            InitializeComponent();
            lienzo.Paint += lienzo_paint;
            typeof(Panel).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
        .SetValue(lienzo, true);
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
            lienzo.TabStop = true;
            lienzo.Click += (s, e) => lienzo.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string n1 = txtNumero1.Text;
            string n2 = txtNumero2.Text;
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            bool siSePudoConvertir1 = int.TryParse(n1, out int num1);
            bool siSePudoConvertir = int.TryParse(n2, out int num2);
            if (siSePudoConvertir && siSePudoConvertir1)
                lblResultado.Text = "Resultado: " + (num1 + num2);
            else
                lblResultado.Text = "POR FAVOR INGRESE SOLO NUMEROS";
        }
        public void unMetodo(object sender, EventArgs e)
        {
            int num1 = 0, num2 = 0;
            try
            {
                num1 = int.Parse(txtNumero1.Text);
                num2 = int.Parse(txtNumero2.Text);
                txtNumero1.Text = "";
                txtNumero2.Text = "";
                lblResultado.Text = "Resultado: " + (num1 / num2);
            }
            catch (FormatException e1)
            {
                lblResultado.Text = "POR FAVOR INGRESE SOLO NUMEROS";
                return;
            }
            catch (DivideByZeroException e2)
            {
                lblResultado.Text = "NO SE PUEDE DIVIDIR POR CERO";
                return;
            }
            catch (Exception e3)
            {
                lblResultado.Text = "OCURRIO UN ERROR INESPERADO: " + e3.Message;
                return;
            }

        }

        private void restar(object sender, EventArgs e)
        {
            int num1 = 0, num2 = 0;
            try
            {
                num1 = int.Parse(txtNumero1.Text);
                num2 = int.Parse(txtNumero2.Text);
            }
            catch (FormatException e1)
            {
                lblResultado.Text = "POR FAVOR INGRESE SOLO NUMEROS";
                return;
            }
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            lblResultado.Text = "Resultado: " + (num1 - num2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num1 = 0, num2 = 0;
            try
            {
                num1 = int.Parse(txtNumero1.Text);
                num2 = int.Parse(txtNumero2.Text);
            }
            catch (FormatException e1)
            {
                lblResultado.Text = "POR FAVOR INGRESE SOLO NUMEROS";
                return;
            }
            catch (Exception e3)
            {
                lblResultado.Text = "OCURRIO UN ERROR INESPERADO: " + e3.Message;
                return;
            }
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            lblResultado.Text = "Resultado: " + (num1 * num2);
        }

        private void convertirApostfix(object sender, EventArgs e)
        {
            // Basado en el algoritmo de https://algotree.org/algorithms/stack_based/infix_to_postfix/
            // Paso 0
            string infix = txtInfix.Text; // 3 + 4 * ( 2 - 1 )
            Queue<string> tokens = new Queue<string>(); // + - 3 4 ( )
            for (int i = 0; i < infix.Length; i++)
            {
                char c = infix[i];
                if (c == ' ')
                    continue;
                tokens.Enqueue(c.ToString());
            }
            // Paso 1
            Stack<string> elementos = new Stack<string>(); //
            elementos.Push("("); // Pila inicializada con (
            tokens.Enqueue(")"); // Cola terminada con )
                                 // Paso 2: Debe existir una iteración para repetir los pasos desde el 3 hasta el 6

            string postfix = "";

            while (tokens.Count > 0)
            {
                string elem = tokens.Dequeue();
                switch (elem)
                {
                    case "(":
                        // Paso 3
                        elementos.Push(elem);
                        break;
                    case ")":
                        // Paso 4
                        //while (elementos.Peek().Equals("+") || elementos.Peek().Equals("-") || elementos.Peek().Equals("*")|| elementos.Peek().Equals("/")|| elementos.Peek().Equals("^"))
                        //{
                        //    postfix += elementos.Pop() + " ";
                        //}
                        // while utilizando el contains:
                        //while (elementos.Peek().Contains("+-*/^"))
                        //{
                        //    postfix += elementos.Pop() + " ";
                        //}
                        while (elementos.Peek() != "(")
                        {
                            postfix += elementos.Pop() + " ";
                        }
                        elementos.Pop();// es el (
                        break;
                    case "+":
                    case "-":
                    case "*":
                    case "/":
                    case "^":

                        // Paso 5: extraer operadores si son de mayor o igual precedencia
                        while (elementos.Peek() == "+" || elementos.Peek() == "-" ||
                               elementos.Peek() == "*" || elementos.Peek() == "/" ||
                               elementos.Peek() == "^")
                        {
                            // Aquí se debe comparar la precedencia
                            string operadorEnPila = elementos.Peek();
                            int precedenciaOperadorEnPila = 0;
                            int precedenciaOperadorActual = 0;
                            switch (operadorEnPila)
                            {
                                case "+":
                                case "-":
                                    precedenciaOperadorEnPila = 1;
                                    break;
                                case "*":
                                case "/":
                                    precedenciaOperadorEnPila = 2;
                                    break;
                                case "^":
                                    precedenciaOperadorEnPila = 3;
                                    break;
                            }
                            switch (elem)
                            {
                                case "+":
                                case "-":
                                    precedenciaOperadorActual = 1;
                                    break;
                                case "*":
                                case "/":
                                    precedenciaOperadorActual = 2;
                                    break;
                                case "^":
                                    precedenciaOperadorActual = 3;
                                    break;
                            }
                            if (precedenciaOperadorEnPila >= precedenciaOperadorActual)
                            {
                                postfix += elementos.Pop() + " ";
                            }
                            else
                                break;
                        }
                        elementos.Push(elem);
                        break;
                    default:
                        // Paso 6
                        postfix += elem + " ";
                        break;
                }

            }
            txtPostfix.Text = postfix;
            lblExpresionPostfix.Text = postfix;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void CalcularExpresionPostfix(object sender, EventArgs e)
        {
            // Ejemplo: 3 4 2 1 - * +
            string postfix = txtPostfix.Text;
            Queue<string> tokens = new Queue<string>();
            for (int i = 0; i < postfix.Length; i++)
            {
                char c = postfix[i];
                if (c == ' ')
                    continue;
                tokens.Enqueue(c.ToString());
            }
            Stack<int> valores = new Stack<int>();
            while (tokens.Count > 0)
            {
                string elem = tokens.Dequeue();
                switch (elem)
                {
                    case "+":
                        {
                            int b = valores.Pop();
                            int a = valores.Pop();
                            int resultado = a + b;
                            valores.Push(resultado);
                        }
                        break;
                    case "-":
                        {
                            int b = valores.Pop();
                            int a = valores.Pop();
                            int resultado = a - b;
                            valores.Push(resultado);
                        }
                        break;
                    case "*":
                        {
                            int b = valores.Pop();
                            int a = valores.Pop();
                            int resultado = a * b;
                            valores.Push(resultado);
                        }
                        break;
                    case "/":
                        {
                            int b = valores.Pop();
                            int a = valores.Pop();
                            int resultado = a / b;
                            valores.Push(resultado);
                        }
                        break;
                    case "^":
                        {
                            int b = valores.Pop();
                            int a = valores.Pop();
                            int resultado = (int)Math.Pow(a, b);
                            valores.Push(resultado);
                        }
                        break;
                    default:
                        {
                            // Es un número
                            int numero = int.Parse(elem);
                            valores.Push(numero);
                        }
                        break;
                }
            }
            lblResultadoPostfix.Text = "Resultado: " + valores.Pop();
        }



        private void lienzo_paint(object sender, PaintEventArgs e)
        {
            // Gráficos en Panel lienzo
            Graphics g = e.Graphics;
            Pen lapiz = new Pen(Color.Blue, 3);
            g.DrawEllipse(lapiz, 10, 10, 100, 100);

            Brush brocha = new SolidBrush(Color.Red);
            g.FillRectangle(brocha, 150, 10, 100, 100);

            Rectangle rectangle = new Rectangle(300, 10, 100, 100);
            g.FillEllipse(brocha, rectangle);

            brocha = new SolidBrush(Color.Green);
            g.FillRectangle(brocha, posicionPoligono.X, posicionPoligono.Y, 100, 100);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // <-- Mover polígono a la izquierda
            posicionPoligono.X -= 10;
            lienzo.Invalidate();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // --> Mover polígono a la derecha
            posicionPoligono.X += 10;
            lienzo.Invalidate();
        }

        private void movimiento_mouse(object sender, MouseEventArgs e)
        {
            // Rescatar coordenadas del mouse
            int x = e.X;
            int y = e.Y;
            posicionPoligono.X = x;
            posicionPoligono.Y = y;
            lienzo.Invalidate();
        }

        // Método evento para teclas presionadas
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                posicionPoligono.X -= 10;
                lienzo.Invalidate();
            }
            else if (e.KeyCode == Keys.D)
            {
                posicionPoligono.X += 10;
                lienzo.Invalidate();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Abrir una ventana emergente
            MessageBox.Show("¡Hola! Esta es una ventana emergente.", "Ventana Emergente", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Mensaje con confirmación
            DialogResult resultado = MessageBox.Show("¿Desea continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
