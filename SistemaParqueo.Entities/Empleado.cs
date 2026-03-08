using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaParqueo.Entities
{
    public class Empleado
    {
        public int EmpleadoId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DUI { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }

        public Empleado()
        {

        }

        public Empleado(string nombre, string apellido, string dui, string correo, string telefono)
        {
            Nombre = nombre;
            Apellido = apellido;
            DUI = dui;
            Correo = correo;
            Telefono = telefono;
        }

        public Empleado(int empleadoId, string nombre, string apellido, string dui, string correo, string telefono)
        {
            EmpleadoId = empleadoId;
            Nombre = nombre;
            Apellido = apellido;
            DUI = dui;
            Correo = correo;
            Telefono = telefono;
        }
    }
}
