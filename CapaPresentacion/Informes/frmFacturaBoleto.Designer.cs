namespace CapaPresentacion
{
    partial class frmFacturaBoleto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFacturaBoleto));
            this.sPFacturaBoletoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new CapaPresentacion.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sP_FacturaBoletoTableAdapter = new CapaPresentacion.DataSet1TableAdapters.SP_FacturaBoletoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sPFacturaBoletoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // sPFacturaBoletoBindingSource
            // 
            this.sPFacturaBoletoBindingSource.DataMember = "SP_FacturaBoleto";
            this.sPFacturaBoletoBindingSource.DataSource = this.dataSet1;
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
            reportDataSource1.Value = this.sPFacturaBoletoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Informes.FacturaBoleto.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(731, 445);
            this.reportViewer1.TabIndex = 0;
            // 
            // sP_FacturaBoletoTableAdapter
            // 
            this.sP_FacturaBoletoTableAdapter.ClearBeforeFill = true;
            // 
            // frmFacturaBoleto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 445);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFacturaBoleto";
            this.Text = "frmFacturaBoleto";
            this.Load += new System.EventHandler(this.frmFacturaBoleto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sPFacturaBoletoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sPFacturaBoletoBindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.SP_FacturaBoletoTableAdapter sP_FacturaBoletoTableAdapter;
    }
}