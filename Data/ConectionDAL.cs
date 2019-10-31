using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Librerias Utilizadas
using System.Configuration;
using System.Data.SqlClient;

namespace Data
{
   public class ConectionDAL
    {
        private SqlConnection Conexion;
        public ConectionDAL()
        {
            Conexion = new SqlConnection(GetConection);
        }

        private string GetConection 
        { 
            get 
            { 
                return ConfigurationManager.ConnectionStrings["PosSystem.Properties.Settings.conexion"].ToString(); 
            }
        }

       public SqlConnection ConecctionString()
        {
            return Conexion;
        }
    }
}
