using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class Estudiante
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }

        public Estudiante(string nombre, string apellido, int dNI)
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dNI;
        }
   
    }
}
