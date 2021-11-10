
namespace PRESENTACION
{
    partial class Formpruebasedit
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
            this.datadetalle = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtidproveedor = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtobservaciones = new System.Windows.Forms.TextBox();
            this.Ovservaciones = new System.Windows.Forms.Label();
            this.txtprueba = new System.Windows.Forms.TextBox();
            this.cbclientes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtfecha = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbvencimiento = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cbrealizada = new System.Windows.Forms.DateTimePicker();
            this.cbtipo = new System.Windows.Forms.ComboBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbtotalpaga = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcomprobante = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datadetalle)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // datadetalle
            // 
            this.datadetalle.AllowUserToAddRows = false;
            this.datadetalle.AllowUserToDeleteRows = false;
            this.datadetalle.AllowUserToOrderColumns = true;
            this.datadetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datadetalle.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.datadetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datadetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1});
            this.datadetalle.Location = new System.Drawing.Point(5, 272);
            this.datadetalle.MultiSelect = false;
            this.datadetalle.Name = "datadetalle";
            this.datadetalle.RowTemplate.Height = 25;
            this.datadetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datadetalle.Size = new System.Drawing.Size(656, 153);
            this.datadetalle.TabIndex = 113;
            this.datadetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datadetalle_CellContentClick);
            this.datadetalle.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.datadetalle_CellFormatting);
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Eliminar";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(269, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 45);
            this.label5.TabIndex = 111;
            this.label5.Text = "Pruebas";
            // 
            // txtidproveedor
            // 
            this.txtidproveedor.AcceptsReturn = true;
            this.txtidproveedor.Location = new System.Drawing.Point(652, 35);
            this.txtidproveedor.Name = "txtidproveedor";
            this.txtidproveedor.ReadOnly = true;
            this.txtidproveedor.Size = new System.Drawing.Size(26, 20);
            this.txtidproveedor.TabIndex = 94;
            this.txtidproveedor.Visible = false;
            this.txtidproveedor.TextChanged += new System.EventHandler(this.txtidproveedor_TextChanged);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(576, 9);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(102, 20);
            this.txtid.TabIndex = 87;
            this.txtid.Visible = false;
            this.txtid.TextChanged += new System.EventHandler(this.txtidproducto_TextChanged);
            // 
            // btnguardar
            // 
            this.btnguardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnguardar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardar.Location = new System.Drawing.Point(553, 448);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(109, 29);
            this.btnguardar.TabIndex = 120;
            this.btnguardar.Text = "Cancelar";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 130;
            this.label7.Text = "Fecha De Solucitud";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtobservaciones
            // 
            this.txtobservaciones.Location = new System.Drawing.Point(284, 116);
            this.txtobservaciones.Multiline = true;
            this.txtobservaciones.Name = "txtobservaciones";
            this.txtobservaciones.Size = new System.Drawing.Size(158, 57);
            this.txtobservaciones.TabIndex = 129;
            // 
            // Ovservaciones
            // 
            this.Ovservaciones.AutoSize = true;
            this.Ovservaciones.Location = new System.Drawing.Point(330, 100);
            this.Ovservaciones.Name = "Ovservaciones";
            this.Ovservaciones.Size = new System.Drawing.Size(78, 13);
            this.Ovservaciones.TabIndex = 128;
            this.Ovservaciones.Text = "Observaciones";
            // 
            // txtprueba
            // 
            this.txtprueba.Location = new System.Drawing.Point(333, 59);
            this.txtprueba.Name = "txtprueba";
            this.txtprueba.Size = new System.Drawing.Size(104, 20);
            this.txtprueba.TabIndex = 127;
            this.txtprueba.TextChanged += new System.EventHandler(this.txtcomprobante_TextChanged);
            // 
            // cbclientes
            // 
            this.cbclientes.FormattingEnabled = true;
            this.cbclientes.Location = new System.Drawing.Point(137, 30);
            this.cbclientes.Name = "cbclientes";
            this.cbclientes.Size = new System.Drawing.Size(104, 21);
            this.cbclientes.TabIndex = 126;
            this.cbclientes.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(462, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 124;
            this.label1.Text = "Tipo ";
            // 
            // dtfecha
            // 
            this.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfecha.Location = new System.Drawing.Point(137, 69);
            this.dtfecha.Name = "dtfecha";
            this.dtfecha.Size = new System.Drawing.Size(101, 20);
            this.dtfecha.TabIndex = 123;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 122;
            this.label13.Text = "Cliente";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(272, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 121;
            this.label12.Text = "Prueba";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtcomprobante);
            this.groupBox1.Controls.Add(this.cbvencimiento);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbrealizada);
            this.groupBox1.Controls.Add(this.cbtipo);
            this.groupBox1.Controls.Add(this.txtdescripcion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtobservaciones);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.Ovservaciones);
            this.groupBox1.Controls.Add(this.dtfecha);
            this.groupBox1.Controls.Add(this.txtprueba);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbclientes);
            this.groupBox1.Location = new System.Drawing.Point(16, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(645, 191);
            this.groupBox1.TabIndex = 131;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 13);
            this.label8.TabIndex = 139;
            this.label8.Text = "Fecha De Vencimiento";
            // 
            // cbvencimiento
            // 
            this.cbvencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cbvencimiento.Location = new System.Drawing.Point(137, 146);
            this.cbvencimiento.Name = "cbvencimiento";
            this.cbvencimiento.Size = new System.Drawing.Size(101, 20);
            this.cbvencimiento.TabIndex = 138;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 137;
            this.label6.Text = "Fecha De Realización";
            // 
            // cbrealizada
            // 
            this.cbrealizada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cbrealizada.Location = new System.Drawing.Point(140, 105);
            this.cbrealizada.Name = "cbrealizada";
            this.cbrealizada.Size = new System.Drawing.Size(101, 20);
            this.cbrealizada.TabIndex = 136;
            // 
            // cbtipo
            // 
            this.cbtipo.FormattingEnabled = true;
            this.cbtipo.Location = new System.Drawing.Point(527, 58);
            this.cbtipo.Name = "cbtipo";
            this.cbtipo.Size = new System.Drawing.Size(104, 21);
            this.cbtipo.TabIndex = 135;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(459, 116);
            this.txtdescripcion.Multiline = true;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(158, 57);
            this.txtdescripcion.TabIndex = 134;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(506, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 133;
            this.label4.Text = "Descripción";
            // 
            // lbtotalpaga
            // 
            this.lbtotalpaga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbtotalpaga.AutoSize = true;
            this.lbtotalpaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtotalpaga.Location = new System.Drawing.Point(121, 457);
            this.lbtotalpaga.Name = "lbtotalpaga";
            this.lbtotalpaga.Size = new System.Drawing.Size(34, 20);
            this.lbtotalpaga.TabIndex = 133;
            this.lbtotalpaga.Text = "0.0";
            this.lbtotalpaga.Click += new System.EventHandler(this.lbtotalpaga_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 457);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 132;
            this.label3.Text = "Total Q";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Image = global::PRESENTACION.Properties.Resources.addbox;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(417, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 35);
            this.button1.TabIndex = 134;
            this.button1.Text = "Guardar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 154;
            this.label2.Text = "Comprobante";
            // 
            // txtcomprobante
            // 
            this.txtcomprobante.Location = new System.Drawing.Point(428, 15);
            this.txtcomprobante.Name = "txtcomprobante";
            this.txtcomprobante.Size = new System.Drawing.Size(104, 20);
            this.txtcomprobante.TabIndex = 155;
            // 
            // Formpruebasedit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(690, 489);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbtotalpaga);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.datadetalle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtidproveedor);
            this.Controls.Add(this.txtid);
            this.Name = "Formpruebasedit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formcompras1";
            this.Load += new System.EventHandler(this.Formcompras1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datadetalle)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datadetalle;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtidproveedor;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtobservaciones;
        private System.Windows.Forms.Label Ovservaciones;
        private System.Windows.Forms.TextBox txtprueba;
        private System.Windows.Forms.ComboBox cbclientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtfecha;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbtotalpaga;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbtipo;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker cbvencimiento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker cbrealizada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcomprobante;
    }
}