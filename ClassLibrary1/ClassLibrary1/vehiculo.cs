using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class Vehiculo
    {
        public string patente { get;  set; }
        public int kilometraje { get;  set; }
        public List<viaje> listaviajes { get;  set; }
        public int capacidadCarga { get;  set; }
        public void AgregarViaje (viaje viajeAgregar)
        {
            listaviajes.Add(viajeAgregar);
        }
        public int CalcularDistanciaTotal()
        {
            int Total = 0;
            foreach (var viaje in listaviajes)
            {
                Total += viaje.distancia;
            }
            return Total;
        }
    }
}
