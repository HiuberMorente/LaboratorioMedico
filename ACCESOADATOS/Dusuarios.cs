using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACCESOADATOS
{
    public class Dusuarios
    {
        private int _id;
        private string _Nombre;
        private string _Apellido;
        private string _Correo;
        private string _Usuario;
        private string _Password;
        private int _RolesId;
        private string _Textobuscar;

        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public string Correo { get => _Correo; set => _Correo = value; }
        public string User { get => _Usuario; set => _Usuario = value; }
        public string Password { get => _Password; set => _Password = value; }
        public int RolesId { get => _RolesId; set => _RolesId = value; }
        public string Textobuscar { get => _Textobuscar; set => _Textobuscar = value; }


        public Dusuarios()
        {

        }

        public Dusuarios(int id, string nombre, string apellido, string correo, string user, string password, int rolesId, string textoBuscar)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Correo = correo;
            this.User = user;
            this.Password = password;
            this.RolesId = rolesId;
            this.Textobuscar = textoBuscar;
        }

        public string Insertar(Dusuarios Usuarios)
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
                SqlCmd.CommandText = "insertarUsuarios"; 
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
                ParamNombreUsuario.Size = 50;
                ParamNombreUsuario.Value = Usuarios.Nombre;
                SqlCmd.Parameters.Add(ParamNombreUsuario);

                SqlParameter ParamApellidoUsuario = new SqlParameter();
                ParamApellidoUsuario.ParameterName = "@apellido";
                ParamApellidoUsuario.SqlDbType = SqlDbType.VarChar;
                ParamApellidoUsuario.Size = 50;
                ParamApellidoUsuario.Value = Usuarios.Apellido;
                SqlCmd.Parameters.Add(ParamApellidoUsuario);

                SqlParameter ParamCorreoUsuario = new SqlParameter();
                ParamCorreoUsuario.ParameterName = "@correo";
                ParamCorreoUsuario.SqlDbType = SqlDbType.VarChar;
                ParamCorreoUsuario.Size = 50;
                ParamCorreoUsuario.Value = Usuarios.Correo;
                SqlCmd.Parameters.Add(ParamCorreoUsuario);

                SqlParameter ParamUserUsuario = new SqlParameter();
                ParamUserUsuario.ParameterName = "@usuario";
                ParamUserUsuario.SqlDbType = SqlDbType.VarChar;
                ParamUserUsuario.Size = 20;
                ParamUserUsuario.Value = Usuarios.User;
                SqlCmd.Parameters.Add(ParamUserUsuario);

                SqlParameter ParamPasswordUsuario = new SqlParameter();
                ParamPasswordUsuario.ParameterName = "@password";
                ParamPasswordUsuario.SqlDbType = SqlDbType.VarChar;
                ParamPasswordUsuario.Size = 20;
                ParamPasswordUsuario.Value = Usuarios.Password;
                SqlCmd.Parameters.Add(ParamPasswordUsuario);

                SqlParameter ParamRolesUsuario = new SqlParameter();
                ParamRolesUsuario.ParameterName = "@roles_id";
                ParamRolesUsuario.SqlDbType = SqlDbType.Int;
                ParamRolesUsuario.Value = Usuarios.RolesId;
                SqlCmd.Parameters.Add(ParamRolesUsuario);

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


        public string Editar(Dusuarios Usuarios)
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
                SqlCmd.CommandText = "editar_usuarios"; // TODO: Verificar el nombre del sp
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Datos a enviar al SP
                SqlParameter ParamIdUsuario = new SqlParameter();
                ParamIdUsuario.ParameterName = "@id";
                ParamIdUsuario.SqlDbType = SqlDbType.Int;
                ParamIdUsuario.Value = Usuarios.Id;
                SqlCmd.Parameters.Add(ParamIdUsuario);

                SqlParameter ParamNombreUsuario = new SqlParameter();
                ParamNombreUsuario.ParameterName = "@nombre";
                ParamNombreUsuario.SqlDbType = SqlDbType.VarChar;
                ParamNombreUsuario.Size = 50;
                ParamNombreUsuario.Value = Usuarios.Nombre;
                SqlCmd.Parameters.Add(ParamNombreUsuario);

                SqlParameter ParamApellidoUsuario = new SqlParameter();
                ParamApellidoUsuario.ParameterName = "@apellido";
                ParamApellidoUsuario.SqlDbType = SqlDbType.VarChar;
                ParamApellidoUsuario.Size = 50;
                ParamApellidoUsuario.Value = Usuarios.Apellido;
                SqlCmd.Parameters.Add(ParamApellidoUsuario);

                SqlParameter ParamCorreoUsuario = new SqlParameter();
                ParamCorreoUsuario.ParameterName = "@correo";
                ParamCorreoUsuario.SqlDbType = SqlDbType.VarChar;
                ParamCorreoUsuario.Size = 50;
                ParamCorreoUsuario.Value = Usuarios.Correo;
                SqlCmd.Parameters.Add(ParamCorreoUsuario);

                SqlParameter ParamUserUsuario = new SqlParameter();
                ParamUserUsuario.ParameterName = "@usuario";
                ParamUserUsuario.SqlDbType = SqlDbType.VarChar;
                ParamUserUsuario.Size = 20;
                ParamUserUsuario.Value = Usuarios.User;
                SqlCmd.Parameters.Add(ParamUserUsuario);

                SqlParameter ParamPasswordUsuario = new SqlParameter();
                ParamPasswordUsuario.ParameterName = "@password";
                ParamPasswordUsuario.SqlDbType = SqlDbType.VarChar;
                ParamPasswordUsuario.Size = 20;
                ParamPasswordUsuario.Value = Usuarios.Password;
                SqlCmd.Parameters.Add(ParamPasswordUsuario);

                SqlParameter ParamRolesUsuario = new SqlParameter();
                ParamRolesUsuario.ParameterName = "@roles_id";
                ParamRolesUsuario.SqlDbType = SqlDbType.Int;
                ParamRolesUsuario.Size = 1;
                ParamRolesUsuario.Value = Usuarios.RolesId;
                SqlCmd.Parameters.Add(ParamRolesUsuario);

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
            DataTable DtResultado = new DataTable("Usuarios");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Conec;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Mostrar_usuarios"; // TODO: verificar en db
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

        public DataTable Mostrarrol()
        {
            DataTable DtResultado = new DataTable("roles");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Conec;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "mostrar_rol"; 
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


        public DataTable BuscarUsuario(Dusuarios Usuarios)
        {
            DataTable DtResponse = new DataTable("Usuarios");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Conec;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Buscar_usuarios";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Usuarios.Textobuscar;
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
