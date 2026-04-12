using SistemaParqueo.DataAccess;
using SistemaParqueo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaParqueo.BusinessLogic
{
    internal class EstadoTicketBL
    {
        private static EstadoTicketBL _instance;
        public static EstadoTicketBL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new EstadoTicketBL();
                return _instance;
            }
        }

        public bool Insert(EstadoTicket entity)
        {
            bool result = false;

            try
            {
                result = EstadoTicketDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool Update(EstadoTicket entity)
        {
            bool result = false;

            try
            {
                result = EstadoTicketDAL.Instance.Update(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool Delete(int estadoTicketId)
        {
            bool result = false;

            try
            {
                result = EstadoTicketDAL.Instance.Delete(estadoTicketId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}