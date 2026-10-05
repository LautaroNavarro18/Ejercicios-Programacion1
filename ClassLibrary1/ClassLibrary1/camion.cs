using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class camion : Vehiculo
    {
        public int cargaAdicional { get; private set; }
        public int CalcularCargaTotal()
        {
            return capacidadCarga + cargaAdicional;
        }
        public camion(string patente, int kilometraje, int carga, int cargaAdicional)
        {
            this.capacidadCarga = capacidadCarga;
            this.cargaAdicional = cargaAdicional;
            this.patente = patente;
            this.kilometraje = kilometraje; 
            listaviajes = new List<viaje>();
        }
    }
}
