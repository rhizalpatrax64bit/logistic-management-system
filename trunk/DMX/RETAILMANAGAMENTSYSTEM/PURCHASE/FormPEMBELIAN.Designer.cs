namespace LOGISTICMANAGAMENTSYSTEM.PURCHASE
{
    partial class FormPEMBELIAN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPEMBELIAN));
            this.dgvPEMBELIAN = new System.Windows.Forms.DataGridView();
            this.NOFAKTUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TANGGAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JTHTEMPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUPPLIER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BRUTTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DISKON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NETTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KETERANGAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.POSTING = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PKP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOFAKTURPAJAK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.gbVIEW = new System.Windows.Forms.GroupBox();
            this.btnLIHAT = new System.Windows.Forms.Button();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelBUTTON = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnKELUAR = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnTAMBAH = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPEMBELIAN)).BeginInit();
            this.gbVIEW.SuspendLayout();
            this.panelBUTTON.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPEMBELIAN
            // 
            this.dgvPEMBELIAN.AllowUserToAddRows = false;
            this.dgvPEMBELIAN.AllowUserToResizeRows = false;
            this.dgvPEMBELIAN.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvPEMBELIAN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPEMBELIAN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NOFAKTUR,
            this.TANGGAL,
            this.JTHTEMPO,
            this.SUPPLIER,
            this.BRUTTO,
            this.DISKON,
            this.PPN,
            this.NETTO,
            this.KETERANGAN,
            this.POSTING,
            this.PKP,
            this.NOFAKTURPAJAK,
            this.USER});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPEMBELIAN.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPEMBELIAN.Location = new System.Drawing.Point(4, 58);
            this.dgvPEMBELIAN.Name = "dgvPEMBELIAN";
            this.dgvPEMBELIAN.ReadOnly = true;
            this.dgvPEMBELIAN.RowHeadersVisible = false;
            this.dgvPEMBELIAN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPEMBELIAN.Size = new System.Drawing.Size(893, 365);
            this.dgvPEMBELIAN.TabIndex = 0;
            // 
            // NOFAKTUR
            // 
            this.NOFAKTUR.HeaderText = "NO. FAKTUR";
            this.NOFAKTUR.Name = "NOFAKTUR";
            this.NOFAKTUR.ReadOnly = true;
            // 
            // TANGGAL
            // 
            this.TANGGAL.HeaderText = "TANGGAL";
            this.TANGGAL.Name = "TANGGAL";
            this.TANGGAL.ReadOnly = true;
            // 
            // JTHTEMPO
            // 
            this.JTHTEMPO.HeaderText = "JTH.TEMPO";
            this.JTHTEMPO.Name = "JTHTEMPO";
            this.JTHTEMPO.ReadOnly = true;
            // 
            // SUPPLIER
            // 
            this.SUPPLIER.HeaderText = "SUPPLIER";
            this.SUPPLIER.Name = "SUPPLIER";
            this.SUPPLIER.ReadOnly = true;
            this.SUPPLIER.Width = 120;
            // 
            // BRUTTO
            // 
            this.BRUTTO.HeaderText = "BRUTTO";
            this.BRUTTO.Name = "BRUTTO";
            this.BRUTTO.ReadOnly = true;
            // 
            // DISKON
            // 
            this.DISKON.HeaderText = "DISKON";
            this.DISKON.Name = "DISKON";
            this.DISKON.ReadOnly = true;
            // 
            // PPN
            // 
            this.PPN.HeaderText = "PPN";
            this.PPN.Name = "PPN";
            this.PPN.ReadOnly = true;
            // 
            // NETTO
            // 
            this.NETTO.HeaderText = "NETTO";
            this.NETTO.Name = "NETTO";
            this.NETTO.ReadOnly = true;
            // 
            // KETERANGAN
            // 
            this.KETERANGAN.HeaderText = "KETERANGAN";
            this.KETERANGAN.Name = "KETERANGAN";
            this.KETERANGAN.ReadOnly = true;
            this.KETERANGAN.Width = 116;
            // 
            // POSTING
            // 
            this.POSTING.HeaderText = "POSTING";
            this.POSTING.Name = "POSTING";
            this.POSTING.ReadOnly = true;
            // 
            // PKP
            // 
            this.PKP.HeaderText = "PKP";
            this.PKP.Name = "PKP";
            this.PKP.ReadOnly = true;
            // 
            // NOFAKTURPAJAK
            // 
            this.NOFAKTURPAJAK.HeaderText = "NO. FAKTUR PAJAK";
            this.NOFAKTURPAJAK.Name = "NOFAKTURPAJAK";
            this.NOFAKTURPAJAK.ReadOnly = true;
            this.NOFAKTURPAJAK.Width = 120;
            // 
            // USER
            // 
            this.USER.HeaderText = "USER";
            this.USER.Name = "USER";
            this.USER.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 33);
            this.label1.TabIndex = 10;
            this.label1.Text = "TRANSAKSI PEMBELIAN";
            // 
            // gbVIEW
            // 
            this.gbVIEW.Controls.Add(this.btnLIHAT);
            this.gbVIEW.Controls.Add(this.dtp2);
            this.gbVIEW.Controls.Add(this.dtp1);
            this.gbVIEW.Controls.Add(this.label3);
            this.gbVIEW.Controls.Add(this.label2);
            this.gbVIEW.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbVIEW.ForeColor = System.Drawing.Color.Lime;
            this.gbVIEW.Location = new System.Drawing.Point(521, 4);
            this.gbVIEW.Name = "gbVIEW";
            this.gbVIEW.Size = new System.Drawing.Size(376, 48);
            this.gbVIEW.TabIndex = 13;
            this.gbVIEW.TabStop = false;
            this.gbVIEW.Text = "VIEW DATA";
            // 
            // btnLIHAT
            // 
            this.btnLIHAT.ForeColor = System.Drawing.Color.Black;
            this.btnLIHAT.Location = new System.Drawing.Point(292, 17);
            this.btnLIHAT.Name = "btnLIHAT";
            this.btnLIHAT.Size = new System.Drawing.Size(75, 23);
            this.btnLIHAT.TabIndex = 2;
            this.btnLIHAT.Text = "LIHAT";
            this.btnLIHAT.UseVisualStyleBackColor = true;
            // 
            // dtp2
            // 
            this.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp2.Location = new System.Drawing.Point(195, 17);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(91, 23);
            this.dtp2.TabIndex = 1;
            // 
            // dtp1
            // 
            this.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp1.Location = new System.Drawing.Point(83, 18);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(91, 23);
            this.dtp1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(178, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "TANGGAL";
            // 
            // panelBUTTON
            // 
            this.panelBUTTON.Controls.Add(this.button1);
            this.panelBUTTON.Controls.Add(this.button6);
            this.panelBUTTON.Controls.Add(this.btnKELUAR);
            this.panelBUTTON.Controls.Add(this.button3);
            this.panelBUTTON.Controls.Add(this.button4);
            this.panelBUTTON.Controls.Add(this.button2);
            this.panelBUTTON.Controls.Add(this.button5);
            this.panelBUTTON.Controls.Add(this.btnTAMBAH);
            this.panelBUTTON.Location = new System.Drawing.Point(4, 426);
            this.panelBUTTON.Name = "panelBUTTON";
            this.panelBUTTON.Size = new System.Drawing.Size(773, 56);
            this.panelBUTTON.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(564, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 50);
            this.button1.TabIndex = 8;
            this.button1.Text = "POSTING BONUS";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(460, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(105, 50);
            this.button6.TabIndex = 8;
            this.button6.Text = "POSTING TERTAGIH";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btnKELUAR
            // 
            this.btnKELUAR.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKELUAR.Image = ((System.Drawing.Image)(resources.GetObject("btnKELUAR.Image")));
            this.btnKELUAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKELUAR.Location = new System.Drawing.Point(668, 3);
            this.btnKELUAR.Name = "btnKELUAR";
            this.btnKELUAR.Size = new System.Drawing.Size(101, 50);
            this.btnKELUAR.TabIndex = 8;
            this.btnKELUAR.Text = "KELUAR";
            this.btnKELUAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKELUAR.UseVisualStyleBackColor = true;
            this.btnKELUAR.Click += new System.EventHandler(this.btnKELUAR_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(369, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 50);
            this.button3.TabIndex = 6;
            this.button3.Text = "SURAT\r\nJALAN";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(186, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 50);
            this.button4.TabIndex = 2;
            this.button4.Text = "HAPUS";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(106, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 50);
            this.button2.TabIndex = 5;
            this.button2.Text = "EDIT";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(285, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(85, 50);
            this.button5.TabIndex = 3;
            this.button5.Text = "CETAK";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnTAMBAH
            // 
            this.btnTAMBAH.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTAMBAH.Image = ((System.Drawing.Image)(resources.GetObject("btnTAMBAH.Image")));
            this.btnTAMBAH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTAMBAH.Location = new System.Drawing.Point(1, 3);
            this.btnTAMBAH.Name = "btnTAMBAH";
            this.btnTAMBAH.Size = new System.Drawing.Size(106, 50);
            this.btnTAMBAH.TabIndex = 4;
            this.btnTAMBAH.Text = "TAMBAH";
            this.btnTAMBAH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTAMBAH.UseVisualStyleBackColor = true;
            this.btnTAMBAH.Click += new System.EventHandler(this.btnTAMBAH_Click);
            // 
            // FormPEMBELIAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(900, 484);
            this.Controls.Add(this.panelBUTTON);
            this.Controls.Add(this.gbVIEW);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPEMBELIAN);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPEMBELIAN";
            this.Text = "FormPEMBELIAN";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPEMBELIAN)).EndInit();
            this.gbVIEW.ResumeLayout(false);
            this.gbVIEW.PerformLayout();
            this.panelBUTTON.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPEMBELIAN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbVIEW;
        private System.Windows.Forms.Button btnLIHAT;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelBUTTON;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnKELUAR;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnTAMBAH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOFAKTUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn TANGGAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn JTHTEMPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUPPLIER;
        private System.Windows.Forms.DataGridViewTextBoxColumn BRUTTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DISKON;
        private System.Windows.Forms.DataGridViewTextBoxColumn PPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NETTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn KETERANGAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn POSTING;
        private System.Windows.Forms.DataGridViewTextBoxColumn PKP;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOFAKTURPAJAK;
        private System.Windows.Forms.DataGridViewTextBoxColumn USER;
    }
}