using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class LoginDAL
    {
        private ConectionDAL conexion;

        public LoginDAL()
        {
            conexion = new ConectionDAL();
        }

        public string[] ValidatedUsuario(string usuario, string clave)
        {
            EncryptDecrypt encryp = new EncryptDecrypt();

            string[] existe=new string[2];
            
            

            conexion.ConecctionString().Open();
            using (SqlCommand comando = new SqlCommand("proc_ValidarUsuario", conexion.ConecctionString()))
            {

                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Usuario", usuario);
                comando.Parameters.AddWithValue("@Password",encryp.Encrypt(clave));

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        existe[0] = reader["Rango"].ToString();
                        existe[1] = reader["IDTrabajador"].ToString();
                    }

                }

                conexion.ConecctionString().Close();

                return existe;
            }
        }

        public string ValidarUsuario(string usuario, string clave)
        {
            EncryptDecrypt encryp = new EncryptDecrypt();

            string existe = "";



            conexion.ConecctionString().Open();
            using (SqlCommand comando = new SqlCommand("proc_ValidarUsuario", conexion.ConecctionString()))
            {

                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Usuario", usuario);
                comando.Parameters.AddWithValue("@Password",encryp.Encrypt(clave));

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        existe = reader["Rango"].ToString();
                    }

                }

                conexion.ConecctionString().Close();

                return existe;
            }
        }

    }
}
