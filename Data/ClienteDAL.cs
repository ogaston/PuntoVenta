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
    public class ClienteDAL
    {
        private ConectionDAL conexion;

        public ClienteDAL()
        {
            conexion = new ConectionDAL();
        }
        public void Insert(Cliente nuevo)
        {
            conexion.ConecctionString().Open();
            using (SqlCommand comando = new SqlCommand("proc_ClienteInsert", conexion.ConecctionString()))
            {
                comando.CommandType = CommandType.StoredProcedure;
                // comando.Parameters.AddWithValue("@IDCliente", nuevo.IDCliente);
                comando.Parameters.AddWithValue("@Nombre", nuevo.Nombre);
                comando.Parameters.AddWithValue("@Apellido", nuevo.Apellido);
                comando.Parameters.AddWithValue("@Sexo", nuevo.Sexo);
                comando.Parameters.AddWithValue("@FechaNacimiento", nuevo.Fecha_Nacimiento.Date);
                comando.Parameters.AddWithValue("@TipoDocumento", nuevo.Tipo_Documento);
                comando.Parameters.AddWithValue("@NumDocumeto", nuevo.Num_Documento);
                comando.Parameters.AddWithValue("@Telefono", nuevo.Telofono);
                comando.Parameters.AddWithValue("@Direccion", nuevo.Direccion);
                comando.Parameters.AddWithValue("@Email", nuevo.Email);
                comando.ExecuteNonQuery();
            }
            conexion.ConecctionString().Close();
        }

        public DataTable SelectAll()
        {

            conexion.ConecctionString().Open();

            DataTable dataTable = new DataTable();
            using (SqlCommand comando = new SqlCommand("proc_ClienteLoadAll", conexion.ConecctionString()))
            {
                using (SqlDataReader reader = comando.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    dataTable.Load(reader);
                }
            }
            conexion.ConecctionString().Close();

            return dataTable;
        }

        public DataTable SelectById(string codigo)
        {
            conexion.ConecctionString().Open();

            DataTable dataTable = new DataTable();
            using (SqlCommand comando = new SqlCommand("proc_ClienteLoadById", conexion.ConecctionString()))
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IDCliente", codigo);
                using (SqlDataReader reader = comando.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    dataTable.Load(reader);
                }
            }
            conexion.ConecctionString().Close();

            return dataTable;
        }

        public void Update(Cliente modifica)
        {
            conexion.ConecctionString().Open();
            using (SqlCommand comando = new SqlCommand("proc_ClienteUpdate", conexion.ConecctionString()))
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IDCliente", modifica.IDCliente);
                comando.Parameters.AddWithValue("@Nombre", modifica.Nombre);
                comando.Parameters.AddWithValue("@Apellido", modifica.Apellido);
                comando.Parameters.AddWithValue("@Sexo", modifica.Sexo);
                comando.Parameters.AddWithValue("@FechaNacimiento", modifica.Fecha_Nacimiento.Date);
                comando.Parameters.AddWithValue("@TipoDocumento", modifica.Tipo_Documento);
                comando.Parameters.AddWithValue("@NumDocumeto", modifica.Num_Documento);
                comando.Parameters.AddWithValue("@Telefono", modifica.Telofono);
                comando.Parameters.AddWithValue("@Direccion", modifica.Direccion);
                comando.Parameters.AddWithValue("@Email", modifica.Email);
                comando.ExecuteNonQuery();
            }
            conexion.ConecctionString().Close();
        }

        public void Delete(int id)
        {

            conexion.ConecctionString().Open();
            using (SqlCommand comando = new SqlCommand("proc_ClienteDelete", conexion.ConecctionString()))
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IDCliente", id);
                comando.ExecuteNonQuery();
            }
            conexion.ConecctionString().Close();

        }
    }
}
