namespace LOGISTICMANAGAMENTSYSTEM.FINANCE
{
    partial class FormVIEWAGENT
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
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCARI = new System.Windows.Forms.TextBox();
            this.dgvAGENT = new System.Windows.Forms.DataGridView();
            this.IDAGENT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HANDLING = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ALAMAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEPON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAGENT)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(565, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "CARI [ F1 ]";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 48);
            this.panel1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ketikan kode atau nama kota di kotak pencarian";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "TABEL AGENT";
            // 
            // txtCARI
            // 
            this.txtCARI.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtCARI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCARI.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCARI.Location = new System.Drawing.Point(2, 68);
            this.txtCARI.Name = "txtCARI";
            this.txtCARI.Size = new System.Drawing.Size(552, 27);
            this.txtCARI.TabIndex = 13;
            this.txtCARI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCARI.TextChanged += new System.EventHandler(this.txtCARI_TextChanged);
            // 
            // dgvAGENT
            // 
            this.dgvAGENT.AllowUserToAddRows = false;
            this.dgvAGENT.AllowUserToResizeRows = false;
            this.dgvAGENT.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvAGENT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAGENT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDAGENT,
            this.KODE,
            this.NAMA,
            this.HANDLING,
            this.ALAMAT,
            this.CP,
            this.TELEPON});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAGENT.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAGENT.Location = new System.Drawing.Point(2, 101);
            this.dgvAGENT.Name = "dgvAGENT";
            this.dgvAGENT.ReadOnly = true;
            this.dgvAGENT.RowHeadersVisible = false;
            this.dgvAGENT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvAGENT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAGENT.Size = new System.Drawing.Size(708, 271);
            this.dgvAGENT.TabIndex = 14;
            this.dgvAGENT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAGENT_CellClick);
            this.dgvAGENT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvAGENT_KeyDown);
            // 
            // IDAGENT
            // 
            this.IDAGENT.HeaderText = "IDAGENT";
            this.IDAGENT.Name = "IDAGENT";
            this.IDAGENT.ReadOnly = true;
            this.IDAGENT.Visible = false;
            this.IDAGENT.Width = 120;
            // 
            // KODE
            // 
            this.KODE.HeaderText = "Kode Agent";
            this.KODE.Name = "KODE";
            this.KODE.ReadOnly = true;
            this.KODE.Width = 50;
            // 
            // NAMA
            // 
            this.NAMA.HeaderText = "Nama Agent";
            this.NAMA.Name = "NAMA";
            this.NAMA.ReadOnly = true;
            this.NAMA.Width = 130;
            // 
            // HANDLING
            // 
            this.HANDLING.HeaderText = "Handling ";
            this.HANDLING.Name = "HANDLING";
            this.HANDLING.ReadOnly = true;
            // 
            // ALAMAT
            // 
            this.ALAMAT.HeaderText = "Alamat";
            this.ALAMAT.Name = "ALAMAT";
            this.ALAMAT.ReadOnly = true;
            // 
            // CP
            // 
            this.CP.HeaderText = "Contact Person";
            this.CP.Name = "CP";
            this.CP.ReadOnly = true;
            // 
            // TELEPON
            // 
            this.TELEPON.HeaderText = "Telepon";
            this.TELEPON.Name = "TELEPON";
            this.TELEPON.ReadOnly = true;
            // 
            // FormVIEWAGENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(714, 387);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtCARI);
            this.Controls.Add(this.dgvAGENT);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "FormVIEWAGENT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVIEWAGENT";
            this.TopMost = true;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormVIEWAGENT_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAGENT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCARI;
        private System.Windows.Forms.DataGridView dgvAGENT;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDAGENT;
        private System.Windows.Forms.DataGridViewTextBoxColumn KODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn HANDLING;
        private System.Windows.Forms.DataGridViewTextBoxColumn ALAMAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEPON;
    }
}