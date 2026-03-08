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
        public int TipoClienteId { get; set; }

        public Cliente()
        {

        }

        public Cliente(string nombre, string apellido, string telefono, string dui, int tipoClienteId)
        {
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            DUI = dui;
            TipoClienteId = tipoClienteId;
        }

        public Cliente(int clienteId, string nombre, string apellido, string telefono, string dui, int tipoClienteId)
        {
            ClienteId = clienteId;
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            DUI = dui;
            TipoClienteId = tipoClienteId;
        }
    }
}
