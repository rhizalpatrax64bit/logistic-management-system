namespace LOGISTICMANAGAMENTSYSTEM.REPORTS.INVOICE
{
    partial class FormBIAYASTT
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
            this.crystalReportViewerBIAYASTT = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerBIAYASTT
            // 
            this.crystalReportViewerBIAYASTT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerBIAYASTT.LocalReport.ReportEmbeddedResource = "LOGISTICMANAGAMENTSYSTEM.REPORTS.INVOICE.reportBIAYA.rdlc";
            this.crystalReportViewerBIAYASTT.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerBIAYASTT.Name = "crystalReportViewerBIAYASTT";
            this.crystalReportViewerBIAYASTT.Size = new System.Drawing.Size(1284, 608);
            this.crystalReportViewerBIAYASTT.TabIndex = 0;
            // 
            // FormBIAYASTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1284, 608);
            this.Controls.Add(this.crystalReportViewerBIAYASTT);
            this.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.Name = "FormBIAYASTT";
            this.Text = "REPORT BIAYA STT";
            this.Load += new System.EventHandler(this.FormBIAYASTT_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormBIAYASTT_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer crystalReportViewerBIAYASTT;

    }
}