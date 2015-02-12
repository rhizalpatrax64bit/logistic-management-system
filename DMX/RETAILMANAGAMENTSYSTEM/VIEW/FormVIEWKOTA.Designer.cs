namespace LOGISTICMANAGAMENTSYSTEM.VIEW
{
    partial class FormVIEWKOTA
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
            this.txtCARI = new System.Windows.Forms.TextBox();
            this.dgvKOTA = new System.Windows.Forms.DataGridView();
            this.IDKOTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKOTA)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCARI
            // 
            this.txtCARI.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtCARI.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCARI.Location = new System.Drawing.Point(3, 56);
            this.txtCARI.Name = "txtCARI";
            this.txtCARI.Size = new System.Drawing.Size(560, 27);
            this.txtCARI.TabIndex = 0;
            this.txtCARI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCARI.TextChanged += new System.EventHandler(this.txtCARI_TextChanged);
            // 
            // dgvKOTA
            // 
            this.dgvKOTA.AllowUserToAddRows = false;
            this.dgvKOTA.AllowUserToResizeRows = false;
            this.dgvKOTA.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvKOTA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKOTA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDKOTA,
            this.KODE,
            this.NAMA});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKOTA.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKOTA.Location = new System.Drawing.Point(3, 87);
            this.dgvKOTA.Name = "dgvKOTA";
            this.dgvKOTA.ReadOnly = true;
            this.dgvKOTA.RowHeadersVisible = false;
            this.dgvKOTA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvKOTA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKOTA.Size = new System.Drawing.Size(708, 285);
            this.dgvKOTA.TabIndex = 1;
            this.dgvKOTA.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKOTA_CellClick);
            this.dgvKOTA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvKOTA_KeyDown);
            // 
            // IDKOTA
            // 
            this.IDKOTA.HeaderText = "IDKOTA";
            this.IDKOTA.Name = "IDKOTA";
            this.IDKOTA.ReadOnly = true;
            this.IDKOTA.Visible = false;
            this.IDKOTA.Width = 50;
            // 
            // KODE
            // 
            this.KODE.HeaderText = "Kode Area";
            this.KODE.Name = "KODE";
            this.KODE.ReadOnly = true;
            // 
            // NAMA
            // 
            this.NAMA.HeaderText = "Nama Kota";
            this.NAMA.Name = "NAMA";
            this.NAMA.ReadOnly = true;
            this.NAMA.Width = 350;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 48);
            this.panel1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ketikan kode atau nama kota di kotak pencarian";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "TABEL KOTA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(569, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "CARI [ F1 ]";
            // 
            // FormVIEWKOTA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(707, 387);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtCARI);
            this.Controls.Add(this.dgvKOTA);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormVIEWKOTA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PENCARIAN KOTA";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormVIEWKOTA_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormVIEWKOTA_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKOTA)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCARI;
        private System.Windows.Forms.DataGridView dgvKOTA;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDKOTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn KODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAMA;
    }
}