namespace LOGISTICMANAGAMENTSYSTEM.REPORTS.EXPRESS
{
    partial class FormViewerSPJ
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
            this.reportViewerSPJ = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportSPJ = new LOGISTICMANAGAMENTSYSTEM.REPORTS.EXPRESS.reportSPJ();
            this.v_spjBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.reportSPJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_spjBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewerSPJ
            // 
            this.reportViewerSPJ.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "reportSPJ_v_spj";
            reportDataSource1.Value = this.v_spjBindingSource;
            this.reportViewerSPJ.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerSPJ.LocalReport.ReportEmbeddedResource = "LOGISTICMANAGAMENTSYSTEM.REPORTS.EXPRESS.reportSPJ.rdlc";
            this.reportViewerSPJ.Location = new System.Drawing.Point(0, 0);
            this.reportViewerSPJ.Name = "reportViewerSPJ";
            this.reportViewerSPJ.Size = new System.Drawing.Size(1284, 608);
            this.reportViewerSPJ.TabIndex = 0;
            // 
            // reportSPJ
            // 
            this.reportSPJ.DataSetName = "reportSPJ";
            this.reportSPJ.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_spjBindingSource
            // 
            this.v_spjBindingSource.DataMember = "v_spj";
            this.v_spjBindingSource.DataSource = this.reportSPJ;
            // 
            // FormViewerSPJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1284, 608);
            this.Controls.Add(this.reportViewerSPJ);
            this.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.Name = "FormViewerSPJ";
            this.Text = "REPORT BONGKAR MUAT (SPJ)";
            this.Load += new System.EventHandler(this.FormViewerSPJ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportSPJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_spjBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerSPJ;
        private System.Windows.Forms.BindingSource v_spjBindingSource;
        private reportSPJ reportSPJ;

    }
}