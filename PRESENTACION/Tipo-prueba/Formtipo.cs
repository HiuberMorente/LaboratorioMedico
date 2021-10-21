using System;
using System.Windows.Forms;
using NEGOCIO;

namespace PRESENTACION.pruebas
{
    public partial class Formtipo : Form
    {

        private static Formtipo _instancia;
     

        public Formtipo()
        {
            InitializeComponent();
        }

        public static Formtipo GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new Formtipo();
            }
            return _instancia;
        }

        private void OcultarColumnas()
        {
            this.dataPruebas.Columns[0].Visible = false;

        }

        public void Mostrar()
        {
            this.dataPruebas.DataSource = Ntipoprueba.Mostrar();
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
            FormtipoAgregar form = new FormtipoAgregar();
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
            this.dataPruebas.DataSource = Ntipoprueba.BuscarTipo(this.textBuscar.Text);
            this.OcultarColumnas();
        }

        private void datacliente_DoubleClick(object sender, EventArgs e)
        {
            FormtipoEditar formp = new FormtipoEditar();
            string varp2,varp1;
            int varp;


            varp = Convert.ToInt32(this.dataPruebas.CurrentRow.Cells["Id"].Value);
            varp1 = Convert.ToString(this.dataPruebas.CurrentRow.Cells["Nombre"].Value);
            varp2 = Convert.ToString(this.dataPruebas.CurrentRow.Cells["Descripción"].Value);



            formp.Settipoprueba(varp, varp1, varp2);
            formp.Show();
            formp.TopLevel = true;
            formp.BringToFront();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
