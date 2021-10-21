
namespace PRESENTACION
{
    partial class Formcompras1
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
            this.txtiduser = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtobservaciones = new System.Windows.Forms.TextBox();
            this.Ovservaciones = new System.Windows.Forms.Label();
            this.txtcomprobante = new System.Windows.Forms.TextBox();
            this.cbproveedor = new System.Windows.Forms.ComboBox();
            this.txtlote = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtfecha = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbestado = new System.Windows.Forms.ComboBox();
            this.lbtotalpaga = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
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
            this.datadetalle.Location = new System.Drawing.Point(5, 245);
            this.datadetalle.MultiSelect = false;
            this.datadetalle.Name = "datadetalle";
            this.datadetalle.RowTemplate.Height = 25;
            this.datadetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datadetalle.Size = new System.Drawing.Size(542, 140);
            this.datadetalle.TabIndex = 113;
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
            this.label5.Location = new System.Drawing.Point(201, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 45);
            this.label5.TabIndex = 111;
            this.label5.Text = "Compras";
            // 
            // txtiduser
            // 
            this.txtiduser.AcceptsReturn = true;
            this.txtiduser.Location = new System.Drawing.Point(509, 57);
            this.txtiduser.Name = "txtiduser";
            this.txtiduser.ReadOnly = true;
            this.txtiduser.Size = new System.Drawing.Size(38, 20);
            this.txtiduser.TabIndex = 94;
            this.txtiduser.Visible = false;
            this.txtiduser.TextChanged += new System.EventHandler(this.txtidproveedor_TextChanged);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(433, 31);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(114, 20);
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
            this.btnguardar.Location = new System.Drawing.Point(433, 413);
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
            this.label7.Location = new System.Drawing.Point(77, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 130;
            this.label7.Text = "Fecha";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtobservaciones
            // 
            this.txtobservaciones.Location = new System.Drawing.Point(231, 71);
            this.txtobservaciones.Multiline = true;
            this.txtobservaciones.Name = "txtobservaciones";
            this.txtobservaciones.Size = new System.Drawing.Size(158, 57);
            this.txtobservaciones.TabIndex = 129;
            // 
            // Ovservaciones
            // 
            this.Ovservaciones.AutoSize = true;
            this.Ovservaciones.Location = new System.Drawing.Point(277, 55);
            this.Ovservaciones.Name = "Ovservaciones";
            this.Ovservaciones.Size = new System.Drawing.Size(78, 13);
            this.Ovservaciones.TabIndex = 128;
            this.Ovservaciones.Text = "Observaciones";
            // 
            // txtcomprobante
            // 
            this.txtcomprobante.Location = new System.Drawing.Point(121, 26);
            this.txtcomprobante.Name = "txtcomprobante";
            this.txtcomprobante.Size = new System.Drawing.Size(104, 20);
            this.txtcomprobante.TabIndex = 127;
            this.txtcomprobante.TextChanged += new System.EventHandler(this.txtcomprobante_TextChanged);
            // 
            // cbproveedor
            // 
            this.cbproveedor.FormattingEnabled = true;
            this.cbproveedor.Location = new System.Drawing.Point(121, 78);
            this.cbproveedor.Name = "cbproveedor";
            this.cbproveedor.Size = new System.Drawing.Size(104, 21);
            this.cbproveedor.TabIndex = 126;
            this.cbproveedor.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // txtlote
            // 
            this.txtlote.Location = new System.Drawing.Point(121, 52);
            this.txtlote.Name = "txtlote";
            this.txtlote.Size = new System.Drawing.Size(104, 20);
            this.txtlote.TabIndex = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 124;
            this.label1.Text = "Lote No.";
            // 
            // dtfecha
            // 
            this.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfecha.Location = new System.Drawing.Point(124, 105);
            this.dtfecha.Name = "dtfecha";
            this.dtfecha.Size = new System.Drawing.Size(101, 20);
            this.dtfecha.TabIndex = 123;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(59, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 122;
            this.label13.Text = "Proveedor";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 13);
            this.label12.TabIndex = 121;
            this.label12.Text = "Comprobante No.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbestado);
            this.groupBox1.Controls.Add(this.txtobservaciones);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.Ovservaciones);
            this.groupBox1.Controls.Add(this.dtfecha);
            this.groupBox1.Controls.Add(this.txtcomprobante);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbproveedor);
            this.groupBox1.Controls.Add(this.txtlote);
            this.groupBox1.Location = new System.Drawing.Point(66, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 168);
            this.groupBox1.TabIndex = 131;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 132;
            this.label2.Text = "Esado";
            // 
            // cbestado
            // 
            this.cbestado.FormattingEnabled = true;
            this.cbestado.Items.AddRange(new object[] {
            "HECHA",
            "ANULADA"});
            this.cbestado.Location = new System.Drawing.Point(121, 141);
            this.cbestado.Name = "cbestado";
            this.cbestado.Size = new System.Drawing.Size(104, 21);
            this.cbestado.TabIndex = 131;
            this.cbestado.SelectedIndexChanged += new System.EventHandler(this.cbestado_SelectedIndexChanged);
            // 
            // lbtotalpaga
            // 
            this.lbtotalpaga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbtotalpaga.AutoSize = true;
            this.lbtotalpaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtotalpaga.Location = new System.Drawing.Point(121, 422);
            this.lbtotalpaga.Name = "lbtotalpaga";
            this.lbtotalpaga.Size = new System.Drawing.Size(34, 20);
            this.lbtotalpaga.TabIndex = 133;
            this.lbtotalpaga.Text = "0.0";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 422);
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
            this.button1.Location = new System.Drawing.Point(297, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 35);
            this.button1.TabIndex = 134;
            this.button1.Text = "Guardar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Formcompras1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(554, 454);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbtotalpaga);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.datadetalle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtiduser);
            this.Controls.Add(this.txtid);
            this.Name = "Formcompras1";
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
        public System.Windows.Forms.TextBox txtiduser;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtobservaciones;
        private System.Windows.Forms.Label Ovservaciones;
        private System.Windows.Forms.TextBox txtcomprobante;
        private System.Windows.Forms.ComboBox cbproveedor;
        private System.Windows.Forms.TextBox txtlote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtfecha;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbtotalpaga;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbestado;
        private System.Windows.Forms.Button button1;
    }
}