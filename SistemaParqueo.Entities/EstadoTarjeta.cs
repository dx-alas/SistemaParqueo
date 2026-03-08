using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaParqueo.Entities
{
    public class EstadoTarjeta
    {
        public int EstadoTarjetaId { get; set; }
        public string Nombre { get; set; }

        public EstadoTarjeta()
        {

        }

        public EstadoTarjeta(string estadoTarjetaNombre)
        {
            Nombre = estadoTarjetaNombre;
        }

        public EstadoTarjeta(int estadoTarjetaId, string estadoTarjetaNombre)
        {
            EstadoTarjetaId = estadoTarjetaId;
            Nombre = estadoTarjetaNombre;
        }
    }
}
