using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ACCESOADATOS;

namespace NEGOCIO
{
    public class Nproveedor
    {
        public static string Insertar(string nombre, string contacto, int telefonoempresa, int telefonocontacto, string correo, string direccion)
        {
            Dproveedores Obj = new Dproveedores();
            Obj.Nombre = nombre;
            Obj.Contacto = contacto;
            Obj.Telefonoempresa = telefonoempresa;
            Obj.Telefonocontacto = telefonocontacto;
            Obj.Correo = correo;
            Obj.Direccion = direccion;
     


            return Obj.Insertar(Obj);
        }

        //Método Editar que llama al método Editar de la clase DTrabajador
        //de la CapaDatos
        public static string Editar(int id, string nombre, string contacto, int telefonoempresa, int telefonocontacto, string correo, string direccion)
        {
            Dproveedores Obj = new Dproveedores();
            Obj.Id = id;
            Obj.Nombre = nombre;
            Obj.Contacto = contacto;
            Obj.Telefonoempresa = telefonoempresa;
            Obj.Telefonocontacto = telefonocontacto;
            Obj.Correo = correo;
            Obj.Direccion = direccion;
       



            return Obj.Editar(Obj);
        }



        //Método Mostrar que llama al método Mostrar de la clase DTrabajador
        //de la CapaDatos
        public static DataTable Mostrar()
        {
            return new Dproveedores().Mostrar();
        }

        //Método BuscarApellidos que llama al método BuscarApellidos
        //de la clase DTrabajador de la CapaDatos
        public static DataTable BuscarNombre(string textobuscar)
        {
            Dproveedores Obj = new Dproveedores();
            Obj.Textobuscar = textobuscar;
            return Obj.BuscarNombre(Obj);
        }

        public static DataTable MostrarInsumoProveedor(int textobuscar)
        {
            Dproveedores Obj = new Dproveedores();
            return Obj.MostrarInsumoProveedor(textobuscar);
        }
    }

}
