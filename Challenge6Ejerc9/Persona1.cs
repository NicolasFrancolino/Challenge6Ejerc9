using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge6Ejerc9
{
    partial class Persona
    {

        public Persona(string nombre, DateTime fecha)
        {
            Nombre = nombre;
            FechaNac = fecha;
        }
        public string Nombre { get; set; }
        public DateTime FechaNac { get; set; }


    }
}
