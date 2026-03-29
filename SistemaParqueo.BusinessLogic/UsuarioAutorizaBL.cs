using SistemaParqueo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaParqueo.BusinessLogic
{
    internal class UsuarioAutorizaBL
    {
        private static UsuarioAutorizaBL _instance;
        public static UsuarioAutorizaBL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UsuarioAutorizaBL();
                return _instance;
            }
        }

        public bool Insert(UsuarioAutoriza entity)
        {
            bool result = false;

            try
            {
                result = UsuarioAutorizaBL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool Update(UsuarioAutoriza entity)
        {
            bool result = false;

            try
            {
                result = UsuarioAutorizaBL.Instance.Update(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool Delete(int usuarioAutorizaId)
        {
            bool result = false;

            try
            {
                result = UsuarioAutorizaBL.Instance.Delete(usuarioAutorizaId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}

