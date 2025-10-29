using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiAppGrafica.Ventanas
{
    public partial class Ventana1 : Form
    {
        private Form1 ventanaOriginal;

        public int num1 { get; set; } = 0;
        public int num2 { get; set; } = 1;
        public Ventana1()
        {
            InitializeComponent();
        }
        public Ventana1(Form1 form)
        {
            InitializeComponent();
            ventanaOriginal = form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ventanaOriginal.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblResultado.Text = (num1 % num2).ToString();
        }
    }
}
