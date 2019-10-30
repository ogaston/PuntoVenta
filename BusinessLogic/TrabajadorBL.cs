using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Data;
using Entity;

namespace BusinessLogic
{
    public class TrabajadorBL
    {
        public static void InsertTrabajador(Trabajador insertNew)
        {
            TrabajadorDAL.InsertTrabajador(insertNew);
        }

        public static void UpdateTrabajador(Trabajador update)
        {
            TrabajadorDAL.UpdateTrabajador(update);
        }

        public static void DeleteTrabajador(int id)
        {
            TrabajadorDAL.DeleteTrabajador(id);
        }

        public static DataTable SelectAllTrabajador()
        {
            return TrabajadorDAL.SelectAllTrabajador();
        }
    }
}
