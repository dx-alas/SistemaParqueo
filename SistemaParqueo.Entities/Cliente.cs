using System;

namespace SistemaParqueo.Entities
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string TipoDocumento { get; set; }
        public string DUI { get; set; }
        public string CarnetExtranjero { get; set; }
        public int TarjetaId { get; set; }
        public int TipoClienteId { get; set; }
        public int EstadoClienteId { get; set; }

        public Cliente()
        {

        }

        public Cliente(string nombre, string apellido, string telefono, string tipoDocumento, string dui, string carnetExtranjero, int tarjetaId, int tipoClienteId, int estadoClienteId)
        {
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            TipoDocumento = tipoDocumento;
            DUI = dui;
            CarnetExtranjero = carnetExtranjero;
            TarjetaId = tarjetaId;
            TipoClienteId = tipoClienteId;
            EstadoClienteId = estadoClienteId;
        }

        public Cliente(int clienteId, string nombre, string apellido, string telefono, string tipoDocumento, string dui, string carnetExtranjero, int tarjetaId, int tipoClienteId, int estadoClienteId)
        {
            ClienteId = clienteId;
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            TipoDocumento = tipoDocumento;
            DUI = dui;
            CarnetExtranjero = carnetExtranjero;
            TarjetaId = tarjetaId;
            TipoClienteId = tipoClienteId;
            EstadoClienteId = estadoClienteId;
        }
    }
}