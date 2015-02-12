namespace LOGISTICMANAGAMENTSYSTEM.MASTER.REPORT
{
    partial class FormViewerPRICELIST
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
            this.reportViewerPRICELIST = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PRICELIST = new LOGISTICMANAGAMENTSYSTEM.MASTER.REPORT.PRICELIST();
            this.PRICELISTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PRICELIST)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRICELISTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewerPRICELIST
            // 
            this.reportViewerPRICELIST.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "PRICELIST_PRICELIST";
            reportDataSource1.Value = this.PRICELISTBindingSource;
            this.reportViewerPRICELIST.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerPRICELIST.LocalReport.ReportEmbeddedResource = "LOGISTICMANAGAMENTSYSTEM.MASTER.REPORT.quotationPricelist.rdlc";
            this.reportViewerPRICELIST.Location = new System.Drawing.Point(0, 0);
            this.reportViewerPRICELIST.Name = "reportViewerPRICELIST";
            this.reportViewerPRICELIST.Size = new System.Drawing.Size(1284, 608);
            this.reportViewerPRICELIST.TabIndex = 0;
            // 
            // PRICELIST
            // 
            this.PRICELIST.DataSetName = "PRICELIST";
            this.PRICELIST.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PRICELISTBindingSource
            // 
            this.PRICELISTBindingSource.DataMember = "PRICELIST";
            this.PRICELISTBindingSource.DataSource = this.PRICELIST;
            // 
            // FormViewerPRICELIST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1284, 608);
            this.Controls.Add(this.reportViewerPRICELIST);
            this.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.Name = "FormViewerPRICELIST";
            this.Text = "PRICELIST";
            this.Load += new System.EventHandler(this.FormViewerPRICELIST_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormViewerPRICELIST_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.PRICELIST)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRICELISTBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerPRICELIST;
        private System.Windows.Forms.BindingSource PRICELISTBindingSource;
        private PRICELIST PRICELIST;

    }
}