namespace shoping
{
    partial class reporting
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Invo_Indiv_Select_topProcBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.advanceDataSet = new shoping.advanceDataSet();
            this.IndivisualDeliverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deliveriesSelectProcBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.invoIndivSelecttopProcBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invo_Indiv_Select_topProcTableAdapter = new shoping.advanceDataSetTableAdapters.Invo_Indiv_Select_topProcTableAdapter();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.IndivisualDeliverTableAdapter = new shoping.advanceDataSetTableAdapters.IndivisualDeliverTableAdapter();
            this.advanceDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.deliveriesSelectProcTableAdapter = new shoping.advanceDataSetTableAdapters.DeliveriesSelectProcTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Invo_Indiv_Select_topProcBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advanceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IndivisualDeliverBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveriesSelectProcBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoIndivSelecttopProcBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advanceDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Invo_Indiv_Select_topProcBindingSource
            // 
            this.Invo_Indiv_Select_topProcBindingSource.DataMember = "Invo_Indiv_Select_topProc";
            this.Invo_Indiv_Select_topProcBindingSource.DataSource = this.advanceDataSet;
            // 
            // advanceDataSet
            // 
            this.advanceDataSet.DataSetName = "advanceDataSet";
            this.advanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // IndivisualDeliverBindingSource
            // 
            this.IndivisualDeliverBindingSource.DataMember = "IndivisualDeliver";
            this.IndivisualDeliverBindingSource.DataSource = this.advanceDataSet;
            // 
            // deliveriesSelectProcBindingSource
            // 
            this.deliveriesSelectProcBindingSource.DataMember = "DeliveriesSelectProc";
            this.deliveriesSelectProcBindingSource.DataSource = this.advanceDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Invo_Indiv_Select_topProcBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "shoping.Report_Invoices.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(994, 575);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Tag = "تقارير الفواتير";
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // invoIndivSelecttopProcBindingSource
            // 
            this.invoIndivSelecttopProcBindingSource.DataMember = "Invo_Indiv_Select_topProc";
            this.invoIndivSelecttopProcBindingSource.DataSource = this.advanceDataSet;
            // 
            // invo_Indiv_Select_topProcTableAdapter
            // 
            this.invo_Indiv_Select_topProcTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.IndivisualDeliverBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "shoping.Report_Deliveries.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(994, 575);
            this.reportViewer2.TabIndex = 1;
            this.reportViewer2.Visible = false;
            this.reportViewer2.Load += new System.EventHandler(this.reportViewer2_Load);
            // 
            // IndivisualDeliverTableAdapter
            // 
            this.IndivisualDeliverTableAdapter.ClearBeforeFill = true;
            // 
            // advanceDataSetBindingSource
            // 
            this.advanceDataSetBindingSource.DataSource = this.advanceDataSet;
            this.advanceDataSetBindingSource.Position = 0;
            // 
            // reportViewer3
            // 
            this.reportViewer3.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.deliveriesSelectProcBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "shoping.Report_Deliveries.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(0, 0);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.Size = new System.Drawing.Size(994, 575);
            this.reportViewer3.TabIndex = 2;
            this.reportViewer3.Visible = false;
            this.reportViewer3.Load += new System.EventHandler(this.reportViewer3_Load);
            // 
            // deliveriesSelectProcTableAdapter
            // 
            this.deliveriesSelectProcTableAdapter.ClearBeforeFill = true;
            // 
            // reporting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 575);
            this.Controls.Add(this.reportViewer3);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.reportViewer1);
            this.Name = "reporting";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقارير الفواتير";
            this.Load += new System.EventHandler(this.report_invoices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Invo_Indiv_Select_topProcBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advanceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IndivisualDeliverBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveriesSelectProcBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoIndivSelecttopProcBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advanceDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource invoIndivSelecttopProcBindingSource;
        private advanceDataSetTableAdapters.Invo_Indiv_Select_topProcTableAdapter invo_Indiv_Select_topProcTableAdapter;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        public advanceDataSet advanceDataSet;
        private System.Windows.Forms.BindingSource Invo_Indiv_Select_topProcBindingSource;
        private System.Windows.Forms.BindingSource IndivisualDeliverBindingSource;
        private advanceDataSetTableAdapters.IndivisualDeliverTableAdapter IndivisualDeliverTableAdapter;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource advanceDataSetBindingSource;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.BindingSource deliveriesSelectProcBindingSource;
        private advanceDataSetTableAdapters.DeliveriesSelectProcTableAdapter deliveriesSelectProcTableAdapter;
    }
}