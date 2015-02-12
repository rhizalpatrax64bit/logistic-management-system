namespace LOGISTICMANAGAMENTSYSTEM.VIEW
{
    partial class FormVIEWPENERIMAANBARANG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVIEWPENERIMAANBARANG));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboSTATUS = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCARI = new System.Windows.Forms.Button();
            this.btnTAMBAH = new System.Windows.Forms.Button();
            this.btnKELUAR = new System.Windows.Forms.Button();
            this.dgvRESIPENGIRIMAN = new System.Windows.Forms.DataGridView();
            this.PILIH = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NORESI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TGLTERIMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ETD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUSTOMER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ASAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TUJUAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PENERIMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ALAMAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEPONPENERIMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FAXPENERIMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HPPENERIMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAILPENERIMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SERVICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JENISKIRIMAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JUMLAH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BERAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHARGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OTHERCHARGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DISKON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRESIPENGIRIMAN)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboSTATUS
            // 
            this.cboSTATUS.AutoCompleteCustomSource.AddRange(new string[] {
            "SEMUA\t",
            "INV",
            "PAID\t",
            "CASH",
            "COLL"});
            this.cboSTATUS.FormattingEnabled = true;
            this.cboSTATUS.Items.AddRange(new object[] {
            "SEMUA",
            "INV",
            "PAID",
            "CASH",
            "COLL"});
            this.cboSTATUS.Location = new System.Drawing.Point(432, 35);
            this.cboSTATUS.Name = "cboSTATUS";
            this.cboSTATUS.Size = new System.Drawing.Size(132, 23);
            this.cboSTATUS.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(374, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 43;
            this.label1.Text = "STATUS ";
            // 
            // dtEnd
            // 
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEnd.Location = new System.Drawing.Point(250, 32);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(118, 23);
            this.dtEnd.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(220, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 15);
            this.label4.TabIndex = 41;
            this.label4.Text = "-";
            // 
            // dtStart
            // 
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStart.Location = new System.Drawing.Point(78, 33);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(118, 23);
            this.dtStart.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(4, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 40;
            this.label6.Text = "TANGGAL";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(985, 48);
            this.panel1.TabIndex = 45;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(320, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "TABEL PENERIMAAN BARANG EXPRESS";
            // 
            // btnCARI
            // 
            this.btnCARI.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCARI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCARI.Image = ((System.Drawing.Image)(resources.GetObject("btnCARI.Image")));
            this.btnCARI.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCARI.Location = new System.Drawing.Point(586, 26);
            this.btnCARI.Name = "btnCARI";
            this.btnCARI.Size = new System.Drawing.Size(100, 39);
            this.btnCARI.TabIndex = 46;
            this.btnCARI.Text = "CARI";
            this.btnCARI.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCARI.UseVisualStyleBackColor = true;
            this.btnCARI.Click += new System.EventHandler(this.btnCARI_Click);
            // 
            // btnTAMBAH
            // 
            this.btnTAMBAH.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTAMBAH.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTAMBAH.Image = ((System.Drawing.Image)(resources.GetObject("btnTAMBAH.Image")));
            this.btnTAMBAH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTAMBAH.Location = new System.Drawing.Point(0, 398);
            this.btnTAMBAH.Name = "btnTAMBAH";
            this.btnTAMBAH.Size = new System.Drawing.Size(103, 43);
            this.btnTAMBAH.TabIndex = 47;
            this.btnTAMBAH.Text = "SIMPAN";
            this.btnTAMBAH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTAMBAH.UseVisualStyleBackColor = false;
            this.btnTAMBAH.Click += new System.EventHandler(this.btnTAMBAH_Click);
            // 
            // btnKELUAR
            // 
            this.btnKELUAR.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKELUAR.Image = ((System.Drawing.Image)(resources.GetObject("btnKELUAR.Image")));
            this.btnKELUAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKELUAR.Location = new System.Drawing.Point(105, 398);
            this.btnKELUAR.Name = "btnKELUAR";
            this.btnKELUAR.Size = new System.Drawing.Size(103, 43);
            this.btnKELUAR.TabIndex = 48;
            this.btnKELUAR.Text = "KELUAR";
            this.btnKELUAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKELUAR.UseVisualStyleBackColor = true;
            // 
            // dgvRESIPENGIRIMAN
            // 
            this.dgvRESIPENGIRIMAN.AllowUserToAddRows = false;
            this.dgvRESIPENGIRIMAN.AllowUserToResizeRows = false;
            this.dgvRESIPENGIRIMAN.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvRESIPENGIRIMAN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRESIPENGIRIMAN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PILIH,
            this.ID,
            this.STATUS,
            this.NORESI,
            this.TGLTERIMA,
            this.ETD,
            this.CUSTOMER,
            this.ASAL,
            this.TUJUAN,
            this.PENERIMA,
            this.ALAMAT,
            this.TELEPONPENERIMA,
            this.FAXPENERIMA,
            this.HPPENERIMA,
            this.EMAILPENERIMA,
            this.SERVICE,
            this.JENISKIRIMAN,
            this.JUMLAH,
            this.BERAT,
            this.CHARGE,
            this.OTHERCHARGE,
            this.DISKON,
            this.TOTAL});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRESIPENGIRIMAN.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvRESIPENGIRIMAN.Location = new System.Drawing.Point(0, 136);
            this.dgvRESIPENGIRIMAN.Name = "dgvRESIPENGIRIMAN";
            this.dgvRESIPENGIRIMAN.ReadOnly = true;
            this.dgvRESIPENGIRIMAN.RowHeadersVisible = false;
            this.dgvRESIPENGIRIMAN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRESIPENGIRIMAN.Size = new System.Drawing.Size(1265, 256);
            this.dgvRESIPENGIRIMAN.TabIndex = 49;
            this.dgvRESIPENGIRIMAN.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRESIPENGIRIMAN_CellContentClick);
            // 
            // PILIH
            // 
            this.PILIH.HeaderText = "PILIH";
            this.PILIH.Name = "PILIH";
            this.PILIH.ReadOnly = true;
            this.PILIH.Width = 50;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // STATUS
            // 
            this.STATUS.HeaderText = "Status";
            this.STATUS.Name = "STATUS";
            this.STATUS.ReadOnly = true;
            // 
            // NORESI
            // 
            this.NORESI.HeaderText = "NoResi";
            this.NORESI.Name = "NORESI";
            this.NORESI.ReadOnly = true;
            this.NORESI.Width = 150;
            // 
            // TGLTERIMA
            // 
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.TGLTERIMA.DefaultCellStyle = dataGridViewCellStyle1;
            this.TGLTERIMA.HeaderText = "Tgl Manifest";
            this.TGLTERIMA.Name = "TGLTERIMA";
            this.TGLTERIMA.ReadOnly = true;
            this.TGLTERIMA.Width = 70;
            // 
            // ETD
            // 
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.ETD.DefaultCellStyle = dataGridViewCellStyle2;
            this.ETD.HeaderText = "ETD [Estimated Delivery]";
            this.ETD.Name = "ETD";
            this.ETD.ReadOnly = true;
            this.ETD.Width = 70;
            // 
            // CUSTOMER
            // 
            this.CUSTOMER.HeaderText = "Customer";
            this.CUSTOMER.Name = "CUSTOMER";
            this.CUSTOMER.ReadOnly = true;
            this.CUSTOMER.ToolTipText = "Customer";
            // 
            // ASAL
            // 
            this.ASAL.HeaderText = "Kota Asal";
            this.ASAL.Name = "ASAL";
            this.ASAL.ReadOnly = true;
            // 
            // TUJUAN
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.TUJUAN.DefaultCellStyle = dataGridViewCellStyle3;
            this.TUJUAN.HeaderText = "Kota Tujuan";
            this.TUJUAN.Name = "TUJUAN";
            this.TUJUAN.ReadOnly = true;
            this.TUJUAN.ToolTipText = "Kota Tujuan";
            // 
            // PENERIMA
            // 
            this.PENERIMA.HeaderText = "Penerima";
            this.PENERIMA.Name = "PENERIMA";
            this.PENERIMA.ReadOnly = true;
            this.PENERIMA.ToolTipText = "Penerima";
            // 
            // ALAMAT
            // 
            this.ALAMAT.HeaderText = "Alamat";
            this.ALAMAT.Name = "ALAMAT";
            this.ALAMAT.ReadOnly = true;
            this.ALAMAT.Width = 150;
            // 
            // TELEPONPENERIMA
            // 
            this.TELEPONPENERIMA.HeaderText = "Telp.Penerima";
            this.TELEPONPENERIMA.Name = "TELEPONPENERIMA";
            this.TELEPONPENERIMA.ReadOnly = true;
            this.TELEPONPENERIMA.ToolTipText = "Telp.Penerima";
            this.TELEPONPENERIMA.Visible = false;
            // 
            // FAXPENERIMA
            // 
            this.FAXPENERIMA.HeaderText = "Fax.Penerima";
            this.FAXPENERIMA.Name = "FAXPENERIMA";
            this.FAXPENERIMA.ReadOnly = true;
            this.FAXPENERIMA.ToolTipText = "Fax.Penerima";
            this.FAXPENERIMA.Visible = false;
            // 
            // HPPENERIMA
            // 
            this.HPPENERIMA.HeaderText = "Hp.Penerima";
            this.HPPENERIMA.Name = "HPPENERIMA";
            this.HPPENERIMA.ReadOnly = true;
            this.HPPENERIMA.ToolTipText = "Hp.Penerima";
            this.HPPENERIMA.Visible = false;
            // 
            // EMAILPENERIMA
            // 
            this.EMAILPENERIMA.HeaderText = "Email.Penerima";
            this.EMAILPENERIMA.Name = "EMAILPENERIMA";
            this.EMAILPENERIMA.ReadOnly = true;
            this.EMAILPENERIMA.ToolTipText = "Email.Penerima";
            this.EMAILPENERIMA.Visible = false;
            // 
            // SERVICE
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.SERVICE.DefaultCellStyle = dataGridViewCellStyle4;
            this.SERVICE.HeaderText = "Layanan";
            this.SERVICE.Name = "SERVICE";
            this.SERVICE.ReadOnly = true;
            this.SERVICE.ToolTipText = "Layanan";
            // 
            // JENISKIRIMAN
            // 
            this.JENISKIRIMAN.HeaderText = "Jenis Kiriman";
            this.JENISKIRIMAN.Name = "JENISKIRIMAN";
            this.JENISKIRIMAN.ReadOnly = true;
            // 
            // JUMLAH
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JUMLAH.DefaultCellStyle = dataGridViewCellStyle5;
            this.JUMLAH.HeaderText = "Jumlah";
            this.JUMLAH.Name = "JUMLAH";
            this.JUMLAH.ReadOnly = true;
            // 
            // BERAT
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BERAT.DefaultCellStyle = dataGridViewCellStyle6;
            this.BERAT.HeaderText = "Berat";
            this.BERAT.Name = "BERAT";
            this.BERAT.ReadOnly = true;
            this.BERAT.Visible = false;
            // 
            // CHARGE
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHARGE.DefaultCellStyle = dataGridViewCellStyle7;
            this.CHARGE.HeaderText = "Charge (IDR)";
            this.CHARGE.Name = "CHARGE";
            this.CHARGE.ReadOnly = true;
            this.CHARGE.Visible = false;
            // 
            // OTHERCHARGE
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OTHERCHARGE.DefaultCellStyle = dataGridViewCellStyle8;
            this.OTHERCHARGE.HeaderText = "Othercharge (IDR)";
            this.OTHERCHARGE.Name = "OTHERCHARGE";
            this.OTHERCHARGE.ReadOnly = true;
            this.OTHERCHARGE.Visible = false;
            // 
            // DISKON
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DISKON.DefaultCellStyle = dataGridViewCellStyle9;
            this.DISKON.HeaderText = "Diskon (IDR)";
            this.DISKON.Name = "DISKON";
            this.DISKON.ReadOnly = true;
            this.DISKON.Visible = false;
            // 
            // TOTAL
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TOTAL.DefaultCellStyle = dataGridViewCellStyle10;
            this.TOTAL.HeaderText = "Total (IDR)";
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.ReadOnly = true;
            this.TOTAL.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtEnd);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtStart);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnCARI);
            this.groupBox1.Controls.Add(this.cboSTATUS);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(692, 72);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Berdasarkan Tgl Manifest";
            // 
            // FormVIEWPENERIMAANBARANG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(985, 441);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvRESIPENGIRIMAN);
            this.Controls.Add(this.btnKELUAR);
            this.Controls.Add(this.btnTAMBAH);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Name = "FormVIEWPENERIMAANBARANG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PENERIMAAN BARANG EXPRESS";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRESIPENGIRIMAN)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboSTATUS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCARI;
        private System.Windows.Forms.Button btnTAMBAH;
        private System.Windows.Forms.Button btnKELUAR;
        private System.Windows.Forms.DataGridView dgvRESIPENGIRIMAN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PILIH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NORESI;
        private System.Windows.Forms.DataGridViewTextBoxColumn TGLTERIMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ETD;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUSTOMER;
        private System.Windows.Forms.DataGridViewTextBoxColumn ASAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TUJUAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn PENERIMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ALAMAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEPONPENERIMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn FAXPENERIMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn HPPENERIMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAILPENERIMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SERVICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn JENISKIRIMAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn JUMLAH;
        private System.Windows.Forms.DataGridViewTextBoxColumn BERAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHARGE;
        private System.Windows.Forms.DataGridViewTextBoxColumn OTHERCHARGE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DISKON;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
    }
}