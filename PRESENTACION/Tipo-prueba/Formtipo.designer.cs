
namespace PRESENTACION.pruebas
{
    partial class Formtipo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBuscar = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.dataPruebas = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPruebas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.textBuscar);
            this.panel1.Controls.Add(this.btnagregar);
            this.panel1.Controls.Add(this.dataPruebas);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 470);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBuscar
            // 
            this.textBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBuscar.Location = new System.Drawing.Point(557, 93);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(185, 20);
            this.textBuscar.TabIndex = 3;
            this.textBuscar.Text = "Buscar";
            this.textBuscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.ForeColor = System.Drawing.Color.Black;
            this.btnagregar.Location = new System.Drawing.Point(12, 93);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(86, 31);
            this.btnagregar.TabIndex = 2;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataPruebas
            // 
            this.dataPruebas.AllowUserToAddRows = false;
            this.dataPruebas.AllowUserToDeleteRows = false;
            this.dataPruebas.AllowUserToOrderColumns = true;
            this.dataPruebas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataPruebas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataPruebas.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataPruebas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPruebas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dataPruebas.Location = new System.Drawing.Point(12, 159);
            this.dataPruebas.Name = "dataPruebas";
            this.dataPruebas.ReadOnly = true;
            this.dataPruebas.Size = new System.Drawing.Size(742, 287);
            this.dataPruebas.TabIndex = 1;
            this.dataPruebas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataPruebas.DoubleClick += new System.EventHandler(this.datacliente_DoubleClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo Pruebas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Formtipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 470);
            this.Controls.Add(this.panel1);
            this.Name = "Formtipo";
            this.Text = "Tipo de Pruebas";
            this.Load += new System.EventHandler(this.Formcliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPruebas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.DataGridView dataPruebas;
        private System.Windows.Forms.TextBox textBuscar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
    }
}