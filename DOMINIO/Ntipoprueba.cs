using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACCESOADATOS;

namespace NEGOCIO
{
    public class Ntipoprueba
    {
        public static string Insertar(string nombre, string descripcion)
        {
            Dtipoprueba Obj = new Dtipoprueba();
            Obj.Nombre = nombre;
            Obj.Descripción = descripcion;

            return Obj.Insertar(Obj);
        }

        //Método Editar que llama al método Editar de la clase DTrabajador
        //de la CapaDatos
        public static string Editar(int id, string nombre, string descripcion)
        {
            Dtipoprueba Obj = new Dtipoprueba();
            Obj.Id = id;
            Obj.Nombre = nombre;
            Obj.Descripción = descripcion;

            return Obj.Editar(Obj);
        }



        //Método Mostrar que llama al método Mostrar de la clase DTrabajador
        //de la CapaDatos
        public static DataTable Mostrar()
        {
            return new Dtipoprueba().Mostrar();
        }

        //Método BuscarApellidos que llama al método BuscarApellidos
        //de la clase DTrabajador de la CapaDatos
        public static DataTable BuscarTipo(string textobuscar)
        {
            Dtipoprueba Obj = new Dtipoprueba();
            Obj.Textobuscar = textobuscar;
            return Obj.BuscarTipoprueba(Obj);
        }

    }
}
