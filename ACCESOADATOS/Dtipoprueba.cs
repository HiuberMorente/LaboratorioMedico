using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ACCESOADATOS
{
     public class Dtipoprueba
    {
        private int _id;
        private string _nombre;
        private string _descripción;
        private string _textobuscar;

        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Descripción { get => _descripción; set => _descripción = value; }
        public string Textobuscar { get => _textobuscar; set => _textobuscar = value; }

        public Dtipoprueba()
        {

        }

        public Dtipoprueba(int id, string nombre, string descripcion)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Descripción = descripcion;
   
        }



        public string Insertar(Dtipoprueba Tipopru)
        {
            string response = "";

            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //open connection
                SqlCon.ConnectionString = Conexion.Conec;
                SqlCon.Open();

                //Lammado al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "insertar_tipo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Datos a enviar al SP
                SqlParameter ParamIdUsuario = new SqlParameter();
                ParamIdUsuario.ParameterName = "@id";
                ParamIdUsuario.SqlDbType = SqlDbType.Int;
                ParamIdUsuario.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParamIdUsuario);

                SqlParameter ParamNombreUsuario = new SqlParameter();
                ParamNombreUsuario.ParameterName = "@nombre";
                ParamNombreUsuario.SqlDbType = SqlDbType.VarChar;
                ParamNombreUsuario.Size = 40;
                ParamNombreUsuario.Value = Tipopru.Nombre;
                SqlCmd.Parameters.Add(ParamNombreUsuario);

                SqlParameter ParamApellidoUsuario = new SqlParameter();
                ParamApellidoUsuario.ParameterName = "@descripcion";
                ParamApellidoUsuario.SqlDbType = SqlDbType.VarChar;
                ParamApellidoUsuario.Size = 40;
                ParamApellidoUsuario.Value = Tipopru.Descripción;
                SqlCmd.Parameters.Add(ParamApellidoUsuario);


                //Ejecucion command
                response = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "Failed to insert User";

            }
            catch (Exception ex)
            {
                response = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return response;

        }


        public string Editar(Dtipoprueba Tipopru)
        {
            string response = "";

            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //open connection
                SqlCon.ConnectionString = Conexion.Conec;
                SqlCon.Open();

                //Lammado al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "editar_tipoprueba"; 
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Datos a enviar al SP
                SqlParameter ParamIdUsuario = new SqlParameter();
                ParamIdUsuario.ParameterName = "@id";
                ParamIdUsuario.SqlDbType = SqlDbType.Int;
                ParamIdUsuario.Value = Tipopru.Id;
                SqlCmd.Parameters.Add(ParamIdUsuario);

                SqlParameter ParamNombreUsuario = new SqlParameter();
                ParamNombreUsuario.ParameterName = "@nombre";
                ParamNombreUsuario.SqlDbType = SqlDbType.VarChar;
                ParamNombreUsuario.Size = 40;
                ParamNombreUsuario.Value = Tipopru.Nombre;
                SqlCmd.Parameters.Add(ParamNombreUsuario);

                SqlParameter ParamApellidoUsuario = new SqlParameter();
                ParamApellidoUsuario.ParameterName = "@descripción";
                ParamApellidoUsuario.SqlDbType = SqlDbType.VarChar;
                ParamApellidoUsuario.Size = 40;
                ParamApellidoUsuario.Value = Tipopru.Descripción;
                SqlCmd.Parameters.Add(ParamApellidoUsuario);



                //Ejecucion command
                response = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "Failed to insert User";

            }
            catch (Exception ex)
            {
                response = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return response;

        }


        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("tipoPruebas");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Conec;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "mostrar_tipoprueba"; // TODO: verificar en db
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




        public DataTable BuscarTipoprueba(Dtipoprueba tipoPruebas)
        {
            DataTable DtResponse = new DataTable("tipoPruebas");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Conec;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "buscar_tipoprueba";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = tipoPruebas.Textobuscar;
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
