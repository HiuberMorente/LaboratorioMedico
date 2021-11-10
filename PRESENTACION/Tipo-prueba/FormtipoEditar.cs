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

namespace PRESENTACION.pruebas
{
    public partial class FormtipoEditar : Form
    {
        private bool Esnuevo = true;
        private void MensajeOK(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema De Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Para mostrar mensaje de error
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema De Inventario", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public FormtipoEditar()
        {
            InitializeComponent();
        
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        public void Settipoprueba(int varp,string varp1, string varp2)
            {


            this.txtid.Text = Convert.ToString(varp);
            this.txtnombre.Text = varp1;
            this.txtdescripcion.Text = varp2;
     
    

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
                if (this.txtnombre.Text == string.Empty|| this.txtdescripcion.Text == string.Empty)
                {

                
                }
                else
                {
                    if (this.Esnuevo)
                    {
                        //Vamos a insertar un producto
                        Respuesta = Ntipoprueba.Editar(Convert.ToInt32(this.txtid.Text), this.txtnombre.Text.Trim().ToUpper(),
                                   this.txtdescripcion.Text);

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
   
                    Formtipo far = Formtipo.GetInstancia();
                    far.Mostrar();
                    this.Close();



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

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttelempresa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtinsumo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
