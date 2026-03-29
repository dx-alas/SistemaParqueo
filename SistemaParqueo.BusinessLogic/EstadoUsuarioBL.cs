using SistemaParqueo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaParqueo.BusinessLogic
{
    internal class EstadoUsuarioBL
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
                result = EstadoUsuarioBL.Instance.Insert(entity);
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
                result = EstadoUsuarioBL.Instance.Update(entity);
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
                result = EstadoUsuarioBL.Instance.Delete(estadoUsuarioId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
