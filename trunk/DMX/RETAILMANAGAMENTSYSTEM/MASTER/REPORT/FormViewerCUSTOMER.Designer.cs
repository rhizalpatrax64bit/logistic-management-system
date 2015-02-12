namespace LOGISTICMANAGAMENTSYSTEM.MASTER.REPORT
{
    partial class FormViewerCUSTOMER
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
            this.reportViewerCUSTOMER = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsCUSTOMER = new LOGISTICMANAGAMENTSYSTEM.MASTER.REPORT.dsCUSTOMER();
            this.v_customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dsCUSTOMER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewerCUSTOMER
            // 
            this.reportViewerCUSTOMER.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsCUSTOMER_v_customer";
            reportDataSource1.Value = this.v_customerBindingSource;
            this.reportViewerCUSTOMER.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerCUSTOMER.LocalReport.ReportEmbeddedResource = "LOGISTICMANAGAMENTSYSTEM.MASTER.REPORT.masterCUSTOMER.rdlc";
            this.reportViewerCUSTOMER.Location = new System.Drawing.Point(0, 0);
            this.reportViewerCUSTOMER.Name = "reportViewerCUSTOMER";
            this.reportViewerCUSTOMER.Size = new System.Drawing.Size(900, 484);
            this.reportViewerCUSTOMER.TabIndex = 0;
            // 
            // dsCUSTOMER
            // 
            this.dsCUSTOMER.DataSetName = "dsCUSTOMER";
            this.dsCUSTOMER.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_customerBindingSource
            // 
            this.v_customerBindingSource.DataMember = "v_customer";
            this.v_customerBindingSource.DataSource = this.dsCUSTOMER;
            // 
            // FormViewerCUSTOMER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(900, 484);
            this.Controls.Add(this.reportViewerCUSTOMER);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Name = "FormViewerCUSTOMER";
            this.Text = "FormViewerCUSTOMER";
            this.Load += new System.EventHandler(this.FormViewerCUSTOMER_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsCUSTOMER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_customerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerCUSTOMER;
        private System.Windows.Forms.BindingSource v_customerBindingSource;
        private dsCUSTOMER dsCUSTOMER;

    }
}