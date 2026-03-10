using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Hola*/
namespace SistemaParqueo.Entities
{
    public class DetalleTicket
    {
        public int DetalleTicketId { get; set; }
        public int TicketId { get; set; }
        public int ConceptoId { get; set; }
        public int Cantidad { get; set; }
        public decimal Subtotal { get; set; }

        public DetalleTicket()
        {

        }

        public DetalleTicket(int ticketId, int conceptoId, int cantidad, decimal subtotal)
        {
            TicketId = ticketId;
            ConceptoId = conceptoId;
            Cantidad = cantidad;
            Subtotal = subtotal;
        }

        public DetalleTicket(int detalleTicketId, int ticketId, int conceptoId, int cantidad, decimal subtotal)
        {
            DetalleTicketId = detalleTicketId;
            TicketId = ticketId;
            ConceptoId = conceptoId;
            Cantidad = cantidad;
            Subtotal = subtotal;
        }
    }
}
