using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACCESOADATOS;

namespace NEGOCIO
{
    public class Nreportes
    {
        public static DataTable Mostrar()
        {
            return new Dreportes().Mostrar();
        }

        public static DataTable BuscarinsumoNombre(string textobuscar)
        {
            Dreportes Obj = new Dreportes();
            Obj.Textobuscar = textobuscar;
            return Obj.BuscarInsumoNombre(Obj);
        }

        public static DataTable BuscarinsumoCodigo(string textobuscar)
        {
            Dreportes Obj = new Dreportes();
            Obj.Textobuscar = textobuscar;
            return Obj.BuscarInsumoCodigo(Obj);
        }


        public static DataTable BuscarFechasMovimientos(string textobuscar, string textobuscar2)
        {
            Dreportes Obj = new Dreportes();
            return Obj.BuscarFechasMovimientos(textobuscar, textobuscar2);
        }

        public static DataTable MostrarMovimientos()
        {
            return new Dreportes().MostrarMovimiento();
        }

    }
}
