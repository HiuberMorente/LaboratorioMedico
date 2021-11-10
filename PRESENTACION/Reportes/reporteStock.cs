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
    public partial class reporteStock : Form
    {
        public reporteStock()
        {
            InitializeComponent();
        }

        private void reporteStock_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.mostrar_stockReporte' Puede moverla o quitarla según sea necesario.
            this.mostrar_stockReporteTableAdapter.Fill(this.DataSet1.mostrar_stockReporte);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
