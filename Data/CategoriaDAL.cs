using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class CategoriaDAL
    { 
            private ConectionDAL conexion;

            public CategoriaDAL()
            {
                conexion = new ConectionDAL();
            }

        public void InsertCategoria(Categoria nuevo)
        {
            conexion.ConecctionString().Open();
            using (SqlCommand comando = new SqlCommand("proc_CategoriaInsert", conexion.ConecctionString()))
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Nombre", nuevo.Nombre);
                comando.Parameters.AddWithValue("@Descripcion", nuevo.Descripcion);
                comando.Parameters.AddWithValue("@Estatus", 1);

               
                comando.ExecuteNonQuery();
            }
            conexion.ConecctionString().Close();
        }

        public DataTable SelectAllCategoria()
        {

            conexion.ConecctionString().Open();

            DataTable dataTable = new DataTable();
            using (SqlCommand comando = new SqlCommand("proc_CategoriaLoadAll", conexion.ConecctionString()))
            {
                using (SqlDataReader reader = comando.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    dataTable.Load(reader);
                }
            }
            conexion.ConecctionString().Close();

            return dataTable;
        }

        public DataTable SelectIdCategoria(string nombre)
        {
            conexion.ConecctionString().Open();

            DataTable dataTable = new DataTable();
            using (SqlCommand comando = new SqlCommand("proc_CategoriaLoadById", conexion.ConecctionString()))
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Nombre", nombre);
                using (SqlDataReader reader = comando.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    dataTable.Load(reader);
                }
            }
            conexion.ConecctionString().Close();

            return dataTable;
        }

        public void UpdateCategoria(Categoria modifica)
        {
            conexion.ConecctionString().Open();
            using (SqlCommand comando = new SqlCommand("proc_CategoriaUpdate", conexion.ConecctionString()))
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IDCategoria", modifica.IDCategoria);
                comando.Parameters.AddWithValue("@Nombre", modifica.Nombre);
                comando.Parameters.AddWithValue("@Descripcion", modifica.Descripcion);
                                
                comando.ExecuteNonQuery();
            }
            conexion.ConecctionString().Close();
        }

        public void DeleteCategoria(int id)
        {

            conexion.ConecctionString().Open();
            using (SqlCommand comando = new SqlCommand("proc_CategoriaDelete", conexion.ConecctionString()))
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IDCategoria", id);
                comando.ExecuteNonQuery();
            }
            conexion.ConecctionString().Close();

        }
    }
}
