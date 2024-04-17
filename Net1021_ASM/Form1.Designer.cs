namespace Net1021_ASM
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_qltv = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckb_showmk = new System.Windows.Forms.CheckBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_dangnhap = new System.Windows.Forms.Button();
            this.link_lbl_quenmk = new System.Windows.Forms.LinkLabel();
            this.lbl_matkhau = new System.Windows.Forms.Label();
            this.lbl_taikhoan = new System.Windows.Forms.Label();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.txt_taikhoan = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_qltv
            // 
            this.lbl_qltv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_qltv.AutoSize = true;
            this.lbl_qltv.Font = new System.Drawing.Font("Segoe UI Black", 21.9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qltv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_qltv.Location = new System.Drawing.Point(100, 66);
            this.lbl_qltv.Name = "lbl_qltv";
            this.lbl_qltv.Size = new System.Drawing.Size(979, 98);
            this.lbl_qltv.TabIndex = 0;
            this.lbl_qltv.Text = "Hệ thống quản lý thư viện";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.ckb_showmk);
            this.groupBox1.Controls.Add(this.btn_thoat);
            this.groupBox1.Controls.Add(this.btn_dangnhap);
            this.groupBox1.Controls.Add(this.link_lbl_quenmk);
            this.groupBox1.Controls.Add(this.lbl_matkhau);
            this.groupBox1.Controls.Add(this.lbl_taikhoan);
            this.groupBox1.Controls.Add(this.txt_matkhau);
            this.groupBox1.Controls.Add(this.txt_taikhoan);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(58, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1058, 629);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đăng nhập";
            // 
            // ckb_showmk
            // 
            this.ckb_showmk.AutoSize = true;
            this.ckb_showmk.Location = new System.Drawing.Point(609, 247);
            this.ckb_showmk.Name = "ckb_showmk";
            this.ckb_showmk.Size = new System.Drawing.Size(234, 36);
            this.ckb_showmk.TabIndex = 9;
            this.ckb_showmk.Text = "Hiện mật khẩu";
            this.ckb_showmk.UseVisualStyleBackColor = true;
            this.ckb_showmk.CheckedChanged += new System.EventHandler(this.ckb_showmk_CheckedChanged);
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_thoat.Location = new System.Drawing.Point(784, 389);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(222, 76);
            this.btn_thoat.TabIndex = 8;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_dangnhap
            // 
            this.btn_dangnhap.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_dangnhap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_dangnhap.Location = new System.Drawing.Point(420, 389);
            this.btn_dangnhap.Name = "btn_dangnhap";
            this.btn_dangnhap.Size = new System.Drawing.Size(222, 76);
            this.btn_dangnhap.TabIndex = 7;
            this.btn_dangnhap.Text = "Đăng nhập";
            this.btn_dangnhap.UseVisualStyleBackColor = false;
            this.btn_dangnhap.Click += new System.EventHandler(this.btn_dangnhap_Click);
            // 
            // link_lbl_quenmk
            // 
            this.link_lbl_quenmk.AutoSize = true;
            this.link_lbl_quenmk.Location = new System.Drawing.Point(552, 318);
            this.link_lbl_quenmk.Name = "link_lbl_quenmk";
            this.link_lbl_quenmk.Size = new System.Drawing.Size(207, 32);
            this.link_lbl_quenmk.TabIndex = 5;
            this.link_lbl_quenmk.TabStop = true;
            this.link_lbl_quenmk.Text = "Quên mật khẩu";
            this.link_lbl_quenmk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_lbl_quenmk_LinkClicked);
            // 
            // lbl_matkhau
            // 
            this.lbl_matkhau.AutoSize = true;
            this.lbl_matkhau.Location = new System.Drawing.Point(414, 196);
            this.lbl_matkhau.Name = "lbl_matkhau";
            this.lbl_matkhau.Size = new System.Drawing.Size(130, 32);
            this.lbl_matkhau.TabIndex = 4;
            this.lbl_matkhau.Text = "Mật khẩu";
            // 
            // lbl_taikhoan
            // 
            this.lbl_taikhoan.AutoSize = true;
            this.lbl_taikhoan.Location = new System.Drawing.Point(414, 107);
            this.lbl_taikhoan.Name = "lbl_taikhoan";
            this.lbl_taikhoan.Size = new System.Drawing.Size(139, 32);
            this.lbl_taikhoan.TabIndex = 3;
            this.lbl_taikhoan.Text = "Tài khoản";
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Location = new System.Drawing.Point(609, 193);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.Size = new System.Drawing.Size(397, 38);
            this.txt_matkhau.TabIndex = 2;
            this.txt_matkhau.UseSystemPasswordChar = true;
            this.txt_matkhau.TextChanged += new System.EventHandler(this.txt_matkhau_TextChanged);
            // 
            // txt_taikhoan
            // 
            this.txt_taikhoan.Location = new System.Drawing.Point(609, 104);
            this.txt_taikhoan.Name = "txt_taikhoan";
            this.txt_taikhoan.Size = new System.Drawing.Size(397, 38);
            this.txt_taikhoan.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(331, 448);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 905);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_qltv);
            this.Name = "Form1";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_qltv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_dangnhap;
        private System.Windows.Forms.LinkLabel link_lbl_quenmk;
        private System.Windows.Forms.Label lbl_matkhau;
        private System.Windows.Forms.Label lbl_taikhoan;
        private System.Windows.Forms.TextBox txt_matkhau;
        private System.Windows.Forms.TextBox txt_taikhoan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.CheckBox ckb_showmk;
    }
}

