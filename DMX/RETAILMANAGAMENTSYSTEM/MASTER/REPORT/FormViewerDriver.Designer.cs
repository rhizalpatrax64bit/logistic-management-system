namespace LOGISTICMANAGAMENTSYSTEM.MASTER.REPORT
{
    partial class FormViewerDriver
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
            this.reportViewerDRIVER = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsDRIVER = new LOGISTICMANAGAMENTSYSTEM.MASTER.REPORT.dsDRIVER();
            this.v_driverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dsDRIVER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_driverBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewerDRIVER.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsDRIVER_v_driver";
            reportDataSource1.Value = this.v_driverBindingSource;
            this.reportViewerDRIVER.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerDRIVER.LocalReport.ReportEmbeddedResource = "LOGISTICMANAGAMENTSYSTEM.MASTER.REPORT.masterDriver.rdlc";
            this.reportViewerDRIVER.Location = new System.Drawing.Point(0, 0);
            this.reportViewerDRIVER.Name = "reportViewer1";
            this.reportViewerDRIVER.Size = new System.Drawing.Size(900, 484);
            this.reportViewerDRIVER.TabIndex = 0;
            // 
            // dsDRIVER
            // 
            this.dsDRIVER.DataSetName = "dsDRIVER";
            this.dsDRIVER.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_driverBindingSource
            // 
            this.v_driverBindingSource.DataMember = "v_driver";
            this.v_driverBindingSource.DataSource = this.dsDRIVER;
            // 
            // FormViewerDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(900, 484);
            this.Controls.Add(this.reportViewerDRIVER);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Name = "FormViewerDriver";
            this.Text = "FormViewerDriver";
            this.Load += new System.EventHandler(this.FormViewerDriver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsDRIVER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_driverBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerDRIVER;
        private System.Windows.Forms.BindingSource v_driverBindingSource;
        private dsDRIVER dsDRIVER;
    }
}