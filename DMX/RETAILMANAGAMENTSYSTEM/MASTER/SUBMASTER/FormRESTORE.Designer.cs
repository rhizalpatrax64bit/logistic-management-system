namespace LOGISTICMANAGAMENTSYSTEM.MASTER.SUBMASTER
{
    partial class FormRESTORE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRESTORE));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label24 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label43 = new System.Windows.Forms.Label();
            this.button_SelectFile = new System.Windows.Forms.Button();
            this.textBox_File = new System.Windows.Forms.TextBox();
            this.nmImInterval = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBATAL = new System.Windows.Forms.Button();
            this.btnSIMPAN = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmImInterval)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(612, 68);
            this.panel1.TabIndex = 72;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(483, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 68);
            this.pictureBox1.TabIndex = 93;
            this.pictureBox1.TabStop = false;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(12, 44);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(252, 18);
            this.label24.TabIndex = 35;
            this.label24.Text = "Modul ini digunakan untuk restore data";
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
            this.label43.Size = new System.Drawing.Size(273, 33);
            this.label43.TabIndex = 33;
            this.label43.Text = "KELOLA RESTORE DATA";
            // 
            // button_SelectFile
            // 
            this.button_SelectFile.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SelectFile.Location = new System.Drawing.Point(15, 98);
            this.button_SelectFile.Name = "button_SelectFile";
            this.button_SelectFile.Size = new System.Drawing.Size(49, 38);
            this.button_SelectFile.TabIndex = 73;
            this.button_SelectFile.Text = "Select File";
            this.button_SelectFile.UseVisualStyleBackColor = true;
            this.button_SelectFile.Click += new System.EventHandler(this.button_SelectFile_Click);
            // 
            // textBox_File
            // 
            this.textBox_File.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_File.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_File.Location = new System.Drawing.Point(71, 107);
            this.textBox_File.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_File.Name = "textBox_File";
            this.textBox_File.Size = new System.Drawing.Size(457, 21);
            this.textBox_File.TabIndex = 74;
            // 
            // nmImInterval
            // 
            this.nmImInterval.Location = new System.Drawing.Point(301, 158);
            this.nmImInterval.Name = "nmImInterval";
            this.nmImInterval.Size = new System.Drawing.Size(72, 23);
            this.nmImInterval.TabIndex = 81;
            this.nmImInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmImInterval.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 15);
            this.label6.TabIndex = 80;
            this.label6.Text = "Progress Report Interval (Miliseconds)";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(71, 233);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(257, 23);
            this.progressBar1.TabIndex = 79;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(186, 214);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(70, 15);
            this.lbStatus.TabIndex = 78;
            this.lbStatus.Text = "0 of 0 bytes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 77;
            this.label2.Text = "Processed Bytes:";
            // 
            // btnBATAL
            // 
            this.btnBATAL.Image = ((System.Drawing.Image)(resources.GetObject("btnBATAL.Image")));
            this.btnBATAL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBATAL.Location = new System.Drawing.Point(514, 299);
            this.btnBATAL.Name = "btnBATAL";
            this.btnBATAL.Size = new System.Drawing.Size(87, 41);
            this.btnBATAL.TabIndex = 92;
            this.btnBATAL.Text = "BATAL";
            this.btnBATAL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBATAL.UseVisualStyleBackColor = true;
            this.btnBATAL.Click += new System.EventHandler(this.btnBATAL_Click);
            // 
            // btnSIMPAN
            // 
            this.btnSIMPAN.Image = ((System.Drawing.Image)(resources.GetObject("btnSIMPAN.Image")));
            this.btnSIMPAN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSIMPAN.Location = new System.Drawing.Point(411, 299);
            this.btnSIMPAN.Name = "btnSIMPAN";
            this.btnSIMPAN.Size = new System.Drawing.Size(103, 41);
            this.btnSIMPAN.TabIndex = 91;
            this.btnSIMPAN.Text = "IMPORT";
            this.btnSIMPAN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSIMPAN.UseVisualStyleBackColor = true;
            this.btnSIMPAN.Click += new System.EventHandler(this.btnSIMPAN_Click);
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Location = new System.Drawing.Point(59, 294);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(540, 3);
            this.label14.TabIndex = 90;
            // 
            // FormRESTORE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(612, 352);
            this.ControlBox = false;
            this.Controls.Add(this.btnBATAL);
            this.Controls.Add(this.btnSIMPAN);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.nmImInterval);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_File);
            this.Controls.Add(this.button_SelectFile);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRESTORE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RESTORE DATA";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmImInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Button button_SelectFile;
        private System.Windows.Forms.TextBox textBox_File;
        private System.Windows.Forms.NumericUpDown nmImInterval;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBATAL;
        private System.Windows.Forms.Button btnSIMPAN;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}