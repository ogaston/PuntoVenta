using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class Articulo
    {
        public decimal IDArticulo { get; set; }
        public int IDCategoria { get; set; }
        public int IDPresentacion { get; set; }
        public string Codido_Articulo { get; set; }
        public string Nombre { get; set; }
        public string Imagen { get; set; }
        public int Estatus { get; set; }
        public string Descripcion { get; set; }

    }
}
