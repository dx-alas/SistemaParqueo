using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaParqueo.Entities
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public int EmpleadoId { get; set; }
        public string UsuarioNombre { get; set; }
        public string Clave { get; set; }
        public int RolId { get; set; }
        public int EstadoUsuarioId { get; set; }

        public Usuario()
        {

        }

        public Usuario(int empleadoId, string usuarioNombre, string clave, int rolId, int estadoUsuarioId)
        {
            EmpleadoId = empleadoId;
            UsuarioNombre = usuarioNombre;
            Clave = clave;
            RolId = rolId;
            EstadoUsuarioId = estadoUsuarioId;
        }

        public Usuario(int usuarioId, int empleadoId, string usuarioNombre, string clave, int rolId, int estadoUsuarioId)
        {
            UsuarioId = usuarioId;
            EmpleadoId = empleadoId;
            UsuarioNombre = usuarioNombre;
            Clave = clave;
            RolId = rolId;
            EstadoUsuarioId = estadoUsuarioId;
        }
    }
}
