using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ACCESOADATOS
{
    public class Dcompra
    {
        private int _Id;
        private int _idproveedor;
        private DateTime _fecha;
        private string _comprobante;
        private string _observaciones;
        private string _estado;
        private string _lote;
        private decimal _total;
        private string _Textobuscar;
        private int _iduser;


        public int Id { get => _Id; set => _Id = value; }
        public int Idproveedor { get => _idproveedor; set => _idproveedor = value; }
        public DateTime Fecha { get => _fecha; set => _fecha = value; }
        public string Comprobante { get => _comprobante; set => _comprobante = value; }
        public string Observaciones { get => _observaciones; set => _observaciones = value; }

        public string Lote { get => _lote; set => _lote = value; }
        public decimal Total { get => _total; set => _total = value; }
        public string Textobuscar { get => _Textobuscar; set => _Textobuscar = value; }
        public string Estado { get => _estado; set => _estado = value; }
        public int Iduser { get => _iduser; set => _iduser = value; }




        //Constructores
        public Dcompra()
        {

        }
        public Dcompra(int idcompra, int idproveedor, DateTime fecha, string comprobante, string observacones, string estado, string lote, decimal total, int iduser)
        {
            this.Id = idcompra;
            this.Idproveedor = idproveedor;
            this.Fecha = fecha;
            this.Comprobante = comprobante;
            this.Observaciones = observacones;
            this.Estado = estado;
            this.Lote = lote;
            this.Total = total;
            this.Iduser = iduser;

        }


        public string Insertar(Dcompra Compra, List<Ddetalle_compra> Detalles)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Conexion.Conec;
                SqlCon.Open();
                //Establecer la transacción
                SqlTransaction SqlTra = SqlCon.BeginTransaction();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.Transaction = SqlTra;
                SqlCmd.CommandText = "insertar_Compras";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Parámetros
                SqlParameter Parid = new SqlParameter();
                Parid.ParameterName = "@id";
                Parid.SqlDbType = SqlDbType.Int;
                Parid.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(Parid);

                SqlParameter ParIdproveedor = new SqlParameter();
                ParIdproveedor.ParameterName = "@proveedor";
                ParIdproveedor.SqlDbType = SqlDbType.Int;
                ParIdproveedor.Value = Compra.Idproveedor;
                SqlCmd.Parameters.Add(ParIdproveedor);


                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@fecha";
                ParFecha.SqlDbType = SqlDbType.Date;
                ParFecha.Value = Compra.Fecha;
                SqlCmd.Parameters.Add(ParFecha);

                SqlParameter Partotal = new SqlParameter();
                Partotal.ParameterName = "@total";
                Partotal.SqlDbType = SqlDbType.Decimal;
                Partotal.Precision = 10;
                Partotal.Scale = 2;
                Partotal.Value = Compra.Total;
                SqlCmd.Parameters.Add(Partotal);


                SqlParameter ParComprobante = new SqlParameter();
                ParComprobante.ParameterName = "comprobante";
                ParComprobante.SqlDbType = SqlDbType.VarChar;
                ParComprobante.Size = 40;
                ParComprobante.Value = Compra.Comprobante;
                SqlCmd.Parameters.Add(ParComprobante);

                SqlParameter ParObservaciones = new SqlParameter();
                ParObservaciones.ParameterName = "@observaciones";
                ParObservaciones.SqlDbType = SqlDbType.VarChar;
                ParObservaciones.Size = 50;
                ParObservaciones.Value = Compra.Observaciones;
                SqlCmd.Parameters.Add(ParObservaciones);

            
                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 10;
                ParEstado.Value = Compra.Estado;
                SqlCmd.Parameters.Add(ParEstado);

                SqlParameter ParLote = new SqlParameter();
                ParLote.ParameterName = "@lote";
                ParLote.SqlDbType = SqlDbType.VarChar;
                ParLote.Size = 40;
                ParLote.Value = Compra.Lote;
                SqlCmd.Parameters.Add(ParLote);

                SqlParameter ParIdproveedor1 = new SqlParameter();
                ParIdproveedor1.ParameterName = "@iduser";
                ParIdproveedor1.SqlDbType = SqlDbType.Int;
                ParIdproveedor1.Value = Compra.Iduser;
                SqlCmd.Parameters.Add(ParIdproveedor1);



                //Ejecutamos nuestro comando
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";
                if (rpta.Equals("OK"))
                {
                    //Obtenemos el codigo del ingreso que se genero por la base de datos

                    this.Id = Convert.ToInt32(SqlCmd.Parameters["@id"].Value);
                    foreach (Ddetalle_compra det in Detalles)
                    {
                        //Establecemos el codigo del ingreso que se autogenero
                        det.Idcompra = this.Id;
                        //Llamamos al metodo insertar de la clase DetalleIngreso
                        //y le pasamos la conexion y la transaccion que debe de usar
                        rpta = det.Insertar(det, ref SqlCon, ref SqlTra);
                        if (!rpta.Equals("OK"))
                        {
                            //Si ocurre un error al insertar un detalle de ingreso salimos del for
                            break;
                        }
                        else
                        {
                            //Actualizamos el Stock

                            rpta = AumentarStock(det.Idinsumo, det.Cantidad);
                            if (!rpta.Equals("OK"))
                            {
                                break;
                            }
                        }
                    }
                }
                if (rpta.Equals("OK"))
                {
                    //Se inserto todo los detalles y confirmamos la transaccion
                    SqlTra.Commit();
                }
                else
                {
                    //Algun detalle no se inserto y negamos la transaccion
                    SqlTra.Rollback();
                }

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



        public string Editar(Dcompra Compras)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Conexion.Conec;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "editar_compra";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdtrabajador = new SqlParameter();
                ParIdtrabajador.ParameterName = "@id";
                ParIdtrabajador.SqlDbType = SqlDbType.Int;
                ParIdtrabajador.Value = Compras.Id;
                SqlCmd.Parameters.Add(ParIdtrabajador);

                SqlParameter ParIdproveedor = new SqlParameter();
                ParIdproveedor.ParameterName = "@proveedor";
                ParIdproveedor.SqlDbType = SqlDbType.Int;
                ParIdproveedor.Value = Compras.Idproveedor;
                SqlCmd.Parameters.Add(ParIdproveedor);


                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@fecha";
                ParFecha.SqlDbType = SqlDbType.Date;
                ParFecha.Value = Compras.Fecha;
                SqlCmd.Parameters.Add(ParFecha);

                SqlParameter Partotal = new SqlParameter();
                Partotal.ParameterName = "@total";
                Partotal.SqlDbType = SqlDbType.Decimal;
                Partotal.Precision = 10;
                Partotal.Scale = 2;
                Partotal.Value = Compras.Total;
                SqlCmd.Parameters.Add(Partotal);


                SqlParameter ParComprobante = new SqlParameter();
                ParComprobante.ParameterName = "comprobante";
                ParComprobante.SqlDbType = SqlDbType.VarChar;
                ParComprobante.Size = 40;
                ParComprobante.Value = Compras.Comprobante;
                SqlCmd.Parameters.Add(ParComprobante);

                SqlParameter ParObservaciones = new SqlParameter();
                ParObservaciones.ParameterName = "@observaciones";
                ParObservaciones.SqlDbType = SqlDbType.VarChar;
                ParObservaciones.Size = 50;
                ParObservaciones.Value = Compras.Observaciones;
                SqlCmd.Parameters.Add(ParObservaciones);


                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 10;
                ParEstado.Value = Compras.Estado;
                SqlCmd.Parameters.Add(ParEstado);

                SqlParameter ParLote = new SqlParameter();
                ParLote.ParameterName = "@lote";
                ParLote.SqlDbType = SqlDbType.VarChar;
                ParLote.Size = 40;
                ParLote.Value = Compras.Lote;
                SqlCmd.Parameters.Add(ParLote);


                SqlParameter ParIdproveedor1 = new SqlParameter();
                ParIdproveedor1.ParameterName = "@iduser";
                ParIdproveedor1.SqlDbType = SqlDbType.Int;
                ParIdproveedor1.Value = Compras.Iduser;
                SqlCmd.Parameters.Add(ParIdproveedor1);




                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Actualizo el Registro";
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

        //    public string Anular(Datoscompra Compra)

        //{
        //    string rpta = "";
        //    SqlConnection SqlCon = new SqlConnection();
        //    try
        //    {
        //        //Código
        //        SqlCon.ConnectionString = Conexionsql.Conec;
        //        SqlCon.Open();
        //        //Establecer el Comando
        //        SqlCommand SqlCmd = new SqlCommand();
        //        SqlCmd.Connection = SqlCon;
        //        SqlCmd.CommandText = "anular_compra";
        //        SqlCmd.CommandType = CommandType.StoredProcedure;

        //        SqlParameter ParIdingreso = new SqlParameter();
        //        ParIdingreso.ParameterName = "@idingreso";
        //        ParIdingreso.SqlDbType = SqlDbType.Int;
        //        ParIdingreso.Value = Compra.ID_compra1;
        //        SqlCmd.Parameters.Add(ParIdingreso);
        //        //Ejecutamos nuestro comando

        //        rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se anulo el Ingreso";

        //    }
        //    catch (Exception ex)
        //    {
        //        rpta = ex.Message;
        //    }
        //    finally
        //    {
        //        if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
        //    }
        //    return rpta;
        //}


        //Método Mostrar
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("Compras");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Conec;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Mostrar_compra";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }


        //Método BuscarFechas
        public DataTable BuscarFechas(String TextoBuscar, String TextoBuscar2)
        {
            DataTable DtResultado = new DataTable("Compras");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Conec;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Buscar_compra";
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
            return DtResultado;

        }


        public DataTable BuscarCompraProveedor(Dcompra compra)
        {
            DataTable DtResponse = new DataTable("Compras");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Conec;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "buscar_CompraProveedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = compra.Textobuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResponse);

            }
            catch (Exception ex)
            {

            }

            return DtResponse;
        }


        public DataTable BuscarCompraComprobante(Dcompra compra)
        {
            DataTable DtResponse = new DataTable("Compras");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Conec;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "buscar_CompraComprobante";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = compra.Textobuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResponse);

            }
            catch (Exception ex)
            {

            }

            return DtResponse;
        }


        public DataTable BuscarCompraLote(Dcompra compra)
        {
            DataTable DtResponse = new DataTable("Compras");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Conec;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "buscar_CompraLote";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = compra.Textobuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResponse);

            }
            catch (Exception ex)
            {

            }

            return DtResponse;
        }

        public DataTable BuscarCompraResponsable(Dcompra compra)
        {
            DataTable DtResponse = new DataTable("Compras");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Conec;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "buscar_CompraResponsable";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = compra.Textobuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResponse);

            }
            catch (Exception ex)
            {

            }

            return DtResponse;
        }








        public string AumentarStock(int iddetalle_compra, int cantidad)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Conexion.Conec;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "aumentar_stock";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIddetalle_ingreso = new SqlParameter();
                ParIddetalle_ingreso.ParameterName = "@idinsumo";
                ParIddetalle_ingreso.SqlDbType = SqlDbType.Int;
                ParIddetalle_ingreso.Value = iddetalle_compra;
                SqlCmd.Parameters.Add(ParIddetalle_ingreso);

                SqlParameter ParCantidad = new SqlParameter();
                ParCantidad.ParameterName = "@cantidad";
                ParCantidad.SqlDbType = SqlDbType.Int;
                ParCantidad.Value = cantidad;
                SqlCmd.Parameters.Add(ParCantidad);
                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No Se actualizó el Stock";

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

        //Método BuscarFechas
        public DataTable MostrarDetalle(int TextoBuscar)
        {
            DataTable DtResultado = new DataTable("detallecompra");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Conec;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Mostrar_detalle";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.Int;
                ParTextoBuscar.Value = TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }
    }
}
