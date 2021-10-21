using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capacomun.Cache;
using NEGOCIO;



namespace PRESENTACION
{
    public partial class Formcompras : Form
    {
        private bool IsNuevo = true;

        private int idus = Cachesesionuser.Id; 

        private DataTable dtDetalle;

        private decimal totalPagado = 0;

        private static Formcompras _instancia;


        //Creamos una instancia para poder utilizar los
        //Objetos del formulario
        public static Formcompras GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new Formcompras();
            }
            return _instancia;
        }



        //Mostrar Mensaje de Confirmación
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema De Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        //Mostrar Mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema De Inventario", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Limpiar todos los controles del formulario
        private void Limpiar()
        {
            this.txtidcompra.Text = string.Empty;
            this.txtidproveedor.Text = string.Empty;
            //this.txtserie.Text = string.Empty;
            //this.txtcorrelativo.Text = string.Empty;
            this.txtlote.Text = string.Empty; ;
            this.lbtotalpaga.Text = "0,0";
            this.crearTabla();

        }

        private void limpiarDetalle()
        {
            this.txtidproducto.Text = string.Empty;
            this.txtproducto.Text = string.Empty;
            this.txtcantidad.Text = string.Empty;
            this.txtprecio.Text = string.Empty;

        }

        //Habilitar los controles del formulario
     

       



        //Método BuscarDetalles
        private void MostrarDetalles()
        {
            this.datadetalle.DataSource = Ncompra.MostrarDetalle(Convert.ToInt32(this.txtidcompra.Text));


        }

        


        //Crea la tabla de Detalle 
        private void crearTabla()
        {
            //Crea la tabla con el nombre de Detalle
            this.dtDetalle = new DataTable("Detalle");
            //Agrega las columnas que tendra la tabla
            this.dtDetalle.Columns.Add("idinsumo", System.Type.GetType("System.Int32"));
            this.dtDetalle.Columns.Add("Insumo", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("Fecha de Fabricación", System.Type.GetType("System.DateTime"));
            this.dtDetalle.Columns.Add("Fecha de Vencimiento", System.Type.GetType("System.DateTime"));
            this.dtDetalle.Columns.Add("Cantidad", System.Type.GetType("System.Int32"));
            this.dtDetalle.Columns.Add("Sub-total", System.Type.GetType("System.Decimal"));
            this.dtDetalle.Columns.Add("Total", System.Type.GetType("System.Decimal"));
            this.dtDetalle.Columns.Add("stock", System.Type.GetType("System.Int32"));

            //Relacionamos nuestro datagridview con nuestro datatable
            this.datadetalle.DataSource = this.dtDetalle;
           

        }
       
        private void LlenarComboProveedor()
        {
            comboBox2.DataSource = Nproveedor.Mostrar();
            comboBox2.ValueMember = "Id";
            comboBox2.DisplayMember = "Nombre";
           
        }

        public void setproductos(int v1, string v2)
        {
            this.txtidproducto.Text = Convert.ToString(v1);
            this.txtproducto.Text = Convert.ToString(v2);

        }




        public Formcompras()
        {
            InitializeComponent();
            LlenarComboProveedor();
      
        }

        private void Formventas_Load(object sender, EventArgs e)
        {
            Mostrarventa();
            this.crearTabla();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    
        private void btnnueva_Click(object sender, EventArgs e)
        {
           
        }

        private void Mostrarventa()
        {
         
            
        }

        private void txtproducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {

                if ( this.txtcantidad.Text == string.Empty || txtprecio.Text == string.Empty )
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                    erroricon.SetError(txtcantidad, "Ingrese el stock inicial");
                    erroricon.SetError(txtprecio, "Ingrese el precio de Compra");
               
                }
                else
                {
        

                        //Variable que va a indicar si podemos registrar el detalle
                        bool registrar = true;
                    foreach (DataRow row in dtDetalle.Rows)
                    {
                        if (Convert.ToInt32(row["idinsumo"]) == Convert.ToInt32(this.txtidproducto.Text))
                        {
                            registrar = false;
                            this.MensajeError("Ya se encuentra el producto en el detalle");
                        }
                    }
                    //Si podemos registrar el producto en el detalle
                    if (registrar)
                    {
                        //Calculamos el sub total del detalle sin descuento
                        decimal subTotal = Convert.ToDecimal(this.txtprecio.Text) * Convert.ToDecimal(txtcantidad.Text);
                        totalPagado = totalPagado + subTotal;
                        this.lbtotalpaga.Text = totalPagado.ToString("#0.00#");
                        //Agregamos al fila a nuestro datatable
                        DataRow row = this.dtDetalle.NewRow();
                        row["idinsumo"] = Convert.ToInt32(this.txtidproducto.Text);
                        row["Insumo"] = this.txtproducto.Text;
                        row["Fecha de Fabricación"] = this.dtfabri.Value;
                        row["Fecha de Vencimiento"] = this.dtvencimento.Value;
                        row["Cantidad"] = Convert.ToInt32(this.txtcantidad.Text);
                        row["Sub-total"] = Convert.ToDecimal(this.txtprecio.Text);
                        row["Total"] = subTotal;
                        row["stock"] = Convert.ToInt32(this.txtcantidad.Text);
                        this.dtDetalle.Rows.Add(row);
                        this.limpiarDetalle();
                    }
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnquitar_Click(object sender, EventArgs e)
        {

            try
            {
                //Indice dila actualmente seleccionado y que vamos a eliminar
                int indiceFila = this.datadetalle.CurrentCell.RowIndex;
                //Fila que vamos a eliminar
                DataRow row = this.dtDetalle.Rows[indiceFila];
                //Disminuimos el total a pagar
                this.totalPagado = this.totalPagado - Convert.ToDecimal(row["Sub-total"].ToString());
                this.lbtotalpaga.Text = totalPagado.ToString("#0.00#");
                //Removemos la fila
                this.dtDetalle.Rows.Remove(row);
            }
            catch (Exception ex)
            {
                MensajeError("No hay fila para remover");
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {


            try
            {

                //La variable que almacena si se inserto 
                //o se modifico la tabla
                string Rpta = "";
                if ( /*this.txtserie.Text == string.Empty || txtcorrelativo.Text == string.Empty ||*/ txtlote.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                    //erroricon.SetError(txtserie, "Ingrese la serie del comprobante");
                    //erroricon.SetError(txtcorrelativo, "Ingrese el número del comprobante");
                    erroricon.SetError(txtlote, "Ingrese el porcentaje de IGV");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        //Vamos a insertar un Ingreso
                        Rpta = Ncompra.Insertar( Convert.ToInt32(comboBox2.SelectedValue),
                        Convert.ToDateTime(dtfecha.Value), Convert.ToDecimal(lbtotalpaga.Text),txtobservaciones.Text,txtcomprobante.Text,
                        "HECHA", txtlote.Text,idus, dtDetalle);

                    }

                    //Si la respuesta fue OK, fue porque se modifico 
                    //o inserto el Ingreso
                    //de forma correcta
                    if (Rpta.Equals("OK"))
                    {

                        this.MensajeOk("Se insertó de forma correcta el registro");


                    }
                    else
                    {
                        //Mostramos el mensaje de error
                        this.MensajeError(Rpta);
                    }
                    Formcompra frm = Formcompra.GetInstancia();
                    frm.Mostrar();
                    this.Limpiar();
                    this.limpiarDetalle();
                    this.Close();

                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtidproveedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnbuscarproduct_Click(object sender, EventArgs e)
        {
            Formcomprasproductos formcon = new Formcomprasproductos();
            formcon.Show();
            formcon.TopLevel = true;
            formcon.BringToFront();
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Formcompras_FormClosing(object sender, FormClosingEventArgs e)
        {
            _instancia = null;
        }

        private void datadetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void datadetalle_DoubleClick(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void datadetalle_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtpreciocompra_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtcantidad_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtcantidad.Text, "  ^ [0-9]"))
            {
                txtcantidad.Text = "";
            }
        }

        private void txtlote_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ISR_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
