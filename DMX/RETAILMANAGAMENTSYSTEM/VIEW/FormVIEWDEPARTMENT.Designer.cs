namespace LOGISTICMANAGAMENTSYSTEM.VIEW
{
    partial class FormVIEWDEPARTMENT
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
            this.rdbKODE = new System.Windows.Forms.RadioButton();
            this.rdbNAMA = new System.Windows.Forms.RadioButton();
            this.txtCARI = new System.Windows.Forms.TextBox();
            this.dgvDEPT = new System.Windows.Forms.DataGridView();
            this.KODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDEPT)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbKODE
            // 
            this.rdbKODE.AutoSize = true;
            this.rdbKODE.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbKODE.ForeColor = System.Drawing.Color.White;
            this.rdbKODE.Location = new System.Drawing.Point(4, 5);
            this.rdbKODE.Name = "rdbKODE";
            this.rdbKODE.Size = new System.Drawing.Size(173, 22);
            this.rdbKODE.TabIndex = 0;
            this.rdbKODE.TabStop = true;
            this.rdbKODE.Text = "KODE DEPARTMENT [F3]";
            this.rdbKODE.UseVisualStyleBackColor = true;
            // 
            // rdbNAMA
            // 
            this.rdbNAMA.AutoSize = true;
            this.rdbNAMA.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNAMA.ForeColor = System.Drawing.Color.White;
            this.rdbNAMA.Location = new System.Drawing.Point(174, 5);
            this.rdbNAMA.Name = "rdbNAMA";
            this.rdbNAMA.Size = new System.Drawing.Size(181, 22);
            this.rdbNAMA.TabIndex = 0;
            this.rdbNAMA.TabStop = true;
            this.rdbNAMA.Text = "NAMA DEPARTMENT [F4]";
            this.rdbNAMA.UseVisualStyleBackColor = true;
            // 
            // txtCARI
            // 
            this.txtCARI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtCARI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCARI.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCARI.Location = new System.Drawing.Point(355, 3);
            this.txtCARI.Name = "txtCARI";
            this.txtCARI.Size = new System.Drawing.Size(282, 26);
            this.txtCARI.TabIndex = 1;
            this.txtCARI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCARI.TextChanged += new System.EventHandler(this.txtCARI_TextChanged);
            // 
            // dgvDEPT
            // 
            this.dgvDEPT.AllowUserToAddRows = false;
            this.dgvDEPT.AllowUserToResizeRows = false;
            this.dgvDEPT.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvDEPT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDEPT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KODE,
            this.NAMA});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDEPT.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDEPT.Location = new System.Drawing.Point(4, 33);
            this.dgvDEPT.Name = "dgvDEPT";
            this.dgvDEPT.ReadOnly = true;
            this.dgvDEPT.RowHeadersVisible = false;
            this.dgvDEPT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDEPT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDEPT.Size = new System.Drawing.Size(633, 251);
            this.dgvDEPT.TabIndex = 2;
            this.dgvDEPT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDEPT_CellClick);
            // 
            // KODE
            // 
            this.KODE.HeaderText = "KODE";
            this.KODE.Name = "KODE";
            this.KODE.ReadOnly = true;
            // 
            // NAMA
            // 
            this.NAMA.HeaderText = "NAMA DEPARTMENT";
            this.NAMA.Name = "NAMA";
            this.NAMA.ReadOnly = true;
            this.NAMA.Width = 530;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 287);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(642, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // FormVIEWDEPARTMENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(642, 309);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgvDEPT);
            this.Controls.Add(this.txtCARI);
            this.Controls.Add(this.rdbNAMA);
            this.Controls.Add(this.rdbKODE);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FormVIEWDEPARTMENT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVIEWDEPARTMENT";
            this.TopMost = true;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormVIEWDEPARTMENT_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDEPT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbKODE;
        private System.Windows.Forms.RadioButton rdbNAMA;
        private System.Windows.Forms.TextBox txtCARI;
        private System.Windows.Forms.DataGridView dgvDEPT;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn KODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAMA;
    }
}