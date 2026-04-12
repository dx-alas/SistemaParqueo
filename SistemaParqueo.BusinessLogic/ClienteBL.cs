using SistemaParqueo.DataAccess;
using SistemaParqueo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaParqueo.BusinessLogic
{
    public class ClienteBL
    {
        private static ClienteBL _instance;
        public static ClienteBL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ClienteBL();
                return _instance;
            }
        }

        public bool Insert(Cliente entity)
        {
            bool result = false;

            try
            {
                result = ClienteDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool Update(Cliente entity)
        {
            bool result = false;

            try
            {
                result = ClienteDAL.Instance.Update(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool Delete(int clienteId)
        {
            bool result = false;

            try
            {
                result = ClienteDAL.Instance.Delete(clienteId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}

