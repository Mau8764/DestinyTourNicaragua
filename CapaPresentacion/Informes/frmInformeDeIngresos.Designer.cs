namespace CapaPresentacion
{
    partial class frmInformeDeIngresos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInformeDeIngresos));
            this.sPInformeDeIngresosPorFechasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new CapaPresentacion.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sP_InformeDeIngresosPorFechasTableAdapter = new CapaPresentacion.DataSet1TableAdapters.SP_InformeDeIngresosPorFechasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sPInformeDeIngresosPorFechasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // sPInformeDeIngresosPorFechasBindingSource
            // 
            this.sPInformeDeIngresosPorFechasBindingSource.DataMember = "SP_InformeDeIngresosPorFechas";
            this.sPInformeDeIngresosPorFechasBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "InformeDeIngresos";
            reportDataSource1.Value = this.sPInformeDeIngresosPorFechasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Informes.InformeDeIngresos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(777, 407);
            this.reportViewer1.TabIndex = 0;
            // 
            // sP_InformeDeIngresosPorFechasTableAdapter
            // 
            this.sP_InformeDeIngresosPorFechasTableAdapter.ClearBeforeFill = true;
            // 
            // frmInformeDeIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 407);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInformeDeIngresos";
            this.Text = "frmInformeDeIngresos";
            this.Load += new System.EventHandler(this.frmInformeDeIngresos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sPInformeDeIngresosPorFechasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sPInformeDeIngresosPorFechasBindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.SP_InformeDeIngresosPorFechasTableAdapter sP_InformeDeIngresosPorFechasTableAdapter;
    }
}