using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerProyecto
{
    class Persona
    {
        public int edad;
        public string nombre;

        public Persona(int edad, string nombre)
        {
            this.edad = edad;
            this.nombre = nombre;
        }

        public Persona()
        {
            this.edad = 0;
            this.nombre = "";
        }

        void cumplirAno()
        {
            this.edad++;
        }
    }
}
