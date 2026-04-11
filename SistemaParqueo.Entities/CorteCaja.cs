using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaParqueo.Entities
{
    public class CorteCaja
    {
        public int CorteId { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraEntrega { get; set; }
        public decimal MontoInicial { get; set; }
        public decimal MontoTotal { get; set; }
        public string ObservacionInicial { get; set; }
        public string ObservacionFinal { get; set; }
        public int UsuarioAperturaId { get; set; }
        public int UsuarioCierreId { get; set; }

        public CorteCaja()
        {

        }

        public CorteCaja(DateTime fecha, DateTime horaInicio, DateTime horaEntrega, decimal montoInicial, decimal montoTotal, string observacionInicial, string observacionFinal, int usuarioAperturaId, int usuarioCierreId)
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
        }

        public CorteCaja(int corteId, DateTime fecha, DateTime horaInicio, DateTime horaEntrega, decimal montoInicial, decimal montoTotal, string observacionInicial, string observacionFinal, int usuarioAperturaId, int usuarioCierreId)
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
            UsuarioCierreId= usuarioCierreId;
        }
    }
}