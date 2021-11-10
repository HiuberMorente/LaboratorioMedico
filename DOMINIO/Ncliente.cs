using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACCESOADATOS;

namespace NEGOCIO
{
    public class Ncliente
    {
        //Método Insertar que llama al método Insertar de la clase DTrabajador
        //de la CapaDatos
        public static string Insertar( string nombre, string apellido, int edad, string dpi, string nit, string telefono, string direccion, string correo)
        {
            Dclientes Obj = new Dclientes();
            Obj.Nombre = nombre;
            Obj.Apellido = apellido;
            Obj.Edad = edad;
            Obj.Dpi = dpi;
            Obj.Nit = nit;
            Obj.Telefono = telefono;
            Obj.Direccion = direccion;
            Obj.Correo = correo;
         

            return Obj.Insertar(Obj);
        }

        //Método Editar que llama al método Editar de la clase DTrabajador
        //de la CapaDatos
        public static string Editar( int id, string nombre, string apellido, int edad, string dpi, string nit, string telefono, string direccion, string correo)
        {
            Dclientes Obj = new Dclientes();
            Obj.Id = id;
            Obj.Nombre = nombre;
            Obj.Apellido = apellido;
            Obj.Edad = edad;
            Obj.Dpi = dpi;
            Obj.Nit = nit;
            Obj.Telefono = telefono;
            Obj.Direccion = direccion;
            Obj.Correo = correo;




            return Obj.Editar(Obj);
        }


      
        //Método Mostrar que llama al método Mostrar de la clase DTrabajador
        //de la CapaDatos
        public static DataTable Mostrar()
        {
            return new Dclientes().Mostrar();
        }

        //Método BuscarApellidos que llama al método BuscarApellidos
        //de la clase DTrabajador de la CapaDatos
        public static DataTable BuscarApellidos(string textobuscar)
        {
            Dclientes Obj = new Dclientes();
            Obj.Textobuscar = textobuscar;
            return Obj.BuscarApellidos(Obj);
        }
    }
}
