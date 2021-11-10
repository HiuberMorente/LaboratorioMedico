using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Capacomun.Cache;
using NEGOCIO;

namespace PRESENTACION
{
    public partial class Formpruebasedit : Form
    {
        private int idus = Cachesesionuser.Id;
        private bool IsNuevo = true;
        public Formpruebasedit()
        {
            InitializeComponent();
            LlenarComboClientes();
        }

        private void OcultarColumnas()
        {
            this.datadetalle.Columns[0].Visible = false;
            this.datadetalle.Columns[1].Visible = false;
            this.datadetalle.Columns[2].Visible = false;
            this.datadetalle.Columns[3].Visible = false;


        }
        private void MostrarDetalles() {

            this.datadetalle.DataSource = Npruebas.MostrarDetalle(Convert.ToInt32(this.txtid.Text));
            //this.datadetalle.Columns["Total"].DefaultCellStyle.Format = "N2";
            //this.datadetalle.Columns["Precio"].DefaultCellStyle.Format = "N2";
            OcultarColumnas();           
                

        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema De Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        //Mostrar Mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema De Inventario", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void setproducto(int v1, string v2, string v3, string v4, string v5, DateTime v6, DateTime v7, DateTime v8, decimal v9, string v10, int v11, string v12)
        {

            this.txtid.Text = Convert.ToString(v1);
            this.cbclientes.Text = v2;
            this.cbtipo.Text = v3;
            this.txtprueba.Text = v4;
            this.txtdescripcion.Text = v5;
            this.dtfecha.Value = v6;
            this.cbrealizada.Value = v7;
            this.cbvencimiento.Value = v8;
            this.lbtotalpaga.Text = Convert.ToString(Math.Round(v9, 2));
            this.txtobservaciones.Text = v10;
            this.txtidproveedor.Text = Convert.ToString(v11);
            this.txtcomprobante.Text = v12;
            this.MostrarDetalles();
            



        }

        private void LlenarComboClientes()
        {
            cbclientes.DataSource = Ncliente.Mostrar();
            cbclientes.ValueMember = "Id";
            cbclientes.DisplayMember = "Nombre";

        }


        private void LlenarCombotipo()
        {
            cbtipo.DataSource = Ntipoprueba.Mostrar();
            cbtipo.ValueMember = "Id";
            cbtipo.DisplayMember = "Nombre";

        }


        private void Formcompras1_Load(object sender, EventArgs e)
        {
            //this.cbclientes.Enabled = false;
           
            LlenarCombotipo();
        }

        private void txtidproducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtcomprobante_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtidproveedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbestado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {



            try
            {

                //La variable que almacena si se inserto 
                //o se modifico la tabla
                string Rpta = "";
                if ( /*this.txtserie.Text == string.Empty || txtcorrelativo.Text == string.Empty ||*/ txtprueba.Text == string.Empty)
                {
                    //MensajeError("Falta ingresar algunos datos, serán remarcados");
                    //erroricon.SetError(txtserie, "Ingrese la serie del comprobante");
                    //erroricon.SetError(txtcorrelativo, "Ingrese el número del comprobante");
                    //erroricon.SetError(txtlote, "Ingrese el porcentaje de IGV");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        //Vamos a insertar un Ingreso
                        Rpta = Npruebas.Editar(Convert.ToInt32(this.txtid.Text),
                          Convert.ToInt32(this.cbtipo.SelectedValue),this.txtprueba.Text,this.txtdescripcion.Text, Convert.ToDecimal(lbtotalpaga.Text), Convert.ToDateTime(dtfecha.Value), Convert.ToDateTime(cbrealizada.Value),
                          Convert.ToDateTime(cbvencimiento.Value),txtobservaciones.Text, Convert.ToInt32(this.cbclientes.SelectedValue),Convert.ToInt32(this.txtidproveedor.Text),this.txtcomprobante.Text);

                    }

                    //Si la respuesta fue OK, fue porque se modifico 
                    //o inserto el Ingreso
                    //de forma correcta
                    if (Rpta.Equals("OK"))
                    {

                        this.MensajeOk("Se insertó de forma correcta el registro");


                    }
                    else
                    {
                        //Mostramos el mensaje de error
                        this.MensajeError(Rpta);
                    }
                    Formpruebas frm = Formpruebas.GetInstancia();
                    frm.Mostrar();

                    this.Close();

                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void datadetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lbtotalpaga_Click(object sender, EventArgs e)
        {

        }

        private void datadetalle_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           
                
        }
    }
}
