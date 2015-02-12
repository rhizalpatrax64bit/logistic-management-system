namespace LOGISTICMANAGAMENTSYSTEM.MASTER.REPORT
{
    partial class FormViewerPENERIMA
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
            this.reportViewerPENERIMA = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerPENERIMA
            // 
            this.reportViewerPENERIMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerPENERIMA.Location = new System.Drawing.Point(0, 0);
            this.reportViewerPENERIMA.Name = "reportViewerPENERIMA";
            this.reportViewerPENERIMA.Size = new System.Drawing.Size(1284, 608);
            this.reportViewerPENERIMA.TabIndex = 0;
            // 
            // FormViewerPENERIMA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1284, 608);
            this.Controls.Add(this.reportViewerPENERIMA);
            this.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.Name = "FormViewerPENERIMA";
            this.Text = "REPORT PENERIMA";
            this.Load += new System.EventHandler(this.FormViewerPENERIMA_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormViewerPENERIMA_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerPENERIMA;

    }
}