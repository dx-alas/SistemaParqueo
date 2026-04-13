using SistemaParqueo.DataAccess;
using SistemaParqueo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaParqueo.BusinessLogic
{
    public class EstadoUsuarioBL
    {
        private static EstadoUsuarioBL _instance;
        public static EstadoUsuarioBL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new EstadoUsuarioBL();
                return _instance;
            }
        }

        public bool Insert(EstadoUsuario entity)
        {
            bool result = false;

            try
            {
                result = EstadoUsuarioDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool Update(EstadoUsuario entity)
        {
            bool result = false;

            try
            {
                result = EstadoUsuarioDAL.Instance.Update(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool Delete(int estadoUsuarioId)
        {
            bool result = false;

            try
            {
                result = EstadoUsuarioDAL.Instance.Delete(estadoUsuarioId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public EstadoUsuario SelectById(int estadoUsuarioId)
        {
            EstadoUsuario result = null;

            try
            {
                result = EstadoUsuarioDAL.Instance.SelectById(estadoUsuarioId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public List<EstadoUsuario> SelectAll()
        {
            List<EstadoUsuario> result = null;

            try
            {
                result = EstadoUsuarioDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }
    }
}
