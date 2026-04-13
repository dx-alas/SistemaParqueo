using SistemaParqueo.DataAccess;
using SistemaParqueo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaParqueo.BusinessLogic
{
    public class TicketBL
    {
        private static TicketBL _instance;
        public static TicketBL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TicketBL();
                return _instance;
            }
        }

        public bool Insert(Ticket entity)
        {
            bool result = false;

            try
            {
                result = TicketDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool Update(Ticket entity)
        {
            bool result = false;

            try
            {
                result = TicketDAL.Instance.Update(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool Delete(int ticketId)
        {
            bool result = false;

            try
            {
                result = TicketDAL.Instance.Delete(ticketId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public Ticket SelectById(int ticketId)
        {
            Ticket result = null;

            try
            {
                result = TicketDAL.Instance.SelectById(ticketId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public List<Ticket> SelectAll()
        {
            List<Ticket> result = null;

            try
            {
                result = TicketDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }
    }
}

