using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Data
{
    public class ProveedoresDAL
    {
        private ConectionDAL conexion;

        public ProveedoresDAL()
        {
            conexion = new ConectionDAL();
        }
        public void Insert(Proveedores nuevo)
        {
            conexion.ConecctionString().Open();
            using (SqlCommand comando = new SqlCommand("proc_ProveedorInsert", conexion.ConecctionString()))
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@SectorComercial", nuevo.Sector_Comercial);
                comando.Parameters.AddWithValue("@RazonSocial", nuevo.razon_social);
                comando.Parameters.AddWithValue("@Identificacion", nuevo.Identificacion);
                comando.Parameters.AddWithValue("@Telefono", nuevo.Telefono);
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
            using (SqlCommand comando = new SqlCommand("proc_ProveedorLoadAll", conexion.ConecctionString()))
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
            using (SqlCommand comando = new SqlCommand("proc_ProveedorLoadById", conexion.ConecctionString()))
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IDProveedor", codigo);
                using (SqlDataReader reader = comando.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    dataTable.Load(reader);
                }
            }
            conexion.ConecctionString().Close();

            return dataTable;
        }

        public void Update(Proveedores modifica)
        {
            conexion.ConecctionString().Open();
            using (SqlCommand comando = new SqlCommand("proc_ProveedorUpdate", conexion.ConecctionString()))
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IDProveedor", modifica.IDProveedores);
                comando.Parameters.AddWithValue("@RazonSocial", modifica.razon_social);
                comando.Parameters.AddWithValue("@SectorComercial", modifica.Sector_Comercial);
                comando.Parameters.AddWithValue("@Identificacion", modifica.Identificacion);
                comando.Parameters.AddWithValue("@Telefono", modifica.Telefono);
                comando.Parameters.AddWithValue("@Direccion", modifica.Direccion);
                comando.Parameters.AddWithValue("@Email", modifica.Email);
                comando.ExecuteNonQuery();
            }
            conexion.ConecctionString().Close();
        }

        public void Delete(int id)
        {

            conexion.ConecctionString().Open();
            using (SqlCommand comando = new SqlCommand("proc_ProveedorDelete", conexion.ConecctionString()))
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IDProveedor", id);
                comando.ExecuteNonQuery();
            }
            conexion.ConecctionString().Close();

        }
    }
}
