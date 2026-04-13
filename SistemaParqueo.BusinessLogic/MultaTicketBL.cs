using SistemaParqueo.DataAccess;
using SistemaParqueo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaParqueo.BusinessLogic
{
    public class MultaTicketBL
    {
        private static MultaTicketBL _instance;
        public static MultaTicketBL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MultaTicketBL();
                return _instance;
            }
        }

        public bool Insert(MultaTicket entity)
        {
            bool result = false;

            try
            {
                result = MultaTicketDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool Update(MultaTicket entity)
        {
            bool result = false;

            try
            {
                result = MultaTicketDAL.Instance.Update(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool Delete(int multaId)
        {
            bool result = false;

            try
            {
                result = MultaTicketDAL.Instance.Delete(multaId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public MultaTicket SelectById(int multaId)
        {
            MultaTicket result = null;

            try
            {
                result = MultaTicketDAL.Instance.SelectById(multaId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public List<MultaTicket> SelectAll()
        {
            List<MultaTicket> result = null;

            try
            {
                result = MultaTicketDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }
    }
}

