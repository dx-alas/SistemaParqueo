using SistemaParqueo.DataAccess;
using SistemaParqueo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaParqueo.BusinessLogic
{
    internal class RolBL
    {
        private static RolBL _instance;
        public static RolBL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new RolBL();
                return _instance;
            }
        }

        public bool Insert(Rol entity)
        {
            bool result = false;

            try
            {
                result = RolDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool Update(Rol entity)
        {
            bool result = false;

            try
            {
                result = RolDAL.Instance.Update(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool Delete(int rolId)
        {
            bool result = false;

            try
            {
                result = RolDAL.Instance.Delete(rolId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}