using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ACCESOADATOS
{
    public class Ddetalle_compra
    {

    private int _Id;
    private int _idcompra;
    private int _idinsumo;
    private int _cantidad;
    private decimal _subtotal;
    private decimal _total;
    private DateTime _fechafabricación;
    private DateTime _fechacaducidad;
    private int _stock;



        public int Id { get => _Id; set => _Id = value; }
        public int Idcompra { get => _idcompra; set => _idcompra = value; }
        public int Idinsumo { get => _idinsumo; set => _idinsumo = value; }
        public int Cantidad { get => _cantidad; set => _cantidad = value; }
        public decimal Subtotal { get => _subtotal; set => _subtotal = value; }
        public decimal Total { get => _total; set => _total = value; }
        public DateTime Fechafabricación { get => _fechafabricación; set => _fechafabricación = value; }
        public DateTime Fechacaducidad { get => _fechacaducidad; set => _fechacaducidad = value; }
        public int Stock { get => _stock; set => _stock = value; }

        public Ddetalle_compra()
        {

        }

        public Ddetalle_compra(int id, int idcompra, int idinsumo, int cantida, decimal subtotal, decimal total, DateTime fechafabrcacion,DateTime fechacaducidad,int stock)
        {
            this.Id = id;
            this.Idcompra = idcompra;
            this.Idinsumo = idinsumo;
            this.Cantidad = cantida;
            this.Subtotal = subtotal;
            this.Total = total;
            this.Fechafabricación = fechafabrcacion;
            this.Fechacaducidad = fechacaducidad;
            this.Stock = stock;

        }




        //Método Insertar
        public string Insertar(Ddetalle_compra Detalle_compra, ref SqlConnection SqlCon, ref SqlTransaction SqlTra)
        {
            string rpta = "";
            try
            {

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.Transaction = SqlTra;
                SqlCmd.CommandText = "insertar_detalleCompra";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIddetalle_ingreso = new SqlParameter();
                ParIddetalle_ingreso.ParameterName = "@id";
                ParIddetalle_ingreso.SqlDbType = SqlDbType.Int;
                ParIddetalle_ingreso.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIddetalle_ingreso);

                SqlParameter ParIdingreso = new SqlParameter();
                ParIdingreso.ParameterName = "@compra";
                ParIdingreso.SqlDbType = SqlDbType.Int;
                ParIdingreso.Value = Detalle_compra.Idcompra;
                SqlCmd.Parameters.Add(ParIdingreso);

                SqlParameter ParIdarticulo = new SqlParameter();
                ParIdarticulo.ParameterName = "@insumo";
                ParIdarticulo.SqlDbType = SqlDbType.Int;
                ParIdarticulo.Value = Detalle_compra.Idinsumo;
                SqlCmd.Parameters.Add(ParIdarticulo);

                SqlParameter ParIdarticulo1 = new SqlParameter();
                ParIdarticulo1.ParameterName = "@cantidad";
                ParIdarticulo1.SqlDbType = SqlDbType.Int;
                ParIdarticulo1.Value = Detalle_compra.Cantidad;
                SqlCmd.Parameters.Add(ParIdarticulo1);

                SqlParameter ParPrecio_Compra = new SqlParameter();
                ParPrecio_Compra.ParameterName = "@subTotal";
                ParPrecio_Compra.SqlDbType = SqlDbType.Decimal;
                ParPrecio_Compra.Precision = 10;
                ParPrecio_Compra.Scale = 2;
                ParPrecio_Compra.Value = Detalle_compra.Subtotal;
                SqlCmd.Parameters.Add(ParPrecio_Compra);

                SqlParameter ParPrecio_Venta = new SqlParameter();
                ParPrecio_Venta.ParameterName = "@total";
                ParPrecio_Venta.SqlDbType = SqlDbType.Decimal;
                ParPrecio_Venta.Precision = 10;
                ParPrecio_Venta.Scale = 2;
                ParPrecio_Venta.Value = Detalle_compra.Total;
                SqlCmd.Parameters.Add(ParPrecio_Venta);

                SqlParameter ParStock_Inicial = new SqlParameter();
                ParStock_Inicial.ParameterName = "@fechaFabricacion";
                ParStock_Inicial.SqlDbType = SqlDbType.DateTime;
                ParStock_Inicial.Value = Detalle_compra.Fechafabricación;
                SqlCmd.Parameters.Add(ParStock_Inicial);

                SqlParameter ParStock_Inicial2 = new SqlParameter();
                ParStock_Inicial2.ParameterName = "@fechaCaducidad";
                ParStock_Inicial2.SqlDbType = SqlDbType.DateTime;
                ParStock_Inicial2.Value = Detalle_compra.Fechacaducidad;
                SqlCmd.Parameters.Add(ParStock_Inicial2);

                SqlParameter ParIdarticulo2 = new SqlParameter();
                ParIdarticulo2.ParameterName = "@stock";
                ParIdarticulo2.SqlDbType = SqlDbType.Int;
                ParIdarticulo2.Value = Detalle_compra.Stock;
                SqlCmd.Parameters.Add(ParIdarticulo2);





                //Ejecutamos nuestro comando
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }

            return rpta;

        }

       
    }
}
