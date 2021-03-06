using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpresionesRegulares;
using NEGOCIO;

namespace PRESENTACION.clientes
{
    public partial class Formproveedoreedit : Form
    {
        Boolean Esnuevo;
        private void MensajeOK(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema De Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Para mostrar mensaje de error
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema De Inventario", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public Formproveedoreedit()
        {
            InitializeComponent();
        
        }

        private void OcultarColumnas()
        {
            this.datainsumos.Columns[0].Visible = false;
            this.datainsumos.Columns[1].Visible = false;
            this.datainsumos.Columns[2].Visible = false;
        }
        
        private void MostrarDetalles()
        {
            this.datainsumos.DataSource = Nproveedor.MostrarInsumoProveedor(Convert.ToInt32(this.txtid.Text));
            this.OcultarColumnas();

        }


        private void label4_Click(object sender, EventArgs e)
        {

        }
        public void setproveedor(int varp,string varp1, string varp2,int varp3,int varp4,string varp5,string varp6)
            {


            this.txtid.Text = Convert.ToString(varp);
            this.txtnombre.Text = varp1;
            this.txtcontacto.Text = varp2;
            this.txttelempresa.Text = Convert.ToString(varp3);
            this.txttelcontacto.Text = Convert.ToString(varp3);
            this.txtcorreo.Text = varp5;
            this.txtdireccion.Text = varp6;
             MostrarDetalles();




        }
        private void Formclientea_Load(object sender, EventArgs e)
        {
          
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        Esnuevo = true;

            try
            {

                //La variable que almacena si se inserto
                //o se modifico la tabla
                string Respuesta = "";
                if (this.txtnombre.Text == string.Empty)
                {

                
                }
                else
                {
                    if (this.Esnuevo)
                    {
                        //Vamos a insertar un producto
                        Respuesta = Nproveedor.Editar(Convert.ToInt32(this.txtid.Text), this.txtnombre.Text.Trim().ToUpper(),
                                   this.txtcontacto.Text, Convert.ToInt32(this.txttelempresa.Text), Convert.ToInt32(this.txttelcontacto.Text), this.txtcorreo.Text, this.txtdireccion.Text);

                    }
                 
                    if (Respuesta.Equals("OK"))
                    {
                        if (this.Esnuevo)
                        {
                            this.MensajeOK("Se actualizó de forma correcta el registro");
                        }
                      

                    }
                    else
                    {
                        //Mostramos el mensaje de error
                        this.MensajeError(Respuesta);
                    }
                    this.Esnuevo = false;
                    Formproveedor far = Formproveedor.GetInstancia();
                    far.Mostrar();



                    this.Hide();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void datainsumos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txttelempresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
             (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void txttelcontacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
              (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtcorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcorreo_Leave(object sender, EventArgs e)
        {
            ValidarCorreo VAL = new ValidarCorreo();
            string correo = txtcorreo.Text.Trim();
            if (!VAL.IsValidEmailFormat(correo))
            {
                MessageBox.Show("Email invalido");
                return;
            }
            {
                MessageBox.Show("Email Valido!");
                return;
            }
        }
    }
}
