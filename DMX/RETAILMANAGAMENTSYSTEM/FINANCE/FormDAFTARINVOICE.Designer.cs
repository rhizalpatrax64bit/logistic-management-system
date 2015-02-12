namespace LOGISTICMANAGAMENTSYSTEM.FINANCE
{
    partial class FormDAFTARINVOICE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDAFTARINVOICE));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitleMarketing = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvINVOICE = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TGLINVOICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KODEINVOICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUSTOMER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHARGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtINVOICEDATE = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Button();
            this.txtKODECUSTOMER = new System.Windows.Forms.TextBox();
            this.txtNAMACUSTOMER = new System.Windows.Forms.TextBox();
            this.txtKODEINVOICE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNOINVOICE = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnKELUAR = new System.Windows.Forms.Button();
            this.btnCetak = new System.Windows.Forms.Button();
            this.btnHAPUS = new System.Windows.Forms.Button();
            this.btnEDIT = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvINVOICE)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitleMarketing
            // 
            this.lblTitleMarketing.AutoSize = true;
            this.lblTitleMarketing.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleMarketing.ForeColor = System.Drawing.Color.White;
            this.lblTitleMarketing.Location = new System.Drawing.Point(25, 21);
            this.lblTitleMarketing.Name = "lblTitleMarketing";
            this.lblTitleMarketing.Size = new System.Drawing.Size(199, 33);
            this.lblTitleMarketing.TabIndex = 23;
            this.lblTitleMarketing.Text = "DAFTAR INVOICE";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1318, 71);
            this.panel3.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(333, 18);
            this.label5.TabIndex = 35;
            this.label5.Text = "Modul ini digunakan untuk keloa pembuatan Invoice";
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
            this.label9.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(9, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(351, 33);
            this.label9.TabIndex = 33;
            this.label9.Text = "KELOLA PEMBUATAN INVOICE";
            // 
            // dgvINVOICE
            // 
            this.dgvINVOICE.AllowUserToAddRows = false;
            this.dgvINVOICE.AllowUserToResizeRows = false;
            this.dgvINVOICE.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvINVOICE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvINVOICE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvINVOICE.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TGLINVOICE,
            this.KODEINVOICE,
            this.CUSTOMER,
            this.CHARGE,
            this.COST});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvINVOICE.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvINVOICE.Location = new System.Drawing.Point(8, 203);
            this.dgvINVOICE.MultiSelect = false;
            this.dgvINVOICE.Name = "dgvINVOICE";
            this.dgvINVOICE.ReadOnly = true;
            this.dgvINVOICE.RowHeadersVisible = false;
            this.dgvINVOICE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvINVOICE.Size = new System.Drawing.Size(1314, 380);
            this.dgvINVOICE.StandardTab = true;
            this.dgvINVOICE.TabIndex = 36;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // TGLINVOICE
            // 
            this.TGLINVOICE.HeaderText = "TGLINVOICE";
            this.TGLINVOICE.Name = "TGLINVOICE";
            this.TGLINVOICE.ReadOnly = true;
            // 
            // KODEINVOICE
            // 
            this.KODEINVOICE.HeaderText = "KODEINVOICE";
            this.KODEINVOICE.Name = "KODEINVOICE";
            this.KODEINVOICE.ReadOnly = true;
            this.KODEINVOICE.Width = 150;
            // 
            // CUSTOMER
            // 
            this.CUSTOMER.HeaderText = "CUSTOMER";
            this.CUSTOMER.Name = "CUSTOMER";
            this.CUSTOMER.ReadOnly = true;
            this.CUSTOMER.Width = 150;
            // 
            // CHARGE
            // 
            this.CHARGE.HeaderText = "CHARGE";
            this.CHARGE.Name = "CHARGE";
            this.CHARGE.ReadOnly = true;
            this.CHARGE.Width = 150;
            // 
            // COST
            // 
            this.COST.HeaderText = "COST";
            this.COST.Name = "COST";
            this.COST.ReadOnly = true;
            this.COST.Width = 150;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.Reset);
            this.panel1.Controls.Add(this.txtKODECUSTOMER);
            this.panel1.Controls.Add(this.txtNAMACUSTOMER);
            this.panel1.Controls.Add(this.txtKODEINVOICE);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblNOINVOICE);
            this.panel1.Location = new System.Drawing.Point(8, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 110);
            this.panel1.TabIndex = 37;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(526, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 40);
            this.button2.TabIndex = 20;
            this.button2.Text = "CARI";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtINVOICEDATE);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(7, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(509, 47);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PERIODE INVOICE";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(277, 15);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(118, 23);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(229, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "END";
            // 
            // dtINVOICEDATE
            // 
            this.dtINVOICEDATE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtINVOICEDATE.Location = new System.Drawing.Point(60, 18);
            this.dtINVOICEDATE.Name = "dtINVOICEDATE";
            this.dtINVOICEDATE.Size = new System.Drawing.Size(118, 23);
            this.dtINVOICEDATE.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "BEGIN";
            // 
            // Reset
            // 
            this.Reset.ForeColor = System.Drawing.Color.Black;
            this.Reset.Location = new System.Drawing.Point(526, 75);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(90, 30);
            this.Reset.TabIndex = 3;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            // 
            // txtKODECUSTOMER
            // 
            this.txtKODECUSTOMER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtKODECUSTOMER.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKODECUSTOMER.Location = new System.Drawing.Point(91, 54);
            this.txtKODECUSTOMER.Name = "txtKODECUSTOMER";
            this.txtKODECUSTOMER.Size = new System.Drawing.Size(89, 23);
            this.txtKODECUSTOMER.TabIndex = 1;
            // 
            // txtNAMACUSTOMER
            // 
            this.txtNAMACUSTOMER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtNAMACUSTOMER.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNAMACUSTOMER.Location = new System.Drawing.Point(185, 54);
            this.txtNAMACUSTOMER.Name = "txtNAMACUSTOMER";
            this.txtNAMACUSTOMER.Size = new System.Drawing.Size(334, 23);
            this.txtNAMACUSTOMER.TabIndex = 1;
            // 
            // txtKODEINVOICE
            // 
            this.txtKODEINVOICE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtKODEINVOICE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKODEINVOICE.Location = new System.Drawing.Point(90, 81);
            this.txtKODEINVOICE.Name = "txtKODEINVOICE";
            this.txtKODEINVOICE.ReadOnly = true;
            this.txtKODEINVOICE.Size = new System.Drawing.Size(429, 23);
            this.txtKODEINVOICE.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(7, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "CUSTOMER";
            // 
            // lblNOINVOICE
            // 
            this.lblNOINVOICE.AutoSize = true;
            this.lblNOINVOICE.ForeColor = System.Drawing.Color.Black;
            this.lblNOINVOICE.Location = new System.Drawing.Point(5, 84);
            this.lblNOINVOICE.Name = "lblNOINVOICE";
            this.lblNOINVOICE.Size = new System.Drawing.Size(85, 15);
            this.lblNOINVOICE.TabIndex = 1;
            this.lblNOINVOICE.Text = "KODE INVOICE";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnKELUAR);
            this.panel2.Controls.Add(this.btnCetak);
            this.panel2.Controls.Add(this.btnHAPUS);
            this.panel2.Controls.Add(this.btnEDIT);
            this.panel2.Location = new System.Drawing.Point(0, 589);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1284, 51);
            this.panel2.TabIndex = 43;
            // 
            // btnKELUAR
            // 
            this.btnKELUAR.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKELUAR.Image = ((System.Drawing.Image)(resources.GetObject("btnKELUAR.Image")));
            this.btnKELUAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKELUAR.Location = new System.Drawing.Point(341, 5);
            this.btnKELUAR.Name = "btnKELUAR";
            this.btnKELUAR.Size = new System.Drawing.Size(103, 43);
            this.btnKELUAR.TabIndex = 37;
            this.btnKELUAR.Text = "KELUAR";
            this.btnKELUAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKELUAR.UseVisualStyleBackColor = true;
            // 
            // btnCetak
            // 
            this.btnCetak.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCetak.Image = ((System.Drawing.Image)(resources.GetObject("btnCetak.Image")));
            this.btnCetak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCetak.Location = new System.Drawing.Point(180, 5);
            this.btnCetak.Name = "btnCetak";
            this.btnCetak.Size = new System.Drawing.Size(158, 43);
            this.btnCetak.TabIndex = 36;
            this.btnCetak.Text = "CETAK INVOICE";
            this.btnCetak.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCetak.UseVisualStyleBackColor = true;
            // 
            // btnHAPUS
            // 
            this.btnHAPUS.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHAPUS.Image = ((System.Drawing.Image)(resources.GetObject("btnHAPUS.Image")));
            this.btnHAPUS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHAPUS.Location = new System.Drawing.Point(86, 5);
            this.btnHAPUS.Name = "btnHAPUS";
            this.btnHAPUS.Size = new System.Drawing.Size(90, 43);
            this.btnHAPUS.TabIndex = 35;
            this.btnHAPUS.Text = "HAPUS";
            this.btnHAPUS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHAPUS.UseVisualStyleBackColor = true;
            // 
            // btnEDIT
            // 
            this.btnEDIT.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEDIT.Image = ((System.Drawing.Image)(resources.GetObject("btnEDIT.Image")));
            this.btnEDIT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEDIT.Location = new System.Drawing.Point(11, 5);
            this.btnEDIT.Name = "btnEDIT";
            this.btnEDIT.Size = new System.Drawing.Size(71, 43);
            this.btnEDIT.TabIndex = 34;
            this.btnEDIT.Text = "EDIT";
            this.btnEDIT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEDIT.UseVisualStyleBackColor = true;
            // 
            // FormDAFTARINVOICE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1284, 640);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvINVOICE);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDAFTARINVOICE";
            this.Text = "CETAK INVOICE";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvINVOICE)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitleMarketing;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvINVOICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TGLINVOICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn KODEINVOICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUSTOMER;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHARGE;
        private System.Windows.Forms.DataGridViewTextBoxColumn COST;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtINVOICEDATE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.TextBox txtKODECUSTOMER;
        private System.Windows.Forms.TextBox txtNAMACUSTOMER;
        private System.Windows.Forms.TextBox txtKODEINVOICE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNOINVOICE;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCetak;
        private System.Windows.Forms.Button btnHAPUS;
        private System.Windows.Forms.Button btnEDIT;
        private System.Windows.Forms.Button btnKELUAR;
    }
}