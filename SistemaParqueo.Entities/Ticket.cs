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
        public DateTime Fecha { get; set; }
        public DateTime HoraEntrada { get; set; }
        public DateTime? HoraSalida { get; set; }
        public decimal? Total { get; set; }
        public int TarjetaId { get; set; }
        public int CorteId { get; set; }
        public int EstadoTicketId { get; set; }
        public int UsuarioId { get; set; }
        public int? MultaId { get; set; }
        public int EstadoPermanenciaId { get; set; }

        public Ticket()
        {

        }

        public Ticket(DateTime fecha, DateTime horaEntrada, DateTime? horaSalida, decimal? total, int tarjetaId, int corteId, int estadoTicketId, int usuarioId, int? multaId, int estadoPermanenciaId)
        {
            Fecha = fecha;
            HoraEntrada = horaEntrada;
            HoraSalida = horaSalida;
            Total = total;
            TarjetaId = tarjetaId;
            CorteId = corteId;
            EstadoTicketId = estadoTicketId;
            UsuarioId = usuarioId;
            MultaId = multaId;
            EstadoPermanenciaId = estadoPermanenciaId;
        }

        public Ticket(int ticketId, DateTime fecha, DateTime horaEntrada, DateTime? horaSalida, decimal? total, int tarjetaId, int corteId, int estadoTicketId, int usuarioId, int? multaId, int estadoPermanenciaId)
        {
            TicketId = ticketId;
            Fecha = fecha;
            HoraEntrada = horaEntrada;
            HoraSalida = horaSalida;
            Total = total;
            TarjetaId = tarjetaId;
            CorteId = corteId;
            EstadoTicketId = estadoTicketId;
            UsuarioId = usuarioId;
            MultaId = multaId;
            EstadoPermanenciaId = estadoPermanenciaId;
        }
    }
}