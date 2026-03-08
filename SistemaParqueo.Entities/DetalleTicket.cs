using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaParqueo.Entities
{
    public class DetalleTicket
    {
        public int DetalleTicketId { get; set; }
        public int TicketId { get; set; }
        public int ConceptoId { get; set; }
        public int Cantidad { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Total { get; set; }

        public DetalleTicket()
        {

        }

        public DetalleTicket(int ticketId, int conceptoId, int cantidad, decimal subtotal, decimal total)
        {
            TicketId = ticketId;
            ConceptoId = conceptoId;
            Cantidad = cantidad;
            Subtotal = subtotal;
            Total = total;
        }

        public DetalleTicket(int detalleTicketId, int ticketId, int conceptoId, int cantidad, decimal subtotal, decimal total)
        {
            DetalleTicketId = detalleTicketId;
            TicketId = ticketId;
            ConceptoId = conceptoId;
            Cantidad = cantidad;
            Subtotal = subtotal;
            Total = total;
        }
    }
}
