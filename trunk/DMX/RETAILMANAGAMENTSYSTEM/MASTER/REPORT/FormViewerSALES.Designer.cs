namespace LOGISTICMANAGAMENTSYSTEM.MASTER.REPORT
{
    partial class FormViewerSALES
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
            this.crystalReportSALES = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportSALES
            // 
            this.crystalReportSALES.ActiveViewIndex = -1;
            this.crystalReportSALES.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportSALES.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportSALES.Location = new System.Drawing.Point(0, 0);
            this.crystalReportSALES.Name = "crystalReportSALES";
            this.crystalReportSALES.SelectionFormula = "";
            this.crystalReportSALES.Size = new System.Drawing.Size(900, 484);
            this.crystalReportSALES.TabIndex = 0;
            this.crystalReportSALES.ViewTimeSelectionFormula = "";
            // 
            // FormViewerSALES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(900, 484);
            this.Controls.Add(this.crystalReportSALES);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Name = "FormViewerSALES";
            this.Text = "FormViewerSALES";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormViewerSALES_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportSALES;
    }
}