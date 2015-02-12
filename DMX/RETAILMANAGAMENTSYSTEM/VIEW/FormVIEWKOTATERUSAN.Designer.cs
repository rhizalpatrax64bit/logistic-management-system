namespace LOGISTICMANAGAMENTSYSTEM.VIEW
{
    partial class FormVIEWKOTATERUSAN
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtCARI = new System.Windows.Forms.TextBox();
            this.dgvKOTATERUSAN = new System.Windows.Forms.DataGridView();
            this.IDTERUSAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KODEAREA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAMAAREA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAMAKOTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSEARCH = new System.Windows.Forms.TextBox();
            this.dgvTERUSAN = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AREA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKOTATERUSAN)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTERUSAN)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCARI
            // 
            this.txtCARI.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtCARI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCARI.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCARI.Location = new System.Drawing.Point(382, 15);
            this.txtCARI.Name = "txtCARI";
            this.txtCARI.Size = new System.Drawing.Size(329, 27);
            this.txtCARI.TabIndex = 13;
            this.txtCARI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCARI.TextChanged += new System.EventHandler(this.txtCARI_TextChanged);
            // 
            // dgvKOTATERUSAN
            // 
            this.dgvKOTATERUSAN.AllowUserToAddRows = false;
            this.dgvKOTATERUSAN.AllowUserToResizeRows = false;
            this.dgvKOTATERUSAN.BackgroundColor = System.Drawing.Color.Black;
            this.dgvKOTATERUSAN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKOTATERUSAN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDTERUSAN,
            this.KODEAREA,
            this.NAMAAREA,
            this.NAMAKOTA});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKOTATERUSAN.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKOTATERUSAN.Location = new System.Drawing.Point(3, 46);
            this.dgvKOTATERUSAN.Name = "dgvKOTATERUSAN";
            this.dgvKOTATERUSAN.ReadOnly = true;
            this.dgvKOTATERUSAN.RowHeadersVisible = false;
            this.dgvKOTATERUSAN.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvKOTATERUSAN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKOTATERUSAN.Size = new System.Drawing.Size(708, 326);
            this.dgvKOTATERUSAN.TabIndex = 10;
            // 
            // IDTERUSAN
            // 
            this.IDTERUSAN.HeaderText = "IDTERUSAN";
            this.IDTERUSAN.Name = "IDTERUSAN";
            this.IDTERUSAN.ReadOnly = true;
            // 
            // KODEAREA
            // 
            this.KODEAREA.HeaderText = "KODEAREA";
            this.KODEAREA.Name = "KODEAREA";
            this.KODEAREA.ReadOnly = true;
            // 
            // NAMAAREA
            // 
            this.NAMAAREA.HeaderText = "NAMA AREA";
            this.NAMAAREA.Name = "NAMAAREA";
            this.NAMAAREA.ReadOnly = true;
            this.NAMAAREA.Width = 150;
            // 
            // NAMAKOTA
            // 
            this.NAMAKOTA.HeaderText = "NAMA KOTA";
            this.NAMAKOTA.Name = "NAMAKOTA";
            this.NAMAKOTA.ReadOnly = true;
            this.NAMAKOTA.Width = 250;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 48);
            this.panel1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(382, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ketikan kode area atau nama terusan kota di kotak pencarian";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "TABEL KOTA TERUSAN";
            // 
            // txtSEARCH
            // 
            this.txtSEARCH.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtSEARCH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSEARCH.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSEARCH.Location = new System.Drawing.Point(0, 68);
            this.txtSEARCH.Name = "txtSEARCH";
            this.txtSEARCH.Size = new System.Drawing.Size(597, 27);
            this.txtSEARCH.TabIndex = 12;
            this.txtSEARCH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSEARCH.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSEARCH_KeyUp);
            // 
            // dgvTERUSAN
            // 
            this.dgvTERUSAN.AllowUserToAddRows = false;
            this.dgvTERUSAN.AllowUserToResizeRows = false;
            this.dgvTERUSAN.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvTERUSAN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTERUSAN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.AREA,
            this.NAMA});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTERUSAN.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTERUSAN.Location = new System.Drawing.Point(0, 101);
            this.dgvTERUSAN.Name = "dgvTERUSAN";
            this.dgvTERUSAN.ReadOnly = true;
            this.dgvTERUSAN.RowHeadersVisible = false;
            this.dgvTERUSAN.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvTERUSAN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTERUSAN.Size = new System.Drawing.Size(708, 270);
            this.dgvTERUSAN.TabIndex = 13;
            this.dgvTERUSAN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTERUSAN_CellClick);
            this.dgvTERUSAN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvTERUSAN_KeyDown);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // AREA
            // 
            this.AREA.HeaderText = "Area";
            this.AREA.Name = "AREA";
            this.AREA.ReadOnly = true;
            // 
            // NAMA
            // 
            this.NAMA.HeaderText = "Kota Terusan";
            this.NAMA.Name = "NAMA";
            this.NAMA.ReadOnly = true;
            this.NAMA.Width = 150;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(600, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "CARI [ F1 ]";
            // 
            // FormVIEWKOTATERUSAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(711, 387);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtSEARCH);
            this.Controls.Add(this.dgvTERUSAN);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Name = "FormVIEWKOTATERUSAN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KOTA TERUSAN";
            this.TopMost = true;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormVIEWKOTATERUSAN_KeyUp_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKOTATERUSAN)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTERUSAN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCARI;
        private System.Windows.Forms.DataGridView dgvKOTATERUSAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDTERUSAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn KODEAREA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAMAAREA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAMAKOTA;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSEARCH;
        private System.Windows.Forms.DataGridView dgvTERUSAN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AREA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAMA;
    }
}