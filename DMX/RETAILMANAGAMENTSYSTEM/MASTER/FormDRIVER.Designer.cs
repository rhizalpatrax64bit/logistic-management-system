namespace LOGISTICMANAGAMENTSYSTEM.MASTER
{
    partial class FormDRIVER
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDRIVER));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCetak = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHAPUS = new System.Windows.Forms.Button();
            this.btnEDIT = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnKELUAR = new System.Windows.Forms.Button();
            this.btnTAMBAH = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panelBUTTON = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCARI = new System.Windows.Forms.TextBox();
            this.dgvDRIVER = new System.Windows.Forms.DataGridView();
            this.panelCARI = new System.Windows.Forms.Panel();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ALAMAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEPON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelBUTTON.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDRIVER)).BeginInit();
            this.panelCARI.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCetak
            // 
            this.btnCetak.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCetak.Image = ((System.Drawing.Image)(resources.GetObject("btnCetak.Image")));
            this.btnCetak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCetak.Location = new System.Drawing.Point(263, 2);
            this.btnCetak.Name = "btnCetak";
            this.btnCetak.Size = new System.Drawing.Size(90, 43);
            this.btnCetak.TabIndex = 17;
            this.btnCetak.Text = "CETAK";
            this.btnCetak.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCetak.UseVisualStyleBackColor = true;
            this.btnCetak.Click += new System.EventHandler(this.btnCetak_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(561, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Keterangan : Tekan F1 untuk pencarian, F2 Tambah, F3 Edit F4 Delete, F5 Cetak, ES" +
                "C Keluar";
            // 
            // btnHAPUS
            // 
            this.btnHAPUS.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHAPUS.Image = ((System.Drawing.Image)(resources.GetObject("btnHAPUS.Image")));
            this.btnHAPUS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHAPUS.Location = new System.Drawing.Point(174, 2);
            this.btnHAPUS.Name = "btnHAPUS";
            this.btnHAPUS.Size = new System.Drawing.Size(90, 43);
            this.btnHAPUS.TabIndex = 4;
            this.btnHAPUS.Text = "HAPUS";
            this.btnHAPUS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHAPUS.UseVisualStyleBackColor = true;
            this.btnHAPUS.Click += new System.EventHandler(this.btnHAPUS_Click);
            // 
            // btnEDIT
            // 
            this.btnEDIT.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEDIT.Image = ((System.Drawing.Image)(resources.GetObject("btnEDIT.Image")));
            this.btnEDIT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEDIT.Location = new System.Drawing.Point(104, 2);
            this.btnEDIT.Name = "btnEDIT";
            this.btnEDIT.Size = new System.Drawing.Size(71, 43);
            this.btnEDIT.TabIndex = 4;
            this.btnEDIT.Text = "EDIT";
            this.btnEDIT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEDIT.UseVisualStyleBackColor = true;
            this.btnEDIT.Click += new System.EventHandler(this.btnEDIT_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1284, 88);
            this.panel2.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(285, 18);
            this.label4.TabIndex = 35;
            this.label4.Text = "Modul ini digunakan untuk kelola data driver";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1177, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(9, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(356, 33);
            this.label5.TabIndex = 33;
            this.label5.Text = "KELOLA MASTER DATA DRIVER";
            // 
            // btnKELUAR
            // 
            this.btnKELUAR.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKELUAR.Image = ((System.Drawing.Image)(resources.GetObject("btnKELUAR.Image")));
            this.btnKELUAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKELUAR.Location = new System.Drawing.Point(352, 2);
            this.btnKELUAR.Name = "btnKELUAR";
            this.btnKELUAR.Size = new System.Drawing.Size(103, 43);
            this.btnKELUAR.TabIndex = 2;
            this.btnKELUAR.Text = "KELUAR";
            this.btnKELUAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKELUAR.UseVisualStyleBackColor = true;
            // 
            // btnTAMBAH
            // 
            this.btnTAMBAH.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pencarian :";
            // 
            // panelBUTTON
            // 
            this.panelBUTTON.Controls.Add(this.panel1);
            this.panelBUTTON.Controls.Add(this.btnCetak);
            this.panelBUTTON.Controls.Add(this.btnHAPUS);
            this.panelBUTTON.Controls.Add(this.btnEDIT);
            this.panelBUTTON.Controls.Add(this.btnKELUAR);
            this.panelBUTTON.Controls.Add(this.btnTAMBAH);
            this.panelBUTTON.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBUTTON.Location = new System.Drawing.Point(0, 561);
            this.panelBUTTON.Name = "panelBUTTON";
            this.panelBUTTON.Size = new System.Drawing.Size(1284, 47);
            this.panelBUTTON.TabIndex = 40;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(478, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 33);
            this.panel1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(373, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "CARI [ F1 ]";
            // 
            // txtCARI
            // 
            this.txtCARI.BackColor = System.Drawing.Color.Honeydew;
            this.txtCARI.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCARI.Location = new System.Drawing.Point(88, 4);
            this.txtCARI.Name = "txtCARI";
            this.txtCARI.Size = new System.Drawing.Size(255, 23);
            this.txtCARI.TabIndex = 1;
            this.txtCARI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCARI.TextChanged += new System.EventHandler(this.txtCARI_TextChanged);
            // 
            // dgvDRIVER
            // 
            this.dgvDRIVER.AllowUserToAddRows = false;
            this.dgvDRIVER.AllowUserToResizeRows = false;
            this.dgvDRIVER.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvDRIVER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDRIVER.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.STATUS,
            this.KODE,
            this.NAMA,
            this.ALAMAT,
            this.TELEPON,
            this.NOHP,
            this.EMAIL});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDRIVER.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDRIVER.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvDRIVER.Location = new System.Drawing.Point(0, 172);
            this.dgvDRIVER.Name = "dgvDRIVER";
            this.dgvDRIVER.ReadOnly = true;
            this.dgvDRIVER.RowHeadersVisible = false;
            this.dgvDRIVER.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDRIVER.Size = new System.Drawing.Size(889, 385);
            this.dgvDRIVER.TabIndex = 39;
            // 
            // panelCARI
            // 
            this.panelCARI.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCARI.Controls.Add(this.label2);
            this.panelCARI.Controls.Add(this.label1);
            this.panelCARI.Controls.Add(this.txtCARI);
            this.panelCARI.Location = new System.Drawing.Point(3, 133);
            this.panelCARI.Name = "panelCARI";
            this.panelCARI.Size = new System.Drawing.Size(462, 33);
            this.panelCARI.TabIndex = 38;
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
            this.STATUS.ToolTipText = "Status";
            // 
            // KODE
            // 
            this.KODE.HeaderText = "Kode";
            this.KODE.Name = "KODE";
            this.KODE.ReadOnly = true;
            this.KODE.ToolTipText = "Kode";
            this.KODE.Width = 190;
            // 
            // NAMA
            // 
            this.NAMA.HeaderText = "Nama";
            this.NAMA.Name = "NAMA";
            this.NAMA.ReadOnly = true;
            this.NAMA.ToolTipText = "Nama";
            this.NAMA.Width = 200;
            // 
            // ALAMAT
            // 
            this.ALAMAT.HeaderText = "Alamat";
            this.ALAMAT.Name = "ALAMAT";
            this.ALAMAT.ReadOnly = true;
            this.ALAMAT.ToolTipText = "Alamat";
            this.ALAMAT.Width = 450;
            // 
            // TELEPON
            // 
            this.TELEPON.HeaderText = "Telepon";
            this.TELEPON.Name = "TELEPON";
            this.TELEPON.ReadOnly = true;
            this.TELEPON.ToolTipText = "Telepon";
            this.TELEPON.Width = 140;
            // 
            // NOHP
            // 
            this.NOHP.HeaderText = "Handphone";
            this.NOHP.Name = "NOHP";
            this.NOHP.ReadOnly = true;
            this.NOHP.ToolTipText = "Handphone";
            // 
            // EMAIL
            // 
            this.EMAIL.HeaderText = "Email";
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.ReadOnly = true;
            this.EMAIL.ToolTipText = "Email";
            this.EMAIL.Width = 250;
            // 
            // FormDRIVER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1284, 608);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelBUTTON);
            this.Controls.Add(this.dgvDRIVER);
            this.Controls.Add(this.panelCARI);
            this.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDRIVER";
            this.Text = "FormDRIVER";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormDRIVER_KeyUp);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelBUTTON.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDRIVER)).EndInit();
            this.panelCARI.ResumeLayout(false);
            this.panelCARI.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCetak;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHAPUS;
        private System.Windows.Forms.Button btnEDIT;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnKELUAR;
        private System.Windows.Forms.Button btnTAMBAH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelBUTTON;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCARI;
        private System.Windows.Forms.DataGridView dgvDRIVER;
        private System.Windows.Forms.Panel panelCARI;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn KODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ALAMAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEPON;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL;
    }
}