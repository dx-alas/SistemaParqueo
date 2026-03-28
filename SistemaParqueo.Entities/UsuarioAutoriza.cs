using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaParqueo.Entities
{
    public class UsuarioAutoriza
    {
        public int UsuarioAutorizaId { get; set; }
        public int UsuarioId { get; set; }

        public UsuarioAutoriza()
        {

        }

        public UsuarioAutoriza(int usuarioId)
        {
            UsuarioId = usuarioId;
        }

        public UsuarioAutoriza(int usuarioAutorizaId, int usuarioId)
        {
            UsuarioAutorizaId = usuarioAutorizaId;
            UsuarioId = usuarioId;
        }
    }
}
