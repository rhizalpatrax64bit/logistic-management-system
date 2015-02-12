namespace LOGISTICMANAGAMENTSYSTEM.MASTER.REPORT
{
    partial class FormViewerKENDARAAN
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
            this.reportViewerKENDARAAN = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsKENDARAAN = new LOGISTICMANAGAMENTSYSTEM.MASTER.REPORT.dsKENDARAAN();
            this.v_kendaraanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dsKENDARAAN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_kendaraanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewerKENDARAAN.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsKENDARAAN_v_kendaraan";
            reportDataSource1.Value = this.v_kendaraanBindingSource;
            this.reportViewerKENDARAAN.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerKENDARAAN.LocalReport.ReportEmbeddedResource = "LOGISTICMANAGAMENTSYSTEM.MASTER.REPORT.masterKENDARAAN.rdlc";
            this.reportViewerKENDARAAN.Location = new System.Drawing.Point(0, 0);
            this.reportViewerKENDARAAN.Name = "reportViewer1";
            this.reportViewerKENDARAAN.Size = new System.Drawing.Size(900, 484);
            this.reportViewerKENDARAAN.TabIndex = 0;
            // 
            // dsKENDARAAN
            // 
            this.dsKENDARAAN.DataSetName = "dsKENDARAAN";
            this.dsKENDARAAN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_kendaraanBindingSource
            // 
            this.v_kendaraanBindingSource.DataMember = "v_kendaraan";
            this.v_kendaraanBindingSource.DataSource = this.dsKENDARAAN;
            // 
            // FormViewerKENDARAAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(900, 484);
            this.Controls.Add(this.reportViewerKENDARAAN);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Name = "FormViewerKENDARAAN";
            this.Text = "FormViewerKENDARAAN";
            this.Load += new System.EventHandler(this.FormViewerKENDARAAN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsKENDARAAN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_kendaraanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerKENDARAAN;
        private System.Windows.Forms.BindingSource v_kendaraanBindingSource;
        private dsKENDARAAN dsKENDARAAN;
    }
}