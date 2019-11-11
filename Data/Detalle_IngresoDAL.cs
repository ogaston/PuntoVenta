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
    public class Detalle_IngresoDAL
    {

        private ConectionDAL conexion;
        public Detalle_IngresoDAL()
        {
            conexion = new ConectionDAL();
        }

        public string Insertar(Detalle_Ingreso die)
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

                SqlCmd.Parameters.AddWithValue("@idingreso", die.Idingreso);
                SqlCmd.Parameters.AddWithValue("@idarticulo", die.Idarticulo);
                SqlCmd.Parameters.AddWithValue("@preciocompra", die.Precio_Compra);
                SqlCmd.Parameters.AddWithValue("@precioventa", die.Precio_Venta);
                SqlCmd.Parameters.AddWithValue("@stockinicial", die.Stock_Inicial);
                SqlCmd.Parameters.AddWithValue("@stockactual", die.Stock_Actual);
                SqlCmd.Parameters.AddWithValue("@fechaproduccion", die.Fecha_Produccion);
                SqlCmd.Parameters.AddWithValue("@fechavencimiento", die.Fecha_Vencimiento);

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
