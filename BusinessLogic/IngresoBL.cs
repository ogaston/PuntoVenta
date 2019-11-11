using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Data;
using Entity;
namespace BusinessLogic
{
    public class IngresoBL
    {
        
        public static string Insertar(int idingreso, int idtrabajador, int idproveedor,DateTime fecha,string tipo_pago,
            string num_comprobante, decimal igv, int estado, DataTable dtDetalles)
        {
            IngresoDAL proc = new IngresoDAL();
            Ingreso entidad = new Ingreso();
            entidad.IDIngreso = idingreso;
            entidad.IDTrabajador = idtrabajador;
            entidad.IDproveedor = idproveedor;
            entidad.Fecha = fecha;
            entidad.Tipo_Pago = tipo_pago;
            entidad.Num_Comprobante = num_comprobante;
            entidad.IGV = igv;
            entidad.Estado = estado;


            List<Detalle_Ingreso> detalles = new List<Detalle_Ingreso>();
            foreach (DataRow row in dtDetalles.Rows)
            {
                Detalle_Ingreso detalle = new Detalle_Ingreso();
                detalle.Idarticulo = Convert.ToInt32(row["idarticulo"].ToString());
                detalle.Precio_Compra = Convert.ToDecimal(row["precio_compra"].ToString());
                detalle.Precio_Venta = Convert.ToDecimal(row["precio_venta"].ToString());
                detalle.Stock_Inicial = Convert.ToInt32(row["stock_inicial"].ToString());
                detalle.Stock_Actual = Convert.ToInt32(row["stock_inicial"].ToString());
                detalle.Fecha_Produccion = Convert.ToDateTime(row["fecha_produccion"].ToString());
                detalle.Fecha_Vencimiento = Convert.ToDateTime(row["fecha_vencimiento"].ToString());
                detalles.Add(detalle);
            }


            return proc.Insertar(entidad, detalles);
        }

        public static DataTable Mostrar()
        {
            return new IngresoDAL().Mostrar();
        }
        public static DataTable GenerarIdingreso()
        {
            return new IngresoDAL().GenerarIdIngreso();
        }
        public static DataTable MostrarDetalle(string textobuscar)
        {
            IngresoDAL Obj = new IngresoDAL();
            return Obj.MostrarDetalle(textobuscar);
        }
        #region Articulos
        public static DataTable Buscar_Articulo_Ingreso_Nombre(string textobuscar)
        {
            IngresoDAL Obj = new IngresoDAL();
            return Obj.Buscar_Articulo_Ingreso_Nombre(textobuscar);
        }

        #endregion

        #region Proveedor

        //Método Mostrar que llama al método Mostrar de la clase DCategoría
        //de la CapaDatos
        public static DataTable MostrarProveedor()
        {
            return new IngresoDAL().MostrarProveedor();
        }

        //Método BuscarRazon_Social que llama al método BuscarNombre
        //de la clase DProveedor de la CapaDatos

        public static DataTable Buscar_Proveedor_Ingreso_Nombre(string textobuscar)
        {
            IngresoDAL Obj = new IngresoDAL();
            return Obj.Buscar_Proveedor_Ingreso_Nombre(textobuscar);
        }

        //Método BuscarRazon_Social que llama al método BuscarNombre
        //de la clase DProveedor de la CapaDatos

        public static DataTable Buscar_Proveedor_Ingreso_RNC(string textobuscar)
        {
            IngresoDAL Obj = new IngresoDAL();
            return Obj.Buscar_Proveedor_Ingreso_RNC(textobuscar);
        }
        #endregion
    }
}
