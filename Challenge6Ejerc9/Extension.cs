using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge6Ejerc9
{
    static class Extension
    {
        public static bool MayorEdad(this Persona persona)
        {
            double aux = persona.Edad();
            if (aux >= 18) 
            { 
                return true; 
            }
            else 
            {
                return false; 
            }
        }
    }
}
