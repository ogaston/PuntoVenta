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
        private ConectionDAL conexion;

        public TrabajadorDAL()
        {
            conexion = new ConectionDAL();
        }
        public void InsertTrabajador(Trabajador nuevo)
        {
            conexion.ConecctionString().Open();
            using (SqlCommand comando = new SqlCommand("proc_TrabajadorInsert", conexion.ConecctionString()))
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Nombre", nuevo.Nombre);
                comando.Parameters.AddWithValue("@Apellido", nuevo.Apellido);
                comando.Parameters.AddWithValue("@Sexo", nuevo.Sexo);
                comando.Parameters.AddWithValue("@FechaNacimiento", nuevo.Fecha_Nacimiento);
                comando.Parameters.AddWithValue("@Cedula", nuevo.Cedula);
                comando.Parameters.AddWithValue("@Direccion", nuevo.Direccion);
                comando.Parameters.AddWithValue("@Telefono", nuevo.Telefono);
                comando.Parameters.AddWithValue("@Email", nuevo.Email);
                comando.Parameters.AddWithValue("@Salario", nuevo.Salario);
                comando.Parameters.AddWithValue("@Regla", nuevo.Regla);
                comando.Parameters.AddWithValue("@Usuario", nuevo.Usuario);
                comando.Parameters.AddWithValue("@Password",nuevo.Password);
                comando.Parameters.AddWithValue("@Cargo", nuevo.Cargo);
                comando.Parameters.AddWithValue("@Estatus", 1);
                comando.ExecuteNonQuery();
            }
            conexion.ConecctionString().Close();
        }

        public DataTable SelectAllTrabajador()
        {

            conexion.ConecctionString().Open();

            DataTable dataTable = new DataTable();
            using (SqlCommand comando = new SqlCommand("proc_TrabajadorLoadAll", conexion.ConecctionString()))
            {
                using (SqlDataReader reader = comando.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    dataTable.Load(reader);
                }
            }
            conexion.ConecctionString().Close();

            return dataTable;
        }

        public DataTable SelectNameTrabajador(string nombre)
        {
            conexion.ConecctionString().Open();

            DataTable dataTable = new DataTable();
            using (SqlCommand comando = new SqlCommand("proc_TrabajadorLoadById", conexion.ConecctionString()))
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

        public void UpdateTrabajador(Trabajador modifica)
        {
            conexion.ConecctionString().Open();
            using (SqlCommand comando = new SqlCommand("proc_TrabajadorUpdate", conexion.ConecctionString()))
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IDTrabajador", modifica.IDTrabajador);
                comando.Parameters.AddWithValue("@Nombre", modifica.Nombre);
                comando.Parameters.AddWithValue("@Apellido", modifica.Apellido);
                comando.Parameters.AddWithValue("@Sexo", modifica.Sexo);
                comando.Parameters.AddWithValue("@FechaNacimiento", modifica.Fecha_Nacimiento);
                comando.Parameters.AddWithValue("@Cedula", modifica.Cedula);
                comando.Parameters.AddWithValue("@Direccion", modifica.Direccion);
                comando.Parameters.AddWithValue("@Telefono", modifica.Telefono);
                comando.Parameters.AddWithValue("@Email", modifica.Email);
                comando.Parameters.AddWithValue("@Salario", modifica.Salario);
                comando.Parameters.AddWithValue("@Regla", modifica.Regla);
                comando.Parameters.AddWithValue("@Usuario", modifica.Usuario);
                comando.Parameters.AddWithValue("@Password",modifica.Password);
                comando.Parameters.AddWithValue("@Cargo", modifica.Cargo);
                comando.Parameters.AddWithValue("@Estatus", 1);
                comando.ExecuteNonQuery();
            }
            conexion.ConecctionString().Close();
        }

        public void DeleteTrabajador(int id)
        {

            conexion.ConecctionString().Open();
            using (SqlCommand comando = new SqlCommand("proc_TrabajadorDelete", conexion.ConecctionString()))
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IDTrabajador", id);
                comando.ExecuteNonQuery();
            }
            conexion.ConecctionString().Close();

        }
    }
}
