using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaParqueo.Entities
{
    public class Rol
    {
        public int RolId { get; set; }
        public string Nombre { get; set; }

        public Rol()
        {

        }

        public Rol(string nombre)
        {
            Nombre = nombre;
        }

        public Rol(int rolId, string nombre)
        {
            RolId = rolId;
            Nombre = nombre;
        }
    }
}
