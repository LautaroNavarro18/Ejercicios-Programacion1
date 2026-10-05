using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica_clases;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Persona p = new Persona();
            Console.WriteLine("Ingrese su nombre:");
            string nombre = Console.ReadLine();
            p.Nombre = nombre;
            Console.WriteLine("Ingrese su edad:");
            int edad = int.Parse(Console.ReadLine());
            p.Edad = edad;
            p.Saludar();
            */
            Empleado e = new Empleado();
            Console.WriteLine("Ingrese su nombre:");
            string nombre = Console.ReadLine();
            e.Nombre = nombre;
            Console.WriteLine("Ingrese su edad:");
            int edad = int.Parse(Console.ReadLine());
            e.Edad = edad;
            e.Saludar();
            e.trabajar();
        }
    }
}
