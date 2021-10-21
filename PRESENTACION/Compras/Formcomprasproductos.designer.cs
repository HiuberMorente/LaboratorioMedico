
namespace PRESENTACION
{
    partial class Formcomprasproductos
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
            this.dataproductos = new System.Windows.Forms.DataGridView();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataproductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataproductos
            // 
            this.dataproductos.AllowUserToAddRows = false;
            this.dataproductos.AllowUserToDeleteRows = false;
            this.dataproductos.AllowUserToOrderColumns = true;
            this.dataproductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataproductos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataproductos.Location = new System.Drawing.Point(10, 121);
            this.dataproductos.MultiSelect = false;
            this.dataproductos.Name = "dataproductos";
            this.dataproductos.ReadOnly = true;
            this.dataproductos.RowTemplate.Height = 25;
            this.dataproductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataproductos.Size = new System.Drawing.Size(609, 188);
            this.dataproductos.TabIndex = 38;
            this.dataproductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataproductos_CellContentClick);
            this.dataproductos.DoubleClick += new System.EventHandler(this.dataproductos_DoubleClick);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtbuscar.Location = new System.Drawing.Point(10, 72);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(149, 29);
            this.txtbuscar.TabIndex = 39;
            this.txtbuscar.Text = "Buscar";
            this.txtbuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            this.txtbuscar.Enter += new System.EventHandler(this.txtbuscar_Enter);
            this.txtbuscar.Leave += new System.EventHandler(this.txtbuscar_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(216, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 45);
            this.label1.TabIndex = 40;
            this.label1.Text = "Insumos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Formcomprasproductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(633, 320);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.dataproductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Formcomprasproductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Formcomprasproductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataproductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataproductos;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label label1;
    }
}