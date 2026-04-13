using SistemaParqueo.DataAccess;
using SistemaParqueo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaParqueo.BusinessLogic
{
    public class UsuarioBL
    {
        private static UsuarioBL _instance;
        public static UsuarioBL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UsuarioBL();
                return _instance;
            }
        }

        public bool Insert(Usuario entity)
        {
            bool result = false;

            try
            {
                result = UsuarioDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool Update(Usuario entity)
        {
            bool result = false;

            try
            {
                result = UsuarioDAL.Instance.Update(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool Delete(int usuarioId)
        {
            bool result = false;

            try
            {
                result = UsuarioDAL.Instance.Delete(usuarioId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public Usuario SelectById(int usuarioId)
        {
            Usuario result = null;

            try
            {
                result = UsuarioDAL.Instance.SelectById(usuarioId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public List<Usuario> SelectAll()
        {
            List<Usuario> result = null;

            try
            {
                result = UsuarioDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        // Metodo para LOGIN
        public Usuario Login(string nombre, string clave)
        {
            Usuario result = null;

            try
            {
                result = UsuarioDAL.Instance.Login(nombre, clave);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }
    }
}
