using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DOMINIO;

namespace PRESENTACION.usuarios
{
    public partial class FormUsuarioEdit : Form
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
        public FormUsuarioEdit()
        {
            InitializeComponent();
        
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        public void setcliente(int varp,string varp1, string varp2,int varp3,string varp4,string varp5,string varp6,string varp7,string varp8)
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
                    FormUsuario fral = FormUsuario.GetInstancia();
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
    }
}
