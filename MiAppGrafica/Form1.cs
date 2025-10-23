namespace MiAppGrafica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
    }
}
