using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entity;
using System.Data;

namespace Data
{
    public class TrabajadorDAL
    {
     
        public static void InsertTrabajador(Trabajador nuevo)
        {
            using (SqlConnection conexion = ConectionDAL.ConecctionString())
            {
                try
                {
                    using (SqlCommand comando = new SqlCommand("proc_TrabajadorInsert", conexion))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@IDTrabajador", nuevo.IDTrabajador);
                        comando.Parameters.AddWithValue("@Nombre", nuevo.Nombre);
                        comando.Parameters.AddWithValue("@Apellido", nuevo.Apellido);
                        comando.Parameters.AddWithValue("@Sexo", nuevo.Sexo);
                        comando.Parameters.AddWithValue("@Fecha_Nacimiento", nuevo.Fecha_Nacimiento);
                        comando.Parameters.AddWithValue("@Cedula", nuevo.Cedula);
                        comando.Parameters.AddWithValue("@Direccion", nuevo.Direccion);
                        comando.Parameters.AddWithValue("@Telefono", nuevo.Telefono);
                        comando.Parameters.AddWithValue("@Email", nuevo.Email);
                        comando.Parameters.AddWithValue("@Salario", nuevo.Salario);
                        comando.Parameters.AddWithValue("@Regla", nuevo.Regla);
                        comando.Parameters.AddWithValue("@Usuario", nuevo.Usuario);
                        comando.Parameters.AddWithValue("@Password", nuevo.Password);
                        comando.Parameters.AddWithValue("@Cargo", nuevo.Cargo);
                        comando.Parameters.AddWithValue("@Estatus", nuevo.Estatus);
                        comando.ExecuteNonQuery();
                    }
                }
                catch (Exception)
                {
                    throw;
                }
              
            }
        }

        public static DataTable SelectAllTrabajador()
        {
            using (SqlConnection conexion = ConectionDAL.ConecctionString())
            {
                try
                {
                    DataTable dataTable = new DataTable();
                    using (SqlCommand comando = new SqlCommand("proc_TrabajadorLoadAll", conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader(CommandBehavior.CloseConnection))
                        {
                            dataTable.Load(reader);
                        }
                    }
                    return dataTable;
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

    }
}
