using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class Estudiante
    {
        private string email;
        private int celular;

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public int? Edad { get; set; }
        public string Email { get; set; }
        public int Celular { get ; set ; }
        public Estudiante()
        {

        }
        public Estudiante(string nombre, string apellido, int dNI, int edad, string email, int celular)
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dNI;
            Edad = edad;
            Email = email;
            Celular = celular;
        }

    }
}
