using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Capacomun.Cache;

namespace ACCESOADATOS
{
    public class Userdao : ACCESOADATOS.Conexion
    {
        public bool Login(string user, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select *from usuarios where usuario=@user and password=@pass";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read()) { 
                            Cachesesionuser.Id = reader.GetInt32(0);
                            Cachesesionuser.nombre = reader.GetString(1 );
                            Cachesesionuser.apellido = reader.GetString(2);
                            Cachesesionuser.roles_id = reader.GetInt32(6);
                          
                        }
                        return true;
                    }
                    else
                        return false;
                }
                
            }
        

        }

    }
}