namespace Consultas.Formularios
{
    partial class frmReporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporte));
            this.totalCostosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.newConsultaMedicaDataSet1 = new Consultas.NewConsultaMedicaDataSet1();
            this.totalCostosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultaMedicaDataSet = new Consultas.ConsultaMedicaDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.total_CostosTableAdapter = new Consultas.ConsultaMedicaDataSetTableAdapters.total_CostosTableAdapter();
            this.total_CostosTableAdapter1 = new Consultas.NewConsultaMedicaDataSet1TableAdapters.total_CostosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.totalCostosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newConsultaMedicaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalCostosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaMedicaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // totalCostosBindingSource1
            // 
            this.totalCostosBindingSource1.DataMember = "total_Costos";
            this.totalCostosBindingSource1.DataSource = this.newConsultaMedicaDataSet1;
            // 
            // newConsultaMedicaDataSet1
            // 
            this.newConsultaMedicaDataSet1.DataSetName = "NewConsultaMedicaDataSet1";
            this.newConsultaMedicaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // totalCostosBindingSource
            // 
            this.totalCostosBindingSource.DataMember = "total_Costos";
            this.totalCostosBindingSource.DataSource = this.consultaMedicaDataSet;
            // 
            // consultaMedicaDataSet
            // 
            this.consultaMedicaDataSet.DataSetName = "ConsultaMedicaDataSet";
            this.consultaMedicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.totalCostosBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Consultas.MiReporte.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(863, 460);
            this.reportViewer1.TabIndex = 0;
            // 
            // total_CostosTableAdapter
            // 
            this.total_CostosTableAdapter.ClearBeforeFill = true;
            // 
            // total_CostosTableAdapter1
            // 
            this.total_CostosTableAdapter1.ClearBeforeFill = true;
            // 
            // frmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(863, 460);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReporte";
            this.Text = "Generador de Reportes";
            this.Load += new System.EventHandler(this.frmReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.totalCostosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newConsultaMedicaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalCostosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaMedicaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ConsultaMedicaDataSet consultaMedicaDataSet;
        private System.Windows.Forms.BindingSource totalCostosBindingSource;
        private ConsultaMedicaDataSetTableAdapters.total_CostosTableAdapter total_CostosTableAdapter;
        private NewConsultaMedicaDataSet1 newConsultaMedicaDataSet1;
        private System.Windows.Forms.BindingSource totalCostosBindingSource1;
        private NewConsultaMedicaDataSet1TableAdapters.total_CostosTableAdapter total_CostosTableAdapter1;
    }
}