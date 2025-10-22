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
        public void un«Metodo() { 
        }
    }
}
