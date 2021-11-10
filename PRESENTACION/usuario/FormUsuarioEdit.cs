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

namespace PRESENTACION.usuarios
{
    public partial class FormUsuarioEdit : Form
    {
        private bool EsNuevo = true;
        private void MensajeOK(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema De Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Para mostrar mensaje de error
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema De Inventario", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public FormUsuarioEdit()
        {
            InitializeComponent();
        
        }
        private void LlenarComborol()
        {
            cbrol.DataSource = Nusuarios.Mostrarrol();
            cbrol.ValueMember = "id";
            cbrol.DisplayMember = "Rol";
        }
            private void label4_Click(object sender, EventArgs e)
        {

        }
        public void setcliente(int varp,string varp1, string varp2,string varp3,string varp4,string varp5,string varp6)
            {


            this.txtunir.Text = Convert.ToString(varp);
            this.txtnombre.Text = varp1;
            this.txtapellido.Text = varp2;
            this.txtEmail.Text = Convert.ToString(varp3);
            this.txtUser.Text = varp4;
            this.txtPass.Text = varp5;
            this.cbrol.Text = varp6;
         

        }
        private void Formclientea_Load(object sender, EventArgs e)
        {
            LlenarComborol();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
       

            //try
            //{

            //    //La variable que almacena si se inserto
            //    //o se modifico la tabla
            //    string Respuesta = "";
            //    if (this.txtnombre.Text == string.Empty)
            //    {

                
            //    }
            //    else
            //    {
            //        if (this.Esnuevo)
            //        {
            //            //Vamos a insertar un producto
            //            Respuesta = Ncliente.Editar(Convert.ToInt32(this.txtid.Text), this.txtnombre.Text.Trim().ToUpper(),
            //                       this.txtapellido.Text, Convert.ToInt32(this.txtedad.Text), this.txtdpi.Text, this.txtnit.Text, this.txttelefono.Text,
            //                       this.txtdireccion.Text, this.txtcorreo.Text);

            //        }
                 
            //        if (Respuesta.Equals("OK"))
            //        {
            //            if (this.Esnuevo)
            //            {
            //                this.MensajeOK("Se actualizó de forma correcta el registro");
            //            }
                      

            //        }
            //        else
            //        {
            //            //Mostramos el mensaje de error
            //            this.MensajeError(Respuesta);
            //        }
            //        this.Esnuevo = false;
            //        FormUsuario fral = FormUsuario.GetInstancia();
            //        fral.Mostrar();




            //        this.Hide();

            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message + ex.StackTrace);
            //}

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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
           
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
                    if (this.EsNuevo)
                    {

                        //Vamos a insertar un producto
                        Respuesta = Nusuarios.Editar(Convert.ToInt32(this.txtunir.Text),this.txtnombre.Text.Trim().ToUpper(),
                                   this.txtapellido.Text, Convert.ToString(this.txtEmail.Text), this.txtUser.Text, this.txtPass.Text,
                                   Convert.ToInt32(this.cbrol.SelectedValue));

                    }

                    if (Respuesta.Equals("OK"))
                    {
                        if (this.EsNuevo)
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

                    FormUsuario fral = FormUsuario.GetInstancia();
                    fral.Mostrar();

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
