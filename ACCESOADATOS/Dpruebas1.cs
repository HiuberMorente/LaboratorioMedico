using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ACCESOADATOS
{
   public class Dpruebas1
    {
        private int _Id;
        private int _idtipo;
        private string _nombre;
        private string _descripcion;
        private decimal _precio;
        private DateTime _fechasolucidad;
        private DateTime _fecharealizo;
        private DateTime _fechavigencia;
        private string _observaciones;
        private int _idcliente;
        private string _Textobuscar;
        private int _iduser;

        public int Id { get => _Id; set => _Id = value; }
        public int Idtipo { get => _idtipo; set => _idtipo = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public decimal Precio { get => _precio; set => _precio = value; }
        public DateTime Fechasolucidad { get => _fechasolucidad; set => _fechasolucidad = value; }
        public DateTime Fecharealizo { get => _fecharealizo; set => _fecharealizo = value; }
        public DateTime Fechavigencia { get => _fechavigencia; set => _fechavigencia = value; }
        public string Observaciones { get => _observaciones; set => _observaciones = value; }
        public int Idcliente { get => _idcliente; set => _idcliente = value; }
        public string Textobuscar { get => _Textobuscar; set => _Textobuscar = value; }
        public int Iduser { get => _iduser; set => _iduser = value; }



        //Constructores
        public Dpruebas1()
        {

        }
        public Dpruebas1(int id, int idtipo,string nombre, string descripcion, decimal precio, DateTime fechasolicitud, DateTime fecharealizo, DateTime fechavigencia, string observaciones, int idcliente, int iduser)
        {
            this.Id = id;
            this.Idtipo = idtipo;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Precio = precio;
            this.Fechasolucidad = fechasolicitud;
            this.Fecharealizo = fecharealizo;
            this.Fechavigencia = fechavigencia;
            this.Observaciones= observaciones;
            this.Idcliente = idcliente;
            this.Iduser = iduser;

        }


        public string Insertar(Dpruebas1 Pruebas, List<Ddetalle_pruebas> Detalles)
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
                SqlCmd.CommandText = "insertar_prueba";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Parámetros
                SqlParameter Parid = new SqlParameter();
                Parid.ParameterName = "@id";
                Parid.SqlDbType = SqlDbType.Int;
                Parid.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(Parid);

                SqlParameter ParIdproveedor = new SqlParameter();
                ParIdproveedor.ParameterName = "@idtipo";
                ParIdproveedor.SqlDbType = SqlDbType.Int;
                ParIdproveedor.Value = Pruebas.Idtipo;
                SqlCmd.Parameters.Add(ParIdproveedor);

                SqlParameter ParComprobante = new SqlParameter();
                ParComprobante.ParameterName = "nombre";
                ParComprobante.SqlDbType = SqlDbType.VarChar;
                ParComprobante.Size = 40;
                ParComprobante.Value = Pruebas.Nombre;
                SqlCmd.Parameters.Add(ParComprobante);

                SqlParameter ParComprobante1 = new SqlParameter();
                ParComprobante1.ParameterName = "descripcion";
                ParComprobante1.SqlDbType = SqlDbType.VarChar;
                ParComprobante1.Size = 40;
                ParComprobante1.Value = Pruebas.Descripcion;
                SqlCmd.Parameters.Add(ParComprobante1);

                SqlParameter Partotal = new SqlParameter();
                Partotal.ParameterName = "@precio";
                Partotal.SqlDbType = SqlDbType.Decimal;
                Partotal.Precision = 10;
                Partotal.Scale = 2;
                Partotal.Value = Pruebas.Precio;
                SqlCmd.Parameters.Add(Partotal);


                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@fechasolicitud";
                ParFecha.SqlDbType = SqlDbType.Date;
                ParFecha.Value = Pruebas.Fechasolucidad;
                SqlCmd.Parameters.Add(ParFecha);

                SqlParameter ParFecha1 = new SqlParameter();
                ParFecha1.ParameterName = "@fecharealizo";
                ParFecha1.SqlDbType = SqlDbType.Date;
                ParFecha1.Value = Pruebas.Fecharealizo;
                SqlCmd.Parameters.Add(ParFecha1);

                SqlParameter ParFecha2 = new SqlParameter();
                ParFecha2.ParameterName = "@fechavigencia";
                ParFecha2.SqlDbType = SqlDbType.Date;
                ParFecha2.Value = Pruebas.Fechavigencia;
                SqlCmd.Parameters.Add(ParFecha2);


                SqlParameter ParComprobante2 = new SqlParameter();
                ParComprobante2.ParameterName = "@observaciones";
                ParComprobante2.SqlDbType = SqlDbType.VarChar;
                ParComprobante2.Size = 250;
                ParComprobante2.Value = Pruebas.Observaciones;
                SqlCmd.Parameters.Add(ParComprobante2);

       

                SqlParameter ParIdproveedor1 = new SqlParameter();
                ParIdproveedor1.ParameterName = "@idcliente";
                ParIdproveedor1.SqlDbType = SqlDbType.Int;
                ParIdproveedor1.Value = Pruebas.Idcliente;
                SqlCmd.Parameters.Add(ParIdproveedor1);


                SqlParameter ParIdproveedor2 = new SqlParameter();
                ParIdproveedor2.ParameterName = "@iduser";
                ParIdproveedor2.SqlDbType = SqlDbType.Int;
                ParIdproveedor2.Value = Pruebas.Iduser;
                SqlCmd.Parameters.Add(ParIdproveedor2);





                //Ejecutamos nuestro comando
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";
                if (rpta.Equals("OK"))
                {
                    //Obtenemos el codigo del ingreso que se genero por la base de datos

                    this.Id = Convert.ToInt32(SqlCmd.Parameters["@id"].Value);
                    foreach (Ddetalle_pruebas det in Detalles)
                    {
                        //Establecemos el codigo del ingreso que se autogenero
                        det.Idprueba = this.Id;
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

                                rpta = DisminuirStock(det.Iddcompra, det.Cantidad);
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


        public string DisminuirStock(int iddetalle_compra, int cantidad)
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
                SqlCmd.CommandText = "disminuir_stock";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIddetalle_ingreso = new SqlParameter();
                ParIddetalle_ingreso.ParameterName = "@detallecompra";
                ParIddetalle_ingreso.SqlDbType = SqlDbType.Int;
                ParIddetalle_ingreso.Value = iddetalle_compra;
                SqlCmd.Parameters.Add(ParIddetalle_ingreso);

                SqlParameter ParCantidad = new SqlParameter();
                ParCantidad.ParameterName = "@cantidad";
                ParCantidad.SqlDbType = SqlDbType.Int;
                ParCantidad.Value = cantidad;
                SqlCmd.Parameters.Add(ParCantidad);
                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "Se actualizó el Stock";

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
        public string Editar(Dpruebas1 Pruebas)
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
                SqlCmd.CommandText = "editar_prueba";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdtrabajador = new SqlParameter();
                ParIdtrabajador.ParameterName = "@id";
                ParIdtrabajador.SqlDbType = SqlDbType.Int;
                ParIdtrabajador.Value = Pruebas.Id;
                SqlCmd.Parameters.Add(ParIdtrabajador);
                SqlParameter ParIdproveedor = new SqlParameter();
                ParIdproveedor.ParameterName = "@idtipo";
                ParIdproveedor.SqlDbType = SqlDbType.Int;
                ParIdproveedor.Value = Pruebas.Idtipo;
                SqlCmd.Parameters.Add(ParIdproveedor);

                SqlParameter ParComprobante = new SqlParameter();
                ParComprobante.ParameterName = "nombre";
                ParComprobante.SqlDbType = SqlDbType.VarChar;
                ParComprobante.Size = 40;
                ParComprobante.Value = Pruebas.Nombre;
                SqlCmd.Parameters.Add(ParComprobante);

                SqlParameter ParComprobante1 = new SqlParameter();
                ParComprobante1.ParameterName = "descripcion";
                ParComprobante1.SqlDbType = SqlDbType.VarChar;
                ParComprobante1.Size = 40;
                ParComprobante1.Value = Pruebas.Descripcion;
                SqlCmd.Parameters.Add(ParComprobante1);

                SqlParameter Partotal = new SqlParameter();
                Partotal.ParameterName = "@precio";
                Partotal.SqlDbType = SqlDbType.Decimal;
                Partotal.Precision = 10;
                Partotal.Scale = 2;
                Partotal.Value = Pruebas.Precio;
                SqlCmd.Parameters.Add(Partotal);


                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@fechasolicitud";
                ParFecha.SqlDbType = SqlDbType.Date;
                ParFecha.Value = Pruebas.Fechasolucidad;
                SqlCmd.Parameters.Add(ParFecha);

                SqlParameter ParFecha1 = new SqlParameter();
                ParFecha1.ParameterName = "@fecharealizo";
                ParFecha1.SqlDbType = SqlDbType.Date;
                ParFecha1.Value = Pruebas.Fecharealizo;
                SqlCmd.Parameters.Add(ParFecha1);

                SqlParameter ParFecha2 = new SqlParameter();
                ParFecha2.ParameterName = "@fechavigencia";
                ParFecha2.SqlDbType = SqlDbType.Date;
                ParFecha2.Value = Pruebas.Fechavigencia;
                SqlCmd.Parameters.Add(ParFecha2);


                SqlParameter ParComprobante2 = new SqlParameter();
                ParComprobante2.ParameterName = "@observaciones";
                ParComprobante2.SqlDbType = SqlDbType.VarChar;
                ParComprobante2.Size = 250;
                ParComprobante2.Value = Pruebas.Observaciones;
                SqlCmd.Parameters.Add(ParComprobante2);



                SqlParameter ParIdproveedor1 = new SqlParameter();
                ParIdproveedor1.ParameterName = "@idcliente";
                ParIdproveedor1.SqlDbType = SqlDbType.Int;
                ParIdproveedor1.Value = Pruebas.Idcliente;
                SqlCmd.Parameters.Add(ParIdproveedor1);


                SqlParameter ParIdproveedor2 = new SqlParameter();
                ParIdproveedor2.ParameterName = "@iduser";
                ParIdproveedor2.SqlDbType = SqlDbType.Int;
                ParIdproveedor2.Value = Pruebas.Iduser;
                SqlCmd.Parameters.Add(ParIdproveedor2);




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
            DataTable DtResultado = new DataTable("Pruebas");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Conec;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "mostrar_prueba";
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
            DataTable DtResultado = new DataTable("Pruebas");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Conec;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Buscar_pruebafecha";
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


        public DataTable BuscarFechasRealizada(String TextoBuscar, String TextoBuscar2)
        {
            DataTable DtResultado = new DataTable("Pruebas");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Conec;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Buscar_pruebafechaRealizada";
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


        public DataTable BuscarFechasVencimiento(String TextoBuscar, String TextoBuscar2)
        {
            DataTable DtResultado = new DataTable("Pruebas");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Conec;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Buscar_pruebafechaVencimiento";
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


        public DataTable BuscarPrueba(Dpruebas1 prueba)
        {
            DataTable DtResponse = new DataTable("Usuarios");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Conec;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "buscar_prueba";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = prueba.Textobuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResponse);

            }
            catch (Exception ex)
            {

            }

            return DtResponse;
        }


        public DataTable BuscarPruebaTipo(Dpruebas1 prueba)
        {
            DataTable DtResponse = new DataTable("Usuarios");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Conec;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "buscar_prueba_Tipo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = prueba.Textobuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResponse);

            }
            catch (Exception ex)
            {

            }

            return DtResponse;
        }


        public DataTable BuscarPruebaCliente(Dpruebas1 prueba)
        {
            DataTable DtResponse = new DataTable("Usuarios");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Conec;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "buscar_prueba_Cliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = prueba.Textobuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResponse);

            }
            catch (Exception ex)
            {

            }

            return DtResponse;
        }



        //public string AumentarStock(int iddetalle_compra, int cantidad)
        //{
        //    string rpta = "";
        //    SqlConnection SqlCon = new SqlConnection();
        //    try
        //    {
        //        //Código
        //        SqlCon.ConnectionString = Conexion.Conec;
        //        SqlCon.Open();
        //        //Establecer el Comando
        //        SqlCommand SqlCmd = new SqlCommand();
        //        SqlCmd.Connection = SqlCon;
        //        SqlCmd.CommandText = "aumentar_stock";
        //        SqlCmd.CommandType = CommandType.StoredProcedure;

        //        SqlParameter ParIddetalle_ingreso = new SqlParameter();
        //        ParIddetalle_ingreso.ParameterName = "@iddetalle_compra";
        //        ParIddetalle_ingreso.SqlDbType = SqlDbType.Int;
        //        ParIddetalle_ingreso.Value = iddetalle_compra;
        //        SqlCmd.Parameters.Add(ParIddetalle_ingreso);

        //        SqlParameter ParCantidad = new SqlParameter();
        //        ParCantidad.ParameterName = "@cantidad";
        //        ParCantidad.SqlDbType = SqlDbType.Int;
        //        ParCantidad.Value = cantidad;
        //        SqlCmd.Parameters.Add(ParCantidad);
        //        //Ejecutamos nuestro comando

        //        rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No Se actualizó el Stock";

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

        //Método BuscarFechas
        public DataTable MostrarDetalle(int TextoBuscar)
        {
            DataTable DtResultado = new DataTable("mostrar_detallepruebas");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Conec;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "mostrar_detallepruebas";
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


        public DataTable BuscarInsumoPrueba(Dpruebas1 compra)
        {
            DataTable DtResponse = new DataTable("Compras");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Conec;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "buscar_insumo_prueba";
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

    }
}
