namespace LOGISTICMANAGAMENTSYSTEM.MASTER.REPORT
{
    partial class FormViewerAGENT
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsAGENT = new LOGISTICMANAGAMENTSYSTEM.MASTER.REPORT.dsAGENT();
            this.v_agentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dsAGENT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_agentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "dsAGENT_v_agent";
            reportDataSource1.Value = this.v_agentBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LOGISTICMANAGAMENTSYSTEM.MASTER.REPORT.masterAgent.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-5, -3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1291, 609);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsAGENT
            // 
            this.dsAGENT.DataSetName = "dsAGENT";
            this.dsAGENT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_agentBindingSource
            // 
            this.v_agentBindingSource.DataMember = "v_agent";
            this.v_agentBindingSource.DataSource = this.dsAGENT;
            // 
            // FormViewerAGENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1284, 608);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.Name = "FormViewerAGENT";
            this.Text = "REPORT AGENT";
            this.Load += new System.EventHandler(this.FormViewerAGENT_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormViewerAGENT_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dsAGENT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_agentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource v_agentBindingSource;
        private dsAGENT dsAGENT;

    }
}