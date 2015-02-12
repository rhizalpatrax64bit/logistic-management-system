namespace LOGISTICMANAGAMENTSYSTEM.VIEW
{
    partial class FormVIEWPENERIMAEXPRESS
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCARI = new System.Windows.Forms.TextBox();
            this.dgvPENERIMA = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ALAMAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEPON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FAX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPENERIMA)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 48);
            this.panel1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ketikan kode atau penerima  di kotak pencarian";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "TABEL PENERIMA";
            // 
            // txtCARI
            // 
            this.txtCARI.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtCARI.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCARI.Location = new System.Drawing.Point(3, 68);
            this.txtCARI.Name = "txtCARI";
            this.txtCARI.Size = new System.Drawing.Size(581, 27);
            this.txtCARI.TabIndex = 17;
            this.txtCARI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCARI.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCARI_KeyDown);
            this.txtCARI.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCARI_KeyUp);
            // 
            // dgvPENERIMA
            // 
            this.dgvPENERIMA.AllowUserToAddRows = false;
            this.dgvPENERIMA.AllowUserToResizeRows = false;
            this.dgvPENERIMA.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvPENERIMA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPENERIMA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NAMA,
            this.ALAMAT,
            this.TELEPON,
            this.FAX,
            this.HP});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPENERIMA.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPENERIMA.Location = new System.Drawing.Point(3, 101);
            this.dgvPENERIMA.Name = "dgvPENERIMA";
            this.dgvPENERIMA.ReadOnly = true;
            this.dgvPENERIMA.RowHeadersVisible = false;
            this.dgvPENERIMA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPENERIMA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPENERIMA.Size = new System.Drawing.Size(708, 270);
            this.dgvPENERIMA.TabIndex = 18;
            this.dgvPENERIMA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCARI_KeyDown);
            this.dgvPENERIMA.Click += new System.EventHandler(this.dgvPENERIMA_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // NAMA
            // 
            this.NAMA.HeaderText = "Nama Penerima";
            this.NAMA.Name = "NAMA";
            this.NAMA.ReadOnly = true;
            this.NAMA.ToolTipText = "Nama Penerima";
            this.NAMA.Width = 150;
            // 
            // ALAMAT
            // 
            this.ALAMAT.HeaderText = "Alamat";
            this.ALAMAT.Name = "ALAMAT";
            this.ALAMAT.ReadOnly = true;
            this.ALAMAT.ToolTipText = "Alamat";
            // 
            // TELEPON
            // 
            this.TELEPON.HeaderText = "Telepon";
            this.TELEPON.Name = "TELEPON";
            this.TELEPON.ReadOnly = true;
            this.TELEPON.ToolTipText = "Telepon";
            // 
            // FAX
            // 
            this.FAX.HeaderText = "Fax";
            this.FAX.Name = "FAX";
            this.FAX.ReadOnly = true;
            this.FAX.ToolTipText = "Fax";
            // 
            // HP
            // 
            this.HP.HeaderText = "Handphone";
            this.HP.Name = "HP";
            this.HP.ReadOnly = true;
            this.HP.ToolTipText = "Handphone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(590, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "CARI [ F1 ]";
            // 
            // FormVIEWPENERIMAEXPRESS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(714, 387);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtCARI);
            this.Controls.Add(this.dgvPENERIMA);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Name = "FormVIEWPENERIMAEXPRESS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PENERIMA EXPRESS";
            this.TopMost = true;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormVIEWPENERIMAEXPRESS_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPENERIMA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCARI;
        private System.Windows.Forms.DataGridView dgvPENERIMA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ALAMAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEPON;
        private System.Windows.Forms.DataGridViewTextBoxColumn FAX;
        private System.Windows.Forms.DataGridViewTextBoxColumn HP;
    }
}