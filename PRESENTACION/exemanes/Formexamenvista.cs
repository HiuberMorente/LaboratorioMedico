using System;
using System.Windows.Forms;
using NEGOCIO;

namespace PRESENTACION.clientes
{
    public partial class Formexamenvista : Form
    {

        private static Formproveedor _instancia;
        Formproveedoreedit formp = new Formproveedoreedit();

        public Formexamenvista()
        {
            InitializeComponent();
        }

        public static Formproveedor GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new Formproveedor();
            }
            return _instancia;
        }

        private void OcultarColumnas()
        {
            this.dataproveedor.Columns[0].Visible = false;
            this.dataproveedor.Columns[1].Visible = false;
        }

        public void Mostrar()
        {
            this.dataproveedor.DataSource = Nproveedor.Mostrar();
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
            Formproveedores1 form = new Formproveedores1();
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
            this.dataproveedor.DataSource = Nproveedor.BuscarNombre(this.textBox1.Text);
            this.OcultarColumnas();
        }

        private void datacliente_DoubleClick(object sender, EventArgs e)
        {
         
            //string varp1, varp2, varp5,varp6,varp7;
            //int varp,varp3,varp4;

            //varp = Convert.ToInt32(this.dataproveedor.CurrentRow.Cells["id"].Value);
            //varp1 = Convert.ToString(this.dataproveedor.CurrentRow.Cells["Nombre"].Value);
            //varp2 = Convert.ToString(this.dataproveedor.CurrentRow.Cells["Contacto"].Value);
            //varp3 = Convert.ToInt32(this.dataproveedor.CurrentRow.Cells["telefonoEmpresa"].Value);
            //varp4 = Convert.ToInt32(this.dataproveedor.CurrentRow.Cells["telefonoContacto"].Value);
            //varp5 = Convert.ToString(this.dataproveedor.CurrentRow.Cells["Correo"].Value);
            //varp6 = Convert.ToString(this.dataproveedor.CurrentRow.Cells["Direccion"].Value);
            //varp7 = Convert.ToString(this.dataproveedor.CurrentRow.Cells["Descripcion"].Value);
            //formp.setproveedor(varp, varp1, varp2, varp3, varp4,varp5,varp6,varp7);
            //formp.Show();
            //formp.TopLevel = true;
            //formp.BringToFront();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
