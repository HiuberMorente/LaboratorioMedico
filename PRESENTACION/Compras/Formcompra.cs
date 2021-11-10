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
    public partial class Formcompra : Form
    {
        private static Formcompra _instancia;
      
        public Formcompra()
        {
            InitializeComponent();
        }

        public static Formcompra GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new Formcompra();
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
            this.datacompra.Columns[4].Visible = false;
        }

        private void BuscarFechas()
        {
            this.datacompra.DataSource = Ncompra.BuscarFechas(this.dtfecha1.Value.ToString("MM/dd/yyyy"), this.dtfecha2.Value.ToString("MM/dd/yyyy"));
            this.OcultarColumnas();
            lbltotal.Text = "Total de Registros: " + Convert.ToString(datacompra.Rows.Count);

        }

        private void BuscarComprobante()
        {
            this.datacompra.DataSource = Ncompra.BuscarCompraComprobante(this.txtbuscar.Text);
            this.OcultarColumnas();
            lbltotal.Text = "Total de Registros: " + Convert.ToString(datacompra.Rows.Count);

        }


        private void BuscarLote()
        {
            this.datacompra.DataSource = Ncompra.BuscarCompraLote(this.txtbuscar.Text);
            this.OcultarColumnas();
            lbltotal.Text = "Total de Registros: " + Convert.ToString(datacompra.Rows.Count);

        }

        private void BuscarProveedores()
        {
            this.datacompra.DataSource = Ncompra.BuscarCompraProveedor(this.txtbuscar.Text);
            this.OcultarColumnas();
            lbltotal.Text = "Total de Registros: " + Convert.ToString(datacompra.Rows.Count);

        }

        private void BuscarResponsable()
        {
            this.datacompra.DataSource = Ncompra.BuscarCompraResponsable(this.txtbuscar.Text);
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
            this.datacompra.DataSource = Ncompra.Mostrar();
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

            if (cbbusqueda.Text == "Fecha")
            {
                this.BuscarFechas();
            }
          
            if (cbbusqueda.Text == "Comprobante")
            {
                if (this.txtbuscar.Text != string.Empty)
                {
                    this.BuscarComprobante();
                }
                else this.MensajeOk("Ingrese El Comprobante");

            }
            if (cbbusqueda.Text == "Lote")
            {
                if (this.txtbuscar.Text != string.Empty)
                {
                    this.BuscarLote();
                }
                else this.MensajeOk("Ingrese Número de Lote");

            }
            if (cbbusqueda.Text == "Responsable")
            {
                if (this.txtbuscar.Text != string.Empty)
                {
                    this.BuscarResponsable();
                }
                else this.MensajeOk("Ingrese El Nombre Del Responsable");
            }
            if (cbbusqueda.Text == "Proveedor")
            {
                if (this.txtbuscar.Text != string.Empty)
                {
                    this.BuscarProveedores();
                }
                else this.MensajeOk("Ingrese El Nombre de Proveedor");
            }


        }

        private void btnanular_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea Anular los Ingresos", "Sistema de Inventario", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in datacompra.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            //Rpta = Dcompra.Anular(Convert.ToInt32(Codigo));

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se Anuló Correctamente el registro");
                            }
                            else
                            {
                                this.MensajeError(Rpta);
                            }

                        }
                    }
                    this.Mostrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void dataarea_DoubleClick(object sender, EventArgs e)
        {
            



        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                this.datacompra.Columns[0].Visible = true;
            }
            else
            {
                this.datacompra.Columns[0].Visible = false;
            }

        }

        private void dtfecha2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            Formcompras form =  Formcompras.GetInstancia();
            form.Show();
            form.TopLevel = true;
            form.BringToFront();
        }

        private void datacompra_DoubleClick(object sender, EventArgs e)
        {
            try //boque try con todas las operaciones
            {
                Formcompras1 frms = new Formcompras1();
                string p2, p4, p5, p7, p8;
                int p1, p9;
                DateTime p3;
                decimal p6;

                p1 = Convert.ToInt32(this.datacompra.CurrentRow.Cells["Id"].Value);
                p2 = Convert.ToString(this.datacompra.CurrentRow.Cells["Proveedor"].Value);
                p3 = Convert.ToDateTime(this.datacompra.CurrentRow.Cells["Fecha"].Value);
                p4 = Convert.ToString(this.datacompra.CurrentRow.Cells["Comprobante"].Value);
                p5 = Convert.ToString(this.datacompra.CurrentRow.Cells["Lote"].Value);
                p6 = Convert.ToDecimal(this.datacompra.CurrentRow.Cells["Total"].Value);
                p7 = Convert.ToString(this.datacompra.CurrentRow.Cells["Estado"].Value);
                p8 = Convert.ToString(this.datacompra.CurrentRow.Cells["Observaciones"].Value);
                p9 = Convert.ToInt32(this.datacompra.CurrentRow.Cells["iduser"].Value);


                frms.setproducto(p1, p2, p3, p4, p5, p6, p7, p8, p9);
                frms.Show();
                frms.TopLevel = true;
                frms.BringToFront();
            }
            catch (Exception ex) //bloque catch para captura de error
            {
        
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Formcompra_FormClosing(object sender, FormClosingEventArgs e)
        {
            _instancia = null;
        }
    }
}
