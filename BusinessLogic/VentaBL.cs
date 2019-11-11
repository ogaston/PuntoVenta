using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entity;
using Data;
namespace BusinessLogic
{
    public class VentaBL
    {
        public static string Insertar(int idventa, int idcliente, int idtrabajador, DateTime fecha, string tipo_pago,
            string no_comprobante, string no_crefical, string no_auttarjeta, decimal igv, int estado, DataTable dtDetalles)
        {
            VentaDAL proc = new VentaDAL();
            Venta entidad = new Venta();
            entidad.IDventa = idventa; ;
            entidad.IDTrabajador = idtrabajador;
            entidad.IDCliente = idcliente;
            entidad.Fecha = fecha;
            entidad.Tipo_Pago = tipo_pago;
            entidad.No_Comprobante = no_comprobante;
            entidad.No_Crefiscal = no_crefical;
            entidad.No_Auttarjeta = no_auttarjeta;
            entidad.IGV = igv;
            entidad.Estado = estado;


            List<Detalle_Venta> detalles = new List<Detalle_Venta>();
            foreach (DataRow row in dtDetalles.Rows)
            {
                Detalle_Venta detalle = new Detalle_Venta();
                detalle.IDDetalle_Ingreso = Convert.ToInt32(row["iddetalle_ingreso"].ToString());
                detalle.IDVenta = Convert.ToInt32(row["precio_compra"].ToString());
                detalle.Cantidad = Convert.ToInt32(row["precio_venta"].ToString());
                detalle.Precio_Venta = Convert.ToDecimal(row["stock_inicial"].ToString());
                detalle.Descuento = Convert.ToInt32(row["stock_inicial"].ToString());
                detalles.Add(detalle);
            }


            return proc.Insertar(entidad, detalles);
        }

        public static DataTable Mostrar()
        {
            return new VentaDAL().Mostrar();
        }

        public static DataTable Generaridventa()
        {
            return new VentaDAL().Generaridventa();
        }


        #region Articulos
        public static DataTable BuscarArticuloVentaNombre(string textobuscar)
        {
            VentaDAL Obj = new VentaDAL();
            return Obj.Buscar_Articulo_Venta_Nombre(textobuscar);
        }
        public static DataTable BuscarArticuloVentaCodigo(string textobuscar)
        {
            VentaDAL Obj = new VentaDAL();
            return Obj.Buscar_Articulo_Venta_Codigo(textobuscar);
        }
        public static DataTable BuscarArticuloVentaId(string textobuscar)
        {
            VentaDAL Obj = new VentaDAL();
            return Obj.Buscar_Articulo_Venta_Id(textobuscar);
        }

        #endregion

        #region Cliente

        //Método Mostrar que llama al método Mostrar de la clase DCategoría
        //de la CapaDatos
        public static DataTable MostrarProveedor()
        {
            return new VentaDAL().MostrarCliente();
        }

        //Método BuscarRazon_Social que llama al método BuscarNombre
        //de la clase DProveedor de la CapaDatos

        public static DataTable Buscar_Cliente_Venta_Nombre(string textobuscar)
        {
            VentaDAL Obj = new VentaDAL();
            return Obj.Buscar_Cliente_Venta_Nombre(textobuscar);
        }

        public static DataTable Buscar_Cliente_Venta_Documento(string textobuscar)
        {
            VentaDAL Obj = new VentaDAL();
            return Obj.Buscar_Cliente_Venta_Documento(textobuscar);
        }
        #endregion
    }
}
