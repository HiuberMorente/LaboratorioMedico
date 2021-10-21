using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpresionesRegulares;
using NEGOCIO;

namespace PRESENTACION.clientes
{
    public partial class Formclientea : Form
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
        public Formclientea()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

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
                        Respuesta = Ncliente.Insertar(this.txtnombre.Text.Trim().ToUpper(),
                                   this.txtapellido.Text, Convert.ToInt32(this.txtedad.Text), this.txtdpi.Text, this.txtnit.Text, this.txttelefono.Text,
                                   this.txtdireccion.Text, this.txtcorreo.Text);

                    }
                 
                    if (Respuesta.Equals("OK"))
                    {
                        if (this.Esnuevo)
                        {
                            this.MensajeOK("Se insertó de forma correcta el registro");
                        }
                        else
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtdpi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }


        private void txtdpi_Leave(object sender, EventArgs e)
        { if (txtdpi.Text != null)
            {
                string cui = txtdpi.Text.Trim();
                int sizeCui = cui.Length;
                if (sizeCui == 13)
                {
                    if (!cuiIsValid(cui))
                    {
                        MessageBox.Show("El DPI es invalido");
                    }
                }
                else
                {
                    MessageBox.Show("Cantidad de digitos invalidos");
                }
            }

        }

private static Regex expression = new Regex("[0-9]{13}", RegexOptions.Compiled); public bool HasValidFormat(string cui)
        {
            if (cui == null)
                throw new ArgumentNullException("cui"); return expression.IsMatch(cui);
        }
        public bool cuiIsValid(string cui)
        {
            if (cui == null)
            {
                MessageBox.Show("CUI vacío");
                return true;
            }
            if (!HasValidFormat(cui))
                MessageBox.Show("El CUI debe tener exactamente 13 dígitos y no puede contener espacios en blanco, signos de puntuación ni letras."); string cuiNumber = cui.Substring(0, 8);
            string cheker = cui.Substring(8, 1);
            string stateCodeString = cui.Substring(9, 2);
            string cityCodeString = cui.Substring(11, 2); int stateCode = int.Parse(stateCodeString);
            int cityCode = int.Parse(cityCodeString);
            int checkerCode = int.Parse(cheker);
            int[] stateCityCounts = new int[]
            {
/* 01 - Guatemala: */ 17 /* municipios. */,
/* 02 - El Progreso: */ 8 /* municipios. */,
/* 03 - Sacatepéquez: */ 16 /* municipios. */,
/* 04 - Chimaltenango: */ 16 /* municipios. */,
/* 05 - Escuintla: */ 13 /* municipios. */,
/* 06 - Santa Rosa: */ 14 /* municipios. */,
/* 07 - Sololá: */ 19 /* municipios. */,
/* 08 - Totonicapán: */ 8 /* municipios. */,
/* 09 - Quetzaltenango: */ 24 /* municipios. */,
/* 10 - Suchitepéquez: */ 21 /* municipios. */,
/* 11 - Retalhuleu: */ 9 /* municipios. */,
/* 12 - San Marcos: */ 30 /* municipios. */,
/* 13 - Huehuetenango: */ 32 /* municipios. */,
/* 14 - Quiché: */ 21 /* municipios. */,
/* 15 - Baja Verapaz: */ 8 /* municipios. */,
/* 16 - Alta Verapaz: */ 17 /* municipios. */,
/* 17 - Petén: */ 14 /* municipios. */,
/* 18 - Izabal: */ 5 /* municipios. */,
/* 19 - Zacapa: */ 11 /* municipios. */,
/* 20 - Chiquimula: */ 11 /* municipios. */,
/* 21 - Jalapa: */ 7 /* municipios. */,
/* 22 - Jutiapa: */ 17 /* municipios. */
            }; if (stateCode == 0 || cityCode == 0)
            {
                Trace.TraceInformation("{0}: Código de departamento o de municipio incorrectos", cui);
                return false;
            }
            if (stateCode > stateCityCounts.Length || cityCode > stateCityCounts.Max())
            {
                Trace.TraceInformation("{0}: Código de departamento o de municipio fuera del rango", cui);
                return false;
            }
            if (cityCode > stateCityCounts[stateCode - 1])
            {
                Trace.TraceInformation("{0}: Código de municipio incorrecto", cui);
                return false;
            } // Se verifica el correlativo con base en algoritmo del complemento 11.
            int total = 0; // notar que se ignora el primer dígito
            for (int i = 0; i < cuiNumber.Length; i++)
            {
                total += cuiNumber[i] * (i + 2);
            }
            int modulus = (total % 11); var valid = checkerCode == modulus; if (!valid)
            {
                Trace.TraceInformation("{0}: Módulo {1} distinto a {2}", cui, modulus, checkerCode);
            }
            return valid;
        }


private void textBox1_Leave(object sender, EventArgs e)
        {
           
        }

        private void Formclientea_Leave(object sender, EventArgs e)
        {

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

        private void txtedad_TextChanged(object sender, EventArgs e)
        {

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

        private void txtdpi_KeyPress(object sender, KeyPressEventArgs e)
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
