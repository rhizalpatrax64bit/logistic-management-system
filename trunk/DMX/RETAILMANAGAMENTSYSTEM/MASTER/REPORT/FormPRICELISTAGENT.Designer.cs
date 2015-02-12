namespace LOGISTICMANAGAMENTSYSTEM.MASTER.REPORT
{
    partial class FormPRICELISTAGENT
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
            this.reportViewerPRICELISTAGENT = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsPRICELISTAGENT = new LOGISTICMANAGAMENTSYSTEM.MASTER.REPORT.dsPRICELISTAGENT();
            this.PRICELISTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dsPRICELISTAGENT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRICELISTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewerPRICELISTAGENT
            // 
            this.reportViewerPRICELISTAGENT.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsPRICELISTAGENT_PRICELIST";
            reportDataSource1.Value = this.PRICELISTBindingSource;
            this.reportViewerPRICELISTAGENT.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerPRICELISTAGENT.LocalReport.ReportEmbeddedResource = "LOGISTICMANAGAMENTSYSTEM.MASTER.REPORT.pricelistAgent.rdlc";
            this.reportViewerPRICELISTAGENT.Location = new System.Drawing.Point(0, 0);
            this.reportViewerPRICELISTAGENT.Name = "reportViewerPRICELISTAGENT";
            this.reportViewerPRICELISTAGENT.Size = new System.Drawing.Size(1284, 608);
            this.reportViewerPRICELISTAGENT.TabIndex = 0;
            this.reportViewerPRICELISTAGENT.Load += new System.EventHandler(this.reportViewerPRICELISTAGENT_Load);
            // 
            // dsPRICELISTAGENT
            // 
            this.dsPRICELISTAGENT.DataSetName = "dsPRICELISTAGENT";
            this.dsPRICELISTAGENT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PRICELISTBindingSource
            // 
            this.PRICELISTBindingSource.DataMember = "PRICELIST";
            this.PRICELISTBindingSource.DataSource = this.dsPRICELISTAGENT;
            // 
            // FormPRICELISTAGENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1284, 608);
            this.Controls.Add(this.reportViewerPRICELISTAGENT);
            this.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.Name = "FormPRICELISTAGENT";
            this.Text = "PRICELISTAGENT";
            this.Load += new System.EventHandler(this.FormPRICELISTAGENT_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormPRICELISTAGENT_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dsPRICELISTAGENT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRICELISTBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerPRICELISTAGENT;
        private System.Windows.Forms.BindingSource PRICELISTBindingSource;
        private dsPRICELISTAGENT dsPRICELISTAGENT;

    }
}