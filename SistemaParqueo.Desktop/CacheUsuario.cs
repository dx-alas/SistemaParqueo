using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaParqueo.Desktop
{
    namespace SistemaParqueo.Desktop
    {
        // Esta clase NO es una entidad de BD, es una herramienta de la interfaz
        public static class CacheUsuario
        {
            // Aquí guardamos el objeto Usuario que ya tienes en Entities
            public static Entities.Usuario UsuarioLogueado { get; set; }
        }
    }
}
