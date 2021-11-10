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
    public partial class Formpruebas : Form
    {
        private static Formpruebas _instancia;
      
        public Formpruebas()
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
            this.datacompra.Columns[8].Visible = false;
            this.datacompra.Columns[13].Visible = false;

        }

        private void BuscarFechas()
        {
            this.datacompra.DataSource = Npruebas.BuscarFechas(this.dtfecha1.Value.ToString("MM/dd/yyyy"), this.dtfecha2.Value.ToString("MM/dd/yyyy"));
            this.OcultarColumnas();
            lbltotal.Text = "Total de Registros: " + Convert.ToString(datacompra.Rows.Count);

        }

        private void BuscarFechasRelizada()
        {
            this.datacompra.DataSource = Npruebas.BuscarFechasRealizada(this.dtfecha1.Value.ToString("MM/dd/yyyy"), this.dtfecha2.Value.ToString("MM/dd/yyyy"));
            this.OcultarColumnas();
            lbltotal.Text = "Total de Registros: " + Convert.ToString(datacompra.Rows.Count);

        }

        private void BuscarFechasVencimiento()
        {
            this.datacompra.DataSource = Npruebas.BuscarFechasVencimiento(this.dtfecha1.Value.ToString("MM/dd/yyyy"), this.dtfecha2.Value.ToString("MM/dd/yyyy"));
            this.OcultarColumnas();
            lbltotal.Text = "Total de Registros: " + Convert.ToString(datacompra.Rows.Count);

        }

        private void BuscarPrueba()
        {
            this.datacompra.DataSource = Npruebas.BuscarPrueba(this.txtbuscar.Text);
            this.OcultarColumnas();
            lbltotal.Text = "Total de Registros: " + Convert.ToString(datacompra.Rows.Count);

        }

        private void BuscarPruebaTipo()
        {
            this.datacompra.DataSource = Npruebas.BuscarPruebaTipo(this.txtbuscar.Text);
            this.OcultarColumnas();
            lbltotal.Text = "Total de Registros: " + Convert.ToString(datacompra.Rows.Count);

        }

        private void BuscarPruebaCliente()
        {
            this.datacompra.DataSource = Npruebas.BuscarPruebaCliente(this.txtbuscar.Text);
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
            this.datacompra.DataSource = Npruebas.Mostrar();
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
            if (cbbusqueda.Text == "Fecha De Solicitud") 
            {
                this.BuscarFechas();
            }
            if (cbbusqueda.Text == "Fecha Realizada")
            {
                this.BuscarFechasRelizada();
            }
            if (cbbusqueda.Text == "Fecha De Validez")
            {
                this.BuscarFechasVencimiento();
            }
            if (cbbusqueda.Text == "Cliente")
            {
                if (this.txtbuscar.Text != string.Empty)
                {
                    this.BuscarPruebaCliente();
                }
                else this.MensajeOk("Ingrese El Cliente");
                
            }
            if (cbbusqueda.Text == "Prueba")
            {
                if (this.txtbuscar.Text != string.Empty)
                {
                    this.BuscarPrueba();
                }
                else this.MensajeOk("Ingrese La Prueba");
             
            }
            if (cbbusqueda.Text == "Tipo De Prueba")
            {
                if (this.txtbuscar.Text != string.Empty)
                {
                    this.BuscarPruebaTipo();
                }
                else this.MensajeOk("Ingrese El Tipo De Prueba");
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
            

        }

        private void dtfecha2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            Formpruebasinsert form =  Formpruebasinsert.GetInstancia();
            form.Show();
            form.TopLevel = true;
            form.BringToFront();
        }

        private void datacompra_DoubleClick(object sender, EventArgs e)
        {
            try //boque try con todas las operaciones
            {
                Formpruebasedit formp = new Formpruebasedit();

                string varp2, varp4, varp3, varp1, varp9,varp11;
                int varp, varp10;
                decimal varp8;
                DateTime varp5, varp6, varp7;

                varp = Convert.ToInt32(this.datacompra.CurrentRow.Cells["Id"].Value);
                varp1 = Convert.ToString(this.datacompra.CurrentRow.Cells["Cliente"].Value);
                varp2 = Convert.ToString(this.datacompra.CurrentRow.Cells["Tipo De Prueba"].Value);
                varp3 = Convert.ToString(this.datacompra.CurrentRow.Cells["Prueba"].Value);
                varp4 = Convert.ToString(this.datacompra.CurrentRow.Cells["Descripción"].Value);
                varp5 = Convert.ToDateTime(this.datacompra.CurrentRow.Cells["Fecha De Solicitud"].Value);
                varp6 = Convert.ToDateTime(this.datacompra.CurrentRow.Cells["Fecha Realizada"].Value);
                varp7 = Convert.ToDateTime(this.datacompra.CurrentRow.Cells["Fecha De Validez"].Value);
                varp8 = Convert.ToDecimal(this.datacompra.CurrentRow.Cells["Precio"].Value);
                varp9 = Convert.ToString(this.datacompra.CurrentRow.Cells["Observaciones"].Value);
                varp10 = Convert.ToInt32(this.datacompra.CurrentRow.Cells["iduser"].Value);
                varp11 = Convert.ToString(this.datacompra.CurrentRow.Cells["Comprobante"].Value);


                formp.setproducto(varp, varp1, varp2, varp3, varp4, varp5, varp6, varp7, varp8, varp9, varp10,varp11);
                formp.Show();
                formp.TopLevel = true;
                formp.BringToFront();
            }
            catch (Exception ex) //bloque catch para captura de error
            {
             
            }

            
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
