using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiAppGrafica.Herramientas
{
    [Serializable]
    internal class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Email { get; set; }

        public Persona(string nombre, int edad, string email)
        {
            Nombre = nombre;
            Edad = edad;
            Email = email;
        }
        public override string ToString()
        {
            return $"Nombre: {Nombre}, Edad: {Edad}, Email: {Email}";
        }
    }
}
