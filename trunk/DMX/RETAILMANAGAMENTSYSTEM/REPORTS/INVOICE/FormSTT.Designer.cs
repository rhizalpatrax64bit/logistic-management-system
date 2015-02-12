namespace LOGISTICMANAGAMENTSYSTEM.REPORTS.INVOICE
{
    partial class FormSTT
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
            this.reportViewerPENERIMAANCARGO = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsPENERIMAANCARGO = new LOGISTICMANAGAMENTSYSTEM.REPORTS.INVOICE.dsPENERIMAANCARGO();
            this.V_STTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dsPENERIMAANCARGO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.V_STTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewerPENERIMAANCARGO
            // 
            this.reportViewerPENERIMAANCARGO.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsPENERIMAANCARGO_V_STT";
            reportDataSource1.Value = this.V_STTBindingSource;
            this.reportViewerPENERIMAANCARGO.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerPENERIMAANCARGO.LocalReport.ReportEmbeddedResource = "LOGISTICMANAGAMENTSYSTEM.REPORTS.INVOICE.reportPENERIMAANCARGO.rdlc";
            this.reportViewerPENERIMAANCARGO.Location = new System.Drawing.Point(0, 0);
            this.reportViewerPENERIMAANCARGO.Name = "reportViewerPENERIMAANCARGO";
            this.reportViewerPENERIMAANCARGO.Size = new System.Drawing.Size(1284, 608);
            this.reportViewerPENERIMAANCARGO.TabIndex = 0;
            // 
            // dsPENERIMAANCARGO
            // 
            this.dsPENERIMAANCARGO.DataSetName = "dsPENERIMAANCARGO";
            this.dsPENERIMAANCARGO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // V_STTBindingSource
            // 
            this.V_STTBindingSource.DataMember = "V_STT";
            this.V_STTBindingSource.DataSource = this.dsPENERIMAANCARGO;
            // 
            // FormSTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1284, 608);
            this.Controls.Add(this.reportViewerPENERIMAANCARGO);
            this.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.Name = "FormSTT";
            this.Text = "REPORT STT";
            this.Load += new System.EventHandler(this.FormSTT_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormSTT_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dsPENERIMAANCARGO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.V_STTBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerPENERIMAANCARGO;
        private System.Windows.Forms.BindingSource V_STTBindingSource;
        private dsPENERIMAANCARGO dsPENERIMAANCARGO;

    }
}