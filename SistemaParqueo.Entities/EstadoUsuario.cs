using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaParqueo.Entities
{
    public class EstadoUsuario
    {
        public int EstadoUsuarioId { get; set; }
        public string Nombre { get; set; }

        public EstadoUsuario()
        {

        }

        public EstadoUsuario(string nombre)
        {
            Nombre = nombre;
        }

        public EstadoUsuario(int estadoUsuarioId, string nombre)
        {
            EstadoUsuarioId = estadoUsuarioId;
            Nombre = nombre;
        }
    }
}
