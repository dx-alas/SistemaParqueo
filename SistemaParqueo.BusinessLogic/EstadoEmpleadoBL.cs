using SistemaParqueo.DataAccess;
using SistemaParqueo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaParqueo.BusinessLogic
{
    public class EstadoEmpleadoBL
    {
        private static EstadoEmpleadoBL _instance;
        public static EstadoEmpleadoBL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new EstadoEmpleadoBL();
                return _instance;
            }
        }

        public bool Insert(EstadoEmpleado entity)
        {
            bool result = false;

            try
            {
                result = EstadoEmpleadoDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool Update(EstadoEmpleado entity)
        {
            bool result = false;

            try
            {
                result = EstadoEmpleadoDAL.Instance.Update(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool Delete(int estadoEmpleadoId)
        {
            bool result = false;

            try
            {
                result = EstadoEmpleadoDAL.Instance.Delete(estadoEmpleadoId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public EstadoEmpleado SelectById(int estadoEmpleadoId)
        {
            EstadoEmpleado result = null;

            try
            {
                result = EstadoEmpleadoDAL.Instance.SelectById(estadoEmpleadoId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public List<EstadoEmpleado> SelectAll()
        {
            List<EstadoEmpleado> result = null;

            try
            {
                result = EstadoEmpleadoDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }
    }
}

