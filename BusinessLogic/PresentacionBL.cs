using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entity;
using Data;


namespace BusinessLogic
{
   public class PresentacionBL
    {
        public static DataTable SelectAllPresentacion()
        {
            PresentacionDAL Presentacion = new PresentacionDAL();
            return Presentacion.SelectAllPresentacion();
        }
        public static void InsertPresentacion(Presentacion insertNew)
        {
            PresentacionDAL presentacion = new PresentacionDAL();
            presentacion.InsertPresentacion(insertNew);
        }
        public static DataTable SelectNombrePresentacion(string Nombre)
        {
            PresentacionDAL presentacion = new PresentacionDAL();
            return presentacion.SelectNombrePresentacion(Nombre);
        }
        public static void UpdatePresentacion(Presentacion update)
        {
            PresentacionDAL presentacion = new PresentacionDAL();
            presentacion.UpdatePresentacion(update);
        }
        public static void DeletePresentacion(int id)
        {
            PresentacionDAL presentacion = new PresentacionDAL();
            presentacion.DeletePresentacion(id);
        }

    }

}

