namespace LOGISTICMANAGAMENTSYSTEM.VIEW
{
    partial class FormVIEWKENDARAAN
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCARI = new System.Windows.Forms.TextBox();
            this.dgvKENDARAAN = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOPOL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JENISKENDARAAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAXMUATAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAXVOLUME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDDRIVER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDHELPER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KODEDRIVER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KODEHELPER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAMADRIVER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAMAHELPER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKENDARAAN)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(546, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "CARI [ F1 ]";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 48);
            this.panel1.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ketikan kode atau unit pengiriman";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "TABEL KENDARAAN";
            // 
            // txtCARI
            // 
            this.txtCARI.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtCARI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCARI.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCARI.Location = new System.Drawing.Point(3, 68);
            this.txtCARI.Name = "txtCARI";
            this.txtCARI.Size = new System.Drawing.Size(533, 27);
            this.txtCARI.TabIndex = 18;
            this.txtCARI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvKENDARAAN
            // 
            this.dgvKENDARAAN.AllowUserToAddRows = false;
            this.dgvKENDARAAN.AllowUserToResizeRows = false;
            this.dgvKENDARAAN.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvKENDARAAN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKENDARAAN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NOPOL,
            this.JENISKENDARAAN,
            this.MAXMUATAN,
            this.MAXVOLUME,
            this.IDDRIVER,
            this.IDHELPER,
            this.KODEDRIVER,
            this.KODEHELPER,
            this.NAMADRIVER,
            this.NAMAHELPER,
            this.STATUS});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKENDARAAN.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKENDARAAN.Location = new System.Drawing.Point(3, 101);
            this.dgvKENDARAAN.Name = "dgvKENDARAAN";
            this.dgvKENDARAAN.ReadOnly = true;
            this.dgvKENDARAAN.RowHeadersVisible = false;
            this.dgvKENDARAAN.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvKENDARAAN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKENDARAAN.Size = new System.Drawing.Size(708, 270);
            this.dgvKENDARAAN.TabIndex = 19;
            this.dgvKENDARAAN.Click += new System.EventHandler(this.dgvKENDARAAN_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // NOPOL
            // 
            this.NOPOL.HeaderText = "NoPolisi";
            this.NOPOL.Name = "NOPOL";
            this.NOPOL.ReadOnly = true;
            this.NOPOL.ToolTipText = "NoPolisi";
            this.NOPOL.Width = 120;
            // 
            // JENISKENDARAAN
            // 
            this.JENISKENDARAAN.HeaderText = "Jenis Kendaraan";
            this.JENISKENDARAAN.Name = "JENISKENDARAAN";
            this.JENISKENDARAAN.ReadOnly = true;
            this.JENISKENDARAAN.ToolTipText = "Jenis Kendaraan";
            this.JENISKENDARAAN.Width = 150;
            // 
            // MAXMUATAN
            // 
            this.MAXMUATAN.HeaderText = "Max Muatan";
            this.MAXMUATAN.Name = "MAXMUATAN";
            this.MAXMUATAN.ReadOnly = true;
            this.MAXMUATAN.Width = 150;
            // 
            // MAXVOLUME
            // 
            this.MAXVOLUME.HeaderText = "Max Volume";
            this.MAXVOLUME.Name = "MAXVOLUME";
            this.MAXVOLUME.ReadOnly = true;
            this.MAXVOLUME.ToolTipText = "Max Volume";
            this.MAXVOLUME.Width = 150;
            // 
            // IDDRIVER
            // 
            this.IDDRIVER.HeaderText = "IDDRIVER";
            this.IDDRIVER.Name = "IDDRIVER";
            this.IDDRIVER.ReadOnly = true;
            // 
            // IDHELPER
            // 
            this.IDHELPER.HeaderText = "IDHELPER";
            this.IDHELPER.Name = "IDHELPER";
            this.IDHELPER.ReadOnly = true;
            // 
            // KODEDRIVER
            // 
            this.KODEDRIVER.HeaderText = "Kode Driver";
            this.KODEDRIVER.Name = "KODEDRIVER";
            this.KODEDRIVER.ReadOnly = true;
            this.KODEDRIVER.ToolTipText = "Kode Driver";
            // 
            // KODEHELPER
            // 
            this.KODEHELPER.HeaderText = "Kode Helper";
            this.KODEHELPER.Name = "KODEHELPER";
            this.KODEHELPER.ReadOnly = true;
            this.KODEHELPER.ToolTipText = "Kode Helper";
            // 
            // NAMADRIVER
            // 
            this.NAMADRIVER.HeaderText = "Nama Driver";
            this.NAMADRIVER.Name = "NAMADRIVER";
            this.NAMADRIVER.ReadOnly = true;
            this.NAMADRIVER.ToolTipText = "Nama Driver";
            // 
            // NAMAHELPER
            // 
            this.NAMAHELPER.HeaderText = "Nama Helper";
            this.NAMAHELPER.Name = "NAMAHELPER";
            this.NAMAHELPER.ReadOnly = true;
            this.NAMAHELPER.ToolTipText = "Nama Helper";
            // 
            // STATUS
            // 
            this.STATUS.HeaderText = "Status";
            this.STATUS.Name = "STATUS";
            this.STATUS.ReadOnly = true;
            // 
            // FormVIEWKENDARAAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(696, 387);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtCARI);
            this.Controls.Add(this.dgvKENDARAAN);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Name = "FormVIEWKENDARAAN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KENDARAAN EXPRESS";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKENDARAAN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCARI;
        private System.Windows.Forms.DataGridView dgvKENDARAAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOPOL;
        private System.Windows.Forms.DataGridViewTextBoxColumn JENISKENDARAAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAXMUATAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAXVOLUME;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDDRIVER;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDHELPER;
        private System.Windows.Forms.DataGridViewTextBoxColumn KODEDRIVER;
        private System.Windows.Forms.DataGridViewTextBoxColumn KODEHELPER;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAMADRIVER;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAMAHELPER;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
    }
}