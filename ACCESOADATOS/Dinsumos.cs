using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace ACCESOADATOS
{
   public  class Dinsumos
    {
        private int _id;
        private int _idproveedor;
        private string _Nombre;
        private string _Descripcion;
        private decimal _precio;
        private string _estado;
        private string _codigo;
        private string _textobuscar;

        public int Id { get => _id; set => _id = value; }
        public int Idproveedor { get => _idproveedor; set => _idproveedor = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public decimal Precio { get => _precio; set => _precio = value; }
        public string Estado { get => _estado; set => _estado = value; }
        public string Textobuscar { get => _textobuscar; set => _textobuscar = value; }
        public string Codigo { get => _codigo; set => _codigo = value; }


        //Constructores
        public Dinsumos()
        {

        }

        public Dinsumos(int id, int idproveedor, string nombre, string descripcion,decimal precio, string estado,string codigo)
        {
            this.Id = id;
            this.Idproveedor = idproveedor;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Precio = precio;
            this.Estado = estado;
            this.Codigo = codigo;
        
        }

        //Método Insertar

        public string Insertar(Dinsumos Insumos)
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
                SqlCmd.CommandText = "insertar_insumos";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdtrabajador = new SqlParameter();
                ParIdtrabajador.ParameterName = "@id";
                ParIdtrabajador.SqlDbType = SqlDbType.Int;
                ParIdtrabajador.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdtrabajador);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@idproveedor";
                ParNombre.SqlDbType = SqlDbType.Int;
                ParNombre.Value = Insumos.Idproveedor;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParUsuario = new SqlParameter();
                ParUsuario.ParameterName = "@nombre";
                ParUsuario.SqlDbType = SqlDbType.VarChar;
                ParUsuario.Size = 40;
                ParUsuario.Value = Insumos.Nombre;
                SqlCmd.Parameters.Add(ParUsuario);

                SqlParameter ParPassword = new SqlParameter();
                ParPassword.ParameterName = "@descripcion";
                ParPassword.SqlDbType = SqlDbType.VarChar;
                ParPassword.Size = 40;
                ParPassword.Value = Insumos.Descripcion;
                SqlCmd.Parameters.Add(ParPassword);

                SqlParameter parprecio = new SqlParameter();
                parprecio.ParameterName = "@precio";
                parprecio.SqlDbType = SqlDbType.Decimal;
                parprecio.Precision = 10;
                parprecio.Scale = 2;
                parprecio.Value = Insumos.Precio;
                SqlCmd.Parameters.Add(parprecio);

                SqlParameter ParApellidos = new SqlParameter();
                ParApellidos.ParameterName = "@estado";
                ParApellidos.SqlDbType = SqlDbType.VarChar;
                ParApellidos.Size = 15;
                ParApellidos.Value = Insumos.Estado;
                SqlCmd.Parameters.Add(ParApellidos);

                SqlParameter ParApellidos1 = new SqlParameter();
                ParApellidos1.ParameterName = "@codigo";
                ParApellidos1.SqlDbType = SqlDbType.VarChar;
                ParApellidos1.Size = 50;
                ParApellidos1.Value = Insumos.Codigo;
                SqlCmd.Parameters.Add(ParApellidos1);






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
        public string Editar(Dinsumos Insumos)
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
                SqlCmd.CommandText = "editar_insumos";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdtrabajador = new SqlParameter();
                ParIdtrabajador.ParameterName = "@id";
                ParIdtrabajador.SqlDbType = SqlDbType.Int;
                ParIdtrabajador.Value = Insumos.Id;
                SqlCmd.Parameters.Add(ParIdtrabajador);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@idproveedor";
                ParNombre.SqlDbType = SqlDbType.Int;
                ParNombre.Value = Insumos.Idproveedor;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParUsuario = new SqlParameter();
                ParUsuario.ParameterName = "@nombre";
                ParUsuario.SqlDbType = SqlDbType.VarChar;
                ParUsuario.Size = 40;
                ParUsuario.Value = Insumos.Nombre;
                SqlCmd.Parameters.Add(ParUsuario);

                SqlParameter ParPassword = new SqlParameter();
                ParPassword.ParameterName = "@descripcion";
                ParPassword.SqlDbType = SqlDbType.VarChar;
                ParPassword.Size = 40;
                ParPassword.Value = Insumos.Descripcion;
                SqlCmd.Parameters.Add(ParPassword);

                SqlParameter parprecio = new SqlParameter();
                parprecio.ParameterName = "@precio";
                parprecio.SqlDbType = SqlDbType.Decimal;
                parprecio.Precision = 10;
                parprecio.Scale = 2;
                parprecio.Value = Insumos.Precio;
                SqlCmd.Parameters.Add(parprecio);

                SqlParameter ParApellidos = new SqlParameter();
                ParApellidos.ParameterName = "@estado";
                ParApellidos.SqlDbType = SqlDbType.VarChar;
                ParApellidos.Size = 15;
                ParApellidos.Value = Insumos.Estado;
                SqlCmd.Parameters.Add(ParApellidos);

                SqlParameter ParApellidos1 = new SqlParameter();
                ParApellidos1.ParameterName = "@codigo";
                ParApellidos1.SqlDbType = SqlDbType.VarChar;
                ParApellidos1.Size = 50;
                ParApellidos1.Value = Insumos.Codigo;
                SqlCmd.Parameters.Add(ParApellidos1);


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
            DataTable DtResultado = new DataTable("Insumos");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Conec;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "mostrar_insumos";
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
        public DataTable Buscarinsumos(Dinsumos Insumos)
        {
            DataTable DtResultado = new DataTable("Insumos");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Conec;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "buscar_nombre_insumo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Insumos.Textobuscar;
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
