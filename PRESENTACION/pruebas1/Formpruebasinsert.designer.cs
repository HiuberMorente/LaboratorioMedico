
namespace PRESENTACION
{
    partial class Formpruebasinsert
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
            this.lbtotalpaga = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnquitar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ttmensaje = new System.Windows.Forms.ToolTip(this.components);
            this.erroricon = new System.Windows.Forms.ErrorProvider(this.components);
            this.datadetalle = new System.Windows.Forms.DataGridView();
            this.label17 = new System.Windows.Forms.Label();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnbuscarproduct = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbtipo = new System.Windows.Forms.ComboBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtobservaciones = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Ovservaciones = new System.Windows.Forms.Label();
            this.txtprueba = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbclientes = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.txtidinsumo = new System.Windows.Forms.TextBox();
            this.txtidcompra = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.erroricon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datadetalle)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbtotalpaga
            // 
            this.lbtotalpaga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbtotalpaga.AutoSize = true;
            this.lbtotalpaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtotalpaga.ForeColor = System.Drawing.SystemColors.Control;
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
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(528, 473);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 63;
            this.label4.Text = "Total Q";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnquitar
            // 
            this.btnquitar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnquitar.Location = new System.Drawing.Point(972, 226);
            this.btnquitar.Name = "btnquitar";
            this.btnquitar.Size = new System.Drawing.Size(33, 30);
            this.btnquitar.TabIndex = 64;
            this.btnquitar.UseVisualStyleBackColor = true;
            this.btnquitar.Click += new System.EventHandler(this.btnquitar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnagregar.Location = new System.Drawing.Point(917, 226);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(33, 30);
            this.btnagregar.TabIndex = 65;
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btncancelar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Image = global::PRESENTACION.Properties.Resources.danger;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancelar.Location = new System.Drawing.Point(134, 465);
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
            this.btnguardar.Location = new System.Drawing.Point(12, 465);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(107, 35);
            this.btnguardar.TabIndex = 76;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(457, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 45);
            this.label5.TabIndex = 78;
            this.label5.Text = "Pruebas";
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
            this.datadetalle.Size = new System.Drawing.Size(993, 189);
            this.datadetalle.TabIndex = 80;
            this.datadetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datadetalle_CellContentClick_1);
            this.datadetalle.DoubleClick += new System.EventHandler(this.datadetalle_DoubleClick);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbtipo);
            this.groupBox1.Controls.Add(this.txtdescripcion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtobservaciones);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.Ovservaciones);
            this.groupBox1.Controls.Add(this.txtprueba);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbclientes);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(619, 161);
            this.groupBox1.TabIndex = 89;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Compra";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbtipo
            // 
            this.cbtipo.FormattingEnabled = true;
            this.cbtipo.Location = new System.Drawing.Point(114, 109);
            this.cbtipo.Name = "cbtipo";
            this.cbtipo.Size = new System.Drawing.Size(104, 21);
            this.cbtipo.TabIndex = 151;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(427, 35);
            this.txtdescripcion.Multiline = true;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(158, 96);
            this.txtdescripcion.TabIndex = 150;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(450, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 149;
            this.label3.Text = "Descripción";
            // 
            // txtobservaciones
            // 
            this.txtobservaciones.Location = new System.Drawing.Point(249, 35);
            this.txtobservaciones.Multiline = true;
            this.txtobservaciones.Name = "txtobservaciones";
            this.txtobservaciones.Size = new System.Drawing.Size(158, 95);
            this.txtobservaciones.TabIndex = 147;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(47, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 140;
            this.label12.Text = "Prueba";
            this.label12.Click += new System.EventHandler(this.label12_Click_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(49, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 141;
            this.label13.Text = "Cliente";
            // 
            // Ovservaciones
            // 
            this.Ovservaciones.AutoSize = true;
            this.Ovservaciones.Location = new System.Drawing.Point(286, 19);
            this.Ovservaciones.Name = "Ovservaciones";
            this.Ovservaciones.Size = new System.Drawing.Size(78, 13);
            this.Ovservaciones.TabIndex = 146;
            this.Ovservaciones.Text = "Observaciones";
            // 
            // txtprueba
            // 
            this.txtprueba.Location = new System.Drawing.Point(114, 67);
            this.txtprueba.Name = "txtprueba";
            this.txtprueba.Size = new System.Drawing.Size(104, 20);
            this.txtprueba.TabIndex = 145;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 143;
            this.label9.Text = "Tipo ";
            // 
            // cbclientes
            // 
            this.cbclientes.FormattingEnabled = true;
            this.cbclientes.Location = new System.Drawing.Point(114, 20);
            this.cbclientes.Name = "cbclientes";
            this.cbclientes.Size = new System.Drawing.Size(104, 21);
            this.cbclientes.TabIndex = 144;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtstock);
            this.groupBox2.Controls.Add(this.txtproducto);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnbuscarproduct);
            this.groupBox2.Controls.Add(this.txtcantidad);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txtprecio);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(740, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 161);
            this.groupBox2.TabIndex = 90;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos insumo";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 97;
            this.label1.Text = "Stock";
            // 
            // txtstock
            // 
            this.txtstock.AcceptsReturn = true;
            this.txtstock.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtstock.Location = new System.Drawing.Point(89, 97);
            this.txtstock.Name = "txtstock";
            this.txtstock.ReadOnly = true;
            this.txtstock.Size = new System.Drawing.Size(121, 20);
            this.txtstock.TabIndex = 96;
            // 
            // txtidinsumo
            // 
            this.txtidinsumo.AcceptsReturn = true;
            this.txtidinsumo.Location = new System.Drawing.Point(1007, 31);
            this.txtidinsumo.Name = "txtidinsumo";
            this.txtidinsumo.ReadOnly = true;
            this.txtidinsumo.Size = new System.Drawing.Size(26, 20);
            this.txtidinsumo.TabIndex = 95;
            this.txtidinsumo.Visible = false;
            this.txtidinsumo.TextChanged += new System.EventHandler(this.txtidinsumo_TextChanged);
            // 
            // txtidcompra
            // 
            this.txtidcompra.AcceptsReturn = true;
            this.txtidcompra.Location = new System.Drawing.Point(1034, 71);
            this.txtidcompra.Name = "txtidcompra";
            this.txtidcompra.ReadOnly = true;
            this.txtidcompra.Size = new System.Drawing.Size(26, 20);
            this.txtidcompra.TabIndex = 96;
            this.txtidcompra.Visible = false;
            this.txtidcompra.TextChanged += new System.EventHandler(this.txtidcompra_TextChanged);
            // 
            // Formpruebasinsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1072, 512);
            this.Controls.Add(this.txtidcompra);
            this.Controls.Add(this.txtidinsumo);
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
            this.Name = "Formpruebasinsert";
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
        private System.Windows.Forms.Label lbtotalpaga;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnquitar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip ttmensaje;
        private System.Windows.Forms.ErrorProvider erroricon;
        private System.Windows.Forms.DataGridView datadetalle;
        private System.Windows.Forms.Button btnbuscarproduct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.TextBox txtproducto;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbtipo;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtobservaciones;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label Ovservaciones;
        private System.Windows.Forms.TextBox txtprueba;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbclientes;
        public System.Windows.Forms.TextBox txtidinsumo;
        public System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtidcompra;
    }
}