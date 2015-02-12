namespace LOGISTICMANAGAMENTSYSTEM.VIEW
{
    partial class FormVIEWSATUAN
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVIEWSATUAN));
            this.dgvSATUAN = new System.Windows.Forms.DataGridView();
            this.NAMASATUAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSATUAN)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSATUAN
            // 
            this.dgvSATUAN.AllowUserToAddRows = false;
            this.dgvSATUAN.AllowUserToResizeRows = false;
            this.dgvSATUAN.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvSATUAN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSATUAN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NAMASATUAN,
            this.ISI});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSATUAN.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSATUAN.Location = new System.Drawing.Point(2, 2);
            this.dgvSATUAN.Name = "dgvSATUAN";
            this.dgvSATUAN.ReadOnly = true;
            this.dgvSATUAN.RowHeadersVisible = false;
            this.dgvSATUAN.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSATUAN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSATUAN.Size = new System.Drawing.Size(342, 207);
            this.dgvSATUAN.TabIndex = 0;
            this.dgvSATUAN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSATUAN_CellClick);
            // 
            // NAMASATUAN
            // 
            this.NAMASATUAN.HeaderText = "NAMA SATUAN";
            this.NAMASATUAN.Name = "NAMASATUAN";
            this.NAMASATUAN.ReadOnly = true;
            this.NAMASATUAN.Width = 240;
            // 
            // ISI
            // 
            this.ISI.HeaderText = "ISI";
            this.ISI.Name = "ISI";
            this.ISI.ReadOnly = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 212);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(346, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // FormVIEWSATUAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(346, 234);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgvSATUAN);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormVIEWSATUAN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SATUAN";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dgvSATUAN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSATUAN;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAMASATUAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISI;
    }
}