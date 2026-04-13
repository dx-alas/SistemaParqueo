using SistemaParqueo.DataAccess;
using SistemaParqueo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaParqueo.BusinessLogic
{
    public class EmpleadoBL
    {
        private static EmpleadoBL _instance;
        public static EmpleadoBL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new EmpleadoBL();
                return _instance;
            }
        }

        public bool Insert(Empleado entity)
        {
            bool result = false;

            try
            {
                result = EmpleadoDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool Update(Empleado entity)
        {
            bool result = false;

            try
            {
                result = EmpleadoDAL.Instance.Update(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool Delete(int empleadoId)
        {
            bool result = false;

            try
            {
                result = EmpleadoDAL.Instance.Delete(empleadoId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public Empleado SelectById(int empleadoId)
        {
            Empleado result = null;

            try
            {
                result = EmpleadoDAL.Instance.SelectById(empleadoId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public List<Empleado> SelectAll()
        {
            List<Empleado> result = null;

            try
            {
                result = EmpleadoDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }
    }
}

