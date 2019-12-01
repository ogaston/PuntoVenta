using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Cliente
    {
        public int IDCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Sexo { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public string Num_Documento { get; set; }
        public string Tipo_Documento { get; set; }
        public string Telofono { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
    }
}
