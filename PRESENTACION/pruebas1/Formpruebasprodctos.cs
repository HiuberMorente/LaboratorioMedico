using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NEGOCIO;

namespace PRESENTACION
{
    public partial class Formpruebasprodctos : Form
    {
        public Formpruebasprodctos()
        {
            InitializeComponent();
        }
        private void OcultarColumnaspro()
        {
            ////this.dataproductos.Columns[0].Visible = false;
            ////this.dataproductos.Columns[1].Visible = false;
            ////this.dataproductos.Columns[2].Visible = false;

        }

        //Método Mostrar producto
        ////private void Mostrarproducoto()
        ////{
        ////    this.dataproductos.DataSource = Ninsumos.Mostrar();
        ////    this.OcultarColumnaspro();

        ////}

        //////Método BuscarNombre
        ////private void BuscarNombrepro()
        ////{
        ////    this.dataproductos.DataSource = Ninsumos.Buscarinsumos(this.txtbuscar.Text);
        ////    this.OcultarColumnaspro();


        ////}


        private void BuscarIsnumoPrueba()
        {
            this.dataproductos.DataSource = Npruebas.BuscarInsumoPrueba(this.txtbuscar.Text);
            this.OcultarColumnaspro();


        }
        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtbuscar.Text != "Buscar")
            {
                this.BuscarIsnumoPrueba();
            }
        }

        private void txtbuscar_Leave(object sender, EventArgs e)
        {
            if (txtbuscar.Text == "")
            {
                txtbuscar.Text = "buscar";

            }
        }

        private void txtbuscar_Enter(object sender, EventArgs e)
        {
            if (txtbuscar.Text != "buscar")
            {

                txtbuscar.Text = "";


            }
        }

        private void dataproductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataproductos_DoubleClick(object sender, EventArgs e)
        {
            Formpruebasinsert form3 =  Formpruebasinsert.GetInstancia();
            int var1,var3,var4;
            string var2;
            var1 = Convert.ToInt32(this.dataproductos.CurrentRow.Cells["Id"].Value);
            var2 = Convert.ToString(this.dataproductos.CurrentRow.Cells["Insumo"].Value);
            var3 = Convert.ToInt32(this.dataproductos.CurrentRow.Cells["stock"].Value);
            var4 = Convert.ToInt32(this.dataproductos.CurrentRow.Cells["idcompra"].Value);


            form3.setproductos(var1, var2,var3,var4);
            this.Close();
        }

        private void Formcomprasproductos_Load(object sender, EventArgs e)
        {
            //Mostrarproducoto();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
