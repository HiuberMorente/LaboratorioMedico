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

namespace PRESENTACION.clientes
{
    public partial class Forminsumosedit : Form
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
        public Forminsumosedit()
        {
            InitializeComponent();
        
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        public void setinsumos(int varp,string varp1, string varp2,string varp3,decimal varp4,string varp5,string varp6)
            {


            this.txtid.Text = Convert.ToString(varp);
            this.cbproveedor.Text = varp1;
            this.txtinsumo.Text = varp2;
            this.txtprecio.Text = Convert.ToString(varp4);
            this.cbestado.Text = Convert.ToString(varp5);
            this.txtdescripcion.Text = varp3;
            this.txtcodigo.Text = varp6;
    

        }
        private void Formclientea_Load(object sender, EventArgs e)
        {
            LlenarComboProveedor();
        }

        private void LlenarComboProveedor()
        {
            cbproveedor.DataSource = Nproveedor.Mostrar();
            cbproveedor.ValueMember = "Id";
            cbproveedor.DisplayMember = "Nombre";

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
                if (this.txtinsumo.Text == string.Empty)
                {

                
                }
                else
                {
                    if (this.Esnuevo)
                    {
                        //Vamos a insertar un producto
                        Respuesta = Ninsumos.Editar(Convert.ToInt32(this.txtid.Text), Convert.ToInt32(cbproveedor.SelectedValue), this.txtinsumo.Text.Trim().ToUpper(),
                                   this.txtdescripcion.Text, Convert.ToDecimal(this.txtprecio.Text),this.cbestado.Text,this.txtcodigo.Text);

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

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtdescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtestado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
