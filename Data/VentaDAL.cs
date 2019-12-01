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
    public class VentaDAL
    {
        private ConectionDAL conexion;
        public VentaDAL()
        {
            conexion = new ConectionDAL();
        }


        public string Insertar(Venta ve, List<Detalle_Venta> detalle)
        {
            SqlConnection SqlCon = conexion.ConecctionString();
            string rpta = "";

            try
            {
                if(SqlCon.State == ConnectionState.Closed)
                {
                    SqlCon.Open();
                }

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "proc_VentaInsert";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //En esta parte se envian los parametros al procedimiento almacenado

                SqlCmd.Parameters.AddWithValue("@IDVenta", ve.IDventa);
                SqlCmd.Parameters.AddWithValue("@IDTrabajador", ve.IDTrabajador);
                SqlCmd.Parameters.AddWithValue("@IDCliente", ve.IDCliente);
                SqlCmd.Parameters.AddWithValue("@Fecha", ve.Fecha);
                SqlCmd.Parameters.AddWithValue("@TipoPago", ve.Tipo_Pago);
                SqlCmd.Parameters.AddWithValue("@NoComprobante", ve.No_Comprobante);
                SqlCmd.Parameters.AddWithValue("@NoCreFiscal", ve.No_Crefiscal);
                SqlCmd.Parameters.AddWithValue("Igv", ve.IGV);
                SqlCmd.Parameters.AddWithValue("@NoAutTarjeta", ve.No_Auttarjeta);
                SqlCmd.Parameters.AddWithValue("Estado", ve.Estado);

                //ejecutamos la consulta, en caso de que retorne 1 será OK

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se ha posido insertar";
                //si se guarda correctamente, ejecutamos la consulta para guardar los detalles
                if (rpta.Equals("OK"))
                {
                    foreach (Detalle_Venta dt in detalle)
                    {
                        Detalle_VentaDAL dal = new Detalle_VentaDAL();
                        dt.IDVenta = ve.IDventa;
                        rpta = dal.Insertar(dt);

                        if (!rpta.Equals("OK"))
                        {
                            break;
                        }
                        else
                        {
                            //Actualizamos el Stock
                            rpta = DisminuirStock(dt.IDDetalle_Ingreso,dt.Cantidad);
                            if (!rpta.Equals("OK"))
                            {
                                break;
                            }
                        }


                    }

                }
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

        public string Anular(Venta Venta)
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
                SqlCmd.CommandText = "proc_VentaAnular";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdingreso = new SqlParameter();
                ParIdingreso.ParameterName = "@idventa";
                ParIdingreso.SqlDbType = SqlDbType.Int;
                ParIdingreso.Value = Venta.IDventa;
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
        public string DisminuirStock(int iddetalle_ingreso, int cantidad)
        {
            string rpta = "";
            SqlConnection SqlCon = conexion.ConecctionString();
            try
            {
                //Código
                if (SqlCon.State == ConnectionState.Closed)
                {
                    SqlCon.Open();
                }
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "proc_VentaDisminuirstock";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIddetalle_ingreso = new SqlParameter();
                ParIddetalle_ingreso.ParameterName = "@iddetalle_ingreso";
                ParIddetalle_ingreso.SqlDbType = SqlDbType.Int;
                ParIddetalle_ingreso.Value = iddetalle_ingreso;
                SqlCmd.Parameters.Add(ParIddetalle_ingreso);

                SqlParameter ParCantidad = new SqlParameter();
                ParCantidad.ParameterName = "@cantidad";
                ParCantidad.SqlDbType = SqlDbType.Int;
                ParCantidad.Value = cantidad;
                SqlCmd.Parameters.Add(ParCantidad);


                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Actualizo el Stock";


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

            DataTable DtResultado = new DataTable("venta");
            try
            {
                if (SqlCon.State == ConnectionState.Closed) SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "proc_VentaLoadAll";
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
            DataTable DtResultado = new DataTable("detalle_venta");
            SqlConnection SqlCon = conexion.ConecctionString();
            try
            {

                if (SqlCon.State == ConnectionState.Closed) SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "proc_VentaMostrarDetalle";
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


        public DataTable Generaridventa()
        {
            SqlConnection SqlCon = conexion.ConecctionString();

            DataTable DtResultado = new DataTable("ingreso");
            try
            {
                if (SqlCon.State == ConnectionState.Closed) SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "proc_VentaGenerarId";
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

        public DataTable VentaBuscarFecha(string TextoBuscar, string TextoBuscar2)
        {
            DataTable DtResultado = new DataTable("venta");
            SqlConnection SqlCon = conexion.ConecctionString();
            try
            {
                if (SqlCon.State == ConnectionState.Closed) SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "proc_VentaBuscarFecha";
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

        public DataTable Buscar_Articulo_Venta_Nombre(string TextoBuscar)
        {
            SqlConnection SqlCon = conexion.ConecctionString();
            DataTable DtResultado = new DataTable("Articulos");

            try
            {
                if (SqlCon.State == ConnectionState.Closed) SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "proc_VentaBuscarArticuloNombre";
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

        public DataTable Buscar_Articulo_Venta_Codigo(string TextoBuscar)
        {
            SqlConnection SqlCon = conexion.ConecctionString();
            DataTable DtResultado = new DataTable("Articulos");

            try
            {
                if (SqlCon.State == ConnectionState.Closed) SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "proc_VentaBuscarArticuloCodigo";
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

        public DataTable Buscar_Articulo_Venta_Id(string TextoBuscar)
        {
            SqlConnection SqlCon = conexion.ConecctionString();
            DataTable DtResultado = new DataTable("Articulos");

            try
            {
                if (SqlCon.State == ConnectionState.Closed) SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "proc_BuscarArticuloVentaId";
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


        #region Clientes

        //****************************************************PROVEEDORES************************************************************//
        public DataTable MostrarCliente()
        {
            SqlConnection SqlCon = conexion.ConecctionString();

            DataTable DtResultado = new DataTable("venta");
            try
            {
                if (SqlCon.State == ConnectionState.Closed) SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "proc_ClienteLoadAll";
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


        public DataTable Buscar_Cliente_Venta_Nombre(string TextoBuscar)
        {
            SqlConnection SqlCon = conexion.ConecctionString();
            DataTable DtResultado = new DataTable("Proveedor");

            try
            {
                if (SqlCon.State == ConnectionState.Closed) SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "proc_VentaBuscarClienteNombre";
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


        public DataTable Buscar_Cliente_Venta_Documento(string TextoBuscar)
        {
            SqlConnection SqlCon = conexion.ConecctionString();
            DataTable DtResultado = new DataTable("Cliente");

            try
            {
                if (SqlCon.State == ConnectionState.Closed) SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "proc_VentaBuscarClienteDocumento";
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
        #endregion


    }
}
