using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaParqueo.Entities
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public string Fecha { get; set; }
        public string HoraEntrada { get; set; }
        public decimal Total { get; set; }
        public int VehiculoId { get; set; }
        public int CorteId { get; set; }
        public int ParqueoId { get; set; }
        public int EstadoTicketId { get; set; }
        public int UsuarioId { get; set; }

        public Ticket()
        {

        }

        public Ticket(string fecha, string horaEntrada, decimal total, int vehiculoId, int corteId, int parqueoId, int estadoTicketId, int usuarioId)
        {
            Fecha = fecha;
            HoraEntrada = horaEntrada;
            Total = total;
            VehiculoId = vehiculoId;
            CorteId = corteId;
            ParqueoId = parqueoId;
            EstadoTicketId = estadoTicketId;
            UsuarioId = usuarioId;
        }

        public Ticket(int ticketId, string fecha, string horaEntrada, decimal total, int vehiculoId, int corteId, int parqueoId, int estadoTicketId, int usuarioId)
        {
            TicketId = ticketId;
            Fecha = fecha;
            HoraEntrada = horaEntrada;
            Total = total;
            VehiculoId = vehiculoId;
            CorteId = corteId;
            ParqueoId = parqueoId;
            EstadoTicketId = estadoTicketId;
            UsuarioId = usuarioId;
        }
    }
}
