namespace Net1021_ASM
{
    partial class quanlyTK
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_lammoi = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_capnhat = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.dgv_danhsachtk = new System.Windows.Forms.DataGridView();
            this.gbx_thongtin = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_manv = new System.Windows.Forms.Label();
            this.lbl_hoten = new System.Windows.Forms.Label();
            this.lbl_ngaysinh = new System.Windows.Forms.Label();
            this.lbl_sodt = new System.Windows.Forms.Label();
            this.lbl_vaitro = new System.Windows.Forms.Label();
            this.txt_manv = new System.Windows.Forms.TextBox();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.txt_sodt = new System.Windows.Forms.TextBox();
            this.txt_vaitro = new System.Windows.Forms.TextBox();
            this.lbl_mk = new System.Windows.Forms.Label();
            this.txt_mk = new System.Windows.Forms.TextBox();
            this.lbl_tk = new System.Windows.Forms.Label();
            this.txt_tk = new System.Windows.Forms.TextBox();
            this.dtp_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachtk)).BeginInit();
            this.gbx_thongtin.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_lammoi);
            this.groupBox3.Controls.Add(this.btn_xoa);
            this.groupBox3.Controls.Add(this.btn_capnhat);
            this.groupBox3.Controls.Add(this.btn_them);
            this.groupBox3.Location = new System.Drawing.Point(48, 1089);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(824, 165);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thêm";
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.Location = new System.Drawing.Point(547, 55);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(169, 56);
            this.btn_lammoi.TabIndex = 25;
            this.btn_lammoi.Text = "Làm mới";
            this.btn_lammoi.UseVisualStyleBackColor = true;
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(386, 55);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(128, 56);
            this.btn_xoa.TabIndex = 24;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.Location = new System.Drawing.Point(190, 55);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(169, 56);
            this.btn_capnhat.TabIndex = 23;
            this.btn_capnhat.Text = "Cập nhật";
            this.btn_capnhat.UseVisualStyleBackColor = true;
            this.btn_capnhat.Click += new System.EventHandler(this.btn_capnhat_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(28, 55);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(134, 56);
            this.btn_them.TabIndex = 22;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Location = new System.Drawing.Point(278, 55);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(169, 68);
            this.btn_timkiem.TabIndex = 21;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_timkiem);
            this.groupBox2.Controls.Add(this.txt_timkiem);
            this.groupBox2.Location = new System.Drawing.Point(969, 1089);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 165);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(22, 65);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(250, 38);
            this.txt_timkiem.TabIndex = 20;
            // 
            // dgv_danhsachtk
            // 
            this.dgv_danhsachtk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_danhsachtk.Location = new System.Drawing.Point(16, 79);
            this.dgv_danhsachtk.Name = "dgv_danhsachtk";
            this.dgv_danhsachtk.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_danhsachtk.RowHeadersWidth = 102;
            this.dgv_danhsachtk.RowTemplate.Height = 40;
            this.dgv_danhsachtk.Size = new System.Drawing.Size(1672, 473);
            this.dgv_danhsachtk.TabIndex = 0;
            this.dgv_danhsachtk.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_danhsachtk_CellContentClick);
            // 
            // gbx_thongtin
            // 
            this.gbx_thongtin.Controls.Add(this.dtp_ngaysinh);
            this.gbx_thongtin.Controls.Add(this.txt_tk);
            this.gbx_thongtin.Controls.Add(this.lbl_tk);
            this.gbx_thongtin.Controls.Add(this.txt_mk);
            this.gbx_thongtin.Controls.Add(this.lbl_mk);
            this.gbx_thongtin.Controls.Add(this.txt_vaitro);
            this.gbx_thongtin.Controls.Add(this.txt_sodt);
            this.gbx_thongtin.Controls.Add(this.txt_hoten);
            this.gbx_thongtin.Controls.Add(this.txt_manv);
            this.gbx_thongtin.Controls.Add(this.lbl_vaitro);
            this.gbx_thongtin.Controls.Add(this.lbl_sodt);
            this.gbx_thongtin.Controls.Add(this.lbl_ngaysinh);
            this.gbx_thongtin.Controls.Add(this.lbl_hoten);
            this.gbx_thongtin.Controls.Add(this.lbl_manv);
            this.gbx_thongtin.Location = new System.Drawing.Point(48, 48);
            this.gbx_thongtin.Name = "gbx_thongtin";
            this.gbx_thongtin.Size = new System.Drawing.Size(1577, 311);
            this.gbx_thongtin.TabIndex = 19;
            this.gbx_thongtin.TabStop = false;
            this.gbx_thongtin.Text = "Thông tin sách";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_danhsachtk);
            this.groupBox1.Location = new System.Drawing.Point(48, 384);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1782, 628);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách tài khoản";
            // 
            // lbl_manv
            // 
            this.lbl_manv.AutoSize = true;
            this.lbl_manv.Location = new System.Drawing.Point(68, 84);
            this.lbl_manv.Name = "lbl_manv";
            this.lbl_manv.Size = new System.Drawing.Size(184, 32);
            this.lbl_manv.TabIndex = 0;
            this.lbl_manv.Text = "Mã nhân viên";
            // 
            // lbl_hoten
            // 
            this.lbl_hoten.AutoSize = true;
            this.lbl_hoten.Location = new System.Drawing.Point(68, 155);
            this.lbl_hoten.Name = "lbl_hoten";
            this.lbl_hoten.Size = new System.Drawing.Size(97, 32);
            this.lbl_hoten.TabIndex = 1;
            this.lbl_hoten.Text = "Họ tên";
            // 
            // lbl_ngaysinh
            // 
            this.lbl_ngaysinh.AutoSize = true;
            this.lbl_ngaysinh.Location = new System.Drawing.Point(591, 77);
            this.lbl_ngaysinh.Name = "lbl_ngaysinh";
            this.lbl_ngaysinh.Size = new System.Drawing.Size(140, 32);
            this.lbl_ngaysinh.TabIndex = 3;
            this.lbl_ngaysinh.Text = "Ngày sinh";
            // 
            // lbl_sodt
            // 
            this.lbl_sodt.AutoSize = true;
            this.lbl_sodt.Location = new System.Drawing.Point(591, 152);
            this.lbl_sodt.Name = "lbl_sodt";
            this.lbl_sodt.Size = new System.Drawing.Size(181, 32);
            this.lbl_sodt.TabIndex = 4;
            this.lbl_sodt.Text = "Số điện thoại";
            // 
            // lbl_vaitro
            // 
            this.lbl_vaitro.AutoSize = true;
            this.lbl_vaitro.Location = new System.Drawing.Point(69, 219);
            this.lbl_vaitro.Name = "lbl_vaitro";
            this.lbl_vaitro.Size = new System.Drawing.Size(96, 32);
            this.lbl_vaitro.TabIndex = 8;
            this.lbl_vaitro.Text = "Vai trò";
            // 
            // txt_manv
            // 
            this.txt_manv.Location = new System.Drawing.Point(278, 74);
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.Size = new System.Drawing.Size(250, 38);
            this.txt_manv.TabIndex = 9;
            // 
            // txt_hoten
            // 
            this.txt_hoten.Location = new System.Drawing.Point(278, 152);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(250, 38);
            this.txt_hoten.TabIndex = 10;
            // 
            // txt_sodt
            // 
            this.txt_sodt.Location = new System.Drawing.Point(788, 149);
            this.txt_sodt.Name = "txt_sodt";
            this.txt_sodt.Size = new System.Drawing.Size(250, 38);
            this.txt_sodt.TabIndex = 11;
            // 
            // txt_vaitro
            // 
            this.txt_vaitro.Location = new System.Drawing.Point(278, 222);
            this.txt_vaitro.Name = "txt_vaitro";
            this.txt_vaitro.Size = new System.Drawing.Size(250, 38);
            this.txt_vaitro.TabIndex = 14;
            // 
            // lbl_mk
            // 
            this.lbl_mk.AutoSize = true;
            this.lbl_mk.Location = new System.Drawing.Point(1097, 149);
            this.lbl_mk.Name = "lbl_mk";
            this.lbl_mk.Size = new System.Drawing.Size(130, 32);
            this.lbl_mk.TabIndex = 16;
            this.lbl_mk.Text = "Mật khẩu";
            // 
            // txt_mk
            // 
            this.txt_mk.Location = new System.Drawing.Point(1263, 146);
            this.txt_mk.Name = "txt_mk";
            this.txt_mk.Size = new System.Drawing.Size(236, 38);
            this.txt_mk.TabIndex = 17;
            // 
            // lbl_tk
            // 
            this.lbl_tk.AutoSize = true;
            this.lbl_tk.Location = new System.Drawing.Point(1097, 77);
            this.lbl_tk.Name = "lbl_tk";
            this.lbl_tk.Size = new System.Drawing.Size(139, 32);
            this.lbl_tk.TabIndex = 18;
            this.lbl_tk.Text = "Tài khoản";
            // 
            // txt_tk
            // 
            this.txt_tk.Location = new System.Drawing.Point(1263, 74);
            this.txt_tk.Name = "txt_tk";
            this.txt_tk.Size = new System.Drawing.Size(236, 38);
            this.txt_tk.TabIndex = 19;
            // 
            // dtp_ngaysinh
            // 
            this.dtp_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngaysinh.Location = new System.Drawing.Point(788, 71);
            this.dtp_ngaysinh.Name = "dtp_ngaysinh";
            this.dtp_ngaysinh.Size = new System.Drawing.Size(250, 38);
            this.dtp_ngaysinh.TabIndex = 20;
            // 
            // quanlyTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1313);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbx_thongtin);
            this.Controls.Add(this.groupBox1);
            this.Name = "quanlyTK";
            this.Text = "Quản lý tài khoản";
            this.Load += new System.EventHandler(this.quanlyTK_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachtk)).EndInit();
            this.gbx_thongtin.ResumeLayout(false);
            this.gbx_thongtin.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_lammoi;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_capnhat;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.DataGridView dgv_danhsachtk;
        private System.Windows.Forms.GroupBox gbx_thongtin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtp_ngaysinh;
        private System.Windows.Forms.TextBox txt_tk;
        private System.Windows.Forms.Label lbl_tk;
        private System.Windows.Forms.TextBox txt_mk;
        private System.Windows.Forms.Label lbl_mk;
        private System.Windows.Forms.TextBox txt_vaitro;
        private System.Windows.Forms.TextBox txt_sodt;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.TextBox txt_manv;
        private System.Windows.Forms.Label lbl_vaitro;
        private System.Windows.Forms.Label lbl_sodt;
        private System.Windows.Forms.Label lbl_ngaysinh;
        private System.Windows.Forms.Label lbl_hoten;
        private System.Windows.Forms.Label lbl_manv;
    }
}