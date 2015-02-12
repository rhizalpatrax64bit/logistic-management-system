namespace LOGISTICMANAGAMENTSYSTEM.REPORTS.EXPRESS
{
    partial class FormViewerCARGO
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
            this.reportViewerCARGO = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerCARGO
            // 
            this.reportViewerCARGO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerCARGO.LocalReport.ReportEmbeddedResource = "LOGISTICMANAGAMENTSYSTEM.REPORTS.INVOICE.reportPENERIMAANCARGO.rdlc";
            this.reportViewerCARGO.Location = new System.Drawing.Point(0, 0);
            this.reportViewerCARGO.Name = "reportViewerCARGO";
            this.reportViewerCARGO.Size = new System.Drawing.Size(1284, 608);
            this.reportViewerCARGO.TabIndex = 0;
            // 
            // FormViewerCARGO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1284, 608);
            this.Controls.Add(this.reportViewerCARGO);
            this.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.Name = "FormViewerCARGO";
            this.Text = "REPORT PENGIRIMAN BARANG";
            this.Load += new System.EventHandler(this.FormViewerCARGO_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerCARGO;
    }
}