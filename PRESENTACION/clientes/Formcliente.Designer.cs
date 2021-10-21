
namespace PRESENTACION.clientes
{
    partial class Formcliente
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.datacliente = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datacliente)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btnagregar);
            this.panel1.Controls.Add(this.datacliente);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 308);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(12, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Buscar";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.SystemColors.Control;
            this.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.ForeColor = System.Drawing.Color.Black;
            this.btnagregar.Image = global::PRESENTACION.Properties.Resources.add5;
            this.btnagregar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnagregar.Location = new System.Drawing.Point(203, 56);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(41, 31);
            this.btnagregar.TabIndex = 2;
            this.btnagregar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // datacliente
            // 
            this.datacliente.AllowUserToAddRows = false;
            this.datacliente.AllowUserToDeleteRows = false;
            this.datacliente.AllowUserToOrderColumns = true;
            this.datacliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datacliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datacliente.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.datacliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datacliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.datacliente.Location = new System.Drawing.Point(12, 93);
            this.datacliente.Name = "datacliente";
            this.datacliente.ReadOnly = true;
            this.datacliente.Size = new System.Drawing.Size(742, 203);
            this.datacliente.TabIndex = 1;
            this.datacliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.datacliente.DoubleClick += new System.EventHandler(this.datacliente_DoubleClick);
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
            this.label1.Location = new System.Drawing.Point(303, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clientes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Formcliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 308);
            this.Controls.Add(this.panel1);
            this.Name = "Formcliente";
            this.Text = "Formcliente";
            this.Load += new System.EventHandler(this.Formcliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datacliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.DataGridView datacliente;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
    }
}