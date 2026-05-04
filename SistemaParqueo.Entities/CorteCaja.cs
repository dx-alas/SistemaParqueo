using System;

namespace SistemaParqueo.Entities
{
    public class CorteCaja
    {
        public int CorteId { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan? HoraEntrega { get; set; }
        public decimal? MontoInicial { get; set; }
        public decimal? MontoTotal { get; set; }
        public string ObservacionInicial { get; set; }
        public string ObservacionFinal { get; set; }
        public int UsuarioAperturaId { get; set; }
        public int? UsuarioCierreId { get; set; }
        public int EstadoCorteId { get; set; }

        public CorteCaja()
        {

        }

        public CorteCaja(DateTime fecha, TimeSpan horaInicio, TimeSpan? horaEntrega, decimal? montoInicial, decimal? montoTotal, string observacionInicial, string observacionFinal, int usuarioAperturaId, int? usuarioCierreId, int estadoCorteId)
        {
            Fecha = fecha;
            HoraInicio = horaInicio;
            HoraEntrega = horaEntrega;
            MontoInicial = montoInicial;
            MontoTotal = montoTotal;
            ObservacionInicial = observacionInicial;
            ObservacionFinal = observacionFinal;
            UsuarioAperturaId = usuarioAperturaId;
            UsuarioCierreId = usuarioCierreId;
            EstadoCorteId = estadoCorteId;
        }

        public CorteCaja(int corteId, DateTime fecha, TimeSpan horaInicio, TimeSpan? horaEntrega, decimal? montoInicial, decimal? montoTotal, string observacionInicial, string observacionFinal, int usuarioAperturaId, int? usuarioCierreId, int estadoCorteId)
        {
            CorteId = corteId;
            Fecha = fecha;
            HoraInicio = horaInicio;
            HoraEntrega = horaEntrega;
            MontoInicial = montoInicial;
            MontoTotal = montoTotal;
            ObservacionInicial = observacionInicial;
            ObservacionFinal = observacionFinal;
            UsuarioAperturaId = usuarioAperturaId;
            UsuarioCierreId = usuarioCierreId;
            EstadoCorteId = estadoCorteId;
        }
    }
}