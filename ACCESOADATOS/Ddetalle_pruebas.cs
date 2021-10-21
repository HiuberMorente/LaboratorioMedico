using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ACCESOADATOS
{
    public class Ddetalle_pruebas
    {

        private int _Id;
        private int _idinsumo;
        private int _idprueba;
        private int _cantidad;
        private decimal _precio;
        private decimal _total;
        private int _iddcompra;
 

        public int Id { get => _Id; set => _Id = value; }
        public int Idinsumo { get => _idinsumo; set => _idinsumo = value; }
        public int Cantidad { get => _cantidad; set => _cantidad = value; }
        public int Idprueba { get => _idprueba; set => _idprueba = value; }
        public decimal Precio { get => _precio; set => _precio = value; }
        public decimal Total { get => _total; set => _total = value; }
        public int Iddcompra { get => _iddcompra; set => _iddcompra = value; }

        public Ddetalle_pruebas()
        {

        }

        public Ddetalle_pruebas(int id,  int idinsumo, int idprueba, int cantida, decimal precio,decimal total, int idcompra)
        {
            this.Id = id;
            this.Idinsumo = idinsumo;
            this.Idprueba = idprueba;
            this.Cantidad = cantida;
            this.Precio = precio;
            this.Total = total;
            this.Iddcompra = idcompra;


        }




        //Método Insertar
        public string Insertar(Ddetalle_pruebas Detalle_compra, ref SqlConnection SqlCon, ref SqlTransaction SqlTra)
        {
            string rpta = "";
            try
            {

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.Transaction = SqlTra;
                SqlCmd.CommandText = "insertar_detallepruebas";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIddetalle_ingreso = new SqlParameter();
                ParIddetalle_ingreso.ParameterName = "@id";
                ParIddetalle_ingreso.SqlDbType = SqlDbType.Int;
                ParIddetalle_ingreso.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIddetalle_ingreso);

                SqlParameter ParIdingreso = new SqlParameter();
                ParIdingreso.ParameterName = "@idinsumo";
                ParIdingreso.SqlDbType = SqlDbType.Int;
                ParIdingreso.Value = Detalle_compra.Idinsumo;
                SqlCmd.Parameters.Add(ParIdingreso);

                SqlParameter ParIdarticulo = new SqlParameter();
                ParIdarticulo.ParameterName = "@idprueba";
                ParIdarticulo.SqlDbType = SqlDbType.Int;
                ParIdarticulo.Value = Detalle_compra.Idprueba;
                SqlCmd.Parameters.Add(ParIdarticulo);

                SqlParameter ParIdarticulo1 = new SqlParameter();
                ParIdarticulo1.ParameterName = "@cantidad";
                ParIdarticulo1.SqlDbType = SqlDbType.Int;
                ParIdarticulo1.Value = Detalle_compra.Cantidad;
                SqlCmd.Parameters.Add(ParIdarticulo1);

                SqlParameter ParPrecio_Compra = new SqlParameter();
                ParPrecio_Compra.ParameterName = "@precio";
                ParPrecio_Compra.SqlDbType = SqlDbType.Decimal;
                ParPrecio_Compra.Precision = 10;
                ParPrecio_Compra.Scale = 2;
                ParPrecio_Compra.Value = Detalle_compra.Precio;
                SqlCmd.Parameters.Add(ParPrecio_Compra);

                SqlParameter ParPrecio_Compra1 = new SqlParameter();
                ParPrecio_Compra1.ParameterName = "@total";
                ParPrecio_Compra1.SqlDbType = SqlDbType.Decimal;
                ParPrecio_Compra1.Precision = 10;
                ParPrecio_Compra1.Scale = 2;
                ParPrecio_Compra1.Value = Detalle_compra.Total;
                SqlCmd.Parameters.Add(ParPrecio_Compra1);

                SqlParameter ParIdingreso1 = new SqlParameter();
                ParIdingreso1.ParameterName = "@idcompra";
                ParIdingreso1.SqlDbType = SqlDbType.Int;
                ParIdingreso1.Value = Detalle_compra.Iddcompra;
                SqlCmd.Parameters.Add(ParIdingreso1);



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
