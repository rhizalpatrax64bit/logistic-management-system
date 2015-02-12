namespace LOGISTICMANAGAMENTSYSTEM.MASTER.SUBMASTER
{
    partial class FormADDITEMJENISANGGOTA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormADDITEMJENISANGGOTA));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.dgvJENIS = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKODE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNAMA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSIMPAN = new System.Windows.Forms.Button();
            this.btnHAPUS = new System.Windows.Forms.Button();
            this.KODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JENISKEANGGOTAAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJENIS)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 340);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(356, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // dgvJENIS
            // 
            this.dgvJENIS.AllowUserToAddRows = false;
            this.dgvJENIS.AllowUserToResizeRows = false;
            this.dgvJENIS.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvJENIS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJENIS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KODE,
            this.JENISKEANGGOTAAN});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvJENIS.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvJENIS.Location = new System.Drawing.Point(1, 2);
            this.dgvJENIS.Name = "dgvJENIS";
            this.dgvJENIS.ReadOnly = true;
            this.dgvJENIS.RowHeadersVisible = false;
            this.dgvJENIS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJENIS.Size = new System.Drawing.Size(353, 231);
            this.dgvJENIS.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(2, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(351, 3);
            this.label2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "KODE";
            // 
            // txtKODE
            // 
            this.txtKODE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtKODE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKODE.Location = new System.Drawing.Point(56, 240);
            this.txtKODE.Name = "txtKODE";
            this.txtKODE.Size = new System.Drawing.Size(198, 23);
            this.txtKODE.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "JENIS";
            // 
            // txtNAMA
            // 
            this.txtNAMA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtNAMA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNAMA.Location = new System.Drawing.Point(56, 264);
            this.txtNAMA.Name = "txtNAMA";
            this.txtNAMA.Size = new System.Drawing.Size(296, 23);
            this.txtNAMA.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(1, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(351, 3);
            this.label4.TabIndex = 0;
            // 
            // btnSIMPAN
            // 
            this.btnSIMPAN.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnSIMPAN.Image = ((System.Drawing.Image)(resources.GetObject("btnSIMPAN.Image")));
            this.btnSIMPAN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSIMPAN.Location = new System.Drawing.Point(165, 296);
            this.btnSIMPAN.Name = "btnSIMPAN";
            this.btnSIMPAN.Size = new System.Drawing.Size(98, 43);
            this.btnSIMPAN.TabIndex = 3;
            this.btnSIMPAN.Text = "SIMPAN";
            this.btnSIMPAN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSIMPAN.UseVisualStyleBackColor = true;
            this.btnSIMPAN.Click += new System.EventHandler(this.btnSIMPAN_Click);
            // 
            // btnHAPUS
            // 
            this.btnHAPUS.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHAPUS.Image = ((System.Drawing.Image)(resources.GetObject("btnHAPUS.Image")));
            this.btnHAPUS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHAPUS.Location = new System.Drawing.Point(262, 296);
            this.btnHAPUS.Name = "btnHAPUS";
            this.btnHAPUS.Size = new System.Drawing.Size(90, 43);
            this.btnHAPUS.TabIndex = 4;
            this.btnHAPUS.Text = "HAPUS";
            this.btnHAPUS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHAPUS.UseVisualStyleBackColor = true;
            this.btnHAPUS.Click += new System.EventHandler(this.btnHAPUS_Click);
            // 
            // KODE
            // 
            this.KODE.DataPropertyName = "KODEANGGOTA";
            this.KODE.HeaderText = "KODE";
            this.KODE.Name = "KODE";
            this.KODE.ReadOnly = true;
            // 
            // JENISKEANGGOTAAN
            // 
            this.JENISKEANGGOTAAN.DataPropertyName = "JENISANGGOTA";
            this.JENISKEANGGOTAAN.HeaderText = "JENIS KEANGGOTAAN";
            this.JENISKEANGGOTAAN.Name = "JENISKEANGGOTAAN";
            this.JENISKEANGGOTAAN.ReadOnly = true;
            this.JENISKEANGGOTAAN.Width = 250;
            // 
            // FormADDITEMJENISANGGOTA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(356, 362);
            this.Controls.Add(this.btnHAPUS);
            this.Controls.Add(this.btnSIMPAN);
            this.Controls.Add(this.txtNAMA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKODE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvJENIS);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormADDITEMJENISANGGOTA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JENIS KEANGGOTAAN";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dgvJENIS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridView dgvJENIS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKODE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNAMA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSIMPAN;
        private System.Windows.Forms.Button btnHAPUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn KODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn JENISKEANGGOTAAN;
    }
}