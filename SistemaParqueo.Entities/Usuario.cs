using System;

namespace SistemaParqueo.Entities
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Clave { get; set; }
        public int EmpleadoId { get; set; }
        public int RolId { get; set; }
        public int EstadoUsuarioId { get; set; }

        public Usuario()
        {

        }

        public Usuario(string nombre, string clave, int empleadoId, int rolId, int estadoUsuarioId)
        {
            Nombre = nombre;
            Clave = clave;
            EmpleadoId = empleadoId;
            RolId = rolId;
            EstadoUsuarioId = estadoUsuarioId;
        }

        public Usuario(int usuarioId, string nombre, string clave, int empleadoId, int rolId, int estadoUsuarioId)
        {
            UsuarioId = usuarioId;
            Nombre = nombre;
            Clave = clave;
            EmpleadoId = empleadoId;
            RolId = rolId;
            EstadoUsuarioId = estadoUsuarioId;
        }
    }
}