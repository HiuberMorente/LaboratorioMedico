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
    public partial class Formcliente : Form
    {
        private static Formcliente _instancia;
        public Formcliente()
        {
            InitializeComponent();
        }

        public static Formcliente GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new Formcliente();
            }
            return _instancia;
        }
        private void OcultarColumnas()
        {
            this.datacliente.Columns[0].Visible = false;
            this.datacliente.Columns[1].Visible = false;
        }

        public void Mostrar()
        {
            this.datacliente.DataSource = Ncliente.Mostrar();
            this.OcultarColumnas();
      
        }

       



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Formcliente_Load(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formclientea form = new Formclientea();
            form.Show();
            form.TopLevel = true;
            form.BringToFront();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "Buscar")
            {
                this.datacliente.DataSource = Ncliente.BuscarApellidos(this.textBox1.Text);
                this.OcultarColumnas();
                


            }

        }

        private void datacliente_DoubleClick(object sender, EventArgs e)
        {
            try //boque try con todas las operaciones
            {
                Formclienteedit formp = new Formclienteedit();
                string varp1, varp2, varp5, varp4, varp6, varp7, varp8;
                int varp, varp3;

                varp = Convert.ToInt32(this.datacliente.CurrentRow.Cells["id"].Value);
                varp1 = Convert.ToString(this.datacliente.CurrentRow.Cells["Nombre"].Value);
                varp2 = Convert.ToString(this.datacliente.CurrentRow.Cells["Apellido"].Value);
                varp3 = Convert.ToInt32(this.datacliente.CurrentRow.Cells["Edad"].Value);
                varp4 = Convert.ToString(this.datacliente.CurrentRow.Cells["Dpi"].Value);
                varp5 = Convert.ToString(this.datacliente.CurrentRow.Cells["Nit"].Value);
                varp6 = Convert.ToString(this.datacliente.CurrentRow.Cells["telefono"].Value);
                varp7 = Convert.ToString(this.datacliente.CurrentRow.Cells["Direccion"].Value);
                varp8 = Convert.ToString(this.datacliente.CurrentRow.Cells["Correo"].Value);
                formp.setcliente(varp, varp1, varp2, varp3, varp4, varp5, varp6, varp7, varp8);
                formp.Show();
                formp.TopLevel = true;
                formp.BringToFront();
            }
            catch (Exception ex) //bloque catch para captura de error
            { }
                      
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text != "buscar")
            {

                textBox1.Text = "";


            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {

                textBox1.Text = "buscar";


            }
        }

        private void Formcliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            _instancia = null;
        }
    }
}
