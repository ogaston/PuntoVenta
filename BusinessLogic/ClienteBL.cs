using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using System.Data;

namespace BusinessLogic
{
    public class ClienteBL
    {
        static public void Create(Cliente client)
        {
            ClienteDAL dal = new ClienteDAL();
            dal.Insert(client);
        }

        public static DataTable SelectAll()
        {
            ClienteDAL dal = new ClienteDAL();
            return dal.SelectAll();
        }

        public static DataTable SelectById(string id)
        {
            ClienteDAL dal = new ClienteDAL();
            return dal.SelectById(id);
        }

        public static void Update(Cliente client)
        {
            ClienteDAL dal = new ClienteDAL();
            dal.Update(client);
        }

        public static void Delete(int iD)
        {
            ClienteDAL dal = new ClienteDAL();
            dal.Delete(iD);
        }
    }
}
