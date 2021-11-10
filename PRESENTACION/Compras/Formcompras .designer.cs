
namespace PRESENTACION
{
    partial class Formcompras
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
            this.txtidproveedor = new System.Windows.Forms.TextBox();
            this.txtlote = new System.Windows.Forms.TextBox();
            this.ISR = new System.Windows.Forms.Label();
            this.dtfecha = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.txtidproducto = new System.Windows.Forms.TextBox();
            this.txtidcompra = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lbtotalpaga = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ttmensaje = new System.Windows.Forms.ToolTip(this.components);
            this.erroricon = new System.Windows.Forms.ErrorProvider(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.datadetalle = new System.Windows.Forms.DataGridView();
            this.txtcomprobante = new System.Windows.Forms.TextBox();
            this.txtobservaciones = new System.Windows.Forms.TextBox();
            this.Ovservaciones = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblptotal = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtvencimento = new System.Windows.Forms.DateTimePicker();
            this.dtfabri = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnbuscarproduct = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnquitar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.erroricon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datadetalle)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtidproveedor
            // 
            this.txtidproveedor.AcceptsReturn = true;
            this.txtidproveedor.Location = new System.Drawing.Point(328, 15);
            this.txtidproveedor.Name = "txtidproveedor";
            this.txtidproveedor.ReadOnly = true;
            this.txtidproveedor.Size = new System.Drawing.Size(38, 20);
            this.txtidproveedor.TabIndex = 53;
            this.txtidproveedor.Visible = false;
            this.txtidproveedor.TextChanged += new System.EventHandler(this.txtidproveedor_TextChanged);
            // 
            // txtlote
            // 
            this.txtlote.Location = new System.Drawing.Point(109, 73);
            this.txtlote.Name = "txtlote";
            this.txtlote.Size = new System.Drawing.Size(109, 20);
            this.txtlote.TabIndex = 51;
            this.txtlote.TextChanged += new System.EventHandler(this.txtlote_TextChanged);
            // 
            // ISR
            // 
            this.ISR.AutoSize = true;
            this.ISR.Location = new System.Drawing.Point(46, 76);
            this.ISR.Name = "ISR";
            this.ISR.Size = new System.Drawing.Size(48, 13);
            this.ISR.TabIndex = 50;
            this.ISR.Text = "Lote No.";
            this.ISR.Click += new System.EventHandler(this.ISR_Click);
            // 
            // dtfecha
            // 
            this.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfecha.Location = new System.Drawing.Point(109, 125);
            this.dtfecha.Name = "dtfecha";
            this.dtfecha.Size = new System.Drawing.Size(109, 20);
            this.dtfecha.TabIndex = 46;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 13);
            this.label12.TabIndex = 42;
            this.label12.Text = "Comprobante No.";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // txtidproducto
            // 
            this.txtidproducto.Location = new System.Drawing.Point(224, 15);
            this.txtidproducto.Name = "txtidproducto";
            this.txtidproducto.Size = new System.Drawing.Size(98, 20);
            this.txtidproducto.TabIndex = 45;
            this.txtidproducto.Visible = false;
            // 
            // txtidcompra
            // 
            this.txtidcompra.Location = new System.Drawing.Point(109, 15);
            this.txtidcompra.Name = "txtidcompra";
            this.txtidcompra.Size = new System.Drawing.Size(109, 20);
            this.txtidcompra.TabIndex = 40;
            this.txtidcompra.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(54, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 39;
            this.label15.Text = "Codigo";
            this.label15.Visible = false;
            // 
            // lbtotalpaga
            // 
            this.lbtotalpaga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbtotalpaga.AutoSize = true;
            this.lbtotalpaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtotalpaga.Location = new System.Drawing.Point(637, 473);
            this.lbtotalpaga.Name = "lbtotalpaga";
            this.lbtotalpaga.Size = new System.Drawing.Size(34, 20);
            this.lbtotalpaga.TabIndex = 71;
            this.lbtotalpaga.Text = "0.0";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(528, 473);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 63;
            this.label4.Text = "Total Q";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(12, 226);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(68, 17);
            this.checkBox2.TabIndex = 56;
            this.checkBox2.Text = "Eliminara";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(293, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 45);
            this.label5.TabIndex = 78;
            this.label5.Text = "Compras";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // ttmensaje
            // 
            this.ttmensaje.IsBalloon = true;
            // 
            // erroricon
            // 
            this.erroricon.ContainerControl = this;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(109, 98);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(109, 21);
            this.comboBox2.TabIndex = 79;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(38, 101);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 43;
            this.label13.Text = "Proveedor";
            // 
            // datadetalle
            // 
            this.datadetalle.AllowUserToAddRows = false;
            this.datadetalle.AllowUserToDeleteRows = false;
            this.datadetalle.AllowUserToOrderColumns = true;
            this.datadetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datadetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datadetalle.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.datadetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datadetalle.Location = new System.Drawing.Point(12, 262);
            this.datadetalle.MultiSelect = false;
            this.datadetalle.Name = "datadetalle";
            this.datadetalle.RowTemplate.Height = 25;
            this.datadetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datadetalle.Size = new System.Drawing.Size(666, 189);
            this.datadetalle.TabIndex = 80;
            this.datadetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datadetalle_CellContentClick_1);
            this.datadetalle.DoubleClick += new System.EventHandler(this.datadetalle_DoubleClick);
            // 
            // txtcomprobante
            // 
            this.txtcomprobante.Location = new System.Drawing.Point(109, 45);
            this.txtcomprobante.Name = "txtcomprobante";
            this.txtcomprobante.Size = new System.Drawing.Size(109, 20);
            this.txtcomprobante.TabIndex = 81;
            // 
            // txtobservaciones
            // 
            this.txtobservaciones.Location = new System.Drawing.Point(224, 61);
            this.txtobservaciones.Multiline = true;
            this.txtobservaciones.Name = "txtobservaciones";
            this.txtobservaciones.Size = new System.Drawing.Size(142, 84);
            this.txtobservaciones.TabIndex = 83;
            // 
            // Ovservaciones
            // 
            this.Ovservaciones.AutoSize = true;
            this.Ovservaciones.Location = new System.Drawing.Point(257, 45);
            this.Ovservaciones.Name = "Ovservaciones";
            this.Ovservaciones.Size = new System.Drawing.Size(78, 13);
            this.Ovservaciones.TabIndex = 82;
            this.Ovservaciones.Text = "Observaciones";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 87;
            this.label7.Text = "Fecha";
            // 
            // lblptotal
            // 
            this.lblptotal.AutoSize = true;
            this.lblptotal.Location = new System.Drawing.Point(20, 107);
            this.lblptotal.Name = "lblptotal";
            this.lblptotal.Size = new System.Drawing.Size(62, 13);
            this.lblptotal.TabIndex = 41;
            this.lblptotal.Text = "Fabricación";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(33, 48);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 13);
            this.label17.TabIndex = 58;
            this.label17.Text = "Cantidad";
            // 
            // txtproducto
            // 
            this.txtproducto.Location = new System.Drawing.Point(89, 19);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.Size = new System.Drawing.Size(123, 20);
            this.txtproducto.TabIndex = 60;
            this.txtproducto.TextChanged += new System.EventHandler(this.txtproducto_TextChanged);
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(88, 45);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(124, 20);
            this.txtcantidad.TabIndex = 59;
            this.txtcantidad.TextChanged += new System.EventHandler(this.txtcantidad_TextChanged);
            this.txtcantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcantidad_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 67;
            this.label2.Text = "Precio ";
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(88, 71);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.ReadOnly = true;
            this.txtprecio.Size = new System.Drawing.Size(124, 20);
            this.txtprecio.TabIndex = 66;
            this.txtprecio.TextChanged += new System.EventHandler(this.txtpreciocompra_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 70;
            this.label6.Text = "Insumo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 84;
            this.label1.Text = "Vencimiento";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtvencimento
            // 
            this.dtvencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtvencimento.Location = new System.Drawing.Point(89, 127);
            this.dtvencimento.Name = "dtvencimento";
            this.dtvencimento.Size = new System.Drawing.Size(163, 20);
            this.dtvencimento.TabIndex = 85;
            // 
            // dtfabri
            // 
            this.dtfabri.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfabri.Location = new System.Drawing.Point(88, 101);
            this.dtfabri.Name = "dtfabri";
            this.dtfabri.Size = new System.Drawing.Size(162, 20);
            this.dtfabri.TabIndex = 88;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtidcompra);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtcomprobante);
            this.groupBox1.Controls.Add(this.txtobservaciones);
            this.groupBox1.Controls.Add(this.Ovservaciones);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtlote);
            this.groupBox1.Controls.Add(this.ISR);
            this.groupBox1.Controls.Add(this.txtidproducto);
            this.groupBox1.Controls.Add(this.txtidproveedor);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.dtfecha);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 161);
            this.groupBox1.TabIndex = 89;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Compra";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtproducto);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dtvencimento);
            this.groupBox2.Controls.Add(this.dtfabri);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnbuscarproduct);
            this.groupBox2.Controls.Add(this.txtcantidad);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txtprecio);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblptotal);
            this.groupBox2.Location = new System.Drawing.Point(409, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 161);
            this.groupBox2.TabIndex = 90;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnbuscarproduct
            // 
            this.btnbuscarproduct.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnbuscarproduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscarproduct.Image = global::PRESENTACION.Properties.Resources.searchbox1;
            this.btnbuscarproduct.Location = new System.Drawing.Point(218, 13);
            this.btnbuscarproduct.Name = "btnbuscarproduct";
            this.btnbuscarproduct.Size = new System.Drawing.Size(32, 32);
            this.btnbuscarproduct.TabIndex = 72;
            this.btnbuscarproduct.UseVisualStyleBackColor = false;
            this.btnbuscarproduct.Click += new System.EventHandler(this.btnbuscarproduct_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btncancelar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Image = global::PRESENTACION.Properties.Resources.danger;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancelar.Location = new System.Drawing.Point(163, 460);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(96, 35);
            this.btncancelar.TabIndex = 77;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnguardar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnguardar.Image = global::PRESENTACION.Properties.Resources.addbox;
            this.btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardar.Location = new System.Drawing.Point(41, 460);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(107, 35);
            this.btnguardar.TabIndex = 76;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnquitar
            // 
            this.btnquitar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnquitar.Image = global::PRESENTACION.Properties.Resources.menos__1_;
            this.btnquitar.Location = new System.Drawing.Point(645, 226);
            this.btnquitar.Name = "btnquitar";
            this.btnquitar.Size = new System.Drawing.Size(33, 30);
            this.btnquitar.TabIndex = 64;
            this.btnquitar.UseVisualStyleBackColor = true;
            this.btnquitar.Click += new System.EventHandler(this.btnquitar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnagregar.Image = global::PRESENTACION.Properties.Resources.mas__4_;
            this.btnagregar.Location = new System.Drawing.Point(590, 226);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(33, 30);
            this.btnagregar.TabIndex = 65;
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // Formcompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(745, 512);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.datadetalle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.lbtotalpaga);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnquitar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.checkBox2);
            this.Name = "Formcompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compras";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Formcompras_FormClosing);
            this.Load += new System.EventHandler(this.Formventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erroricon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datadetalle)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox txtidproveedor;
        private System.Windows.Forms.TextBox txtlote;
        private System.Windows.Forms.Label ISR;
        private System.Windows.Forms.DateTimePicker dtfecha;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtidproducto;
        private System.Windows.Forms.TextBox txtidcompra;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbtotalpaga;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnquitar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip ttmensaje;
        private System.Windows.Forms.ErrorProvider erroricon;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView datadetalle;
        private System.Windows.Forms.TextBox txtobservaciones;
        private System.Windows.Forms.Label Ovservaciones;
        private System.Windows.Forms.TextBox txtcomprobante;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtvencimento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnbuscarproduct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.TextBox txtproducto;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblptotal;
        private System.Windows.Forms.DateTimePicker dtfabri;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}