using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Ingreso
    {
        private int _IDIngreso;
        private int _IDTrabajador;
        private int _IDproveedor;
        private DateTime _Fecha;
        private string _Num_Comprobante;
        private decimal _IGV;
        private int _Estado;
        private string _Tipo_Pago;
        public int IDIngreso
        {
            get
            {
                return _IDIngreso;
            }

            set
            {
                _IDIngreso = value;
            }
        }

        public int IDTrabajador
        {
            get
            {
                return _IDTrabajador;
            }

            set
            {
                _IDTrabajador = value;
            }
        }

        public int IDproveedor
        {
            get
            {
                return _IDproveedor;
            }

            set
            {
                _IDproveedor = value;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return _Fecha;
            }

            set
            {
                _Fecha = value;
            }
        }

        public string Num_Comprobante
        {
            get
            {
                return _Num_Comprobante;
            }

            set
            {
                _Num_Comprobante = value;
            }
        }

        public decimal IGV
        {
            get
            {
                return _IGV;
            }

            set
            {
                _IGV = value;
            }
        }

        public int Estado
        {
            get
            {
                return _Estado;
            }

            set
            {
                _Estado = value;
            }
        }

        public string Tipo_Pago
        {
            get
            {
                return _Tipo_Pago;
            }

            set
            {
                _Tipo_Pago = value;
            }
        }

        public Ingreso()
        {

        }

        public Ingreso(int idingreso, int idtrabajador, int idproveedor, string num_comprobante, decimal igv, int estado, string tipo_pago)
        {
            this.IDIngreso = idingreso;
            this.IDTrabajador = idtrabajador;
            this.IDproveedor = idproveedor;
            this.Num_Comprobante = num_comprobante;
            this.IGV = igv;
            this.Estado = estado;
            this.Tipo_Pago = tipo_pago;
            
        }
    }
}
