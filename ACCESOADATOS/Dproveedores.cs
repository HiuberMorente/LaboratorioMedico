using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ACCESOADATOS
{
    public class Dproveedores
    {
        private int _id;
        private string _nombre;
        private string _contacto;
        private int _telefonoempresa;
        private int _telefonocontacto;
        private string _correo;
        private string _direccion;
        private string _descripcion;
        private string _textobuscar;

        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Contacto { get => _contacto; set => _contacto = value; }
        public int Telefonoempresa { get => _telefonoempresa; set => _telefonoempresa = value; }
        public int Telefonocontacto { get => Telefonocontacto1; set => Telefonocontacto1 = value; }
        public string Correo { get => _correo; set => _correo = value; }
        public int Telefonocontacto1 { get => _telefonocontacto; set => _telefonocontacto = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public string Textobuscar { get => _textobuscar; set => _textobuscar = value; }

        public Dproveedores()
        {

        }

        public Dproveedores(int id, string nombre, string contacto, int telefonoempresa, int telefonocontacto, string correo, string direccion, string descripcion, string textobuscar)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Contacto = contacto;
            this.Telefonoempresa = telefonoempresa;
            this.Telefonocontacto = telefonocontacto;
            this.Correo = correo;
            this.Direccion = direccion;
            this.Descripcion = direccion;
            this.Textobuscar = textobuscar;
        }

        //Método Insertar

        public string Insertar(Dproveedores Proveedores)
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
                SqlCmd.CommandText = "insertar_proveedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter Parid = new SqlParameter();
                Parid.ParameterName = "@id";
                Parid.SqlDbType = SqlDbType.Int;
                Parid.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(Parid);

                SqlParameter Parnombre = new SqlParameter();
                Parnombre.ParameterName = "@nombre";
                Parnombre.SqlDbType = SqlDbType.VarChar;
                Parnombre.Size = 40;
                Parnombre.Value = Proveedores.Nombre;
                SqlCmd.Parameters.Add(Parnombre);

                SqlParameter Parcontacto = new SqlParameter();
                Parcontacto.ParameterName = "@contacto";
                Parcontacto.SqlDbType = SqlDbType.VarChar;
                Parcontacto.Size = 40;
                Parcontacto.Value = Proveedores.Contacto;
                SqlCmd.Parameters.Add(Parcontacto);

                SqlParameter Partelefonoempresa = new SqlParameter();
                Partelefonoempresa.ParameterName = "@telefonoEmpresa";
                Partelefonoempresa.SqlDbType = SqlDbType.Int;
                Partelefonoempresa.Value = Proveedores.Telefonoempresa;
                SqlCmd.Parameters.Add(Partelefonoempresa);

                SqlParameter ParApellidos = new SqlParameter();
                ParApellidos.ParameterName = "@telefonocontacto";
                ParApellidos.SqlDbType = SqlDbType.Int;
                ParApellidos.Value = Proveedores.Telefonocontacto;
                SqlCmd.Parameters.Add(ParApellidos);



                SqlParameter correo = new SqlParameter();
                correo.ParameterName = "@correo";
                correo.SqlDbType = SqlDbType.VarChar;
                correo.Size = 40;
                correo.Value = Proveedores.Correo;
                SqlCmd.Parameters.Add(correo);

                SqlParameter direccionn = new SqlParameter();
                direccionn.ParameterName = "@direccion";
                direccionn.SqlDbType = SqlDbType.VarChar;
                direccionn.Size = 40;
                direccionn.Value = Proveedores.Direccion;
                SqlCmd.Parameters.Add(direccionn);

             

                //Ejecutamos nuestro comando
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";

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

        //Método Editar
        public string Editar(Dproveedores Proveedores)
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
                SqlCmd.CommandText = "editar_proveedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdtrabajador = new SqlParameter();
                ParIdtrabajador.ParameterName = "@id";
                ParIdtrabajador.SqlDbType = SqlDbType.Int;
                ParIdtrabajador.Value = Proveedores.Id;
                SqlCmd.Parameters.Add(ParIdtrabajador);

                SqlParameter Parnombre = new SqlParameter();
                Parnombre.ParameterName = "@nombre";
                Parnombre.SqlDbType = SqlDbType.VarChar;
                Parnombre.Size = 40;
                Parnombre.Value = Proveedores.Nombre;
                SqlCmd.Parameters.Add(Parnombre);

                SqlParameter Parcontacto = new SqlParameter();
                Parcontacto.ParameterName = "@contacto";
                Parcontacto.SqlDbType = SqlDbType.VarChar;
                Parcontacto.Size = 40;
                Parcontacto.Value = Proveedores.Contacto;
                SqlCmd.Parameters.Add(Parcontacto);

                SqlParameter Partelefonoempresa = new SqlParameter();
                Partelefonoempresa.ParameterName = "@telefonoEmpresa";
                Partelefonoempresa.SqlDbType = SqlDbType.Int;
                Partelefonoempresa.Value = Proveedores.Telefonoempresa;
                SqlCmd.Parameters.Add(Partelefonoempresa);

                SqlParameter ParApellidos = new SqlParameter();
                ParApellidos.ParameterName = "@telefonocontacto";
                ParApellidos.SqlDbType = SqlDbType.Int;
                ParApellidos.Value = Proveedores.Telefonocontacto;
                SqlCmd.Parameters.Add(ParApellidos);



                SqlParameter correo = new SqlParameter();
                correo.ParameterName = "@correo";
                correo.SqlDbType = SqlDbType.VarChar;
                correo.Size = 40;
                correo.Value = Proveedores.Correo;
                SqlCmd.Parameters.Add(correo);

                SqlParameter direccionn = new SqlParameter();
                direccionn.ParameterName = "@direccion";
                direccionn.SqlDbType = SqlDbType.VarChar;
                direccionn.Size = 40;
                direccionn.Value = Proveedores.Direccion;
                SqlCmd.Parameters.Add(direccionn);

  



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

        //Método Eliminar


        //Método Mostrar
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("Proveedores");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Conec;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "mostrar_proveedor";
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


        //Método BuscarApellidos
        public DataTable BuscarNombre(Dproveedores cliente)
        {
            DataTable DtResultado = new DataTable("Proveedores");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Conec;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "buscar_proveedor_nombre";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = cliente.Textobuscar;
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

        public DataTable MostrarInsumoProveedor(int TextoBuscar)
        {
            DataTable DtResultado = new DataTable("Insumos");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Conec;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "mostrar_insumoproveedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@idproveedor";
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
