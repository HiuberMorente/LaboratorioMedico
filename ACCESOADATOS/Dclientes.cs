using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ACCESOADATOS
{
    public class Dclientes
    {
        private int _id;
        private string _Nombre;
        private string _Apellido;
        private int _edad;
        private string _Dpi;
        private string _Nit;
        private string _Telefono;
        private string _Direccion;
        private string _Correo;
        private string _Textobuscar;

public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public int Edad { get => _edad; set => _edad = value; }
        public string Dpi { get => _Dpi; set => _Dpi = value; }
        public string Nit { get => _Nit; set => _Nit = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Correo { get => _Correo; set => _Correo = value; }
        public string Textobuscar { get => _Textobuscar; set => _Textobuscar = value; }




        //Constructores
        public Dclientes()
        {

        }

        public Dclientes(int id, string nombre, string apellido, int edad, string dpi, string nit, string telefono, string direccion, string correo, string textobuscar)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Edad = edad;
            this.Dpi = dpi;
            this.Nit = nit;
            this.Telefono = telefono;
            this.Direccion = direccion;
            this.Correo = correo;
            this.Textobuscar = textobuscar;
        }

        //Método Insertar

        public string Insertar(Dclientes Clientes)
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
                SqlCmd.CommandText = "insertar_cliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdtrabajador = new SqlParameter();
                ParIdtrabajador.ParameterName = "@id";
                ParIdtrabajador.SqlDbType = SqlDbType.Int;
                ParIdtrabajador.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdtrabajador);

                SqlParameter ParUsuario = new SqlParameter();
                ParUsuario.ParameterName = "@nombre";
                ParUsuario.SqlDbType = SqlDbType.VarChar;
                ParUsuario.Size = 40;
                ParUsuario.Value = Clientes.Nombre;
                SqlCmd.Parameters.Add(ParUsuario);

                SqlParameter ParPassword = new SqlParameter();
                ParPassword.ParameterName = "@apellido";
                ParPassword.SqlDbType = SqlDbType.VarChar;
                ParPassword.Size = 40;
                ParPassword.Value = Clientes.Apellido;
                SqlCmd.Parameters.Add(ParPassword);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@edad";
                ParNombre.SqlDbType = SqlDbType.Int;
                ParNombre.Value = Clientes.Edad;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParApellidos = new SqlParameter();
                ParApellidos.ParameterName = "@dpi";
                ParApellidos.SqlDbType = SqlDbType.VarChar;
                ParApellidos.Size = 40;
                ParApellidos.Value = Clientes.Dpi;
                SqlCmd.Parameters.Add(ParApellidos);



                SqlParameter ParFecha_Nacimiento = new SqlParameter();
                ParFecha_Nacimiento.ParameterName = "@nit";
                ParFecha_Nacimiento.SqlDbType = SqlDbType.VarChar;
                ParFecha_Nacimiento.Size = 40;
                ParFecha_Nacimiento.Value = Clientes.Nit;
                SqlCmd.Parameters.Add(ParFecha_Nacimiento);

                SqlParameter ParNum_Documento = new SqlParameter();
                ParNum_Documento.ParameterName = "@telefono";
                ParNum_Documento.SqlDbType = SqlDbType.VarChar;
                ParNum_Documento.Size = 12;
                ParNum_Documento.Value = Clientes.Telefono;
                SqlCmd.Parameters.Add(ParNum_Documento);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 40;
                ParDireccion.Value = Clientes.Direccion;
                SqlCmd.Parameters.Add(ParDireccion);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@correo";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 40;
                ParTelefono.Value = Clientes.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);




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
        public string Editar(Dclientes Cliente)
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
                SqlCmd.CommandText = "editar_cliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdtrabajador = new SqlParameter();
                ParIdtrabajador.ParameterName = "@id";
                ParIdtrabajador.SqlDbType = SqlDbType.Int;
                ParIdtrabajador.Value = Cliente.Id;
                SqlCmd.Parameters.Add(ParIdtrabajador);

                SqlParameter ParUsuario = new SqlParameter();
                ParUsuario.ParameterName = "@nombre";
                ParUsuario.SqlDbType = SqlDbType.VarChar;
                ParUsuario.Size = 40;
                ParUsuario.Value = Cliente.Nombre;
                SqlCmd.Parameters.Add(ParUsuario);

                SqlParameter ParPassword = new SqlParameter();
                ParPassword.ParameterName = "@apellido";
                ParPassword.SqlDbType = SqlDbType.VarChar;
                ParPassword.Size = 40;
                ParPassword.Value = Cliente.Apellido;
                SqlCmd.Parameters.Add(ParPassword);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@edad";
                ParNombre.SqlDbType = SqlDbType.Int;
                ParNombre.Value = Cliente.Edad;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParApellidos = new SqlParameter();
                ParApellidos.ParameterName = "@dpi";
                ParApellidos.SqlDbType = SqlDbType.VarChar;
                ParApellidos.Size = 40;
                ParApellidos.Value = Cliente.Dpi;
                SqlCmd.Parameters.Add(ParApellidos);



                SqlParameter ParFecha_Nacimiento = new SqlParameter();
                ParFecha_Nacimiento.ParameterName = "@nit";
                ParFecha_Nacimiento.SqlDbType = SqlDbType.VarChar;
                ParFecha_Nacimiento.Size = 40;
                ParFecha_Nacimiento.Value = Cliente.Nit;
                SqlCmd.Parameters.Add(ParFecha_Nacimiento);

                SqlParameter ParNum_Documento = new SqlParameter();
                ParNum_Documento.ParameterName = "@telefono";
                ParNum_Documento.SqlDbType = SqlDbType.VarChar;
                ParNum_Documento.Size = 12;
                ParNum_Documento.Value = Cliente.Telefono;
                SqlCmd.Parameters.Add(ParNum_Documento);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 40;
                ParDireccion.Value = Cliente.Direccion;
                SqlCmd.Parameters.Add(ParDireccion);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@correo";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 40;
                ParTelefono.Value = Cliente.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);



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
            DataTable DtResultado = new DataTable("Pacientes");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Conec;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "mostrar_cliente";
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
        public DataTable BuscarApellidos(Dclientes cliente)
        {
            DataTable DtResultado = new DataTable("Usuariso");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Conec;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "buscar_cliente_apellidos";
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
    }
}
