using SistemaParqueo.DataAccess;
using SistemaParqueo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaParqueo.BusinessLogic
{
    public class CorteCajaBL
    {
        private static CorteCajaBL _instance;
        public static CorteCajaBL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CorteCajaBL();
                return _instance;
            }
        }

        public bool Insert(CorteCaja entity)
        {
            bool result = false;

            try
            {
                result = CorteCajaDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool Update(CorteCaja entity)
        {
            bool result = false;

            try
            {
                result = CorteCajaDAL.Instance.Update(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool Delete(int corteId)
        {
            bool result = false;

            try
            {
                result = CorteCajaDAL.Instance.Delete(corteId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public CorteCaja SelectById(int corteId)
        {
            CorteCaja result = null;

            try
            {
                result = CorteCajaDAL.Instance.SelectById(corteId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public List<CorteCaja> SelectAll()
        {
            List<CorteCaja> result = null;

            try
            {
                result = CorteCajaDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }
    }
}

