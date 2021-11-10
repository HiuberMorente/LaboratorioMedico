using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ACCESOADATOS;

namespace NEGOCIO
{
    public class Ncompra
    {
        

            //Método Insertar que llama al método Insertar de la clase DIngreso
            //de la CapaDatos
            public static string Insertar(int idproveedor, DateTime fecha, decimal total, string observaciones, string comprobante,string estado, string lote,int iduser, DataTable dtDetalles)
            {
                Dcompra Obj = new Dcompra();
                Obj.Idproveedor = idproveedor;
                Obj.Fecha = fecha;
                Obj.Total = total;
                Obj.Observaciones = observaciones;
                Obj.Comprobante = comprobante;
                Obj.Estado = estado;
                Obj.Lote = lote;
                Obj.Iduser = iduser;
            List<Ddetalle_compra> detalles = new List<Ddetalle_compra> ();
                foreach (DataRow row in dtDetalles.Rows)
                {
                    Ddetalle_compra detalle = new Ddetalle_compra();
                    detalle.Idinsumo = Convert.ToInt32(row["idinsumo"].ToString());
                    detalle.Cantidad = Convert.ToInt32(row["Cantidad"].ToString());
                    detalle.Subtotal = Convert.ToDecimal(row["Sub-total"].ToString());
                    detalle.Total = Convert.ToDecimal(row["Total"].ToString());
                    detalle.Fechafabricación = Convert.ToDateTime(row["Fecha de Fabricación"].ToString());
                    detalle.Fechacaducidad = Convert.ToDateTime(row["Fecha de Vencimiento"].ToString());
                    detalle.Stock = Convert.ToInt32(row["stock"].ToString());
                detalles.Add(detalle);
                }


                return Obj.Insertar(Obj, detalles);
            }

        public static string Editar(int id,int idproveedor, DateTime fecha, decimal total, string observaciones, string comprobante, string estado, string lote, int iduser)
        {
            Dcompra Obj = new Dcompra();
            Obj.Id = id;
            Obj.Idproveedor = idproveedor;
            Obj.Fecha = fecha;
            Obj.Total = total;
            Obj.Observaciones = observaciones;
            Obj.Comprobante = comprobante;
            Obj.Estado = estado;
            Obj.Lote = lote;
            Obj.Iduser = iduser;




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
                return new Dcompra().Mostrar();
            }

            //Método BuscarApellidos que llama al método BuscarApellidos
            //de la clase DCliente de la CapaDatos
            public static DataTable BuscarFechas(string textobuscar, string textobuscar2)
            {
                Dcompra Obj = new Dcompra();
                return Obj.BuscarFechas(textobuscar, textobuscar2);
            }

        public static DataTable BuscarCompraProveedor(string textobuscar)
        {
            Dcompra Obj = new Dcompra();
            Obj.Textobuscar = textobuscar;
            return Obj.BuscarCompraProveedor(Obj);
        }

        public static DataTable BuscarCompraComprobante(string textobuscar)
        {
            Dcompra Obj = new Dcompra();
            Obj.Textobuscar = textobuscar;
            return Obj.BuscarCompraComprobante(Obj);
        }

        public static DataTable BuscarCompraLote(string textobuscar)
        {
            Dcompra Obj = new Dcompra();
            Obj.Textobuscar = textobuscar;
            return Obj.BuscarCompraLote(Obj);
        }

        public static DataTable BuscarCompraResponsable(string textobuscar)
        {
            Dcompra Obj = new Dcompra();
            Obj.Textobuscar = textobuscar;
            return Obj.BuscarCompraResponsable(Obj);
        }


        public static DataTable MostrarDetalle(int textobuscar)
            {
                Dcompra Obj = new Dcompra();
                return Obj.MostrarDetalle(textobuscar);
            }

        

       
    }
}
