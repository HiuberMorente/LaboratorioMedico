using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NEGOCIO;

namespace PRESENTACION
{
    public partial class Formcompras1 : Form
    {



        private bool IsNuevo = true;
        public Formcompras1()
        {
            InitializeComponent();
        }
        private void MostrarDetalles() { 
      
            this.datadetalle.DataSource = Ncompra.MostrarDetalle(Convert.ToInt32(this.txtid.Text));
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
        public void setproducto(int v1, string v2, DateTime v3, string v4, string v5, decimal v6,string v7,string v8,int v9)
        {

            this.txtid.Text = Convert.ToString(v1);
            this.cbproveedor.Text = v2;
            this.dtfecha.Value = v3;
            this.txtcomprobante.Text = v4;
            this.txtlote.Text = v5;
            this.lbtotalpaga.Text = Convert.ToString(v6);
            this.cbestado.Text = v7;
            this.txtobservaciones.Text = v8;
            this.txtiduser.Text = Convert.ToString(v9);

            this.MostrarDetalles();
     

        }

        private void LlenarComboProveedor()
        {
            cbproveedor.DataSource = Nproveedor.Mostrar();
            cbproveedor.ValueMember = "Id";
            cbproveedor.DisplayMember = "Nombre";

        }
        private void OcultarColumnas()
        {
            this.datadetalle.Columns[0].Visible = false;
            this.datadetalle.Columns[1].Visible = false;
            this.datadetalle.Columns[2].Visible = false;
        }


        private void Formcompras1_Load(object sender, EventArgs e)
        {
            LlenarComboProveedor();
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
                if ( /*this.txtserie.Text == string.Empty || txtcorrelativo.Text == string.Empty ||*/ txtlote.Text == string.Empty)
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
                        Rpta = Ncompra.Editar(Convert.ToInt32(this.txtid.Text), Convert.ToInt32(this.cbproveedor.SelectedValue),
                        Convert.ToDateTime(dtfecha.Value), Convert.ToDecimal(lbtotalpaga.Text), txtobservaciones.Text, txtcomprobante.Text,
                        this.cbestado.Text, txtlote.Text, Convert.ToInt32(this.txtiduser.Text));

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
                    Formcompra frm = Formcompra.GetInstancia();
                    frm.Mostrar();
  
                    this.Close();

                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
