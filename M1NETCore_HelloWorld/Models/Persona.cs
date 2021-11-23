using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1NETCore_HelloWorld.Models
{
    public class Persona
    {
        public string nombre { get; set; }
        public string dni { get; set; }
        public string telefono { get; set; }

        public Persona() { }

        public Persona(string dni, string nombre, string telefono)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.telefono = telefono;
        }

    }
}
