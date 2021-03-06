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
    public partial class FormUsuario : Form
    {
        private static FormUsuario _instancia;
        public FormUsuario()
        {
            InitializeComponent();
        }

        public static FormUsuario GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new FormUsuario();
            }
            return _instancia;
        }
        private void OcultarColumnas()
        {
            this.dataUsuarios.Columns[0].Visible = false;
            this.dataUsuarios.Columns[1].Visible = false;
        }

        public void Mostrar()
        {
            this.dataUsuarios.DataSource = Nusuarios.Mostrar();
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
            FormUsuarioInsert form = new FormUsuarioInsert();
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
                this.dataUsuarios.DataSource = Nusuarios.BuscarApellidos(this.textBox1.Text);
                this.OcultarColumnas();
            }
           
        }

        private void datacliente_DoubleClick(object sender, EventArgs e)
        {
            FormUsuarioEdit formp = new FormUsuarioEdit();
            string varp1, varp2, varp3, varp5, varp4,varp6;
            int varp;

            varp = Convert.ToInt32(this.dataUsuarios.CurrentRow.Cells["id"].Value);
            varp1 = Convert.ToString(this.dataUsuarios.CurrentRow.Cells["Nombres"].Value);
            varp2 = Convert.ToString(this.dataUsuarios.CurrentRow.Cells["Apellidos"].Value);
            varp3 = Convert.ToString(this.dataUsuarios.CurrentRow.Cells["Correo"].Value);
            varp4 = Convert.ToString(this.dataUsuarios.CurrentRow.Cells["Usuario"].Value);
            varp5 = Convert.ToString(this.dataUsuarios.CurrentRow.Cells["Contraseña"].Value);
            varp6 = Convert.ToString(this.dataUsuarios.CurrentRow.Cells["Rol"].Value);
        
            formp.setcliente(varp, varp1, varp2, varp3, varp4, varp5, varp6);
            formp.Show();
            formp.TopLevel = true;
            formp.BringToFront();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {

                textBox1.Text = "buscar";


            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text != "buscar")
            {

                textBox1.Text = "";


            }
        }
    }
}
