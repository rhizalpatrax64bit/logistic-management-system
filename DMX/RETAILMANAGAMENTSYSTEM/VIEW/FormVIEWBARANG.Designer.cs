namespace LOGISTICMANAGAMENTSYSTEM.VIEW
{
    partial class FormVIEWBARANG
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
            this.dgvBARANG = new System.Windows.Forms.DataGridView();
            this.KODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BARCODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HARGAJUALKRT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HARGAJUALPCS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STOK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.rdbKODE = new System.Windows.Forms.RadioButton();
            this.rdbNAMA = new System.Windows.Forms.RadioButton();
            this.txtCARI = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBARANG)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBARANG
            // 
            this.dgvBARANG.AllowUserToAddRows = false;
            this.dgvBARANG.AllowUserToResizeRows = false;
            this.dgvBARANG.BackgroundColor = System.Drawing.Color.Black;
            this.dgvBARANG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBARANG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KODE,
            this.NAMA,
            this.BARCODE,
            this.HARGAJUALKRT,
            this.HARGAJUALPCS,
            this.STOK});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBARANG.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBARANG.Location = new System.Drawing.Point(2, 33);
            this.dgvBARANG.Name = "dgvBARANG";
            this.dgvBARANG.ReadOnly = true;
            this.dgvBARANG.RowHeadersVisible = false;
            this.dgvBARANG.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvBARANG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBARANG.Size = new System.Drawing.Size(918, 401);
            this.dgvBARANG.TabIndex = 0;
            this.dgvBARANG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBARANG_CellClick);
            // 
            // KODE
            // 
            this.KODE.HeaderText = "KODE";
            this.KODE.Name = "KODE";
            this.KODE.ReadOnly = true;
            this.KODE.Width = 120;
            // 
            // NAMA
            // 
            this.NAMA.HeaderText = "NAMA";
            this.NAMA.Name = "NAMA";
            this.NAMA.ReadOnly = true;
            this.NAMA.Width = 315;
            // 
            // BARCODE
            // 
            this.BARCODE.HeaderText = "BARCODE";
            this.BARCODE.Name = "BARCODE";
            this.BARCODE.ReadOnly = true;
            this.BARCODE.Width = 140;
            // 
            // HARGAJUALKRT
            // 
            this.HARGAJUALKRT.HeaderText = "HARGA JUAL KRT";
            this.HARGAJUALKRT.Name = "HARGAJUALKRT";
            this.HARGAJUALKRT.ReadOnly = true;
            this.HARGAJUALKRT.Width = 120;
            // 
            // HARGAJUALPCS
            // 
            this.HARGAJUALPCS.HeaderText = "HARGA JUAL PCS";
            this.HARGAJUALPCS.Name = "HARGAJUALPCS";
            this.HARGAJUALPCS.ReadOnly = true;
            this.HARGAJUALPCS.Width = 120;
            // 
            // STOK
            // 
            this.STOK.HeaderText = "STOK";
            this.STOK.Name = "STOK";
            this.STOK.ReadOnly = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 437);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(924, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // rdbKODE
            // 
            this.rdbKODE.AutoSize = true;
            this.rdbKODE.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbKODE.ForeColor = System.Drawing.Color.White;
            this.rdbKODE.Location = new System.Drawing.Point(3, 3);
            this.rdbKODE.Name = "rdbKODE";
            this.rdbKODE.Size = new System.Drawing.Size(181, 27);
            this.rdbKODE.TabIndex = 2;
            this.rdbKODE.TabStop = true;
            this.rdbKODE.Text = "KODE BARANG [F3]";
            this.rdbKODE.UseVisualStyleBackColor = true;
            // 
            // rdbNAMA
            // 
            this.rdbNAMA.AutoSize = true;
            this.rdbNAMA.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNAMA.ForeColor = System.Drawing.Color.White;
            this.rdbNAMA.Location = new System.Drawing.Point(190, 2);
            this.rdbNAMA.Name = "rdbNAMA";
            this.rdbNAMA.Size = new System.Drawing.Size(192, 27);
            this.rdbNAMA.TabIndex = 2;
            this.rdbNAMA.TabStop = true;
            this.rdbNAMA.Text = "NAMA BARANG [F4]";
            this.rdbNAMA.UseVisualStyleBackColor = true;
            // 
            // txtCARI
            // 
            this.txtCARI.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtCARI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCARI.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCARI.Location = new System.Drawing.Point(389, 3);
            this.txtCARI.Name = "txtCARI";
            this.txtCARI.Size = new System.Drawing.Size(533, 27);
            this.txtCARI.TabIndex = 3;
            this.txtCARI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCARI.TextChanged += new System.EventHandler(this.txtCARI_TextChanged);
            // 
            // FormVIEWBARANG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(924, 459);
            this.Controls.Add(this.txtCARI);
            this.Controls.Add(this.rdbNAMA);
            this.Controls.Add(this.rdbKODE);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgvBARANG);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FormVIEWBARANG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVIEWBARANG";
            this.TopMost = true;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormVIEWBARANG_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBARANG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBARANG;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.RadioButton rdbKODE;
        private System.Windows.Forms.RadioButton rdbNAMA;
        private System.Windows.Forms.TextBox txtCARI;
        private System.Windows.Forms.DataGridViewTextBoxColumn KODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn BARCODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn HARGAJUALKRT;
        private System.Windows.Forms.DataGridViewTextBoxColumn HARGAJUALPCS;
        private System.Windows.Forms.DataGridViewTextBoxColumn STOK;
    }
}