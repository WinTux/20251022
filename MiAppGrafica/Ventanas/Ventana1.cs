using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
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

        private void guardar_texto_plano(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.Filter = "Archivo de texto plano|*.educ";
            guardar.Title = "Guardar archivo de texto plano";
            if (guardar.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(guardar.FileName))
                    {
                        writer.Write(txtContenido.Text);
                        writer.Close();
                    }
                    MessageBox.Show("Archivo de texto plano guardado correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el archivo: " + ex.Message);
                }
            }
        }

        private void leer_texto_plano(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "Archivo de texto plano|*.educ";
            abrir.Title = "Abrir archivo de texto plano";
            if (abrir.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamReader reader = new StreamReader(abrir.FileName))
                    {
                        txtContenido.Text = reader.ReadToEnd();
                        reader.Close();
                    }
                    MessageBox.Show("Archivo de texto plano leído correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al leer el archivo: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No se seleccionó ningún archivo.");
            }
        }

        private async void button5_Click(object sender, EventArgs e)
        {
           
            // Guardar el objeto persona en un archivo binario
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.Filter = "Archivo binario|*.dat";
            guardar.Title = "Guardar objeto";
            if (guardar.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Armar el objeto persona
                    string nom = txtFormNombre.Text;
                    int eda = int.Parse(txtformEdad.Text);
                    string ema = txtFormEmail.Text;
                    Herramientas.Persona p = new Herramientas.Persona(nom, eda, ema);
                    using (FileStream fs = new FileStream(guardar.FileName, FileMode.Create))
                    {
                        await JsonSerializer.SerializeAsync(fs, p);
                        fs.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el archivo: " + ex.Message);
                }
            }
        }
    }
}
