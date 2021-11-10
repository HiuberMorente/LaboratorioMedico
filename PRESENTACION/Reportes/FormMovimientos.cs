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
using PRESENTACION.Reportes;

namespace PRESENTACION
{
    public partial class FormMovimientos : Form
    {
        private static Formpruebas _instancia;
      
        public FormMovimientos()
        {
            InitializeComponent();
        }


        public static Formpruebas GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new Formpruebas();
            }
            return _instancia;
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema De Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void OcultarColumnas()
        {
            this.datacompra.Columns[0].Visible = false;
            this.datacompra.Columns[1].Visible = false;
            this.datacompra.Columns[2].Visible = false;
            this.datacompra.Columns[3].Visible = false;
         

        }

        private void BuscarFechasMovimientos()
        {
            this.datacompra.DataSource = Nreportes.BuscarFechasMovimientos(this.dtfecha1.Value.ToString("MM/dd/yyyy"), this.dtfecha2.Value.ToString("MM/dd/yyyy"));
            this.OcultarColumnas();
            lbltotal.Text = "Total de Registros: " + Convert.ToString(datacompra.Rows.Count);

        }

  

     

        //Mostrar Mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema De Inventario", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Mostrar()
        {
            this.datacompra.DataSource = Nreportes.MostrarMovimientos();
            this.OcultarColumnas();
            lbltotal.Text = "Total de Registros: " + Convert.ToString(datacompra.Rows.Count);
        }

        private void Formcompra_Load(object sender, EventArgs e)
        {
            this.Mostrar();
        }

        private void dataarea_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == datacompra.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)datacompra.Rows[e.RowIndex].Cells["Eliminar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            this.BuscarFechasMovimientos();
           
        }

        private void btnanular_Click(object sender, EventArgs e)
        {
        }

        private void dataarea_DoubleClick(object sender, EventArgs e)
        {
            



        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        private void dtfecha2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
         

        }

        private void datacompra_DoubleClick(object sender, EventArgs e)
        {
            //Formpruebasedit formp = new Formpruebasedit();

            //string varp2, varp4, varp3, varp1, varp9;
            //int varp,varp10;
            //decimal  varp8;
            //DateTime varp5, varp6, varp7;

            //varp = Convert.ToInt32(this.datacompra.CurrentRow.Cells["Id"].Value);
            //varp1 = Convert.ToString(this.datacompra.CurrentRow.Cells["Cliente"].Value);
            //varp2 = Convert.ToString(this.datacompra.CurrentRow.Cells["Tipo De Prueba"].Value);
            //varp3 = Convert.ToString(this.datacompra.CurrentRow.Cells["Prueba"].Value);
            //varp4 = Convert.ToString(this.datacompra.CurrentRow.Cells["Descripción"].Value);
            //varp5 = Convert.ToDateTime(this.datacompra.CurrentRow.Cells["Fecha De Solicitud"].Value);
            //varp6 = Convert.ToDateTime(this.datacompra.CurrentRow.Cells["Fecha Realizada"].Value);
            //varp7 = Convert.ToDateTime(this.datacompra.CurrentRow.Cells["Fecha De Validez"].Value);
            //varp8 = Convert.ToDecimal(this.datacompra.CurrentRow.Cells["Precio"].Value);
            //varp9 = Convert.ToString(this.datacompra.CurrentRow.Cells["Observaciones"].Value);
            //varp10 = Convert.ToInt32(this.datacompra.CurrentRow.Cells["iduser"].Value);


            //formp.setproducto(varp, varp1, varp2, varp3, varp4, varp5, varp6, varp7, varp8, varp9,varp10);
            //formp.Show();
            //formp.TopLevel = true;
            //formp.BringToFront();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbltotal_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            mov movimiento = new mov();
            movimiento.Fecha1 = this.dtfecha1.Value.ToString("MM/dd/yyyy");
            movimiento.Fecha2 = this.dtfecha2.Value.ToString("MM/dd/yyyy");
            movimiento.Show();

        }
    }
}
