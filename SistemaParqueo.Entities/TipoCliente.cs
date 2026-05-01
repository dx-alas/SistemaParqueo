using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaParqueo.Entities
{
    public class TipoCliente
    {
        public int TipoClienteId { get; set; }
        public string Nombre { get; set; }

        public TipoCliente()
        {

        }

        public TipoCliente(string nombre)
        {
            Nombre = nombre;
        }

        public TipoCliente(int tipoClienteId, string nombre)
        {
            TipoClienteId = tipoClienteId;
            Nombre = nombre;
            
        }
    }
}
