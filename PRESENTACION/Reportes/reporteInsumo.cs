using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRESENTACION
{
    public partial class reporte_insumo : Form
    {
        public reporte_insumo()
        {
            InitializeComponent();
        }

        private void reporte_insumo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet2.mostrar_insumos' Puede moverla o quitarla según sea necesario.
            this.mostrar_insumosTableAdapter.Fill(this.DataSet2.mostrar_insumos);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
