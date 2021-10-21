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
    public partial class Formclienteedit : Form
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
        public Formclienteedit()
        {
            InitializeComponent();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        public void setcliente(int varp, string varp1, string varp2, int varp3, string varp4, string varp5, string varp6, string varp7, string varp8)
        {


            this.txtid.Text = Convert.ToString(varp);
            this.txtnombre.Text = varp1;
            this.txtapellido.Text = varp2;
            this.txtedad.Text = Convert.ToString(varp3);
            this.txtdpi.Text = varp4;
            this.txtnit.Text = varp5;
            this.txttelefono.Text = varp6;
            this.txtdireccion.Text = varp7;
            this.txtcorreo.Text = varp8;

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
                        Respuesta = Ncliente.Editar(Convert.ToInt32(this.txtid.Text), this.txtnombre.Text.Trim().ToUpper(),
                                   this.txtapellido.Text, Convert.ToInt32(this.txtedad.Text), this.txtdpi.Text, this.txtnit.Text, this.txttelefono.Text,
                                   this.txtdireccion.Text, this.txtcorreo.Text);

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
                    Formcliente fral = Formcliente.GetInstancia();
                    fral.Mostrar();




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

        private void txtnit_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txttelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttelefono_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtedad_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtnit_Leave(object sender, EventArgs e)
        {
            ValidarNIT VAL = new ValidarNIT();
            string nit = this.txtnit.Text;
            if (VAL.HasValidFormat(nit))
            {
                if (VAL.nitIsValid(nit))
                {
                    MessageBox.Show("Número de NIT es invalido!");
                }
                else
                {
                    MessageBox.Show("El NIT: " + nit + " es válido!");
                }
            }
            else
            {
                MessageBox.Show("El numbero de nit debe contener 8 digitos!");
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
