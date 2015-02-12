namespace LOGISTICMANAGAMENTSYSTEM.REPORTS.EXPRESS
{
    partial class FormViewerCETAKSPJ
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
            this.dsSPJ = new LOGISTICMANAGAMENTSYSTEM.REPORTS.EXPRESS.dsSPJ();
            this.v_cetak_spjBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dsSPJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_cetak_spjBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsSPJ_v_cetak_spj";
            reportDataSource1.Value = this.v_cetak_spjBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LOGISTICMANAGAMENTSYSTEM.REPORTS.EXPRESS.cetakSPJ.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1284, 608);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsSPJ
            // 
            this.dsSPJ.DataSetName = "dsSPJ";
            this.dsSPJ.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_cetak_spjBindingSource
            // 
            this.v_cetak_spjBindingSource.DataMember = "v_cetak_spj";
            this.v_cetak_spjBindingSource.DataSource = this.dsSPJ;
            // 
            // FormViewerCETAKSPJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1284, 608);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.Name = "FormViewerCETAKSPJ";
            this.Text = "CETAK SPJ";
            this.Load += new System.EventHandler(this.FormViewerCETAKSPJ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsSPJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_cetak_spjBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource v_cetak_spjBindingSource;
        private dsSPJ dsSPJ;

    }
}