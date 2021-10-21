
namespace PRESENTACION
{
    partial class Formpruebas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbltotal = new System.Windows.Forms.Label();
            this.datacompra = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.dtfecha1 = new System.Windows.Forms.DateTimePicker();
            this.dtfecha2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.erroricon = new System.Windows.Forms.ErrorProvider(this.components);
            this.ttmensaje = new System.Windows.Forms.ToolTip(this.components);
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.cbbusqueda = new System.Windows.Forms.ComboBox();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datacompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroricon)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltotal
            // 
            this.lbltotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(698, 145);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(35, 13);
            this.lbltotal.TabIndex = 20;
            this.lbltotal.Text = "label1";
            // 
            // datacompra
            // 
            this.datacompra.AllowUserToAddRows = false;
            this.datacompra.AllowUserToDeleteRows = false;
            this.datacompra.AllowUserToOrderColumns = true;
            this.datacompra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datacompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datacompra.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.datacompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datacompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.datacompra.Location = new System.Drawing.Point(12, 164);
            this.datacompra.Name = "datacompra";
            this.datacompra.ReadOnly = true;
            this.datacompra.Size = new System.Drawing.Size(760, 337);
            this.datacompra.TabIndex = 18;
            this.datacompra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataarea_CellContentClick);
            this.datacompra.DoubleClick += new System.EventHandler(this.datacompra_DoubleClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Anular";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(320, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 37);
            this.label7.TabIndex = 13;
            this.label7.Text = "Pruebas";
            // 
            // dtfecha1
            // 
            this.dtfecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfecha1.Location = new System.Drawing.Point(298, 75);
            this.dtfecha1.Name = "dtfecha1";
            this.dtfecha1.Size = new System.Drawing.Size(100, 20);
            this.dtfecha1.TabIndex = 21;
            // 
            // dtfecha2
            // 
            this.dtfecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfecha2.Location = new System.Drawing.Point(477, 75);
            this.dtfecha2.Name = "dtfecha2";
            this.dtfecha2.Size = new System.Drawing.Size(97, 20);
            this.dtfecha2.TabIndex = 22;
            this.dtfecha2.ValueChanged += new System.EventHandler(this.dtfecha2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(409, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Hasta";
            // 
            // erroricon
            // 
            this.erroricon.ContainerControl = this;
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.ForeColor = System.Drawing.Color.Black;
            this.btnagregar.Image = global::PRESENTACION.Properties.Resources.addbox;
            this.btnagregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnagregar.Location = new System.Drawing.Point(351, 111);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(107, 33);
            this.btnagregar.TabIndex = 25;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.Image = global::PRESENTACION.Properties.Resources.searchbox;
            this.btnbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbuscar.Location = new System.Drawing.Point(235, 111);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(110, 33);
            this.btnbuscar.TabIndex = 15;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // cbbusqueda
            // 
            this.cbbusqueda.FormattingEnabled = true;
            this.cbbusqueda.Items.AddRange(new object[] {
            "Cliente",
            "Tipo De Prueba",
            "Prueba",
            "Fecha De Solicitud",
            "Fecha Realizada",
            "Fecha De Validez"});
            this.cbbusqueda.Location = new System.Drawing.Point(89, 75);
            this.cbbusqueda.Name = "cbbusqueda";
            this.cbbusqueda.Size = new System.Drawing.Size(121, 21);
            this.cbbusqueda.TabIndex = 27;
            this.cbbusqueda.Text = "Fecha De Solicitud";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(89, 119);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(121, 20);
            this.txtbuscar.TabIndex = 28;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // Formpruebas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(784, 513);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.cbbusqueda);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtfecha2);
            this.Controls.Add(this.dtfecha1);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.datacompra);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.label7);
            this.Name = "Formpruebas";
            this.Text = "Formcompra";
            this.Load += new System.EventHandler(this.Formcompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datacompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroricon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.DataGridView datacompra;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.DateTimePicker dtfecha1;
        private System.Windows.Forms.DateTimePicker dtfecha2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider erroricon;
        private System.Windows.Forms.ToolTip ttmensaje;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.ComboBox cbbusqueda;
        private System.Windows.Forms.TextBox txtbuscar;
    }
}