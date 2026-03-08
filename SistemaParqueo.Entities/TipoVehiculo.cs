using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaParqueo.Entities
{
    public class TipoVehiculo
    {
        public int TipoVehiculoId { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        public TipoVehiculo() 
        {

        }

        public TipoVehiculo(string nombre, decimal precio)
        {
            Nombre = nombre;
            Precio = precio;
        }

        public TipoVehiculo(int tipoVehiculoId, string nombre, decimal precio)
        {
            TipoVehiculoId = tipoVehiculoId;
            Nombre = nombre;
            Precio = precio;
        }
    }
}
