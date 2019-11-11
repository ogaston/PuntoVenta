using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace BusinessLogic
{
    public class LoginBL
    {
        public static string[] ValidatedUsuario(string usuario,string clave)
        {
            LoginDAL validate = new LoginDAL();
            return validate.ValidatedUsuario(usuario,clave);
        }
    }
}
