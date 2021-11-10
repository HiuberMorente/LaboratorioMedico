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
using PRESENTACION.usuarios;

namespace PRESENTACION.usuarios 
{
    public partial class FormUsuarioInsert : Form
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

        private void LlenarComborol()
        {
            cbrol.DataSource = Nusuarios.Mostrarrol();
            cbrol.ValueMember = "id";
            cbrol.DisplayMember = "Rol";

        }
        public FormUsuarioInsert()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

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
                        Respuesta = Nusuarios.Insertar(Convert.ToString(this.txtnombre.Text),
                                    Convert.ToString(this.txtapellido.Text), Convert.ToString(this.txtEmail.Text), Convert.ToString(this.txtUser.Text), Convert.ToString(this.txtPass.Text),
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

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
