namespace LOGISTICMANAGAMENTSYSTEM.FINANCE
{
    partial class FormDAFTARPEMBAYARANHUTANG
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDAFTARPEMBAYARANHUTANG));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitleMarketing = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboSTATUS = new System.Windows.Forms.ComboBox();
            this.dtEND = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtBEGIN = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panelBUTTON = new System.Windows.Forms.Panel();
            this.btnCetak = new System.Windows.Forms.Button();
            this.btnEDIT = new System.Windows.Forms.Button();
            this.btnHAPUS = new System.Windows.Forms.Button();
            this.btnTAGIHAN = new System.Windows.Forms.Button();
            this.btnKELUAR = new System.Windows.Forms.Button();
            this.btnPEMBAYARAN = new System.Windows.Forms.Button();
            this.dgvTAGIHAN = new System.Windows.Forms.DataGridView();
            this.btnCARI = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AGENT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HANDLING = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TGLDATANGINV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TGLINV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOINV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TAGIHAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JUMLAHBAYAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SISA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TGLBAYAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KETERANGAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelBUTTON.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTAGIHAN)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitleMarketing
            // 
            this.lblTitleMarketing.AutoSize = true;
            this.lblTitleMarketing.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleMarketing.ForeColor = System.Drawing.Color.White;
            this.lblTitleMarketing.Location = new System.Drawing.Point(21, 20);
            this.lblTitleMarketing.Name = "lblTitleMarketing";
            this.lblTitleMarketing.Size = new System.Drawing.Size(367, 33);
            this.lblTitleMarketing.TabIndex = 23;
            this.lblTitleMarketing.Text = "DAFTAR PEMBAYARAN HUTANG";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCARI);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cboSTATUS);
            this.groupBox2.Controls.Add(this.dtEND);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtBEGIN);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(8, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(812, 74);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cari Berdasrakan Tanggal Invoice ";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(360, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Status Pembayaran";
            // 
            // cboSTATUS
            // 
            this.cboSTATUS.FormattingEnabled = true;
            this.cboSTATUS.Items.AddRange(new object[] {
            "SEMUA",
            "LUNAS",
            "BELUM LUNAS"});
            this.cboSTATUS.Location = new System.Drawing.Point(492, 30);
            this.cboSTATUS.Name = "cboSTATUS";
            this.cboSTATUS.Size = new System.Drawing.Size(193, 23);
            this.cboSTATUS.TabIndex = 4;
            // 
            // dtEND
            // 
            this.dtEND.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEND.Location = new System.Drawing.Point(225, 29);
            this.dtEND.Name = "dtEND";
            this.dtEND.Size = new System.Drawing.Size(118, 23);
            this.dtEND.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(208, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "-";
            // 
            // dtBEGIN
            // 
            this.dtBEGIN.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBEGIN.Location = new System.Drawing.Point(72, 28);
            this.dtBEGIN.Name = "dtBEGIN";
            this.dtBEGIN.Size = new System.Drawing.Size(118, 23);
            this.dtBEGIN.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tanggal";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(2, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1318, 71);
            this.panel3.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(344, 18);
            this.label5.TabIndex = 35;
            this.label5.Text = "Modul ini digunakan untuk kelola pembayaran tagihan";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1177, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(376, 33);
            this.label9.TabIndex = 33;
            this.label9.Text = "KELOLA PEMBAYARAN TAGIHAN";
            // 
            // panelBUTTON
            // 
            this.panelBUTTON.Controls.Add(this.btnCetak);
            this.panelBUTTON.Controls.Add(this.btnEDIT);
            this.panelBUTTON.Controls.Add(this.btnHAPUS);
            this.panelBUTTON.Controls.Add(this.btnTAGIHAN);
            this.panelBUTTON.Controls.Add(this.btnKELUAR);
            this.panelBUTTON.Controls.Add(this.btnPEMBAYARAN);
            this.panelBUTTON.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBUTTON.Location = new System.Drawing.Point(0, 561);
            this.panelBUTTON.Name = "panelBUTTON";
            this.panelBUTTON.Size = new System.Drawing.Size(1284, 47);
            this.panelBUTTON.TabIndex = 41;
            // 
            // btnCetak
            // 
            this.btnCetak.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCetak.Image = ((System.Drawing.Image)(resources.GetObject("btnCetak.Image")));
            this.btnCetak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCetak.Location = new System.Drawing.Point(269, 1);
            this.btnCetak.Name = "btnCetak";
            this.btnCetak.Size = new System.Drawing.Size(90, 43);
            this.btnCetak.TabIndex = 87;
            this.btnCetak.Text = "CETAK";
            this.btnCetak.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCetak.UseVisualStyleBackColor = true;
            this.btnCetak.Click += new System.EventHandler(this.btnCetak_Click);
            // 
            // btnEDIT
            // 
            this.btnEDIT.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEDIT.Image = ((System.Drawing.Image)(resources.GetObject("btnEDIT.Image")));
            this.btnEDIT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEDIT.Location = new System.Drawing.Point(103, 1);
            this.btnEDIT.Name = "btnEDIT";
            this.btnEDIT.Size = new System.Drawing.Size(71, 43);
            this.btnEDIT.TabIndex = 85;
            this.btnEDIT.Text = "EDIT";
            this.btnEDIT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEDIT.UseVisualStyleBackColor = true;
            this.btnEDIT.Click += new System.EventHandler(this.btnEDIT_Click);
            // 
            // btnHAPUS
            // 
            this.btnHAPUS.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHAPUS.Image = ((System.Drawing.Image)(resources.GetObject("btnHAPUS.Image")));
            this.btnHAPUS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHAPUS.Location = new System.Drawing.Point(177, 1);
            this.btnHAPUS.Name = "btnHAPUS";
            this.btnHAPUS.Size = new System.Drawing.Size(90, 43);
            this.btnHAPUS.TabIndex = 86;
            this.btnHAPUS.Text = "HAPUS";
            this.btnHAPUS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHAPUS.UseVisualStyleBackColor = true;
            // 
            // btnTAGIHAN
            // 
            this.btnTAGIHAN.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTAGIHAN.Image = ((System.Drawing.Image)(resources.GetObject("btnTAGIHAN.Image")));
            this.btnTAGIHAN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTAGIHAN.Location = new System.Drawing.Point(3, 1);
            this.btnTAGIHAN.Name = "btnTAGIHAN";
            this.btnTAGIHAN.Size = new System.Drawing.Size(100, 43);
            this.btnTAGIHAN.TabIndex = 3;
            this.btnTAGIHAN.Text = "TAGIHAN";
            this.btnTAGIHAN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTAGIHAN.UseVisualStyleBackColor = true;
            this.btnTAGIHAN.Click += new System.EventHandler(this.btnTAGIHAN_Click);
            // 
            // btnKELUAR
            // 
            this.btnKELUAR.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKELUAR.Image = ((System.Drawing.Image)(resources.GetObject("btnKELUAR.Image")));
            this.btnKELUAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKELUAR.Location = new System.Drawing.Point(523, 0);
            this.btnKELUAR.Name = "btnKELUAR";
            this.btnKELUAR.Size = new System.Drawing.Size(103, 43);
            this.btnKELUAR.TabIndex = 2;
            this.btnKELUAR.Text = "KELUAR";
            this.btnKELUAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKELUAR.UseVisualStyleBackColor = true;
            this.btnKELUAR.Click += new System.EventHandler(this.btnKELUAR_Click);
            // 
            // btnPEMBAYARAN
            // 
            this.btnPEMBAYARAN.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPEMBAYARAN.Image = ((System.Drawing.Image)(resources.GetObject("btnPEMBAYARAN.Image")));
            this.btnPEMBAYARAN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPEMBAYARAN.Location = new System.Drawing.Point(364, 1);
            this.btnPEMBAYARAN.Name = "btnPEMBAYARAN";
            this.btnPEMBAYARAN.Size = new System.Drawing.Size(156, 43);
            this.btnPEMBAYARAN.TabIndex = 2;
            this.btnPEMBAYARAN.Text = "PEMBAYARAN";
            this.btnPEMBAYARAN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPEMBAYARAN.UseVisualStyleBackColor = true;
            this.btnPEMBAYARAN.Click += new System.EventHandler(this.btnPEMBAYARAN_Click);
            // 
            // dgvTAGIHAN
            // 
            this.dgvTAGIHAN.AllowUserToAddRows = false;
            this.dgvTAGIHAN.AllowUserToResizeRows = false;
            this.dgvTAGIHAN.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvTAGIHAN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTAGIHAN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.AGENT,
            this.HANDLING,
            this.TGLDATANGINV,
            this.TGLINV,
            this.NOINV,
            this.TAGIHAN,
            this.JUMLAHBAYAR,
            this.SISA,
            this.TGLBAYAR,
            this.STATUS,
            this.KETERANGAN});
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Calibri", 9.75F);
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTAGIHAN.DefaultCellStyle = dataGridViewCellStyle24;
            this.dgvTAGIHAN.Location = new System.Drawing.Point(2, 192);
            this.dgvTAGIHAN.Name = "dgvTAGIHAN";
            this.dgvTAGIHAN.ReadOnly = true;
            this.dgvTAGIHAN.RowHeadersVisible = false;
            this.dgvTAGIHAN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTAGIHAN.Size = new System.Drawing.Size(1276, 363);
            this.dgvTAGIHAN.TabIndex = 33;
            // 
            // btnCARI
            // 
            this.btnCARI.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCARI.ForeColor = System.Drawing.Color.Black;
            this.btnCARI.Image = ((System.Drawing.Image)(resources.GetObject("btnCARI.Image")));
            this.btnCARI.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCARI.Location = new System.Drawing.Point(716, 19);
            this.btnCARI.Name = "btnCARI";
            this.btnCARI.Size = new System.Drawing.Size(90, 40);
            this.btnCARI.TabIndex = 42;
            this.btnCARI.Text = "CARI";
            this.btnCARI.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCARI.UseVisualStyleBackColor = true;
            this.btnCARI.Click += new System.EventHandler(this.button2_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // AGENT
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.AGENT.DefaultCellStyle = dataGridViewCellStyle13;
            this.AGENT.HeaderText = "Nama Agent";
            this.AGENT.Name = "AGENT";
            this.AGENT.ReadOnly = true;
            this.AGENT.Width = 150;
            // 
            // HANDLING
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.HANDLING.DefaultCellStyle = dataGridViewCellStyle14;
            this.HANDLING.HeaderText = "Handling";
            this.HANDLING.Name = "HANDLING";
            this.HANDLING.ReadOnly = true;
            this.HANDLING.Width = 150;
            // 
            // TGLDATANGINV
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.TGLDATANGINV.DefaultCellStyle = dataGridViewCellStyle15;
            this.TGLDATANGINV.HeaderText = "Tgl Datang Invoice";
            this.TGLDATANGINV.Name = "TGLDATANGINV";
            this.TGLDATANGINV.ReadOnly = true;
            // 
            // TGLINV
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TGLINV.DefaultCellStyle = dataGridViewCellStyle16;
            this.TGLINV.HeaderText = "Tgl Invoice";
            this.TGLINV.Name = "TGLINV";
            this.TGLINV.ReadOnly = true;
            // 
            // NOINV
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NOINV.DefaultCellStyle = dataGridViewCellStyle17;
            this.NOINV.HeaderText = "No Invoice";
            this.NOINV.Name = "NOINV";
            this.NOINV.ReadOnly = true;
            this.NOINV.Width = 120;
            // 
            // TAGIHAN
            // 
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TAGIHAN.DefaultCellStyle = dataGridViewCellStyle18;
            this.TAGIHAN.HeaderText = "Jumlah Tagihan [IDR]";
            this.TAGIHAN.Name = "TAGIHAN";
            this.TAGIHAN.ReadOnly = true;
            this.TAGIHAN.Width = 120;
            // 
            // JUMLAHBAYAR
            // 
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JUMLAHBAYAR.DefaultCellStyle = dataGridViewCellStyle19;
            this.JUMLAHBAYAR.HeaderText = "Jumlah Bayar [IDR]";
            this.JUMLAHBAYAR.Name = "JUMLAHBAYAR";
            this.JUMLAHBAYAR.ReadOnly = true;
            this.JUMLAHBAYAR.Width = 120;
            // 
            // SISA
            // 
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SISA.DefaultCellStyle = dataGridViewCellStyle20;
            this.SISA.HeaderText = "Sisa (Balance) [IDR]";
            this.SISA.Name = "SISA";
            this.SISA.ReadOnly = true;
            this.SISA.Width = 120;
            // 
            // TGLBAYAR
            // 
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TGLBAYAR.DefaultCellStyle = dataGridViewCellStyle21;
            this.TGLBAYAR.HeaderText = "Tgl Bayar";
            this.TGLBAYAR.Name = "TGLBAYAR";
            this.TGLBAYAR.ReadOnly = true;
            // 
            // STATUS
            // 
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.STATUS.DefaultCellStyle = dataGridViewCellStyle22;
            this.STATUS.HeaderText = "Status";
            this.STATUS.Name = "STATUS";
            this.STATUS.ReadOnly = true;
            // 
            // KETERANGAN
            // 
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.KETERANGAN.DefaultCellStyle = dataGridViewCellStyle23;
            this.KETERANGAN.HeaderText = "Keterangan";
            this.KETERANGAN.Name = "KETERANGAN";
            this.KETERANGAN.ReadOnly = true;
            // 
            // FormDAFTARPEMBAYARANHUTANG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1284, 608);
            this.Controls.Add(this.dgvTAGIHAN);
            this.Controls.Add(this.panelBUTTON);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDAFTARPEMBAYARANHUTANG";
            this.Text = "FormDAFTARPEMBAYRANHUTANG";
            this.Load += new System.EventHandler(this.FormDAFTARPEMBAYARANHUTANG_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelBUTTON.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTAGIHAN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitleMarketing;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboSTATUS;
        private System.Windows.Forms.DateTimePicker dtEND;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtBEGIN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panelBUTTON;
        private System.Windows.Forms.Button btnKELUAR;
        private System.Windows.Forms.Button btnPEMBAYARAN;
        private System.Windows.Forms.DataGridView dgvTAGIHAN;
        private System.Windows.Forms.Button btnCARI;
        private System.Windows.Forms.Button btnTAGIHAN;
        private System.Windows.Forms.Button btnEDIT;
        private System.Windows.Forms.Button btnHAPUS;
        private System.Windows.Forms.Button btnCetak;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AGENT;
        private System.Windows.Forms.DataGridViewTextBoxColumn HANDLING;
        private System.Windows.Forms.DataGridViewTextBoxColumn TGLDATANGINV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TGLINV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOINV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TAGIHAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn JUMLAHBAYAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn SISA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TGLBAYAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn KETERANGAN;
    }
}