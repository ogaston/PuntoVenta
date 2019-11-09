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
   public class ArticuloBL
    {
        public static void InsertArticulo(Articulo insertNew)
        {
            ArticuloDAL Articulo = new ArticuloDAL();
            Articulo.InsertArticulo(insertNew);
        }


        // Agregando mensaje de prueba
        public static void UpdateArticulo(Articulo update)
        {
            ArticuloDAL Articulo = new ArticuloDAL();
            Articulo.UpdateArticulo(update);
        }

        public static void DeleteArticulo(int id)
        {
            ArticuloDAL Articulo = new ArticuloDAL();
            Articulo.DeleteArticulo(id);
        }

        public static DataTable SelectAllArticulo()
        {
            ArticuloDAL Articulo = new ArticuloDAL();
            return Articulo.SelectAllArticulo();
        }

        public static DataTable SelectCodigoArticulo(string codigo)
        {
            ArticuloDAL Articulo = new ArticuloDAL();
            return Articulo.SelectCodigoArticulo(codigo);
        }
    }
}
