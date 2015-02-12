namespace LOGISTICMANAGAMENTSYSTEM.REPORTS.INVOICE
{
    partial class FormViewerRESICARGO
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
            this.reportViewerRESICARGO = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerRESICARGO
            // 
            this.reportViewerRESICARGO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerRESICARGO.LocalReport.ReportEmbeddedResource = "LOGISTICMANAGAMENTSYSTEM.REPORTS.INVOICE.cetakRESICARGO.rdlc";
            this.reportViewerRESICARGO.Location = new System.Drawing.Point(0, 0);
            this.reportViewerRESICARGO.Name = "reportViewerRESICARGO";
            this.reportViewerRESICARGO.Size = new System.Drawing.Size(978, 571);
            this.reportViewerRESICARGO.TabIndex = 0;
            // 
            // FormViewerRESICARGO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 571);
            this.Controls.Add(this.reportViewerRESICARGO);
            this.Name = "FormViewerRESICARGO";
            this.Text = "RESI CARGO";
            this.Load += new System.EventHandler(this.FormViewerRESICARGO_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerRESICARGO;
    }
}