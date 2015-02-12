namespace LOGISTICMANAGAMENTSYSTEM.MASTER
{
    partial class FormDEPARTMENT
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDEPARTMENT));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelCARI = new System.Windows.Forms.Panel();
            this.txtCARI = new System.Windows.Forms.TextBox();
            this.rdbNAMA = new System.Windows.Forms.RadioButton();
            this.rdbKODE = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDEPARTMENT = new System.Windows.Forms.DataGridView();
            this.panelBUTTON = new System.Windows.Forms.Panel();
            this.btnHAPUS = new System.Windows.Forms.Button();
            this.btnEDIT = new System.Windows.Forms.Button();
            this.btnKELUAR = new System.Windows.Forms.Button();
            this.btnTAMBAH = new System.Windows.Forms.Button();
            this.KODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MINMARGIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAXMARGIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BANYAKITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelCARI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDEPARTMENT)).BeginInit();
            this.panelBUTTON.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCARI
            // 
            this.panelCARI.Controls.Add(this.txtCARI);
            this.panelCARI.Controls.Add(this.rdbNAMA);
            this.panelCARI.Controls.Add(this.rdbKODE);
            this.panelCARI.Location = new System.Drawing.Point(342, 5);
            this.panelCARI.Name = "panelCARI";
            this.panelCARI.Size = new System.Drawing.Size(552, 33);
            this.panelCARI.TabIndex = 9;
            // 
            // txtCARI
            // 
            this.txtCARI.BackColor = System.Drawing.Color.Honeydew;
            this.txtCARI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCARI.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCARI.Location = new System.Drawing.Point(318, 5);
            this.txtCARI.Name = "txtCARI";
            this.txtCARI.Size = new System.Drawing.Size(231, 23);
            this.txtCARI.TabIndex = 1;
            this.txtCARI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCARI.TextChanged += new System.EventHandler(this.txtCARI_TextChanged);
            // 
            // rdbNAMA
            // 
            this.rdbNAMA.AutoSize = true;
            this.rdbNAMA.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNAMA.ForeColor = System.Drawing.Color.White;
            this.rdbNAMA.Location = new System.Drawing.Point(165, 7);
            this.rdbNAMA.Name = "rdbNAMA";
            this.rdbNAMA.Size = new System.Drawing.Size(152, 19);
            this.rdbNAMA.TabIndex = 0;
            this.rdbNAMA.TabStop = true;
            this.rdbNAMA.Text = "Nama Department [F4]";
            this.rdbNAMA.UseVisualStyleBackColor = true;
            // 
            // rdbKODE
            // 
            this.rdbKODE.AutoSize = true;
            this.rdbKODE.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbKODE.ForeColor = System.Drawing.Color.White;
            this.rdbKODE.Location = new System.Drawing.Point(18, 7);
            this.rdbKODE.Name = "rdbKODE";
            this.rdbKODE.Size = new System.Drawing.Size(148, 19);
            this.rdbKODE.TabIndex = 0;
            this.rdbKODE.TabStop = true;
            this.rdbKODE.Text = "Kode Department [F3]";
            this.rdbKODE.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "DATA MASTER DEPARTMENT";
            // 
            // dgvDEPARTMENT
            // 
            this.dgvDEPARTMENT.AllowUserToAddRows = false;
            this.dgvDEPARTMENT.AllowUserToResizeRows = false;
            this.dgvDEPARTMENT.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvDEPARTMENT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDEPARTMENT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KODE,
            this.NAMA,
            this.MINMARGIN,
            this.MAXMARGIN,
            this.BANYAKITEM});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDEPARTMENT.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDEPARTMENT.Location = new System.Drawing.Point(4, 39);
            this.dgvDEPARTMENT.Name = "dgvDEPARTMENT";
            this.dgvDEPARTMENT.ReadOnly = true;
            this.dgvDEPARTMENT.RowHeadersVisible = false;
            this.dgvDEPARTMENT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDEPARTMENT.Size = new System.Drawing.Size(890, 388);
            this.dgvDEPARTMENT.TabIndex = 10;
            // 
            // panelBUTTON
            // 
            this.panelBUTTON.Controls.Add(this.btnHAPUS);
            this.panelBUTTON.Controls.Add(this.btnEDIT);
            this.panelBUTTON.Controls.Add(this.btnKELUAR);
            this.panelBUTTON.Controls.Add(this.btnTAMBAH);
            this.panelBUTTON.Location = new System.Drawing.Point(2, 433);
            this.panelBUTTON.Name = "panelBUTTON";
            this.panelBUTTON.Size = new System.Drawing.Size(884, 47);
            this.panelBUTTON.TabIndex = 11;
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
            // KODE
            // 
            this.KODE.HeaderText = "KODE";
            this.KODE.Name = "KODE";
            this.KODE.ReadOnly = true;
            // 
            // NAMA
            // 
            this.NAMA.HeaderText = "NAMA";
            this.NAMA.Name = "NAMA";
            this.NAMA.ReadOnly = true;
            this.NAMA.Width = 400;
            // 
            // MINMARGIN
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.MINMARGIN.DefaultCellStyle = dataGridViewCellStyle1;
            this.MINMARGIN.HeaderText = "MIN MARGIN";
            this.MINMARGIN.Name = "MINMARGIN";
            this.MINMARGIN.ReadOnly = true;
            this.MINMARGIN.Width = 120;
            // 
            // MAXMARGIN
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.MAXMARGIN.DefaultCellStyle = dataGridViewCellStyle2;
            this.MAXMARGIN.HeaderText = "MAX MARGIN";
            this.MAXMARGIN.Name = "MAXMARGIN";
            this.MAXMARGIN.ReadOnly = true;
            this.MAXMARGIN.Width = 120;
            // 
            // BANYAKITEM
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.BANYAKITEM.DefaultCellStyle = dataGridViewCellStyle3;
            this.BANYAKITEM.HeaderText = "BANYAK ITEM";
            this.BANYAKITEM.Name = "BANYAKITEM";
            this.BANYAKITEM.ReadOnly = true;
            this.BANYAKITEM.Width = 120;
            // 
            // FormDEPARTMENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(900, 484);
            this.Controls.Add(this.panelBUTTON);
            this.Controls.Add(this.dgvDEPARTMENT);
            this.Controls.Add(this.panelCARI);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FormDEPARTMENT";
            this.Text = "FormDEPARTMENT";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormDEPARTMENT_KeyUp);
            this.panelCARI.ResumeLayout(false);
            this.panelCARI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDEPARTMENT)).EndInit();
            this.panelBUTTON.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCARI;
        private System.Windows.Forms.TextBox txtCARI;
        private System.Windows.Forms.RadioButton rdbNAMA;
        private System.Windows.Forms.RadioButton rdbKODE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDEPARTMENT;
        private System.Windows.Forms.Panel panelBUTTON;
        private System.Windows.Forms.Button btnHAPUS;
        private System.Windows.Forms.Button btnEDIT;
        private System.Windows.Forms.Button btnKELUAR;
        private System.Windows.Forms.Button btnTAMBAH;
        private System.Windows.Forms.DataGridViewTextBoxColumn KODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MINMARGIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAXMARGIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn BANYAKITEM;
    }
}