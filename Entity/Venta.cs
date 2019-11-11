using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Venta
    {
        private int _IDventa;
        private int _IDCliente;
        private int _IDTrabajador;
        private DateTime _Fecha;
        private string _Tipo_Pago;
        private string _No_Comprobante;
        private string _No_Crefiscal;
        private decimal _IGV;
        private string _No_Auttarjeta;
        private int _Estado;

        public int IDventa
        {
            get
            {
                return _IDventa;
            }

            set
            {
                _IDventa = value;
            }
        }

        public int IDCliente
        {
            get
            {
                return _IDCliente;
            }

            set
            {
                _IDCliente = value;
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

        public string No_Comprobante
        {
            get
            {
                return _No_Comprobante;
            }

            set
            {
                _No_Comprobante = value;
            }
        }

        public string No_Crefiscal
        {
            get
            {
                return _No_Crefiscal;
            }

            set
            {
                _No_Crefiscal = value;
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

        public string No_Auttarjeta
        {
            get
            {
                return _No_Auttarjeta;
            }

            set
            {
                _No_Auttarjeta = value;
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


        public Venta()
        {

        }

        public Venta(int idventa, int idcliente, int idtrabajador, DateTime fecha, string tipo_pago,
            string no_comprobante, string no_crefical, string no_auttarjeta,decimal igv, int estado)
        {
            this.IDventa = idventa;
            this.IDCliente = idcliente;
            this.IDTrabajador = idtrabajador;
            this.Fecha = fecha;
            this.Tipo_Pago = tipo_pago;
            this.No_Comprobante = no_comprobante;
            this.No_Crefiscal = no_crefical;
            this.No_Auttarjeta = no_auttarjeta;
            this.IGV = igv;
            this.Estado = estado;
        }

    }
}
