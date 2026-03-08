using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaParqueo.Entities
{
    public class Vehiculo
    {
        public int VehiculoId { get; set; }
        public int ClienteId { get; set; }
        public string Placa { get; set; }
        public int TipoVehiculoId { get; set; }

        public Vehiculo()
        {

        }

        public Vehiculo(int clienteId, string placa, int tipoVehiculoId)
        {
            ClienteId = clienteId;
            Placa = placa;
            TipoVehiculoId = tipoVehiculoId;
        }

        public Vehiculo(int vehiculoId, int clienteId, string placa, int tipoVehiculoId)
        {
            VehiculoId = vehiculoId;
            ClienteId = clienteId;
            Placa = placa;
            TipoVehiculoId = tipoVehiculoId;
        }
    }
}
