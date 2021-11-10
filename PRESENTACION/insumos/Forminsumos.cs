using System;
using System.Windows.Forms;
using NEGOCIO;
using PRESENTACION;

namespace PRESENTACION.clientes
{
    public partial class Forminsumos : Form
    {

        private static Forminsumos _instancia;
        Forminsumosedit formp = new Forminsumosedit();

        public Forminsumos()
        {
            InitializeComponent();
        }

        public static Forminsumos GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new Forminsumos();
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
            this.dataproveedor.DataSource = Ninsumos.Mostrar();
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
            Forminsumos1 form = new Forminsumos1();
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
                this.dataproveedor.DataSource = Ninsumos.Buscarinsumos(this.textBox1.Text);
                this.OcultarColumnas();
            }
      
        }

        private void datacliente_DoubleClick(object sender, EventArgs e)
        {

            string varp2, varp3, varp1, varp5,varp6;
            int varp;
            decimal varp4;

            varp = Convert.ToInt32(this.dataproveedor.CurrentRow.Cells["id"].Value);
            varp1 = Convert.ToString(this.dataproveedor.CurrentRow.Cells["Proveedor"].Value);
            varp2 = Convert.ToString(this.dataproveedor.CurrentRow.Cells["Insumo"].Value);
            varp3 = Convert.ToString(this.dataproveedor.CurrentRow.Cells["Descripción"].Value);
            varp4 = Convert.ToDecimal(this.dataproveedor.CurrentRow.Cells["Precio"].Value);
            varp5 = Convert.ToString(this.dataproveedor.CurrentRow.Cells["Estado"].Value);
            varp6 = Convert.ToString(this.dataproveedor.CurrentRow.Cells["Código"].Value);


            formp.setinsumos(varp, varp1, varp2, varp3, varp4,varp5,varp6);
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            reporte_insumo insumo = new reporte_insumo();
            insumo.Show();
        }
    }
}
