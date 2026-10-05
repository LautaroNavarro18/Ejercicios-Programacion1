using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_clases
{
    public class Empleado : Persona
    {
        public string Puesto { get; set; }

        public void trabajar()
        {
            Console.WriteLine($"Estoy trabajando como {Puesto}.");
        }
    }
}
