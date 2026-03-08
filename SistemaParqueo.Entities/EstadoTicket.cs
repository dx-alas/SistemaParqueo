using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaParqueo.Entities
{
    public class EstadoTicket
    {
        public int EstadoTicketId { get; set; }
        public string Nombre { get; set; }

        public EstadoTicket()
        {

        }

        public EstadoTicket(string nombre)
        {
            Nombre = nombre;
        }

        public EstadoTicket(int estadoTicketId, string nombre)
        {
            EstadoTicketId = estadoTicketId;
            Nombre = nombre;
        }
    }
}
