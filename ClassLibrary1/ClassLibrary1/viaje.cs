using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class viaje
    {
        public int distancia { get; private set; }
        public int cargaTransportada { get; private set; }
        public DateTime fechaViaje { get; private set; }

        public viaje(int distancia, int cargaTransportada, DateTime fechaViaje)
        {
            this.distancia = distancia;
            this.cargaTransportada = cargaTransportada;
            this.fechaViaje = fechaViaje;
        }
    }
}
