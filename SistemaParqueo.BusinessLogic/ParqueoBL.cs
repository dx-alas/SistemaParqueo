using SistemaParqueo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaParqueo.BusinessLogic
{
    internal class ParqueoBL
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
                result = ParqueoBL.Instance.Insert(entity);
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
                result = ParqueoBL.Instance.Update(entity);
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
                result = ParqueoBL.Instance.Delete(parqueoId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}