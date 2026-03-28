using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaParqueo.Entities
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string DUI { get; set; }
        public int TarjetaId { get; set; }
        public int TipoClienteId { get; set; }

        public Cliente() // Constructor vacio
        {

        }

        public Cliente(string nombre, string apellido, string telefono, string dui, int tarjetaId, int tipoClienteId)
        {
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            DUI = dui;
            TarjetaId = tarjetaId;
            TipoClienteId = tipoClienteId;
        }

        public Cliente(int clienteId, string nombre, string apellido, string telefono, string dui, int tarjetaId, int tipoClienteId)
        {
            ClienteId = clienteId;
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            DUI = dui;
            TarjetaId = tarjetaId;
            TipoClienteId = tipoClienteId;
        }
    }
}
