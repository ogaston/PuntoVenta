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
    public class IngresoDAL
    {
        private ConectionDAL conexion;
        public IngresoDAL()
        {
            conexion = new ConectionDAL();
        }
        
       
        public string Insertar(Ingreso ie, List<Detalle_Ingreso> detalle)
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
                SqlCmd.CommandText = "proc_IngresoInsert";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //En esta parte se envian los parametros al procedimiento almacenado

                SqlCmd.Parameters.AddWithValue("@IDIngreso", ie.IDIngreso);
                SqlCmd.Parameters.AddWithValue("@IDTrabajador", ie.IDTrabajador);
                SqlCmd.Parameters.AddWithValue("@IDProveedor", ie.IDproveedor);
                SqlCmd.Parameters.AddWithValue("@Fecha", ie.Fecha);
                SqlCmd.Parameters.AddWithValue("@tipopago", ie.Tipo_Pago);
                SqlCmd.Parameters.AddWithValue("@numcomprobante", ie.Num_Comprobante);
                SqlCmd.Parameters.AddWithValue("IGV", ie.IGV);
                SqlCmd.Parameters.AddWithValue("estado", ie.Estado);

                //ejecutamos la consulta, en caso de que retorne 1 será OK

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se ha posido insertar";
                //si se guarda correctamente, ejecutamos la consulta para guardar los detalles
                if(rpta.Equals("OK"))
                {
                    foreach (Detalle_Ingreso dt in detalle)
                    {
                        Detalle_IngresoDAL dal = new Detalle_IngresoDAL();
                        dt.Idingreso = ie.IDIngreso;
                        rpta = dal.Insertar(dt);
                    }

                }
            }
            catch(Exception ex)
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


        public string Anular(Ingreso Ingreso)
        {
            string rpta = "";
            SqlConnection SqlCon = conexion.ConecctionString();
            try
            {
                if (SqlCon.State == ConnectionState.Closed)
                {
                    SqlCon.Open();
                }
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "proc_IngresoAnular";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdingreso = new SqlParameter();
                ParIdingreso.ParameterName = "@idingreso";
                ParIdingreso.SqlDbType = SqlDbType.Int;
                ParIdingreso.Value = Ingreso.IDIngreso;
                SqlCmd.Parameters.Add(ParIdingreso);


                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Anuló el Registro";


            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;


        }
        public DataTable Mostrar()
        {
            SqlConnection SqlCon = conexion.ConecctionString();

            DataTable DtResultado = new DataTable("ingreso");
            try
            {
                if (SqlCon.State == ConnectionState.Closed) SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "proc_IngresoLoadAll";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return DtResultado;


        }


        public DataTable MostrarDetalle(string TextoBuscar)
        {
            DataTable DtResultado = new DataTable("detalle_ingreso");
            SqlConnection SqlCon = conexion.ConecctionString();
            try
            {
               
                if (SqlCon.State == ConnectionState.Closed) SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "proc_IngresoMostrarDetalle";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);


                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return DtResultado;


        }


        public DataTable GenerarIdIngreso()
        {
            DataTable DtResultado = new DataTable("ingreso");
            SqlConnection SqlCon = conexion.ConecctionString();
            try
            {

                if (SqlCon.State == ConnectionState.Closed) SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "proc_IngresoGenerarId";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return DtResultado;


        }

        public DataTable IngresoBuscarFecha(string TextoBuscar, string TextoBuscar2)
        {
            DataTable DtResultado = new DataTable("ingreso");
            SqlConnection SqlCon = conexion.ConecctionString();
            try
            {
                if (SqlCon.State == ConnectionState.Closed) SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "proc_IngresoBuscarFecha";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlParameter ParTextoBuscar2 = new SqlParameter();
                ParTextoBuscar2.ParameterName = "@textobuscar2";
                ParTextoBuscar2.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar2.Size = 50;
                ParTextoBuscar2.Value = TextoBuscar2;
                SqlCmd.Parameters.Add(ParTextoBuscar2);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return DtResultado;


        }

        #region Articulos

        //****************************************************Articulos************************************************************//

        public DataTable Buscar_Articulo_Ingreso_Nombre(string TextoBuscar)
        {
            SqlConnection SqlCon = conexion.ConecctionString();
            DataTable DtResultado = new DataTable("Articulos");

            try
            {
                if (SqlCon.State == ConnectionState.Closed) SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "proc_IngresoBuscarArticuloNombre";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);


                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return DtResultado;


        }
        #endregion


        #region Proveedores

        //****************************************************PROVEEDORES************************************************************//
        public DataTable MostrarProveedor()
        {
            SqlConnection SqlCon = conexion.ConecctionString();

            DataTable DtResultado = new DataTable("ingreso");
            try
            {
                if (SqlCon.State == ConnectionState.Closed) SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "proc_ProveedorLoadAll";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return DtResultado;


        }


        public DataTable Buscar_Proveedor_Ingreso_Nombre(string TextoBuscar)
        {
            SqlConnection SqlCon = conexion.ConecctionString();
            DataTable DtResultado = new DataTable("Proveedor");

            try
            {
                if (SqlCon.State == ConnectionState.Closed) SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "proc_IngresoBuscarProveedorRazon";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlCmd.Parameters.AddWithValue("@textobuscar", TextoBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return DtResultado;


        }


        public DataTable Buscar_Proveedor_Ingreso_RNC(string TextoBuscar)
        {
            SqlConnection SqlCon = conexion.ConecctionString();
            DataTable DtResultado = new DataTable("Proveedor");

            try
            {
                if (SqlCon.State == ConnectionState.Closed) SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "proc_IngresoBuscarProveedorRnc";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlCmd.Parameters.AddWithValue("@textobuscar",TextoBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return DtResultado;


        }
        #endregion


    }
}
