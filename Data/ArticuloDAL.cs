using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Entity;

namespace Data
{
   public class ArticuloDAL
    {
        private ConectionDAL conexion;

        public ArticuloDAL()
        {
            conexion = new ConectionDAL();
        }
        public void InsertArticulo(Articulo nuevo)
        {
            conexion.ConecctionString().Open();
            using (SqlCommand comando = new SqlCommand("proc_ArticuloInsert", conexion.ConecctionString()))
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IDCategoria", nuevo.IDCategoria);
                comando.Parameters.AddWithValue("@IDPresentacion", nuevo.IDPresentacion);
                comando.Parameters.AddWithValue("@Codigo_Articulo", nuevo.Codido_Articulo);
                comando.Parameters.AddWithValue("@Nombre", nuevo.Nombre);
                comando.Parameters.AddWithValue("@Descripcion", nuevo.Descripcion);

                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                nuevo.Imagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
               
                comando.Parameters.AddWithValue("@Imagen", ms.GetBuffer());
                comando.Parameters.AddWithValue("@Estatus", 1);
                comando.ExecuteNonQuery();
            }
            conexion.ConecctionString().Close();
        }

        public DataTable SelectAllArticulo()
        {

            conexion.ConecctionString().Open();

            DataTable dataTable = new DataTable();
            using (SqlCommand comando = new SqlCommand("proc_ArticuloLoadAll", conexion.ConecctionString()))
            {
                using (SqlDataReader reader = comando.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    dataTable.Load(reader);
                }
            }
            conexion.ConecctionString().Close();

            return dataTable;
        }

        public DataTable SelectCodigoArticulo(string codigo)
        {
            conexion.ConecctionString().Open();

            DataTable dataTable = new DataTable();
            using (SqlCommand comando = new SqlCommand("proc_ArticuloLoadById", conexion.ConecctionString()))
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Codigo_Articulo", codigo);
                using (SqlDataReader reader = comando.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    dataTable.Load(reader);
                }
            }
            conexion.ConecctionString().Close();

            return dataTable;
        }

        public void UpdateArticulo(Articulo modifica)
        {
            conexion.ConecctionString().Open();
            using (SqlCommand comando = new SqlCommand("proc_ArticuloUpdate", conexion.ConecctionString()))
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IDArticulo", modifica.IDArticulo);
                comando.Parameters.AddWithValue("@Codigo_Articulo", modifica.Codido_Articulo);
                comando.Parameters.AddWithValue("@IDCategoria", modifica.IDCategoria);
                comando.Parameters.AddWithValue("@IDPresentacion", modifica.IDPresentacion);
                comando.Parameters.AddWithValue("@Nombre", modifica.Nombre);
                comando.Parameters.AddWithValue("@Descripcion", modifica.Descripcion);

                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                modifica.Imagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                comando.Parameters.AddWithValue("@Imagen", ms.GetBuffer());
                comando.Parameters.AddWithValue("@Estatus", 1);
                comando.ExecuteNonQuery();
            }
            conexion.ConecctionString().Close();
        }

        public void DeleteArticulo(int id)
        {

            conexion.ConecctionString().Open();
            using (SqlCommand comando = new SqlCommand("proc_ArticuloDelete", conexion.ConecctionString()))
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IDArticulo", id);
                comando.ExecuteNonQuery();
            }
            conexion.ConecctionString().Close();

        }
    }
}
