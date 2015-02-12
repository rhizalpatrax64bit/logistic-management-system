namespace LOGISTICMANAGAMENTSYSTEM.MASTER.REPORT
{
    partial class FormViewerMARKETING
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.reportViewerMARKETING = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsMARKETING = new LOGISTICMANAGAMENTSYSTEM.MASTER.REPORT.dsMARKETING();
            this._v_marketingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dsMARKETING)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._v_marketingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.SelectionFormula = "";
            this.crystalReportViewer1.Size = new System.Drawing.Size(284, 262);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ViewTimeSelectionFormula = "";
            // 
            // reportViewerMARKETING
            // 
            this.reportViewerMARKETING.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsMARKETING__v_marketing";
            reportDataSource1.Value = this._v_marketingBindingSource;
            this.reportViewerMARKETING.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerMARKETING.LocalReport.ReportEmbeddedResource = "LOGISTICMANAGAMENTSYSTEM.MASTER.REPORT.masterMarketing.rdlc";
            this.reportViewerMARKETING.Location = new System.Drawing.Point(0, 0);
            this.reportViewerMARKETING.Name = "reportViewerMARKETING";
            this.reportViewerMARKETING.Size = new System.Drawing.Size(900, 484);
            this.reportViewerMARKETING.TabIndex = 0;
            // 
            // dsMARKETING
            // 
            this.dsMARKETING.DataSetName = "dsMARKETING";
            this.dsMARKETING.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // _v_marketingBindingSource
            // 
            this._v_marketingBindingSource.DataMember = " v_marketing";
            this._v_marketingBindingSource.DataSource = this.dsMARKETING;
            // 
            // FormViewerMARKETING
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(900, 484);
            this.Controls.Add(this.reportViewerMARKETING);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Name = "FormViewerMARKETING";
            this.Text = "FormViewerMARKETING";
            this.Load += new System.EventHandler(this.FormViewerMARKETING_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormViewerMARKETING_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dsMARKETING)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._v_marketingBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerMARKETING;
        private System.Windows.Forms.BindingSource _v_marketingBindingSource;
        private dsMARKETING dsMARKETING;
    }
}