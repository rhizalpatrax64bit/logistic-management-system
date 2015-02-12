namespace Anovsys.DAL
{
    partial class FormCONFIG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCONFIG));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHOST = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUSER = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPASS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPORT = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnBATAL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 167);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(526, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOST NAME";
            // 
            // txtHOST
            // 
            this.txtHOST.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHOST.Location = new System.Drawing.Point(286, 12);
            this.txtHOST.Name = "txtHOST";
            this.txtHOST.Size = new System.Drawing.Size(232, 23);
            this.txtHOST.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "USER NAME";
            // 
            // txtUSER
            // 
            this.txtUSER.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUSER.Location = new System.Drawing.Point(286, 40);
            this.txtUSER.Name = "txtUSER";
            this.txtUSER.Size = new System.Drawing.Size(232, 23);
            this.txtUSER.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "PASSWORD";
            // 
            // txtPASS
            // 
            this.txtPASS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPASS.Location = new System.Drawing.Point(286, 69);
            this.txtPASS.Name = "txtPASS";
            this.txtPASS.PasswordChar = '*';
            this.txtPASS.Size = new System.Drawing.Size(232, 23);
            this.txtPASS.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "PORT";
            // 
            // txtPORT
            // 
            this.txtPORT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPORT.Location = new System.Drawing.Point(286, 98);
            this.txtPORT.Name = "txtPORT";
            this.txtPORT.Size = new System.Drawing.Size(232, 23);
            this.txtPORT.TabIndex = 4;
            // 
            // btnOK
            // 
            this.btnOK.ForeColor = System.Drawing.Color.Red;
            this.btnOK.Location = new System.Drawing.Point(441, 128);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 30);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnBATAL
            // 
            this.btnBATAL.ForeColor = System.Drawing.Color.Red;
            this.btnBATAL.Location = new System.Drawing.Point(365, 128);
            this.btnBATAL.Name = "btnBATAL";
            this.btnBATAL.Size = new System.Drawing.Size(75, 30);
            this.btnBATAL.TabIndex = 5;
            this.btnBATAL.Text = "BATAL";
            this.btnBATAL.UseVisualStyleBackColor = true;
            this.btnBATAL.Click += new System.EventHandler(this.btnBATAL_Click);
            // 
            // FormCONFIG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(526, 189);
            this.Controls.Add(this.btnBATAL);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtPORT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPASS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUSER);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHOST);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCONFIG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SETTING CONFIG DATABASE";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHOST;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUSER;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPASS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPORT;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnBATAL;
    }
}