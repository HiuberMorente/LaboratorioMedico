using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRESENTACION.Reportes
{
    public partial class Pruebas : Form
    {
        private string fecha1;
        private string fecha2;

        public Pruebas()
        {
            InitializeComponent();
        }

        private void Pruebas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetPruebas.Buscar_pruebafechaRealizadaReporte' Puede moverla o quitarla según sea necesario.
            this.Buscar_pruebafechaRealizadaReporteTableAdapter.Fill(this.DataSetPruebas.Buscar_pruebafechaRealizadaReporte,fecha1,fecha2);

            this.reportViewer1.RefreshReport();

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            this.Buscar_pruebafechaRealizadaReporteTableAdapter.Fill(this.DataSetPruebas.Buscar_pruebafechaRealizadaReporte, this.dtfecha1.Value.ToString("MM/dd/yyyy"), this.dtfecha2.Value.ToString("MM/dd/yyyy"));
            this.reportViewer1.RefreshReport();
        }
    }
}
