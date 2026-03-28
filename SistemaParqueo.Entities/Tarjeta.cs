using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaParqueo.Entities
{
    public class Tarjeta
    {
        public int TarjetaId { get; set; }
        public string Codigo { get; set; }
        public int EstadoTarjetaId { get; set; }

        public Tarjeta()
        {

        }

        public Tarjeta(string codigo, int estadoTarjetaId)
        {
            Codigo = codigo;
            EstadoTarjetaId = estadoTarjetaId;
        }

        public Tarjeta(int tarjetaId, string codigo, int estadoTarjetaId)
        {
            TarjetaId = tarjetaId;
            Codigo = codigo;
            EstadoTarjetaId = estadoTarjetaId;
        }
    }
}
