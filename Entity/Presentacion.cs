using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;


namespace Entity
{
   public class  Presentacion
    {
        public int IDPresentacion { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
       
    }
}
