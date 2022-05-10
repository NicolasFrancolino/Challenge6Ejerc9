using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge6Ejerc9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese nombre");
            string nombre2 = Console.ReadLine();
            Console.WriteLine("Ingrese fecha de nacimiento en el siguiente formato:");
            Console.WriteLine("Dia/Mes/Año");
            string fechaAux2 = Console.ReadLine();
            DateTime fecha2 = DateTime.ParseExact(fechaAux2, "dd/MM/yyyy", null);
            Persona p9 = new Persona(nombre2, fecha2);
            if (p9.MayorEdad())
            {
                Console.WriteLine("Es mayor de edad");
            }
            else
                Console.WriteLine("Es menor de edad");

            Console.ReadKey();  
        }
    }
}
