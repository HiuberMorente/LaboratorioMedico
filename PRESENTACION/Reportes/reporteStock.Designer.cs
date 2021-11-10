
namespace PRESENTACION
{
    partial class reporteStock
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
            this.DataSet1 = new PRESENTACION.DataSet1();
            this.mostrar_stockReporteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mostrar_stockReporteTableAdapter = new PRESENTACION.DataSet1TableAdapters.mostrar_stockReporteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrar_stockReporteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.mostrar_stockReporteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PRESENTACION.Reportes.ReportStock.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, -1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1280, 673);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mostrar_stockReporteBindingSource
            // 
            this.mostrar_stockReporteBindingSource.DataMember = "mostrar_stockReporte";
            this.mostrar_stockReporteBindingSource.DataSource = this.DataSet1;
            // 
            // mostrar_stockReporteTableAdapter
            // 
            this.mostrar_stockReporteTableAdapter.ClearBeforeFill = true;
            // 
            // reporteStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 670);
            this.Controls.Add(this.reportViewer1);
            this.Name = "reporteStock";
            this.Text = "reporteStock";
            this.Load += new System.EventHandler(this.reporteStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrar_stockReporteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource mostrar_stockReporteBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.mostrar_stockReporteTableAdapter mostrar_stockReporteTableAdapter;
    }
}