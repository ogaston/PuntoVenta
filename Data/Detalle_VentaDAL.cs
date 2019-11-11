using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using Entity;

namespace Data
{
    public class Detalle_VentaDAL
    {
        private ConectionDAL conexion;
        public string Insertar(Detalle_Venta dve)
        {
            SqlConnection SqlCon = conexion.ConecctionString();
            string rpta = "";

            try
            {
                if (SqlCon.State == ConnectionState.Closed)
                {
                    SqlCon.Open();
                }
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "proc_Detalle_IngresoInsert";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //En esta parte se envian los parametros al procedimiento almacenado

                SqlCmd.Parameters.AddWithValue("@iddetalle_ingreso", dve.IDDetalle_Ingreso);
                SqlCmd.Parameters.AddWithValue("@idventa", dve.IDVenta);
                SqlCmd.Parameters.AddWithValue("@cantidad", dve.Cantidad);
                SqlCmd.Parameters.AddWithValue("@precio_venta", dve.Precio_Venta);
                SqlCmd.Parameters.AddWithValue("@descuento", dve.Descuento);

                //ejecutamos la consulta, en caso de que retorne 1 será OK

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se ha posido insertar";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }


            return rpta;
        }
    }
}
