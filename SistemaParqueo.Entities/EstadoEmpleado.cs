using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaParqueo.Entities
{
    public class EstadoEmpleado
    {
        public int EstadoEmpleadoId { get; set; }
        public string Nombre { get; set; }

        public EstadoEmpleado()
        {

        }

        public EstadoEmpleado(string nombre)
        {
            Nombre = nombre;
        }

        public EstadoEmpleado(int estadoEmpleadoId, string nombre)
        {
            EstadoEmpleadoId = estadoEmpleadoId;
            Nombre = nombre;
        }
    }
}