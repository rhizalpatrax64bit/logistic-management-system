namespace LOGISTICMANAGAMENTSYSTEM.REPORTS.PIUTANG
{
    partial class FormLAPORANPIUTANG
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
            this.reportViewerPIUTANG = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerPIUTANG
            // 
            this.reportViewerPIUTANG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerPIUTANG.LocalReport.ReportEmbeddedResource = "LOGISTICMANAGAMENTSYSTEM.REPORTS.PIUTANG.reportPIUTANG.rdlc";
            this.reportViewerPIUTANG.Location = new System.Drawing.Point(0, 0);
            this.reportViewerPIUTANG.Name = "reportViewerPIUTANG";
            this.reportViewerPIUTANG.Size = new System.Drawing.Size(1284, 608);
            this.reportViewerPIUTANG.TabIndex = 0;
            // 
            // FormLAPORANPIUTANG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1284, 608);
            this.Controls.Add(this.reportViewerPIUTANG);
            this.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormLAPORANPIUTANG";
            this.Text = "REPORT PIUTANG";
            this.Load += new System.EventHandler(this.FormLAPORANPIUTANG_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerPIUTANG;

    }
}