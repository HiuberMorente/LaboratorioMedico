using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ACCESOADATOS;

namespace NEGOCIO
{
    public class Npruebas
    {


        //Método Insertar que llama al método Insertar de la clase DIngreso
        //de la CapaDatos
        public static string Insertar(int idtipo, string nombre, string descripcion, decimal precio, DateTime fechasolicitud, DateTime fecharealizo, DateTime fechavigencia, string observaciones, int idcliente, int iduser,string comprobante, DataTable dtDetalles)
        {
            Dpruebas1 Obj = new Dpruebas1();
            Obj.Idtipo = idtipo;
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            Obj.Precio = precio;
            Obj.Fechasolucidad = fechasolicitud;
            Obj.Fecharealizo = fecharealizo;
            Obj.Fechavigencia = fechavigencia;
            Obj.Observaciones = observaciones;
            Obj.Idcliente = idcliente;
            Obj.Iduser = iduser;
            Obj.Comprobante = comprobante;

            List<Ddetalle_pruebas> detalles = new List<Ddetalle_pruebas>();
            foreach (DataRow row in dtDetalles.Rows)
            {
                Ddetalle_pruebas detalle = new Ddetalle_pruebas();
                detalle.Idinsumo = Convert.ToInt32(row["idInsumo"].ToString());
                detalle.Cantidad = Convert.ToInt32(row["Cantidad"].ToString());
                detalle.Precio = Convert.ToDecimal(row["Sub-total"].ToString());
                detalle.Total = Convert.ToDecimal(row["Total"].ToString());
                detalle.Iddcompra = Convert.ToInt32(row["idcompra"].ToString());
                detalles.Add(detalle);
            }


            return Obj.Insertar(Obj, detalles);
        }

        public static string Editar(int id, int idtipo, string nombre, string descripcion, decimal precio, DateTime fechasolicitud, DateTime fecharealizo, DateTime fechavigencia, string observaciones, int idcliente, int iduser,string comprobante)
        {
            Dpruebas1 Obj = new Dpruebas1();
            Obj.Id = id;
            Obj.Idtipo = idtipo;
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            Obj.Precio = precio;
            Obj.Fechasolucidad = fechasolicitud;
            Obj.Fecharealizo = fecharealizo;
            Obj.Fechavigencia = fechavigencia;
            Obj.Observaciones = observaciones;
            Obj.Idcliente = idcliente;
            Obj.Iduser = iduser;
            Obj.Comprobante = comprobante;

            return Obj.Editar(Obj);
        }


        //Método Anular que llama al método Anular de la clase DIngreso
        //de la CapaDatos
        //public static string Anular(int idcompra)
        //{
        //    Datoscompra Obj = new Datoscompra();
        //    Obj.ID_compra1 = idcompra;
        //    return Obj.Anular(Obj);
        //}

        //Método Mostrar que llama al método Mostrar de la clase DIngreso
        //de la CapaDatos
        public static DataTable Mostrar()
            {
                return new Dpruebas1().Mostrar();
            }

            //Método BuscarApellidos que llama al método BuscarApellidos
            //de la clase DCliente de la CapaDatos
            public static DataTable BuscarFechas(string textobuscar, string textobuscar2)
            {
                Dpruebas1 Obj = new Dpruebas1();
                return Obj.BuscarFechas(textobuscar, textobuscar2);
            }

        public static DataTable BuscarFechasRealizada(string textobuscar, string textobuscar2)
        {
            Dpruebas1 Obj = new Dpruebas1();
            return Obj.BuscarFechasRealizada(textobuscar, textobuscar2);
        }

        public static DataTable BuscarFechasVencimiento(string textobuscar, string textobuscar2)
        {
            Dpruebas1 Obj = new Dpruebas1();
            return Obj.BuscarFechasVencimiento(textobuscar, textobuscar2);
        }
        public static DataTable MostrarDetalle(int textobuscar)
            {
                Dpruebas1 Obj = new Dpruebas1();
                return Obj.MostrarDetalle(textobuscar);
            }
        public static DataTable BuscarPrueba(string textobuscar)
        {
            Dpruebas1 Obj = new Dpruebas1();
            Obj.Textobuscar = textobuscar;
            return Obj.BuscarPrueba(Obj);
        }

        public static DataTable BuscarInsumoPrueba(string textobuscar)
        {
            Dpruebas1 Obj = new Dpruebas1();
            Obj.Textobuscar = textobuscar;
            return Obj.BuscarInsumoPrueba(Obj);
        }


        public static DataTable BuscarPruebaTipo(string textobuscar)
        {
            Dpruebas1 Obj = new Dpruebas1();
            Obj.Textobuscar = textobuscar;
            return Obj.BuscarPruebaTipo(Obj);
        }

        public static DataTable BuscarPruebaCliente(string textobuscar)
        {
            Dpruebas1 Obj = new Dpruebas1();
            Obj.Textobuscar = textobuscar;
            return Obj.BuscarPruebaCliente(Obj);
        }



    }
}
