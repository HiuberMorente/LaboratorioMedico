using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ACCESOADATOS;

namespace NEGOCIO
{
   public  class Ninsumos
    {

        public static string Insertar(int idproveedor,string nombre,string descripcion,decimal precio,string estado, string codigo)
        {
            Dinsumos Obj = new Dinsumos();
            Obj.Idproveedor = idproveedor;
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            Obj.Precio = precio;
            Obj.Estado = estado;
            Obj.Codigo = codigo;
    

            return Obj.Insertar(Obj);
        }

        //Método Editar que llama al método Editar de la clase DTrabajador
        //de la CapaDatos
        public static string Editar(int id,int idproveedor, string nombre, string descripcion, decimal precio, string estado, string codigo)
        {
            Dinsumos Obj = new Dinsumos();
            Obj.Id = id;
            Obj.Idproveedor = idproveedor;
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            Obj.Precio = precio;
            Obj.Estado = estado;
            Obj.Codigo = codigo;




            return Obj.Editar(Obj);
        }



        //Método Mostrar que llama al método Mostrar de la clase DTrabajador
        //de la CapaDatos
        public static DataTable Mostrar()
        {
            return new Dinsumos().Mostrar();
        }

        //Método BuscarApellidos que llama al método BuscarApellidos
        //de la clase DTrabajador de la CapaDatos
        public static DataTable Buscarinsumos(string textobuscar)
        {
            Dinsumos Obj = new Dinsumos();
            Obj.Textobuscar = textobuscar;
            return Obj.Buscarinsumos(Obj);
        }
    }
}
