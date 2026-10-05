using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehiculo> listaVehiculos = new List<Vehiculo>();
            int opc;
            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("Ingrese 1 para Agregar un vehiculo");
                if (!int.TryParse(Console.ReadLine(), out opc))
                {
                    Console.WriteLine("ERROR: Ingrese un numero valido");
                }
                switch (opc)
                {
                    case 1:
                        Console.WriteLine("Ingrese la patente del vehiculo.");
                        string patente = Console.ReadLine();

                        //Validar que no exista.
                        foreach (Vehiculo vehiculo in listaVehiculos)
                        {
                            if (vehiculo.patente == patente)
                            {
                                Console.WriteLine("ERROR: Patente ya ingresada.");
                                break;
                            }
                        }
                        Console.WriteLine("Ingrese el kilometraje");
                        int kilometraje;
                        if (!int.TryParse(Console.ReadLine(), out kilometraje))
                        {
                            Console.WriteLine("ERROR: Ingrese un kilometraje valido");
                            break;
                        }
                        Console.WriteLine("Ingrese la carga del camion");
                        int Carga;
                        if (!int.TryParse(Console.ReadLine(), out Carga))
                        {
                            Console.WriteLine("ERROR: Ingrese una carga valida");
                            break;
                        }
                        int tipoVehiculo;
                        Console.WriteLine("Ingrese 1 para el tipo de vehiculo: Camion, 2 para Furgoneta, 3 para moto");
                        if (!int.TryParse(Console.ReadLine(), out tipoVehiculo))
                        {
                            Console.WriteLine("ERROR: Ingrese un numero valido");
                        }
                        switch (tipoVehiculo)
                        {
                            case 1:

                                Console.WriteLine("Ingrese la carga adicional del camion");
                                int CargaAdicional;
                                if (!int.TryParse(Console.ReadLine(), out CargaAdicional))
                                {
                                    Console.WriteLine("ERROR: Ingrese una carga adicional valida");
                                    break;
                                }
                                listaVehiculos.Add(new camion(patente, kilometraje, Carga, CargaAdicional));


                                break;
                            //to-do Agregar funcionalidad para pedir datos de furgoneta

                            default:
                                break;
                        }
                        break;
                    //to-do Agregar demas funcionalidades
                    default:
                        break;
                }

            } while (opc != 5);
            Console.WriteLine("Adios!");
        }
    }
}

