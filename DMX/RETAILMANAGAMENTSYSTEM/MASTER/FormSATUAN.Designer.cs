﻿namespace LOGISTICMANAGAMENTSYSTEM.MASTER
{
    partial class FormSATUAN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSATUAN));
            this.dgvSATUAN = new System.Windows.Forms.DataGridView();
            this.panelBUTTON = new System.Windows.Forms.Panel();
            this.btnHAPUS = new System.Windows.Forms.Button();
            this.btnEDIT = new System.Windows.Forms.Button();
            this.btnKELUAR = new System.Windows.Forms.Button();
            this.btnTAMBAH = new System.Windows.Forms.Button();
            this.labelINFO = new System.Windows.Forms.Label();
            this.panelCARI = new System.Windows.Forms.Panel();
            this.txtCARI = new System.Windows.Forms.TextBox();
            this.rdbNAMA = new System.Windows.Forms.RadioButton();
            this.rdbKODE = new System.Windows.Forms.RadioButton();
            this.KODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSATUAN)).BeginInit();
            this.panelBUTTON.SuspendLayout();
            this.panelCARI.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSATUAN
            // 
            this.dgvSATUAN.AllowUserToAddRows = false;
            this.dgvSATUAN.AllowUserToResizeRows = false;
            this.dgvSATUAN.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvSATUAN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSATUAN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KODE,
            this.NAMA});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSATUAN.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSATUAN.Location = new System.Drawing.Point(4, 39);
            this.dgvSATUAN.Name = "dgvSATUAN";
            this.dgvSATUAN.ReadOnly = true;
            this.dgvSATUAN.RowHeadersVisible = false;
            this.dgvSATUAN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSATUAN.Size = new System.Drawing.Size(884, 391);
            this.dgvSATUAN.TabIndex = 11;
            // 
            // panelBUTTON
            // 
            this.panelBUTTON.Controls.Add(this.btnHAPUS);
            this.panelBUTTON.Controls.Add(this.btnEDIT);
            this.panelBUTTON.Controls.Add(this.btnKELUAR);
            this.panelBUTTON.Controls.Add(this.btnTAMBAH);
            this.panelBUTTON.Location = new System.Drawing.Point(3, 434);
            this.panelBUTTON.Name = "panelBUTTON";
            this.panelBUTTON.Size = new System.Drawing.Size(884, 47);
            this.panelBUTTON.TabIndex = 10;
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
            this.btnHAPUS.Click += new System.EventHandler(this.btnHAPUS_Click);
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
            this.btnEDIT.Click += new System.EventHandler(this.btnEDIT_Click);
            // 
            // btnKELUAR
            // 
            this.btnKELUAR.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKELUAR.Image = ((System.Drawing.Image)(resources.GetObject("btnKELUAR.Image")));
            this.btnKELUAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKELUAR.Location = new System.Drawing.Point(263, 2);
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
            // labelINFO
            // 
            this.labelINFO.AutoSize = true;
            this.labelINFO.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelINFO.ForeColor = System.Drawing.Color.White;
            this.labelINFO.Location = new System.Drawing.Point(597, 3);
            this.labelINFO.Name = "labelINFO";
            this.labelINFO.Size = new System.Drawing.Size(269, 33);
            this.labelINFO.TabIndex = 9;
            this.labelINFO.Text = "DATA MASTER SATUAN";
            // 
            // panelCARI
            // 
            this.panelCARI.Controls.Add(this.txtCARI);
            this.panelCARI.Controls.Add(this.rdbNAMA);
            this.panelCARI.Controls.Add(this.rdbKODE);
            this.panelCARI.Location = new System.Drawing.Point(1, 3);
            this.panelCARI.Name = "panelCARI";
            this.panelCARI.Size = new System.Drawing.Size(564, 33);
            this.panelCARI.TabIndex = 12;
            // 
            // txtCARI
            // 
            this.txtCARI.BackColor = System.Drawing.Color.Honeydew;
            this.txtCARI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCARI.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCARI.Location = new System.Drawing.Point(253, 5);
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
            this.rdbNAMA.ForeColor = System.Drawing.Color.White;
            this.rdbNAMA.Location = new System.Drawing.Point(127, 7);
            this.rdbNAMA.Name = "rdbNAMA";
            this.rdbNAMA.Size = new System.Drawing.Size(121, 19);
            this.rdbNAMA.TabIndex = 0;
            this.rdbNAMA.TabStop = true;
            this.rdbNAMA.Text = "Nama Satuan [F4]";
            this.rdbNAMA.UseVisualStyleBackColor = true;
            // 
            // rdbKODE
            // 
            this.rdbKODE.AutoSize = true;
            this.rdbKODE.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbKODE.ForeColor = System.Drawing.Color.White;
            this.rdbKODE.Location = new System.Drawing.Point(4, 7);
            this.rdbKODE.Name = "rdbKODE";
            this.rdbKODE.Size = new System.Drawing.Size(117, 19);
            this.rdbKODE.TabIndex = 0;
            this.rdbKODE.TabStop = true;
            this.rdbKODE.Text = "Kode Satuan [F3]";
            this.rdbKODE.UseVisualStyleBackColor = true;
            // 
            // KODE
            // 
            this.KODE.HeaderText = "KODE";
            this.KODE.Name = "KODE";
            this.KODE.ReadOnly = true;
            // 
            // NAMA
            // 
            this.NAMA.HeaderText = "NAMA SATUAN";
            this.NAMA.Name = "NAMA";
            this.NAMA.ReadOnly = true;
            this.NAMA.Width = 400;
            // 
            // FormSATUAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(900, 484);
            this.Controls.Add(this.panelCARI);
            this.Controls.Add(this.dgvSATUAN);
            this.Controls.Add(this.panelBUTTON);
            this.Controls.Add(this.labelINFO);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FormSATUAN";
            this.Text = "FormSATUAN";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormSATUAN_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSATUAN)).EndInit();
            this.panelBUTTON.ResumeLayout(false);
            this.panelCARI.ResumeLayout(false);
            this.panelCARI.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSATUAN;
        private System.Windows.Forms.Panel panelBUTTON;
        private System.Windows.Forms.Button btnHAPUS;
        private System.Windows.Forms.Button btnEDIT;
        private System.Windows.Forms.Button btnKELUAR;
        private System.Windows.Forms.Button btnTAMBAH;
        private System.Windows.Forms.Label labelINFO;
        private System.Windows.Forms.Panel panelCARI;
        private System.Windows.Forms.TextBox txtCARI;
        private System.Windows.Forms.RadioButton rdbNAMA;
        private System.Windows.Forms.RadioButton rdbKODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn KODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAMA;
    }
}