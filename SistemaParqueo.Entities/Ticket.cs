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
        public TimeSpan HoraEntrada { get; set; }
        public TimeSpan? HoraSalida { get; set; }
        public decimal? Total { get; set; }
        public int TarjetaId { get; set; }
        public int CorteId { get; set; }
        public int EstadoTicketId { get; set; }
        public int UsuarioId { get; set; }
        public int EstadoPermanenciaId { get; set; }
        public int TipoVehiculoId { get; set; }
        public decimal PrecioAplicado { get; set; }
        public int? MultaId { get; set; }
        public int? VehiculoId { get; set; }

        public Ticket()
        {

        }

        public Ticket(DateTime fecha, TimeSpan horaEntrada, TimeSpan? horaSalida, decimal? total,
            int tarjetaId, int corteId, int estadoTicketId, int usuarioId,
            int estadoPermanenciaId, int tipoVehiculoId, decimal precioAplicado,
            int? multaId, int? vehiculoId)
        {
            Fecha = fecha;
            HoraEntrada = horaEntrada;
            HoraSalida = horaSalida;
            Total = total;
            TarjetaId = tarjetaId;
            CorteId = corteId;
            EstadoTicketId = estadoTicketId;
            UsuarioId = usuarioId;
            EstadoPermanenciaId = estadoPermanenciaId;
            TipoVehiculoId = tipoVehiculoId;
            PrecioAplicado = precioAplicado;
            MultaId = multaId;
            VehiculoId = vehiculoId;
        }

        public Ticket(int ticketId, DateTime fecha, TimeSpan horaEntrada, TimeSpan? horaSalida, decimal? total,
            int tarjetaId, int corteId, int estadoTicketId, int usuarioId,
            int estadoPermanenciaId, int tipoVehiculoId, decimal precioAplicado,
            int? multaId, int? vehiculoId)
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
            EstadoPermanenciaId = estadoPermanenciaId;
            TipoVehiculoId = tipoVehiculoId;
            PrecioAplicado = precioAplicado;
            MultaId = multaId;
            VehiculoId = vehiculoId;
        }
    }
}