namespace LOGISTICMANAGAMENTSYSTEM.VIEW
{
    partial class FormVIEWPRICELISTCUSTOMER
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCUSTOMER = new System.Windows.Forms.Label();
            this.dgvPRICELIST = new System.Windows.Forms.DataGridView();
            this.IDPRICELIST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LAYANAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HANDLING = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ASAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KTUJUAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TERUSAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHARGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WAKTU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDASAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDTUJUAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KODEASAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KODETUJUAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDTERUSAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDHANDLING = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDSERVICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRICELIST)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 57);
            this.panel1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(333, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Silahkan Pilih salah satu layanan pada table dibawah ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "TABEL PRICELIST CUSTOMER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "NAMA CUSTOMER :";
            // 
            // lblCUSTOMER
            // 
            this.lblCUSTOMER.AutoSize = true;
            this.lblCUSTOMER.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCUSTOMER.Location = new System.Drawing.Point(168, 85);
            this.lblCUSTOMER.Name = "lblCUSTOMER";
            this.lblCUSTOMER.Size = new System.Drawing.Size(167, 23);
            this.lblCUSTOMER.TabIndex = 13;
            this.lblCUSTOMER.Text = "NAMA CUSTOMER :";
            // 
            // dgvPRICELIST
            // 
            this.dgvPRICELIST.AllowUserToAddRows = false;
            this.dgvPRICELIST.AllowUserToResizeRows = false;
            this.dgvPRICELIST.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvPRICELIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPRICELIST.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPRICELIST,
            this.LAYANAN,
            this.HANDLING,
            this.ASAL,
            this.KTUJUAN,
            this.TERUSAN,
            this.CHARGE,
            this.RC,
            this.WAKTU,
            this.IDASAL,
            this.IDTUJUAN,
            this.KODEASAL,
            this.KODETUJUAN,
            this.IDTERUSAN,
            this.IDHANDLING,
            this.IDSERVICE});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPRICELIST.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPRICELIST.Location = new System.Drawing.Point(0, 120);
            this.dgvPRICELIST.Name = "dgvPRICELIST";
            this.dgvPRICELIST.ReadOnly = true;
            this.dgvPRICELIST.RowHeadersVisible = false;
            this.dgvPRICELIST.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPRICELIST.Size = new System.Drawing.Size(1012, 341);
            this.dgvPRICELIST.TabIndex = 24;
            this.dgvPRICELIST.Click += new System.EventHandler(this.dgvPRICELIST_Click);
            // 
            // IDPRICELIST
            // 
            this.IDPRICELIST.HeaderText = "IDPRICELIST";
            this.IDPRICELIST.Name = "IDPRICELIST";
            this.IDPRICELIST.ReadOnly = true;
            this.IDPRICELIST.Visible = false;
            // 
            // LAYANAN
            // 
            this.LAYANAN.HeaderText = "Layanan";
            this.LAYANAN.Name = "LAYANAN";
            this.LAYANAN.ReadOnly = true;
            // 
            // HANDLING
            // 
            this.HANDLING.HeaderText = "Handling [Moda]";
            this.HANDLING.Name = "HANDLING";
            this.HANDLING.ReadOnly = true;
            // 
            // ASAL
            // 
            this.ASAL.HeaderText = "Kota Asal";
            this.ASAL.Name = "ASAL";
            this.ASAL.ReadOnly = true;
            this.ASAL.ToolTipText = "Kota Asal";
            this.ASAL.Width = 150;
            // 
            // KTUJUAN
            // 
            this.KTUJUAN.HeaderText = "Kota Tujuan";
            this.KTUJUAN.Name = "KTUJUAN";
            this.KTUJUAN.ReadOnly = true;
            this.KTUJUAN.ToolTipText = "Kota Tujuan";
            this.KTUJUAN.Width = 150;
            // 
            // TERUSAN
            // 
            this.TERUSAN.HeaderText = "Kota Terusan";
            this.TERUSAN.Name = "TERUSAN";
            this.TERUSAN.ReadOnly = true;
            this.TERUSAN.ToolTipText = "Kota Terusan";
            this.TERUSAN.Width = 150;
            // 
            // CHARGE
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHARGE.DefaultCellStyle = dataGridViewCellStyle4;
            this.CHARGE.HeaderText = "Charge (KG)";
            this.CHARGE.Name = "CHARGE";
            this.CHARGE.ReadOnly = true;
            this.CHARGE.Width = 110;
            // 
            // RC
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RC.DefaultCellStyle = dataGridViewCellStyle5;
            this.RC.HeaderText = "Refund Customer";
            this.RC.Name = "RC";
            this.RC.ReadOnly = true;
            this.RC.Width = 110;
            // 
            // WAKTU
            // 
            this.WAKTU.HeaderText = "Keterangan";
            this.WAKTU.Name = "WAKTU";
            this.WAKTU.ReadOnly = true;
            this.WAKTU.ToolTipText = "Keterangan";
            this.WAKTU.Width = 150;
            // 
            // IDASAL
            // 
            this.IDASAL.HeaderText = "IDASAL";
            this.IDASAL.Name = "IDASAL";
            this.IDASAL.ReadOnly = true;
            this.IDASAL.Visible = false;
            // 
            // IDTUJUAN
            // 
            this.IDTUJUAN.HeaderText = "IDTUJUAN";
            this.IDTUJUAN.Name = "IDTUJUAN";
            this.IDTUJUAN.ReadOnly = true;
            this.IDTUJUAN.Visible = false;
            // 
            // KODEASAL
            // 
            this.KODEASAL.HeaderText = "KODEASAL";
            this.KODEASAL.Name = "KODEASAL";
            this.KODEASAL.ReadOnly = true;
            // 
            // KODETUJUAN
            // 
            this.KODETUJUAN.HeaderText = "KODETUJUAN";
            this.KODETUJUAN.Name = "KODETUJUAN";
            this.KODETUJUAN.ReadOnly = true;
            // 
            // IDTERUSAN
            // 
            this.IDTERUSAN.HeaderText = "IDTERUSAN";
            this.IDTERUSAN.Name = "IDTERUSAN";
            this.IDTERUSAN.ReadOnly = true;
            // 
            // IDHANDLING
            // 
            this.IDHANDLING.HeaderText = "IDHANDLING";
            this.IDHANDLING.Name = "IDHANDLING";
            this.IDHANDLING.ReadOnly = true;
            // 
            // IDSERVICE
            // 
            this.IDSERVICE.HeaderText = "IDSERVICE";
            this.IDSERVICE.Name = "IDSERVICE";
            this.IDSERVICE.ReadOnly = true;
            // 
            // FormVIEWPRICELISTCUSTOMER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(957, 463);
            this.ControlBox = false;
            this.Controls.Add(this.dgvPRICELIST);
            this.Controls.Add(this.lblCUSTOMER);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.KeyPreview = true;
            this.Name = "FormVIEWPRICELISTCUSTOMER";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRICELIST CUSTOMER";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRICELIST)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCUSTOMER;
        private System.Windows.Forms.DataGridView dgvPRICELIST;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPRICELIST;
        private System.Windows.Forms.DataGridViewTextBoxColumn LAYANAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn HANDLING;
        private System.Windows.Forms.DataGridViewTextBoxColumn ASAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn KTUJUAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TERUSAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHARGE;
        private System.Windows.Forms.DataGridViewTextBoxColumn RC;
        private System.Windows.Forms.DataGridViewTextBoxColumn WAKTU;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDASAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDTUJUAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn KODEASAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn KODETUJUAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDTERUSAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDHANDLING;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDSERVICE;
    }
}