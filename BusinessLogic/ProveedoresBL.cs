using Data;
using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class ProveedoresBL
    {
        static public void Create(Proveedores provider)
        {
            ProveedoresDAL dal = new ProveedoresDAL();
            dal.Insert(provider);
        }

        public static DataTable SelectAll()
        {
            ProveedoresDAL dal = new ProveedoresDAL();
            return dal.SelectAll();
        }

        public static DataTable SelectById(string id)
        {
            ProveedoresDAL dal = new ProveedoresDAL();
            return dal.SelectById(id);
        }

        public static void Update(Proveedores provider)
        {
            ProveedoresDAL dal = new ProveedoresDAL();
            dal.Update(provider);
        }

        public static void Delete(int iD)
        {
            ProveedoresDAL dal = new ProveedoresDAL();
            dal.Delete(iD);
        }
    }
}
