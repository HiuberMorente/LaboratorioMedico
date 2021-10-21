using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACCESOADATOS
{
    public class Conexion
    {
        public static string Conec = "Server=(Local);DataBase=laboratorioPruebas; integrated security= true";
        //public static string Conec = "Server=(Local)\\SQLEXPRESS;DataBase=laboratorioPruebas; integrated security= true";


        private SqlConnection Conexion1 = new SqlConnection("Server=(Local);DataBase=laboratorioPruebas; integrated security= true");
        //private SqlConnection Conexion1 = new SqlConnection("Server=(Local)\\SQLEXPRESS;DataBase=laboratorioPruebas; integrated security= true");
        private readonly string connectionString;
        public Conexion()
        {
            connectionString = "Server=(Local);DataBase=laboratorioPruebas; integrated security= true";
            //connectionString = "Server=(Local)\\SQLEXPRESS;DataBase=laboratorioPruebas; integrated security= true";


        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
        public SqlConnection AbrirConexion()
        {
            if (Conexion1.State == ConnectionState.Closed)
                Conexion1.Open();
            return Conexion1;
        }
        public SqlConnection CerrarConexion()
        {
            if (Conexion1.State == ConnectionState.Open)
                Conexion1.Close();
            return Conexion1;
        }

    }
}
