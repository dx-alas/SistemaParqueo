using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaParqueo.Entities
{
    public class EstadoVehiculo
    {
        public int EstadoVehiculoId { get; set; }
        public string Nombre { get; set; }

        public EstadoVehiculo()
        {

        }

        public EstadoVehiculo(string nombre)
        {
            Nombre = nombre;
        }

        public EstadoVehiculo(int estadoVehiculoId, string nombre)
        {
            EstadoVehiculoId = estadoVehiculoId;
            Nombre = nombre;
        }
    }
}
