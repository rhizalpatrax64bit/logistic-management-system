namespace LOGISTICMANAGAMENTSYSTEM.PURCHASE.SUBPURCHASE
{
    partial class FormADDITEM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormADDITEM));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBARCODE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKODEDEPT = new System.Windows.Forms.TextBox();
            this.txtNAMADEPT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKODEBARANG = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNAMABARANG = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNAMASTRUK = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUNIT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtISIUNIT = new System.Windows.Forms.TextBox();
            this.btnSIMPAN = new System.Windows.Forms.Button();
            this.btnBATAL = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.chkBARANGPUTUS = new System.Windows.Forms.CheckBox();
            this.chkBKENAPAJAK = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 344);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(503, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(86, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(413, 3);
            this.label2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(81, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "INPUT DATA BARANG";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "BARCODE";
            // 
            // txtBARCODE
            // 
            this.txtBARCODE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtBARCODE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBARCODE.Location = new System.Drawing.Point(114, 89);
            this.txtBARCODE.Name = "txtBARCODE";
            this.txtBARCODE.Size = new System.Drawing.Size(226, 23);
            this.txtBARCODE.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(19, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "DEPARTMENT";
            // 
            // txtKODEDEPT
            // 
            this.txtKODEDEPT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtKODEDEPT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKODEDEPT.Location = new System.Drawing.Point(114, 113);
            this.txtKODEDEPT.Name = "txtKODEDEPT";
            this.txtKODEDEPT.Size = new System.Drawing.Size(78, 23);
            this.txtKODEDEPT.TabIndex = 2;
            this.txtKODEDEPT.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtKODEDEPT_KeyUp);
            // 
            // txtNAMADEPT
            // 
            this.txtNAMADEPT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtNAMADEPT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNAMADEPT.Location = new System.Drawing.Point(193, 113);
            this.txtNAMADEPT.Name = "txtNAMADEPT";
            this.txtNAMADEPT.ReadOnly = true;
            this.txtNAMADEPT.Size = new System.Drawing.Size(306, 23);
            this.txtNAMADEPT.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "KODE BARANG";
            // 
            // txtKODEBARANG
            // 
            this.txtKODEBARANG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtKODEBARANG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKODEBARANG.Location = new System.Drawing.Point(114, 137);
            this.txtKODEBARANG.Name = "txtKODEBARANG";
            this.txtKODEBARANG.ReadOnly = true;
            this.txtKODEBARANG.Size = new System.Drawing.Size(226, 23);
            this.txtKODEBARANG.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(19, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "NAMA BARANG";
            // 
            // txtNAMABARANG
            // 
            this.txtNAMABARANG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtNAMABARANG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNAMABARANG.Location = new System.Drawing.Point(114, 161);
            this.txtNAMABARANG.Name = "txtNAMABARANG";
            this.txtNAMABARANG.Size = new System.Drawing.Size(385, 23);
            this.txtNAMABARANG.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(19, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "NAMA STRUK";
            // 
            // txtNAMASTRUK
            // 
            this.txtNAMASTRUK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtNAMASTRUK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNAMASTRUK.Location = new System.Drawing.Point(114, 185);
            this.txtNAMASTRUK.Name = "txtNAMASTRUK";
            this.txtNAMASTRUK.Size = new System.Drawing.Size(273, 23);
            this.txtNAMASTRUK.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(19, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "UNIT";
            // 
            // txtUNIT
            // 
            this.txtUNIT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtUNIT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUNIT.Location = new System.Drawing.Point(114, 209);
            this.txtUNIT.Name = "txtUNIT";
            this.txtUNIT.Size = new System.Drawing.Size(184, 23);
            this.txtUNIT.TabIndex = 6;
            this.txtUNIT.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtUNIT_KeyUp);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(19, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "ISI UNIT";
            // 
            // txtISIUNIT
            // 
            this.txtISIUNIT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtISIUNIT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtISIUNIT.Location = new System.Drawing.Point(114, 233);
            this.txtISIUNIT.Name = "txtISIUNIT";
            this.txtISIUNIT.ReadOnly = true;
            this.txtISIUNIT.Size = new System.Drawing.Size(184, 23);
            this.txtISIUNIT.TabIndex = 7;
            // 
            // btnSIMPAN
            // 
            this.btnSIMPAN.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSIMPAN.Image = ((System.Drawing.Image)(resources.GetObject("btnSIMPAN.Image")));
            this.btnSIMPAN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSIMPAN.Location = new System.Drawing.Point(394, 290);
            this.btnSIMPAN.Name = "btnSIMPAN";
            this.btnSIMPAN.Size = new System.Drawing.Size(105, 50);
            this.btnSIMPAN.TabIndex = 10;
            this.btnSIMPAN.Text = "SIMPAN";
            this.btnSIMPAN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSIMPAN.UseVisualStyleBackColor = true;
            this.btnSIMPAN.Click += new System.EventHandler(this.btnSIMPAN_Click);
            // 
            // btnBATAL
            // 
            this.btnBATAL.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBATAL.Image = ((System.Drawing.Image)(resources.GetObject("btnBATAL.Image")));
            this.btnBATAL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBATAL.Location = new System.Drawing.Point(303, 290);
            this.btnBATAL.Name = "btnBATAL";
            this.btnBATAL.Size = new System.Drawing.Size(92, 50);
            this.btnBATAL.TabIndex = 11;
            this.btnBATAL.Text = "BATAL";
            this.btnBATAL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBATAL.UseVisualStyleBackColor = true;
            this.btnBATAL.Click += new System.EventHandler(this.btnBATAL_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(23, 282);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(473, 3);
            this.label10.TabIndex = 0;
            // 
            // chkBARANGPUTUS
            // 
            this.chkBARANGPUTUS.AutoSize = true;
            this.chkBARANGPUTUS.ForeColor = System.Drawing.Color.White;
            this.chkBARANGPUTUS.Location = new System.Drawing.Point(114, 262);
            this.chkBARANGPUTUS.Name = "chkBARANGPUTUS";
            this.chkBARANGPUTUS.Size = new System.Drawing.Size(111, 19);
            this.chkBARANGPUTUS.TabIndex = 8;
            this.chkBARANGPUTUS.Text = "BARANG PUTUS";
            this.chkBARANGPUTUS.UseVisualStyleBackColor = true;
            // 
            // chkBKENAPAJAK
            // 
            this.chkBKENAPAJAK.AutoSize = true;
            this.chkBKENAPAJAK.ForeColor = System.Drawing.Color.White;
            this.chkBKENAPAJAK.Location = new System.Drawing.Point(231, 262);
            this.chkBKENAPAJAK.Name = "chkBKENAPAJAK";
            this.chkBKENAPAJAK.Size = new System.Drawing.Size(142, 19);
            this.chkBKENAPAJAK.TabIndex = 9;
            this.chkBKENAPAJAK.Text = "BARANG KENA PAJAK";
            this.chkBKENAPAJAK.UseVisualStyleBackColor = true;
            // 
            // FormADDITEM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(503, 366);
            this.Controls.Add(this.chkBKENAPAJAK);
            this.Controls.Add(this.chkBARANGPUTUS);
            this.Controls.Add(this.btnSIMPAN);
            this.Controls.Add(this.btnBATAL);
            this.Controls.Add(this.txtNAMADEPT);
            this.Controls.Add(this.txtKODEDEPT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtISIUNIT);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtUNIT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNAMASTRUK);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNAMABARANG);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtKODEBARANG);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBARCODE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormADDITEM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TAMBAH ITEM";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBARCODE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKODEDEPT;
        private System.Windows.Forms.TextBox txtNAMADEPT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKODEBARANG;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNAMABARANG;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNAMASTRUK;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUNIT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtISIUNIT;
        private System.Windows.Forms.Button btnSIMPAN;
        private System.Windows.Forms.Button btnBATAL;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chkBARANGPUTUS;
        private System.Windows.Forms.CheckBox chkBKENAPAJAK;
    }
}