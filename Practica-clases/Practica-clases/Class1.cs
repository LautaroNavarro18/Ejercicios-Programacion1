using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_clases
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public void Saludar()
        {
            Console.WriteLine();
            Console.WriteLine($"Hola, mi nombre es {Nombre} y tengo {Edad} años.");
        }
    }
}
