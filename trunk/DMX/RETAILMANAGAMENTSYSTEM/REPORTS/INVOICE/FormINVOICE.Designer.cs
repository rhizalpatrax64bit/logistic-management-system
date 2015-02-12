namespace LOGISTICMANAGAMENTSYSTEM.REPORTS.INVOICE
{
    partial class FormINVOICE
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
            this.reportViewerINVOICE = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsINVOICING = new LOGISTICMANAGAMENTSYSTEM.REPORTS.INVOICE.dsINVOICING();
            this.V_INVOICECETAKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dsINVOICING)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.V_INVOICECETAKBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewerINVOICE
            // 
            this.reportViewerINVOICE.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsINVOICING_V_INVOICECETAK";
            reportDataSource1.Value = this.V_INVOICECETAKBindingSource;
            this.reportViewerINVOICE.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerINVOICE.LocalReport.ReportEmbeddedResource = "LOGISTICMANAGAMENTSYSTEM.REPORTS.INVOICE.cetakINVOICE.rdlc";
            this.reportViewerINVOICE.Location = new System.Drawing.Point(0, 0);
            this.reportViewerINVOICE.Name = "reportViewerINVOICE";
            this.reportViewerINVOICE.Size = new System.Drawing.Size(1284, 608);
            this.reportViewerINVOICE.TabIndex = 0;
            // 
            // dsINVOICING
            // 
            this.dsINVOICING.DataSetName = "dsINVOICING";
            this.dsINVOICING.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // V_INVOICECETAKBindingSource
            // 
            this.V_INVOICECETAKBindingSource.DataMember = "V_INVOICECETAK";
            this.V_INVOICECETAKBindingSource.DataSource = this.dsINVOICING;
            // 
            // FormINVOICE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1284, 608);
            this.Controls.Add(this.reportViewerINVOICE);
            this.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.Name = "FormINVOICE";
            this.Text = "FormINVOICE";
            this.Load += new System.EventHandler(this.FormINVOICE_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormINVOICE_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dsINVOICING)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.V_INVOICECETAKBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerINVOICE;
        private System.Windows.Forms.BindingSource V_INVOICECETAKBindingSource;
        private dsINVOICING dsINVOICING;

    }
}