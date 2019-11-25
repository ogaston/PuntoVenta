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
    public class CategoriaBL
    {
        public static void InsertCategoria(Categoria insertNew)
        {
            CategoriaDAL categoria = new CategoriaDAL ();
            categoria.InsertCategoria(insertNew);
        }


        public static void UpdateCategoria(Categoria update)
        {
            CategoriaDAL categoria = new CategoriaDAL();
            categoria.UpdateCategoria(update);
        }

        public static void DeleteCategoria(int id)
        {
            CategoriaDAL categoria = new CategoriaDAL();
            categoria.DeleteCategoria(id);
        }

        public static DataTable SelectAllCategoria()
        {
            CategoriaDAL categoria = new CategoriaDAL();
            return categoria.SelectAllCategoria();
        }

        public static DataTable SelectIdCategoria(string nombre)
        {
            CategoriaDAL categoria = new CategoriaDAL();
            return categoria.SelectIdCategoria(nombre);
        }


    }
}
