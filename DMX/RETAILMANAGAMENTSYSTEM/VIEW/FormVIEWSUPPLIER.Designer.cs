namespace LOGISTICMANAGAMENTSYSTEM.VIEW
{
    partial class FormVIEWSUPPLIER
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.txtCARI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSUPPLIER = new System.Windows.Forms.DataGridView();
            this.HANDLING = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KODEAGENT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAMASAGENT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ALAMAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONTACTPERSON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOTELEPON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OHANDLING = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSUPPLIER)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 365);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(714, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // txtCARI
            // 
            this.txtCARI.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtCARI.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCARI.Location = new System.Drawing.Point(2, 70);
            this.txtCARI.Name = "txtCARI";
            this.txtCARI.Size = new System.Drawing.Size(555, 27);
            this.txtCARI.TabIndex = 5;
            this.txtCARI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCARI.TextChanged += new System.EventHandler(this.txtCARI_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(563, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "CARI [ F1 ]";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 48);
            this.panel1.TabIndex = 13;
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
            this.label1.Size = new System.Drawing.Size(181, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "TABEL AGENT UDARA";
            // 
            // dgvSUPPLIER
            // 
            this.dgvSUPPLIER.AllowUserToAddRows = false;
            this.dgvSUPPLIER.AllowUserToResizeRows = false;
            this.dgvSUPPLIER.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvSUPPLIER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSUPPLIER.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HANDLING,
            this.KODEAGENT,
            this.NAMASAGENT,
            this.ALAMAT,
            this.CONTACTPERSON,
            this.NOTELEPON,
            this.OHANDLING});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSUPPLIER.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSUPPLIER.Location = new System.Drawing.Point(2, 99);
            this.dgvSUPPLIER.Name = "dgvSUPPLIER";
            this.dgvSUPPLIER.ReadOnly = true;
            this.dgvSUPPLIER.RowHeadersVisible = false;
            this.dgvSUPPLIER.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSUPPLIER.Size = new System.Drawing.Size(712, 276);
            this.dgvSUPPLIER.TabIndex = 15;
            this.dgvSUPPLIER.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSUPPLIER_CellClick);
            this.dgvSUPPLIER.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvSUPPLIER_KeyDown);
            // 
            // HANDLING
            // 
            this.HANDLING.HeaderText = "Handling [Moda]";
            this.HANDLING.Name = "HANDLING";
            this.HANDLING.ReadOnly = true;
            this.HANDLING.Width = 150;
            // 
            // KODEAGENT
            // 
            this.KODEAGENT.HeaderText = "Kode Agent";
            this.KODEAGENT.Name = "KODEAGENT";
            this.KODEAGENT.ReadOnly = true;
            // 
            // NAMASAGENT
            // 
            this.NAMASAGENT.HeaderText = "Nama Agent";
            this.NAMASAGENT.Name = "NAMASAGENT";
            this.NAMASAGENT.ReadOnly = true;
            this.NAMASAGENT.Width = 270;
            // 
            // ALAMAT
            // 
            this.ALAMAT.HeaderText = "Alamat";
            this.ALAMAT.Name = "ALAMAT";
            this.ALAMAT.ReadOnly = true;
            this.ALAMAT.Width = 350;
            // 
            // CONTACTPERSON
            // 
            this.CONTACTPERSON.HeaderText = "Contact Person";
            this.CONTACTPERSON.Name = "CONTACTPERSON";
            this.CONTACTPERSON.ReadOnly = true;
            this.CONTACTPERSON.Width = 150;
            // 
            // NOTELEPON
            // 
            this.NOTELEPON.HeaderText = "Telepon";
            this.NOTELEPON.Name = "NOTELEPON";
            this.NOTELEPON.ReadOnly = true;
            this.NOTELEPON.Width = 130;
            // 
            // OHANDLING
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OHANDLING.DefaultCellStyle = dataGridViewCellStyle1;
            this.OHANDLING.HeaderText = "Other Handling";
            this.OHANDLING.Name = "OHANDLING";
            this.OHANDLING.ReadOnly = true;
            this.OHANDLING.Width = 400;
            // 
            // FormVIEWSUPPLIER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(714, 387);
            this.ControlBox = false;
            this.Controls.Add(this.dgvSUPPLIER);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtCARI);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.KeyPreview = true;
            this.Name = "FormVIEWSUPPLIER";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AGENT UDARA";
            this.TopMost = true;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormVIEWSUPPLIER_KeyUp_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSUPPLIER)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox txtCARI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSUPPLIER;
        private System.Windows.Forms.DataGridViewTextBoxColumn HANDLING;
        private System.Windows.Forms.DataGridViewTextBoxColumn KODEAGENT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAMASAGENT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ALAMAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONTACTPERSON;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTELEPON;
        private System.Windows.Forms.DataGridViewTextBoxColumn OHANDLING;
    }
}