using SistemaParqueo.DataAccess;
using SistemaParqueo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaParqueo.BusinessLogic
{
    public class ParqueoBL
    {
        private static ParqueoBL _instance;
        public static ParqueoBL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ParqueoBL();
                return _instance;
            }
        }

        public bool Insert(Parqueo entity)
        {
            bool result = false;

            try
            {
                result = ParqueoDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool Update(Parqueo entity)
        {
            bool result = false;

            try
            {
                result = ParqueoDAL.Instance.Update(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool Delete(int parqueoId)
        {
            bool result = false;

            try
            {
                result = ParqueoDAL.Instance.Delete(parqueoId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public Parqueo SelectById(int parqueoId)
        {
            Parqueo result = null;

            try
            {
                result = ParqueoDAL.Instance.SelectById(parqueoId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public List<Parqueo> SelectAll()
        {
            List<Parqueo> result = null;

            try
            {
                result = ParqueoDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }
    }
}