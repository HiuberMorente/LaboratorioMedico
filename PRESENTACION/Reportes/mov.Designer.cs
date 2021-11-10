
namespace PRESENTACION.Reportes
{
    partial class mov
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.buscar_movimientofechaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetMovimiento = new PRESENTACION.Reportes.DataSetMovimiento();
            this.buscar_movimientofechaTableAdapter = new PRESENTACION.Reportes.DataSetMovimientoTableAdapters.buscar_movimientofechaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.buscar_movimientofechaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetMovimiento)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.buscar_movimientofechaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PRESENTACION.Reportes.ReportMovimiento.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1168, 584);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // buscar_movimientofechaBindingSource
            // 
            this.buscar_movimientofechaBindingSource.DataMember = "buscar_movimientofecha";
            this.buscar_movimientofechaBindingSource.DataSource = this.DataSetMovimiento;
            // 
            // DataSetMovimiento
            // 
            this.DataSetMovimiento.DataSetName = "DataSetMovimiento";
            this.DataSetMovimiento.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buscar_movimientofechaTableAdapter
            // 
            this.buscar_movimientofechaTableAdapter.ClearBeforeFill = true;
            // 
            // mov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 584);
            this.Controls.Add(this.reportViewer1);
            this.Name = "mov";
            this.Text = "mov";
            this.Load += new System.EventHandler(this.mov_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buscar_movimientofechaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetMovimiento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource buscar_movimientofechaBindingSource;
        private DataSetMovimiento DataSetMovimiento;
        private DataSetMovimientoTableAdapters.buscar_movimientofechaTableAdapter buscar_movimientofechaTableAdapter;
    }
}