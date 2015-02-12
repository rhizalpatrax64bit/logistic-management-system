namespace LOGISTICMANAGAMENTSYSTEM.REPORTS.EXPRESS
{
    partial class FormRESIEXPRESS
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
            this.V_TRANSAKSIEXPRESSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsRESI = new LOGISTICMANAGAMENTSYSTEM.REPORTS.EXPRESS.dsRESI();
            this.reportViewerCETAKRESI = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.V_TRANSAKSIEXPRESSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRESI)).BeginInit();
            this.SuspendLayout();
            // 
            // V_TRANSAKSIEXPRESSBindingSource
            // 
            this.V_TRANSAKSIEXPRESSBindingSource.DataMember = "V_TRANSAKSIEXPRESS";
            this.V_TRANSAKSIEXPRESSBindingSource.DataSource = this.dsRESI;
            // 
            // dsRESI
            // 
            this.dsRESI.DataSetName = "dsRESI";
            this.dsRESI.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewerCETAKRESI
            // 
            this.reportViewerCETAKRESI.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsRESI_V_TRANSAKSIEXPRESS";
            reportDataSource1.Value = this.V_TRANSAKSIEXPRESSBindingSource;
            this.reportViewerCETAKRESI.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerCETAKRESI.LocalReport.ReportEmbeddedResource = "LOGISTICMANAGAMENTSYSTEM.REPORTS.EXPRESS.cetakRESI.rdlc";
            this.reportViewerCETAKRESI.Location = new System.Drawing.Point(0, 0);
            this.reportViewerCETAKRESI.Name = "reportViewerCETAKRESI";
            this.reportViewerCETAKRESI.Size = new System.Drawing.Size(978, 571);
            this.reportViewerCETAKRESI.TabIndex = 0;
            // 
            // FormRESIEXPRESS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 571);
            this.Controls.Add(this.reportViewerCETAKRESI);
            this.Name = "FormRESIEXPRESS";
            this.Text = "FormRESIEXPRESS";
            this.Load += new System.EventHandler(this.FormRESIEXPRESS_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormRESIEXPRESS_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.V_TRANSAKSIEXPRESSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRESI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource V_TRANSAKSIEXPRESSBindingSource;
        private dsRESI dsRESI;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerCETAKRESI;

    }
}