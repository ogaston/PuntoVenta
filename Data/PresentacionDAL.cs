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
    public class PresentacionDAL
    {
        private ConectionDAL conexion;

        public PresentacionDAL()
        {
            conexion = new ConectionDAL();
        }

        public DataTable SelectAllPresentacion()
        {

            conexion.ConecctionString().Open();

            DataTable dataTable = new DataTable();
            using (SqlCommand comando = new SqlCommand("proc_PresentacionLoadAll", conexion.ConecctionString()))
            {
                using (SqlDataReader reader = comando.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    dataTable.Load(reader);
                }
            }
            conexion.ConecctionString().Close();

            return dataTable;
        }
        public void InsertPresentacion(Presentacion nuevo)
        {
            conexion.ConecctionString().Open();
            using (SqlCommand comando = new SqlCommand("proc_PresentacionInsert", conexion.ConecctionString()))
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Nombre", nuevo.Nombre);
                comando.Parameters.AddWithValue("@Descripcion", nuevo.Descripcion);
                comando.ExecuteNonQuery();
            }
            conexion.ConecctionString().Close();
        }
        public DataTable SelectNombrePresentacion(string Nombre)
        {
            conexion.ConecctionString().Open();

            DataTable dataTable = new DataTable();
            using (SqlCommand comando = new SqlCommand("proc_nombre", conexion.ConecctionString()))
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Nombre", Nombre);
                using (SqlDataReader reader = comando.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    dataTable.Load(reader);
                }
            }
            conexion.ConecctionString().Close();

            return dataTable;
        }
        public void UpdatePresentacion(Presentacion modifica)
        { 
            conexion.ConecctionString().Open();
            using (SqlCommand comando = new SqlCommand("proc_PresentacionUpdate", conexion.ConecctionString()))
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IDPresentacion", modifica.IDPresentacion);
                comando.Parameters.AddWithValue("@Nombre", modifica.Nombre);
                comando.Parameters.AddWithValue("@Descripcion", modifica.Descripcion);
                comando.ExecuteNonQuery();
            }
            conexion.ConecctionString().Close();
        }
        
        public void DeletePresentacion(int id)
        {

            conexion.ConecctionString().Open();
            using (SqlCommand comando = new SqlCommand("proc_PresentacionDelete", conexion.ConecctionString()))
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IDPresentacion", id);
                comando.ExecuteNonQuery();
            }
            conexion.ConecctionString().Close();

        }
        
    }
}
