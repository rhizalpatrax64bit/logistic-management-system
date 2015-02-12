namespace LOGISTICMANAGAMENTSYSTEM.REPORTS.TAGIHAN
{
    partial class FormTAGIHAN
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
            this.crystalReportViewerTAGIHAN = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerTAGIHAN
            // 
            this.crystalReportViewerTAGIHAN.ActiveViewIndex = -1;
            this.crystalReportViewerTAGIHAN.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.crystalReportViewerTAGIHAN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerTAGIHAN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerTAGIHAN.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerTAGIHAN.Name = "crystalReportViewerTAGIHAN";
            this.crystalReportViewerTAGIHAN.SelectionFormula = "";
            this.crystalReportViewerTAGIHAN.Size = new System.Drawing.Size(1284, 608);
            this.crystalReportViewerTAGIHAN.TabIndex = 2;
            this.crystalReportViewerTAGIHAN.ViewTimeSelectionFormula = "";
            // 
            // FormTAGIHAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1284, 608);
            this.Controls.Add(this.crystalReportViewerTAGIHAN);
            this.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.Name = "FormTAGIHAN";
            this.Text = "REPORT TAGIHAN";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormTAGIHAN_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerTAGIHAN;
    }
}