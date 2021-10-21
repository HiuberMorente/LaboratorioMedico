using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ACCESOADATOS;

namespace NEGOCIO
{
    public class Nusuarios
    {
        public static string Insertar(string nombre, string apellido, string correo, string user, string password, int rolesId) {
            
           
            Dusuarios Obj = new Dusuarios();
            Obj.Nombre = nombre;
            Obj.Apellido = apellido;
            Obj.Correo = correo;
            Obj.User = user;
            Obj.Password = password;
            Obj.RolesId = rolesId;

            return Obj.Insertar(Obj);
        }


        public static string Editar(int id,string nombre, string apellido, string correo, string user, string password, int rolesId)
        {


            Dusuarios Obj = new Dusuarios();
            Obj.Id = id;
            Obj.Nombre = nombre;
            Obj.Apellido = apellido;
            Obj.Correo = correo;
            Obj.User = user;
            Obj.Password = password;
            Obj.RolesId = rolesId;

            return Obj.Editar(Obj);
        }


        public static DataTable Mostrar()
        {
            return new Dusuarios().Mostrar();
        }
        public static DataTable Mostrarrol()
        {
            return new Dusuarios().Mostrarrol();
        }


        public static DataTable BuscarApellidos(string textobuscar)
        {
            Dusuarios Obj = new Dusuarios();
            Obj.Textobuscar = textobuscar;
            return Obj.BuscarUsuario(Obj);
        }
         
    }
}
