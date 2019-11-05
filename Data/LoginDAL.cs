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

        public bool ValidatedUsuario(string usuario, string clave)
        {
            bool existe = false;
            int i = 0;

            conexion.ConecctionString().Open();
            using (SqlCommand comando = new SqlCommand("proc_ValidarUsuario", conexion.ConecctionString()))
            {

                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Usuario", usuario);
                comando.Parameters.AddWithValue("@Password", clave);

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        i++;
                    }

                    if (i >= 1) { existe = true; }
                    else { existe = false; }

                }

                conexion.ConecctionString().Close();

                return existe;
            }
        }

    }
}
