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
    public partial class Formcomprasproductos : Form
    {
        public Formcomprasproductos()
        {
            InitializeComponent();
        }
        private void OcultarColumnaspro()
        {
            //this.dataproductos.Columns[0].Visible = false;
            
        }

        //Método Mostrar producto
        private void Mostrarproducoto()
        {
            this.dataproductos.DataSource = Ninsumos.Mostrar();
            this.OcultarColumnaspro();

        }

        //Método BuscarNombre
        private void BuscarNombrepro()
        {
            this.dataproductos.DataSource = Ninsumos.Buscarinsumos(this.txtbuscar.Text);
            this.OcultarColumnaspro();


        }
        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtbuscar.Text != "Buscar")
            {
                this.BuscarNombrepro();
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
            Formcompras form3 =  Formcompras.GetInstancia();
            int var1;
            string var2,var4;
            decimal var3;
            var1 = Convert.ToInt32(this.dataproductos.CurrentRow.Cells["Id"].Value);
            var2 = Convert.ToString(this.dataproductos.CurrentRow.Cells["Insumo"].Value);
            var3 = Convert.ToDecimal(this.dataproductos.CurrentRow.Cells["Precio"].Value);
            var4 = Convert.ToString(this.dataproductos.CurrentRow.Cells["Proveedor"].Value);
            form3.setproductos(var1, var2,var3,var4);
            this.Close();
        }

        private void Formcomprasproductos_Load(object sender, EventArgs e)
        {
            Mostrarproducoto();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
