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
    public partial class mov : Form
    {
       private  string fecha1;
       private string fecha2;

        public mov()
        {
            InitializeComponent();
        }

        public string Fecha1 { get => fecha1; set => fecha1 = value; }
        public string Fecha2 { get => fecha2; set => fecha2 = value; }

        private void mov_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetMovimiento.buscar_movimientofecha' Puede moverla o quitarla según sea necesario.
            this.buscar_movimientofechaTableAdapter.Fill(this.DataSetMovimiento.buscar_movimientofecha,Fecha1,fecha2);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
