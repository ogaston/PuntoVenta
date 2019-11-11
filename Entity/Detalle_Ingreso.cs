using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Detalle_Ingreso
    {

        private int _Iddetalle_Ingreso;
        private int _Idingreso;
        private int _Idarticulo;
        private decimal _Precio_Compra;
        private decimal _Precio_Venta;
        private int _Stock_Inicial;
        private int _Stock_Actual;
        private DateTime _Fecha_Produccion;
        private DateTime _Fecha_Vencimiento;

        public int Iddetalle_Ingreso
        {
            get
            {
                return _Iddetalle_Ingreso;
            }

            set
            {
                _Iddetalle_Ingreso = value;
            }
        }

        public int Idingreso
        {
            get
            {
                return _Idingreso;
            }

            set
            {
                _Idingreso = value;
            }
        }

        public int Idarticulo
        {
            get
            {
                return _Idarticulo;
            }

            set
            {
                _Idarticulo = value;
            }
        }

        public decimal Precio_Compra
        {
            get
            {
                return _Precio_Compra;
            }

            set
            {
                _Precio_Compra = value;
            }
        }

        public decimal Precio_Venta
        {
            get
            {
                return _Precio_Venta;
            }

            set
            {
                _Precio_Venta = value;
            }
        }

        public int Stock_Inicial
        {
            get
            {
                return _Stock_Inicial;
            }

            set
            {
                _Stock_Inicial = value;
            }
        }

        public int Stock_Actual
        {
            get
            {
                return _Stock_Actual;
            }

            set
            {
                _Stock_Actual = value;
            }
        }

        public DateTime Fecha_Produccion
        {
            get
            {
                return _Fecha_Produccion;
            }

            set
            {
                _Fecha_Produccion = value;
            }
        }

        public DateTime Fecha_Vencimiento
        {
            get
            {
                return _Fecha_Vencimiento;
            }

            set
            {
                _Fecha_Vencimiento = value;
            }
        }


        public Detalle_Ingreso()
        {


        }

        public Detalle_Ingreso(int iddetalle_ingreso, int idingreso,
          int idarticulo, decimal precio_compra, decimal precio_venta,
          int stock_inicial, int stock_actual, DateTime fecha_produccion,
          DateTime fecha_vencimiento)
        {
            this.Iddetalle_Ingreso = iddetalle_ingreso;
            this.Idingreso = idingreso;
            this.Idarticulo = idarticulo;
            this.Precio_Compra = precio_compra;
            this.Precio_Venta = precio_venta;
            this.Stock_Inicial = stock_inicial;
            this.Stock_Actual = stock_actual;
            this.Fecha_Produccion = fecha_produccion;
            this.Fecha_Vencimiento = fecha_vencimiento;
        }
       
    }
}
