namespace LOGISTICMANAGAMENTSYSTEM.PURCHASE
{
    partial class FormRETURPEMBELIAN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRETURPEMBELIAN));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRETUR = new System.Windows.Forms.DataGridView();
            this.NORETUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TANGGAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUPPLIER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SALES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PJWB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BRUTTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KETERANGAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USERENTRI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPEPOST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USERPOSTING = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBUTTON = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnHAPUS = new System.Windows.Forms.Button();
            this.btnEDIT = new System.Windows.Forms.Button();
            this.btnKELUAR = new System.Windows.Forms.Button();
            this.btnTAMBAH = new System.Windows.Forms.Button();
            this.gbVIEW = new System.Windows.Forms.GroupBox();
            this.btnLIHAT = new System.Windows.Forms.Button();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRETUR)).BeginInit();
            this.panelBUTTON.SuspendLayout();
            this.gbVIEW.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "TRANSAKSI RETUR PEMBELIAN";
            // 
            // dgvRETUR
            // 
            this.dgvRETUR.AllowUserToAddRows = false;
            this.dgvRETUR.AllowUserToResizeRows = false;
            this.dgvRETUR.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvRETUR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRETUR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NORETUR,
            this.TANGGAL,
            this.SUPPLIER,
            this.SALES,
            this.PJWB,
            this.BRUTTO,
            this.KETERANGAN,
            this.USERENTRI,
            this.TIPEPOST,
            this.USERPOSTING});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRETUR.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRETUR.Location = new System.Drawing.Point(3, 58);
            this.dgvRETUR.Name = "dgvRETUR";
            this.dgvRETUR.ReadOnly = true;
            this.dgvRETUR.RowHeadersVisible = false;
            this.dgvRETUR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRETUR.Size = new System.Drawing.Size(894, 375);
            this.dgvRETUR.TabIndex = 10;
            // 
            // NORETUR
            // 
            this.NORETUR.HeaderText = "NO. RETUR";
            this.NORETUR.Name = "NORETUR";
            this.NORETUR.ReadOnly = true;
            this.NORETUR.Width = 120;
            // 
            // TANGGAL
            // 
            this.TANGGAL.HeaderText = "TANGGAL";
            this.TANGGAL.Name = "TANGGAL";
            this.TANGGAL.ReadOnly = true;
            this.TANGGAL.Width = 110;
            // 
            // SUPPLIER
            // 
            this.SUPPLIER.HeaderText = "SUPPLIER";
            this.SUPPLIER.Name = "SUPPLIER";
            this.SUPPLIER.ReadOnly = true;
            this.SUPPLIER.Width = 190;
            // 
            // SALES
            // 
            this.SALES.HeaderText = "SALES";
            this.SALES.Name = "SALES";
            this.SALES.ReadOnly = true;
            this.SALES.Width = 150;
            // 
            // PJWB
            // 
            this.PJWB.HeaderText = "P. JAWAB";
            this.PJWB.Name = "PJWB";
            this.PJWB.ReadOnly = true;
            this.PJWB.Width = 142;
            // 
            // BRUTTO
            // 
            this.BRUTTO.HeaderText = "BRUTTO";
            this.BRUTTO.Name = "BRUTTO";
            this.BRUTTO.ReadOnly = true;
            // 
            // KETERANGAN
            // 
            this.KETERANGAN.HeaderText = "KETERANGAN";
            this.KETERANGAN.Name = "KETERANGAN";
            this.KETERANGAN.ReadOnly = true;
            this.KETERANGAN.Width = 195;
            // 
            // USERENTRI
            // 
            this.USERENTRI.HeaderText = "USER ENTRI";
            this.USERENTRI.Name = "USERENTRI";
            this.USERENTRI.ReadOnly = true;
            this.USERENTRI.Width = 110;
            // 
            // TIPEPOST
            // 
            this.TIPEPOST.HeaderText = "TIPE POST";
            this.TIPEPOST.Name = "TIPEPOST";
            this.TIPEPOST.ReadOnly = true;
            this.TIPEPOST.Width = 110;
            // 
            // USERPOSTING
            // 
            this.USERPOSTING.HeaderText = "USER POSTING";
            this.USERPOSTING.Name = "USERPOSTING";
            this.USERPOSTING.ReadOnly = true;
            this.USERPOSTING.Width = 130;
            // 
            // panelBUTTON
            // 
            this.panelBUTTON.Controls.Add(this.button4);
            this.panelBUTTON.Controls.Add(this.button3);
            this.panelBUTTON.Controls.Add(this.button2);
            this.panelBUTTON.Controls.Add(this.button1);
            this.panelBUTTON.Controls.Add(this.btnHAPUS);
            this.panelBUTTON.Controls.Add(this.btnEDIT);
            this.panelBUTTON.Controls.Add(this.btnKELUAR);
            this.panelBUTTON.Controls.Add(this.btnTAMBAH);
            this.panelBUTTON.Location = new System.Drawing.Point(3, 435);
            this.panelBUTTON.Name = "panelBUTTON";
            this.panelBUTTON.Size = new System.Drawing.Size(894, 47);
            this.panelBUTTON.TabIndex = 11;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(538, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 43);
            this.button4.TabIndex = 5;
            this.button4.Text = "KERUGIAN";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(439, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 43);
            this.button3.TabIndex = 5;
            this.button3.Text = "CASH BACK";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(350, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 43);
            this.button2.TabIndex = 5;
            this.button2.Text = "PTG NOTA";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(262, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "CETAK";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnHAPUS
            // 
            this.btnHAPUS.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHAPUS.Image = ((System.Drawing.Image)(resources.GetObject("btnHAPUS.Image")));
            this.btnHAPUS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHAPUS.Location = new System.Drawing.Point(174, 2);
            this.btnHAPUS.Name = "btnHAPUS";
            this.btnHAPUS.Size = new System.Drawing.Size(90, 43);
            this.btnHAPUS.TabIndex = 4;
            this.btnHAPUS.Text = "HAPUS";
            this.btnHAPUS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHAPUS.UseVisualStyleBackColor = true;
            // 
            // btnEDIT
            // 
            this.btnEDIT.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEDIT.Image = ((System.Drawing.Image)(resources.GetObject("btnEDIT.Image")));
            this.btnEDIT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEDIT.Location = new System.Drawing.Point(104, 2);
            this.btnEDIT.Name = "btnEDIT";
            this.btnEDIT.Size = new System.Drawing.Size(71, 43);
            this.btnEDIT.TabIndex = 4;
            this.btnEDIT.Text = "EDIT";
            this.btnEDIT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEDIT.UseVisualStyleBackColor = true;
            // 
            // btnKELUAR
            // 
            this.btnKELUAR.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKELUAR.Image = ((System.Drawing.Image)(resources.GetObject("btnKELUAR.Image")));
            this.btnKELUAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKELUAR.Location = new System.Drawing.Point(627, 2);
            this.btnKELUAR.Name = "btnKELUAR";
            this.btnKELUAR.Size = new System.Drawing.Size(103, 43);
            this.btnKELUAR.TabIndex = 2;
            this.btnKELUAR.Text = "KELUAR";
            this.btnKELUAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKELUAR.UseVisualStyleBackColor = true;
            this.btnKELUAR.Click += new System.EventHandler(this.btnKELUAR_Click);
            // 
            // btnTAMBAH
            // 
            this.btnTAMBAH.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTAMBAH.Image = ((System.Drawing.Image)(resources.GetObject("btnTAMBAH.Image")));
            this.btnTAMBAH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTAMBAH.Location = new System.Drawing.Point(2, 2);
            this.btnTAMBAH.Name = "btnTAMBAH";
            this.btnTAMBAH.Size = new System.Drawing.Size(103, 43);
            this.btnTAMBAH.TabIndex = 2;
            this.btnTAMBAH.Text = "TAMBAH";
            this.btnTAMBAH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTAMBAH.UseVisualStyleBackColor = true;
            this.btnTAMBAH.Click += new System.EventHandler(this.btnTAMBAH_Click);
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
            this.gbVIEW.TabIndex = 12;
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
            // FormRETURPEMBELIAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(900, 484);
            this.Controls.Add(this.gbVIEW);
            this.Controls.Add(this.panelBUTTON);
            this.Controls.Add(this.dgvRETUR);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRETURPEMBELIAN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRETURPEMBELIAN";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRETUR)).EndInit();
            this.panelBUTTON.ResumeLayout(false);
            this.gbVIEW.ResumeLayout(false);
            this.gbVIEW.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvRETUR;
        private System.Windows.Forms.Panel panelBUTTON;
        private System.Windows.Forms.Button btnHAPUS;
        private System.Windows.Forms.Button btnEDIT;
        private System.Windows.Forms.Button btnKELUAR;
        private System.Windows.Forms.Button btnTAMBAH;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbVIEW;
        private System.Windows.Forms.Button btnLIHAT;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NORETUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn TANGGAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUPPLIER;
        private System.Windows.Forms.DataGridViewTextBoxColumn SALES;
        private System.Windows.Forms.DataGridViewTextBoxColumn PJWB;
        private System.Windows.Forms.DataGridViewTextBoxColumn BRUTTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn KETERANGAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn USERENTRI;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPEPOST;
        private System.Windows.Forms.DataGridViewTextBoxColumn USERPOSTING;
    }
}