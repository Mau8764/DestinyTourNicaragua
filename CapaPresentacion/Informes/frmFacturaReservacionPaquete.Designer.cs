namespace CapaPresentacion
{
    partial class frmFacturaReservacionPaquete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFacturaReservacionPaquete));
            this.sPFacturaReservacionPaqueteNacionalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new CapaPresentacion.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sP_FacturaReservacionPaqueteNacionalTableAdapter = new CapaPresentacion.DataSet1TableAdapters.SP_FacturaReservacionPaqueteNacionalTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sPFacturaReservacionPaqueteNacionalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // sPFacturaReservacionPaqueteNacionalBindingSource
            // 
            this.sPFacturaReservacionPaqueteNacionalBindingSource.DataMember = "SP_FacturaReservacionPaqueteNacional";
            this.sPFacturaReservacionPaqueteNacionalBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sPFacturaReservacionPaqueteNacionalBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Informes.FacturaReservacionPaqueteNacional.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(799, 438);
            this.reportViewer1.TabIndex = 0;
            // 
            // sP_FacturaReservacionPaqueteNacionalTableAdapter
            // 
            this.sP_FacturaReservacionPaqueteNacionalTableAdapter.ClearBeforeFill = true;
            // 
            // frmFacturaReservacionPaquete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 438);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFacturaReservacionPaquete";
            this.Text = "frmFacturaReservacionPaquete";
            this.Load += new System.EventHandler(this.frmFacturaReservacionPaquete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sPFacturaReservacionPaqueteNacionalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sPFacturaReservacionPaqueteNacionalBindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.SP_FacturaReservacionPaqueteNacionalTableAdapter sP_FacturaReservacionPaqueteNacionalTableAdapter;
    }
}