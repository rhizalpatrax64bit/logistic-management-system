namespace LOGISTICMANAGAMENTSYSTEM.MASTER
{
    partial class FormKOTA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKOTA));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelCARI = new System.Windows.Forms.Panel();
            this.txtCARI = new System.Windows.Forms.TextBox();
            this.rdbNAMA = new System.Windows.Forms.RadioButton();
            this.rdbKODE = new System.Windows.Forms.RadioButton();
            this.dgvAREA = new System.Windows.Forms.DataGridView();
            this.panelBUTTON = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnTAMBAHTERUSAN = new System.Windows.Forms.Button();
            this.btnHAPUS = new System.Windows.Forms.Button();
            this.btnEDIT = new System.Windows.Forms.Button();
            this.btnTAMBAH = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvKOTA = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dgvTERUSAN = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTERUSAN = new System.Windows.Forms.Label();
            this.IDAREA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KODEAREA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAMAAREA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDKOTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAMAAREAKOTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KODEKOTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAMAKOTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TERUSAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelCARI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAREA)).BeginInit();
            this.panelBUTTON.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKOTA)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTERUSAN)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCARI
            // 
            this.panelCARI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCARI.Controls.Add(this.txtCARI);
            this.panelCARI.Controls.Add(this.rdbNAMA);
            this.panelCARI.Controls.Add(this.rdbKODE);
            this.panelCARI.Location = new System.Drawing.Point(1, 95);
            this.panelCARI.Name = "panelCARI";
            this.panelCARI.Size = new System.Drawing.Size(576, 33);
            this.panelCARI.TabIndex = 18;
            // 
            // txtCARI
            // 
            this.txtCARI.BackColor = System.Drawing.Color.Honeydew;
            this.txtCARI.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCARI.Location = new System.Drawing.Point(267, 4);
            this.txtCARI.Name = "txtCARI";
            this.txtCARI.Size = new System.Drawing.Size(305, 23);
            this.txtCARI.TabIndex = 1;
            this.txtCARI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCARI.TextChanged += new System.EventHandler(this.txtCARI_TextChanged);
            // 
            // rdbNAMA
            // 
            this.rdbNAMA.AutoSize = true;
            this.rdbNAMA.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNAMA.ForeColor = System.Drawing.Color.Black;
            this.rdbNAMA.Location = new System.Drawing.Point(131, 6);
            this.rdbNAMA.Name = "rdbNAMA";
            this.rdbNAMA.Size = new System.Drawing.Size(84, 19);
            this.rdbNAMA.TabIndex = 0;
            this.rdbNAMA.TabStop = true;
            this.rdbNAMA.Text = "Nama  [F4]";
            this.rdbNAMA.UseVisualStyleBackColor = true;
            // 
            // rdbKODE
            // 
            this.rdbKODE.AutoSize = true;
            this.rdbKODE.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbKODE.ForeColor = System.Drawing.Color.Black;
            this.rdbKODE.Location = new System.Drawing.Point(12, 6);
            this.rdbKODE.Name = "rdbKODE";
            this.rdbKODE.Size = new System.Drawing.Size(77, 19);
            this.rdbKODE.TabIndex = 0;
            this.rdbKODE.TabStop = true;
            this.rdbKODE.Text = "Kode [F3]";
            this.rdbKODE.UseVisualStyleBackColor = true;
            // 
            // dgvAREA
            // 
            this.dgvAREA.AllowUserToAddRows = false;
            this.dgvAREA.AllowUserToResizeRows = false;
            this.dgvAREA.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvAREA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAREA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDAREA,
            this.KODEAREA,
            this.NAMAAREA});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAREA.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAREA.Location = new System.Drawing.Point(1, 152);
            this.dgvAREA.Name = "dgvAREA";
            this.dgvAREA.ReadOnly = true;
            this.dgvAREA.RowHeadersVisible = false;
            this.dgvAREA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAREA.Size = new System.Drawing.Size(888, 133);
            this.dgvAREA.TabIndex = 19;
            this.dgvAREA.Click += new System.EventHandler(this.dgvAREA_Click);
            // 
            // panelBUTTON
            // 
            this.panelBUTTON.Controls.Add(this.button3);
            this.panelBUTTON.Controls.Add(this.button5);
            this.panelBUTTON.Controls.Add(this.button6);
            this.panelBUTTON.Controls.Add(this.btnTAMBAHTERUSAN);
            this.panelBUTTON.Controls.Add(this.btnHAPUS);
            this.panelBUTTON.Controls.Add(this.btnEDIT);
            this.panelBUTTON.Controls.Add(this.btnTAMBAH);
            this.panelBUTTON.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBUTTON.Location = new System.Drawing.Point(0, 561);
            this.panelBUTTON.Name = "panelBUTTON";
            this.panelBUTTON.Size = new System.Drawing.Size(1284, 47);
            this.panelBUTTON.TabIndex = 21;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(806, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 43);
            this.button3.TabIndex = 7;
            this.button3.Text = "HAPUS";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(736, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(71, 43);
            this.button5.TabIndex = 8;
            this.button5.Text = "EDIT";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(895, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(103, 43);
            this.button6.TabIndex = 5;
            this.button6.Text = "KELUAR";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnTAMBAHTERUSAN
            // 
            this.btnTAMBAHTERUSAN.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTAMBAHTERUSAN.Image = ((System.Drawing.Image)(resources.GetObject("btnTAMBAHTERUSAN.Image")));
            this.btnTAMBAHTERUSAN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTAMBAHTERUSAN.Location = new System.Drawing.Point(634, 4);
            this.btnTAMBAHTERUSAN.Name = "btnTAMBAHTERUSAN";
            this.btnTAMBAHTERUSAN.Size = new System.Drawing.Size(103, 43);
            this.btnTAMBAHTERUSAN.TabIndex = 6;
            this.btnTAMBAHTERUSAN.Text = "TAMBAH";
            this.btnTAMBAHTERUSAN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTAMBAHTERUSAN.UseVisualStyleBackColor = true;
            this.btnTAMBAHTERUSAN.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnHAPUS
            // 
            this.btnHAPUS.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHAPUS.Image = ((System.Drawing.Image)(resources.GetObject("btnHAPUS.Image")));
            this.btnHAPUS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHAPUS.Location = new System.Drawing.Point(173, 0);
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
            this.btnEDIT.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEDIT.Image = ((System.Drawing.Image)(resources.GetObject("btnEDIT.Image")));
            this.btnEDIT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEDIT.Location = new System.Drawing.Point(103, 0);
            this.btnEDIT.Name = "btnEDIT";
            this.btnEDIT.Size = new System.Drawing.Size(71, 43);
            this.btnEDIT.TabIndex = 4;
            this.btnEDIT.Text = "EDIT";
            this.btnEDIT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEDIT.UseVisualStyleBackColor = true;
            this.btnEDIT.Click += new System.EventHandler(this.btnEDIT_Click);
            // 
            // btnTAMBAH
            // 
            this.btnTAMBAH.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTAMBAH.Image = ((System.Drawing.Image)(resources.GetObject("btnTAMBAH.Image")));
            this.btnTAMBAH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTAMBAH.Location = new System.Drawing.Point(1, 0);
            this.btnTAMBAH.Name = "btnTAMBAH";
            this.btnTAMBAH.Size = new System.Drawing.Size(103, 43);
            this.btnTAMBAH.TabIndex = 2;
            this.btnTAMBAH.Text = "TAMBAH";
            this.btnTAMBAH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTAMBAH.UseVisualStyleBackColor = true;
            this.btnTAMBAH.Click += new System.EventHandler(this.btnTAMBAH_Click);
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
            this.panel2.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 18);
            this.label4.TabIndex = 35;
            this.label4.Text = "Modul ini digunakan untuk kelola data kota";
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
            this.label5.Size = new System.Drawing.Size(335, 33);
            this.label5.TabIndex = 33;
            this.label5.Text = "KELOLA MASTER DATA KOTA";
            // 
            // dgvKOTA
            // 
            this.dgvKOTA.AllowUserToAddRows = false;
            this.dgvKOTA.AllowUserToResizeRows = false;
            this.dgvKOTA.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvKOTA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKOTA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDKOTA,
            this.NAMAAREAKOTA,
            this.KODEKOTA,
            this.NAMAKOTA});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKOTA.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKOTA.Location = new System.Drawing.Point(0, 369);
            this.dgvKOTA.Name = "dgvKOTA";
            this.dgvKOTA.ReadOnly = true;
            this.dgvKOTA.RowHeadersVisible = false;
            this.dgvKOTA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKOTA.Size = new System.Drawing.Size(609, 179);
            this.dgvKOTA.TabIndex = 40;
            this.dgvKOTA.Click += new System.EventHandler(this.dgvKOTA_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 41;
            this.label1.Text = "DAFTAR AREA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 19);
            this.label2.TabIndex = 42;
            this.label2.Text = "DAFTAR KOTA";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(0, 291);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1284, 47);
            this.panel1.TabIndex = 43;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(173, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "HAPUS";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(103, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 43);
            this.button2.TabIndex = 4;
            this.button2.Text = "EDIT";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(1, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 43);
            this.button4.TabIndex = 2;
            this.button4.Text = "TAMBAH";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dgvTERUSAN
            // 
            this.dgvTERUSAN.AllowUserToAddRows = false;
            this.dgvTERUSAN.AllowUserToResizeRows = false;
            this.dgvTERUSAN.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvTERUSAN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTERUSAN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.TERUSAN});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 9.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTERUSAN.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTERUSAN.Location = new System.Drawing.Point(632, 369);
            this.dgvTERUSAN.Name = "dgvTERUSAN";
            this.dgvTERUSAN.ReadOnly = true;
            this.dgvTERUSAN.RowHeadersVisible = false;
            this.dgvTERUSAN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTERUSAN.Size = new System.Drawing.Size(609, 179);
            this.dgvTERUSAN.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(629, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 19);
            this.label3.TabIndex = 45;
            this.label3.Text = "DAFTAR KOTA TERUSAN :";
            // 
            // lblTERUSAN
            // 
            this.lblTERUSAN.AutoSize = true;
            this.lblTERUSAN.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTERUSAN.Location = new System.Drawing.Point(807, 344);
            this.lblTERUSAN.Name = "lblTERUSAN";
            this.lblTERUSAN.Size = new System.Drawing.Size(23, 19);
            this.lblTERUSAN.TabIndex = 46;
            this.lblTERUSAN.Text = "[ ]";
            // 
            // IDAREA
            // 
            this.IDAREA.HeaderText = "IDAREA";
            this.IDAREA.Name = "IDAREA";
            this.IDAREA.ReadOnly = true;
            this.IDAREA.Visible = false;
            // 
            // KODEAREA
            // 
            this.KODEAREA.HeaderText = "Kode Area";
            this.KODEAREA.Name = "KODEAREA";
            this.KODEAREA.ReadOnly = true;
            this.KODEAREA.ToolTipText = "Kode Area";
            // 
            // NAMAAREA
            // 
            this.NAMAAREA.HeaderText = "Nama Area";
            this.NAMAAREA.Name = "NAMAAREA";
            this.NAMAAREA.ReadOnly = true;
            this.NAMAAREA.ToolTipText = "Nama Area";
            this.NAMAAREA.Width = 250;
            // 
            // IDKOTA
            // 
            this.IDKOTA.HeaderText = "IDKOTA";
            this.IDKOTA.Name = "IDKOTA";
            this.IDKOTA.ReadOnly = true;
            this.IDKOTA.Visible = false;
            // 
            // NAMAAREAKOTA
            // 
            this.NAMAAREAKOTA.HeaderText = "Nama Area";
            this.NAMAAREAKOTA.Name = "NAMAAREAKOTA";
            this.NAMAAREAKOTA.ReadOnly = true;
            this.NAMAAREAKOTA.Width = 250;
            // 
            // KODEKOTA
            // 
            this.KODEKOTA.HeaderText = "Kode Kota";
            this.KODEKOTA.Name = "KODEKOTA";
            this.KODEKOTA.ReadOnly = true;
            this.KODEKOTA.ToolTipText = "Kode Kota";
            // 
            // NAMAKOTA
            // 
            this.NAMAKOTA.HeaderText = "Nama Kota";
            this.NAMAKOTA.Name = "NAMAKOTA";
            this.NAMAKOTA.ReadOnly = true;
            this.NAMAKOTA.ToolTipText = "Nama Kota";
            this.NAMAKOTA.Width = 250;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "IDKOTA";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Kode Kota";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.ToolTipText = "Kode Kota";
            // 
            // TERUSAN
            // 
            this.TERUSAN.HeaderText = "Kota Terusan";
            this.TERUSAN.Name = "TERUSAN";
            this.TERUSAN.ReadOnly = true;
            this.TERUSAN.ToolTipText = "Kota Terusan";
            this.TERUSAN.Width = 250;
            // 
            // FormKOTA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1284, 608);
            this.Controls.Add(this.lblTERUSAN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvTERUSAN);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvKOTA);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelBUTTON);
            this.Controls.Add(this.dgvAREA);
            this.Controls.Add(this.panelCARI);
            this.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormKOTA";
            this.Text = "FormKOTA";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormKOTA_KeyUp);
            this.panelCARI.ResumeLayout(false);
            this.panelCARI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAREA)).EndInit();
            this.panelBUTTON.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKOTA)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTERUSAN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCARI;
        private System.Windows.Forms.TextBox txtCARI;
        private System.Windows.Forms.RadioButton rdbNAMA;
        private System.Windows.Forms.RadioButton rdbKODE;
        private System.Windows.Forms.DataGridView dgvAREA;
        private System.Windows.Forms.Panel panelBUTTON;
        private System.Windows.Forms.Button btnHAPUS;
        private System.Windows.Forms.Button btnEDIT;
        private System.Windows.Forms.Button btnTAMBAH;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvKOTA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dgvTERUSAN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnTAMBAHTERUSAN;
        private System.Windows.Forms.Label lblTERUSAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDAREA;
        private System.Windows.Forms.DataGridViewTextBoxColumn KODEAREA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAMAAREA;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDKOTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAMAAREAKOTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn KODEKOTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAMAKOTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn TERUSAN;

    }
}