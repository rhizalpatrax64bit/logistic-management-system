namespace LOGISTICMANAGAMENTSYSTEM.DELIVERYORDER
{
    partial class FormORDERTRACKING
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
            this.lblTitleMarketing = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitleMarketing
            // 
            this.lblTitleMarketing.AutoSize = true;
            this.lblTitleMarketing.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleMarketing.ForeColor = System.Drawing.Color.White;
            this.lblTitleMarketing.Location = new System.Drawing.Point(12, 21);
            this.lblTitleMarketing.Name = "lblTitleMarketing";
            this.lblTitleMarketing.Size = new System.Drawing.Size(214, 33);
            this.lblTitleMarketing.TabIndex = 23;
            this.lblTitleMarketing.Text = "ORDER TRACKING";
            // 
            // FormORDERTRACKING
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(900, 484);
            this.Controls.Add(this.lblTitleMarketing);
            this.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormORDERTRACKING";
            this.Text = "FormORDERTRACKING";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleMarketing;
    }
}