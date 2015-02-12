namespace LOGISTICMANAGAMENTSYSTEM.MASTER.SUBMASTER
{
    partial class FormBACKUP
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBACKUP));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label24 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label43 = new System.Windows.Forms.Label();
            this.button_ExportAs = new System.Windows.Forms.Button();
            this.textBox_File = new System.Windows.Forms.TextBox();
            this.nmExInterval = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.lbRowInAllTable = new System.Windows.Forms.Label();
            this.lbRowInCurTable = new System.Windows.Forms.Label();
            this.lbTableCount = new System.Windows.Forms.Label();
            this.pbRowInAllTable = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.pbRowInCurTable = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.pbTable = new System.Windows.Forms.ProgressBar();
            this.lbCurrentTableName = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnBATAL = new System.Windows.Forms.Button();
            this.btnSIMPAN = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmExInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label43);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 68);
            this.panel1.TabIndex = 71;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(475, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 68);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(12, 44);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(251, 18);
            this.label24.TabIndex = 35;
            this.label24.Text = "Modul ini digunakan untuk backup data";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1177, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.ForeColor = System.Drawing.Color.Black;
            this.label43.Location = new System.Drawing.Point(9, 11);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(265, 33);
            this.label43.TabIndex = 33;
            this.label43.Text = "KELOLA BACKUP DATA";
            // 
            // button_ExportAs
            // 
            this.button_ExportAs.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ExportAs.Location = new System.Drawing.Point(75, 96);
            this.button_ExportAs.Name = "button_ExportAs";
            this.button_ExportAs.Size = new System.Drawing.Size(70, 38);
            this.button_ExportAs.TabIndex = 72;
            this.button_ExportAs.Text = "Export As";
            this.button_ExportAs.UseVisualStyleBackColor = true;
            this.button_ExportAs.Click += new System.EventHandler(this.button_ExportAs_Click);
            // 
            // textBox_File
            // 
            this.textBox_File.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_File.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_File.Location = new System.Drawing.Point(152, 105);
            this.textBox_File.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_File.Name = "textBox_File";
            this.textBox_File.Size = new System.Drawing.Size(229, 21);
            this.textBox_File.TabIndex = 73;
            // 
            // nmExInterval
            // 
            this.nmExInterval.Location = new System.Drawing.Point(305, 147);
            this.nmExInterval.Name = "nmExInterval";
            this.nmExInterval.Size = new System.Drawing.Size(76, 23);
            this.nmExInterval.TabIndex = 86;
            this.nmExInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmExInterval.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 15);
            this.label5.TabIndex = 85;
            this.label5.Text = "Progress Report Interval (Miliseconds)";
            // 
            // lbRowInAllTable
            // 
            this.lbRowInAllTable.AutoSize = true;
            this.lbRowInAllTable.Location = new System.Drawing.Point(72, 400);
            this.lbRowInAllTable.Name = "lbRowInAllTable";
            this.lbRowInAllTable.Size = new System.Drawing.Size(32, 15);
            this.lbRowInAllTable.TabIndex = 84;
            this.lbRowInAllTable.Text = "1 / 1";
            // 
            // lbRowInCurTable
            // 
            this.lbRowInCurTable.AutoSize = true;
            this.lbRowInCurTable.Location = new System.Drawing.Point(72, 318);
            this.lbRowInCurTable.Name = "lbRowInCurTable";
            this.lbRowInCurTable.Size = new System.Drawing.Size(32, 15);
            this.lbRowInCurTable.TabIndex = 83;
            this.lbRowInCurTable.Text = "1 / 1";
            // 
            // lbTableCount
            // 
            this.lbTableCount.AutoSize = true;
            this.lbTableCount.Location = new System.Drawing.Point(72, 235);
            this.lbTableCount.Name = "lbTableCount";
            this.lbTableCount.Size = new System.Drawing.Size(32, 15);
            this.lbTableCount.TabIndex = 82;
            this.lbTableCount.Text = "1 / 1";
            // 
            // pbRowInAllTable
            // 
            this.pbRowInAllTable.Location = new System.Drawing.Point(75, 374);
            this.pbRowInAllTable.Name = "pbRowInAllTable";
            this.pbRowInAllTable.Size = new System.Drawing.Size(270, 23);
            this.pbRowInAllTable.TabIndex = 81;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 15);
            this.label3.TabIndex = 80;
            this.label3.Text = "Rows in All Tables";
            // 
            // pbRowInCurTable
            // 
            this.pbRowInCurTable.Location = new System.Drawing.Point(75, 292);
            this.pbRowInCurTable.Name = "pbRowInCurTable";
            this.pbRowInCurTable.Size = new System.Drawing.Size(270, 23);
            this.pbRowInCurTable.TabIndex = 79;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 15);
            this.label2.TabIndex = 78;
            this.label2.Text = "Rows in Current Table";
            // 
            // pbTable
            // 
            this.pbTable.Location = new System.Drawing.Point(75, 209);
            this.pbTable.Name = "pbTable";
            this.pbTable.Size = new System.Drawing.Size(270, 23);
            this.pbTable.TabIndex = 77;
            // 
            // lbCurrentTableName
            // 
            this.lbCurrentTableName.AutoSize = true;
            this.lbCurrentTableName.Location = new System.Drawing.Point(72, 190);
            this.lbCurrentTableName.Name = "lbCurrentTableName";
            this.lbCurrentTableName.Size = new System.Drawing.Size(37, 15);
            this.lbCurrentTableName.TabIndex = 76;
            this.lbCurrentTableName.Text = "Table";
            // 
            // btnBATAL
            // 
            this.btnBATAL.Image = ((System.Drawing.Image)(resources.GetObject("btnBATAL.Image")));
            this.btnBATAL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBATAL.Location = new System.Drawing.Point(518, 438);
            this.btnBATAL.Name = "btnBATAL";
            this.btnBATAL.Size = new System.Drawing.Size(87, 41);
            this.btnBATAL.TabIndex = 89;
            this.btnBATAL.Text = "BATAL";
            this.btnBATAL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBATAL.UseVisualStyleBackColor = true;
            this.btnBATAL.Click += new System.EventHandler(this.btnBATAL_Click);
            // 
            // btnSIMPAN
            // 
            this.btnSIMPAN.Image = ((System.Drawing.Image)(resources.GetObject("btnSIMPAN.Image")));
            this.btnSIMPAN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSIMPAN.Location = new System.Drawing.Point(427, 438);
            this.btnSIMPAN.Name = "btnSIMPAN";
            this.btnSIMPAN.Size = new System.Drawing.Size(91, 41);
            this.btnSIMPAN.TabIndex = 88;
            this.btnSIMPAN.Text = "SIMPAN";
            this.btnSIMPAN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSIMPAN.UseVisualStyleBackColor = true;
            this.btnSIMPAN.Click += new System.EventHandler(this.btnSIMPAN_Click);
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Location = new System.Drawing.Point(63, 433);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(540, 3);
            this.label14.TabIndex = 87;
            // 
            // FormBACKUP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(629, 491);
            this.ControlBox = false;
            this.Controls.Add(this.btnBATAL);
            this.Controls.Add(this.btnSIMPAN);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.nmExInterval);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbRowInAllTable);
            this.Controls.Add(this.lbRowInCurTable);
            this.Controls.Add(this.lbTableCount);
            this.Controls.Add(this.pbRowInAllTable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbRowInCurTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbTable);
            this.Controls.Add(this.lbCurrentTableName);
            this.Controls.Add(this.textBox_File);
            this.Controls.Add(this.button_ExportAs);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBACKUP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BACKUP DATA";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmExInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Button button_ExportAs;
        private System.Windows.Forms.TextBox textBox_File;
        private System.Windows.Forms.NumericUpDown nmExInterval;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbRowInAllTable;
        private System.Windows.Forms.Label lbRowInCurTable;
        private System.Windows.Forms.Label lbTableCount;
        private System.Windows.Forms.ProgressBar pbRowInAllTable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar pbRowInCurTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar pbTable;
        private System.Windows.Forms.Label lbCurrentTableName;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnBATAL;
        private System.Windows.Forms.Button btnSIMPAN;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}