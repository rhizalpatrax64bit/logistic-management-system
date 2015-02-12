namespace LOGISTICMANAGAMENTSYSTEM.EXPRESS
{
    partial class FormBONGKARMUAT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBONGKARMUAT));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label43 = new System.Windows.Forms.Label();
            this.dgvSO = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAMALAYANAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JENISKIRIMAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TARIFF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TARIF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ETD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.dtTGLCONNOTE = new System.Windows.Forms.DateTimePicker();
            this.panelBUTTON = new System.Windows.Forms.Panel();
            this.btnEDIT = new System.Windows.Forms.Button();
            this.btnTAMBAH = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSO)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panelBUTTON.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label43);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 68);
            this.panel1.TabIndex = 93;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(12, 44);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(406, 18);
            this.label24.TabIndex = 35;
            this.label24.Text = "Modul ini digunakan untuk entry data Surat Tanda Terima Barang";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(733, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.ForeColor = System.Drawing.Color.Black;
            this.label43.Location = new System.Drawing.Point(9, 11);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(296, 33);
            this.label43.TabIndex = 33;
            this.label43.Text = "KELOLA BONGKAR MUAT";
            // 
            // dgvSO
            // 
            this.dgvSO.AllowUserToAddRows = false;
            this.dgvSO.AllowUserToResizeRows = false;
            this.dgvSO.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvSO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NAMALAYANAN,
            this.JENISKIRIMAN,
            this.TARIFF,
            this.TARIF,
            this.ETD});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSO.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSO.Location = new System.Drawing.Point(6, 22);
            this.dgvSO.Name = "dgvSO";
            this.dgvSO.ReadOnly = true;
            this.dgvSO.RowHeadersVisible = false;
            this.dgvSO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSO.Size = new System.Drawing.Size(776, 148);
            this.dgvSO.TabIndex = 95;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // NAMALAYANAN
            // 
            this.NAMALAYANAN.HeaderText = "NAMA LAYANAN";
            this.NAMALAYANAN.Name = "NAMALAYANAN";
            this.NAMALAYANAN.ReadOnly = true;
            this.NAMALAYANAN.Width = 200;
            // 
            // JENISKIRIMAN
            // 
            this.JENISKIRIMAN.HeaderText = "JENIS KIRIMAN";
            this.JENISKIRIMAN.Name = "JENISKIRIMAN";
            this.JENISKIRIMAN.ReadOnly = true;
            this.JENISKIRIMAN.Width = 200;
            // 
            // TARIFF
            // 
            this.TARIFF.HeaderText = "TARIF / KG";
            this.TARIFF.Name = "TARIFF";
            this.TARIFF.ReadOnly = true;
            this.TARIFF.Width = 150;
            // 
            // TARIF
            // 
            this.TARIF.HeaderText = "TARIF";
            this.TARIF.Name = "TARIF";
            this.TARIF.ReadOnly = true;
            // 
            // ETD
            // 
            this.ETD.HeaderText = "TGL TIBA";
            this.ETD.Name = "ETD";
            this.ETD.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvSO);
            this.groupBox1.Location = new System.Drawing.Point(12, 246);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(792, 176);
            this.groupBox1.TabIndex = 96;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item SO";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(88, 126);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(116, 23);
            this.textBox14.TabIndex = 123;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(87, 99);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(117, 23);
            this.textBox13.TabIndex = 122;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(10, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 15);
            this.label11.TabIndex = 117;
            this.label11.Text = "CO DRIVER";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(10, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 15);
            this.label12.TabIndex = 116;
            this.label12.Text = "DRIVER";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.textBox9);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label66);
            this.groupBox3.Controls.Add(this.dtTGLCONNOTE);
            this.groupBox3.Controls.Add(this.textBox14);
            this.groupBox3.Controls.Add(this.textBox13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(12, 74);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(785, 154);
            this.groupBox3.TabIndex = 101;
            this.groupBox3.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 23);
            this.textBox1.TabIndex = 131;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 130;
            this.label1.Text = "NO POLISI";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(87, 14);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(145, 23);
            this.textBox9.TabIndex = 115;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 15);
            this.label7.TabIndex = 114;
            this.label7.Text = "NO SPJ";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label66.ForeColor = System.Drawing.Color.Black;
            this.label66.Location = new System.Drawing.Point(7, 46);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(61, 15);
            this.label66.TabIndex = 99;
            this.label66.Text = "TGL KIRIM";
            // 
            // dtTGLCONNOTE
            // 
            this.dtTGLCONNOTE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTGLCONNOTE.Location = new System.Drawing.Point(87, 42);
            this.dtTGLCONNOTE.Name = "dtTGLCONNOTE";
            this.dtTGLCONNOTE.Size = new System.Drawing.Size(145, 23);
            this.dtTGLCONNOTE.TabIndex = 95;
            // 
            // panelBUTTON
            // 
            this.panelBUTTON.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelBUTTON.Controls.Add(this.btnEDIT);
            this.panelBUTTON.Controls.Add(this.btnTAMBAH);
            this.panelBUTTON.Location = new System.Drawing.Point(12, 458);
            this.panelBUTTON.Name = "panelBUTTON";
            this.panelBUTTON.Size = new System.Drawing.Size(795, 47);
            this.panelBUTTON.TabIndex = 115;
            // 
            // btnEDIT
            // 
            this.btnEDIT.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEDIT.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEDIT.Image = ((System.Drawing.Image)(resources.GetObject("btnEDIT.Image")));
            this.btnEDIT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEDIT.Location = new System.Drawing.Point(110, 2);
            this.btnEDIT.Name = "btnEDIT";
            this.btnEDIT.Size = new System.Drawing.Size(98, 43);
            this.btnEDIT.TabIndex = 2;
            this.btnEDIT.Text = "BATAL";
            this.btnEDIT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEDIT.UseVisualStyleBackColor = false;
            // 
            // btnTAMBAH
            // 
            this.btnTAMBAH.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTAMBAH.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTAMBAH.Image = ((System.Drawing.Image)(resources.GetObject("btnTAMBAH.Image")));
            this.btnTAMBAH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTAMBAH.Location = new System.Drawing.Point(2, 2);
            this.btnTAMBAH.Name = "btnTAMBAH";
            this.btnTAMBAH.Size = new System.Drawing.Size(103, 43);
            this.btnTAMBAH.TabIndex = 1;
            this.btnTAMBAH.Text = "SIMPAN";
            this.btnTAMBAH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTAMBAH.UseVisualStyleBackColor = false;
            // 
            // FormBONGKARMUAT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(819, 517);
            this.ControlBox = false;
            this.Controls.Add(this.panelBUTTON);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBONGKARMUAT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ITEM BONGKAR MUAT";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSO)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panelBUTTON.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.DataGridView dgvSO;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.DateTimePicker dtTGLCONNOTE;
        private System.Windows.Forms.Panel panelBUTTON;
        private System.Windows.Forms.Button btnEDIT;
        private System.Windows.Forms.Button btnTAMBAH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAMALAYANAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn JENISKIRIMAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TARIFF;
        private System.Windows.Forms.DataGridViewTextBoxColumn TARIF;
        private System.Windows.Forms.DataGridViewTextBoxColumn ETD;
    }
}