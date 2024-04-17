namespace Net1021_ASM
{
    partial class frmDangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangKy));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picture_dk = new System.Windows.Forms.PictureBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_xacnhanmk = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_xacnhanmk = new System.Windows.Forms.TextBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_dangki = new System.Windows.Forms.Button();
            this.lbl_matkhau = new System.Windows.Forms.Label();
            this.lbl_taikhoan = new System.Windows.Forms.Label();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.txt_taikhoan = new System.Windows.Forms.TextBox();
            this.lbl_qltv = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_dk)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.picture_dk);
            this.groupBox1.Controls.Add(this.lbl_email);
            this.groupBox1.Controls.Add(this.lbl_xacnhanmk);
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Controls.Add(this.txt_xacnhanmk);
            this.groupBox1.Controls.Add(this.btn_thoat);
            this.groupBox1.Controls.Add(this.btn_dangki);
            this.groupBox1.Controls.Add(this.lbl_matkhau);
            this.groupBox1.Controls.Add(this.lbl_taikhoan);
            this.groupBox1.Controls.Add(this.txt_matkhau);
            this.groupBox1.Controls.Add(this.txt_taikhoan);
            this.groupBox1.Location = new System.Drawing.Point(94, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(885, 864);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đăng ký";
            // 
            // picture_dk
            // 
            this.picture_dk.Image = ((System.Drawing.Image)(resources.GetObject("picture_dk.Image")));
            this.picture_dk.Location = new System.Drawing.Point(275, 54);
            this.picture_dk.Name = "picture_dk";
            this.picture_dk.Size = new System.Drawing.Size(347, 348);
            this.picture_dk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_dk.TabIndex = 13;
            this.picture_dk.TabStop = false;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(72, 639);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(86, 32);
            this.lbl_email.TabIndex = 12;
            this.lbl_email.Text = "Email";
            // 
            // lbl_xacnhanmk
            // 
            this.lbl_xacnhanmk.AutoSize = true;
            this.lbl_xacnhanmk.Location = new System.Drawing.Point(72, 570);
            this.lbl_xacnhanmk.Name = "lbl_xacnhanmk";
            this.lbl_xacnhanmk.Size = new System.Drawing.Size(257, 32);
            this.lbl_xacnhanmk.TabIndex = 11;
            this.lbl_xacnhanmk.Text = "Xác nhận mật khẩu";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(402, 636);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(397, 38);
            this.txt_email.TabIndex = 10;
            // 
            // txt_xacnhanmk
            // 
            this.txt_xacnhanmk.Location = new System.Drawing.Point(402, 567);
            this.txt_xacnhanmk.Name = "txt_xacnhanmk";
            this.txt_xacnhanmk.PasswordChar = '*';
            this.txt_xacnhanmk.Size = new System.Drawing.Size(397, 38);
            this.txt_xacnhanmk.TabIndex = 9;
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_thoat.Location = new System.Drawing.Point(498, 724);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(222, 76);
            this.btn_thoat.TabIndex = 8;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_dangki
            // 
            this.btn_dangki.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_dangki.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_dangki.Location = new System.Drawing.Point(126, 724);
            this.btn_dangki.Name = "btn_dangki";
            this.btn_dangki.Size = new System.Drawing.Size(222, 76);
            this.btn_dangki.TabIndex = 7;
            this.btn_dangki.Text = "Đăng ký";
            this.btn_dangki.UseVisualStyleBackColor = false;
            this.btn_dangki.Click += new System.EventHandler(this.btn_dangki_Click);
            // 
            // lbl_matkhau
            // 
            this.lbl_matkhau.AutoSize = true;
            this.lbl_matkhau.Location = new System.Drawing.Point(72, 502);
            this.lbl_matkhau.Name = "lbl_matkhau";
            this.lbl_matkhau.Size = new System.Drawing.Size(130, 32);
            this.lbl_matkhau.TabIndex = 4;
            this.lbl_matkhau.Text = "Mật khẩu";
            // 
            // lbl_taikhoan
            // 
            this.lbl_taikhoan.AutoSize = true;
            this.lbl_taikhoan.Location = new System.Drawing.Point(72, 441);
            this.lbl_taikhoan.Name = "lbl_taikhoan";
            this.lbl_taikhoan.Size = new System.Drawing.Size(139, 32);
            this.lbl_taikhoan.TabIndex = 3;
            this.lbl_taikhoan.Text = "Tài khoản";
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Location = new System.Drawing.Point(402, 499);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.PasswordChar = '*';
            this.txt_matkhau.Size = new System.Drawing.Size(397, 38);
            this.txt_matkhau.TabIndex = 2;
            // 
            // txt_taikhoan
            // 
            this.txt_taikhoan.Location = new System.Drawing.Point(402, 438);
            this.txt_taikhoan.Name = "txt_taikhoan";
            this.txt_taikhoan.Size = new System.Drawing.Size(397, 38);
            this.txt_taikhoan.TabIndex = 1;
            // 
            // lbl_qltv
            // 
            this.lbl_qltv.AutoSize = true;
            this.lbl_qltv.Font = new System.Drawing.Font("Segoe UI Black", 21.9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qltv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_qltv.Location = new System.Drawing.Point(51, 9);
            this.lbl_qltv.Name = "lbl_qltv";
            this.lbl_qltv.Size = new System.Drawing.Size(979, 98);
            this.lbl_qltv.TabIndex = 2;
            this.lbl_qltv.Text = "Hệ thống quản lý thư viện";
            // 
            // frmDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 1075);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_qltv);
            this.Name = "frmDangKy";
            this.Text = "Đăng ký";
            this.Load += new System.EventHandler(this.frmDangKy_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_dk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_xacnhanmk;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_xacnhanmk;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_dangki;
        private System.Windows.Forms.Label lbl_matkhau;
        private System.Windows.Forms.Label lbl_taikhoan;
        private System.Windows.Forms.TextBox txt_matkhau;
        private System.Windows.Forms.TextBox txt_taikhoan;
        private System.Windows.Forms.Label lbl_qltv;
        private System.Windows.Forms.PictureBox picture_dk;
    }
}