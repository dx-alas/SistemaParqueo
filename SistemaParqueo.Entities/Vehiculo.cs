using System;

namespace SistemaParqueo.Entities
{
    public class Vehiculo
    {
        public int VehiculoId { get; set; }
        public string Placa { get; set; }

        public int ClienteId { get; set; }
        public int TipoVehiculoId { get; set; }
        public int EstadoVehiculoId { get; set; }

        // CAMPOS PARA SELECT (JOIN)
        public string Cliente { get; set; }
        public string TipoVehiculo { get; set; }
        public string EstadoVehiculo { get; set; }

        public Vehiculo()
        {

        }

        public Vehiculo(string placa, int clienteId, int tipoVehiculoId, int estadoVehiculoId)
        {
            Placa = placa;
            ClienteId = clienteId;
            TipoVehiculoId = tipoVehiculoId;
            EstadoVehiculoId = estadoVehiculoId;
        }

        public Vehiculo(int vehiculoId, string placa, int clienteId, int tipoVehiculoId, int estadoVehiculoId)
        {
            VehiculoId = vehiculoId;
            Placa = placa;
            ClienteId = clienteId;
            TipoVehiculoId = tipoVehiculoId;
            EstadoVehiculoId = estadoVehiculoId;
        }

        public Vehiculo(int vehiculoId, string cliente, string placa, string tipoVehiculo, string estadoVehiculo)
        {
            VehiculoId = vehiculoId;
            Cliente = cliente;
            Placa = placa;
            TipoVehiculo = tipoVehiculo;
            EstadoVehiculo = estadoVehiculo;
        }
    }
}