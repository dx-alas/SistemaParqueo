using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaParqueo.Entities
{
    public class EstadoCliente
    {
        public int EstadoClienteId { get; set; }
        public string Nombre { get; set; }

        public EstadoCliente ()
        {

        }

        public EstadoCliente(string nombre)
        {
            Nombre = nombre;
        }

        public EstadoCliente(int estadoClienteId, string nombre)
        {
            EstadoClienteId = estadoClienteId;
            Nombre = nombre;
        }
    }
}
