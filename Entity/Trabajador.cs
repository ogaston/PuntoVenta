using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class Trabajador
    {
        public int IDTrabajador { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Sexo { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public string Cedula { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public double Salario { get; set; }
        public string Regla { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public string Cargo { get; set; }
        public int Estatus { get; set; }
    }
}
