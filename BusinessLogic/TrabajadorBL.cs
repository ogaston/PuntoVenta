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
            TrabajadorDAL trabajador = new TrabajadorDAL();
               trabajador.InsertTrabajador(insertNew);
        }

        public static void UpdateTrabajador(Trabajador update)
        {
            TrabajadorDAL trabajador = new TrabajadorDAL();
            trabajador.UpdateTrabajador(update);
        }

        public static void DeleteTrabajador(int id)
        {
            TrabajadorDAL trabajador = new TrabajadorDAL();
                trabajador.DeleteTrabajador(id);
        }

        public static DataTable SelectAllTrabajador()
        {
            TrabajadorDAL trabajador = new TrabajadorDAL();
            return trabajador.SelectAllTrabajador();
        }
    }
}
