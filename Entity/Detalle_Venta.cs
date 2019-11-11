using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Detalle_Venta
    {
        #region Properties
        public int IDDetalle_Venta { get; set; }
        public int IDDetalle_Ingreso { get; set; }
        public int IDVenta { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio_Venta { get; set; }
        public decimal Descuento { get; set; }
        #endregion


        public Detalle_Venta()
        { }

        public Detalle_Venta(int iddetalle_venta, int iddetalle_ingreso, int idventa,
            int cantidad, decimal precio_venta, decimal descuento)
        {
            this.IDDetalle_Ingreso = iddetalle_ingreso;
            this.IDDetalle_Venta = iddetalle_venta;
            this.IDVenta = idventa;
            this.Cantidad = cantidad;
            this.Precio_Venta = precio_venta;
            this.Descuento = descuento;

        }


    }
}
