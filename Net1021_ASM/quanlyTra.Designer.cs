namespace Net1021_ASM
{
    partial class quanlyTra
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
            this.txt_sodt = new System.Windows.Forms.TextBox();
            this.txt_madocgia = new System.Windows.Forms.TextBox();
            this.lbl_sodienthoai = new System.Windows.Forms.Label();
            this.lbl_tendocgia = new System.Windows.Forms.Label();
            this.lbl_madocgia = new System.Windows.Forms.Label();
            this.dgv_danhsachtra = new System.Windows.Forms.DataGridView();
            this.txt_tendocgia = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_lammoi = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_capnhat = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.gbx_thongtin = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachtra)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbx_thongtin.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_sodt
            // 
            this.txt_sodt.Location = new System.Drawing.Point(992, 81);
            this.txt_sodt.Name = "txt_sodt";
            this.txt_sodt.Size = new System.Drawing.Size(236, 38);
            this.txt_sodt.TabIndex = 14;
            // 
            // txt_madocgia
            // 
            this.txt_madocgia.Location = new System.Drawing.Point(364, 81);
            this.txt_madocgia.Name = "txt_madocgia";
            this.txt_madocgia.Size = new System.Drawing.Size(250, 38);
            this.txt_madocgia.TabIndex = 9;
            // 
            // lbl_sodienthoai
            // 
            this.lbl_sodienthoai.AutoSize = true;
            this.lbl_sodienthoai.Location = new System.Drawing.Point(756, 81);
            this.lbl_sodienthoai.Name = "lbl_sodienthoai";
            this.lbl_sodienthoai.Size = new System.Drawing.Size(127, 32);
            this.lbl_sodienthoai.TabIndex = 8;
            this.lbl_sodienthoai.Text = "Số lượng";
            // 
            // lbl_tendocgia
            // 
            this.lbl_tendocgia.AutoSize = true;
            this.lbl_tendocgia.Location = new System.Drawing.Point(93, 164);
            this.lbl_tendocgia.Name = "lbl_tendocgia";
            this.lbl_tendocgia.Size = new System.Drawing.Size(120, 32);
            this.lbl_tendocgia.TabIndex = 3;
            this.lbl_tendocgia.Text = "Mã sách";
            // 
            // lbl_madocgia
            // 
            this.lbl_madocgia.AutoSize = true;
            this.lbl_madocgia.Location = new System.Drawing.Point(93, 81);
            this.lbl_madocgia.Name = "lbl_madocgia";
            this.lbl_madocgia.Size = new System.Drawing.Size(131, 32);
            this.lbl_madocgia.TabIndex = 0;
            this.lbl_madocgia.Text = "Mã phiếu";
            // 
            // dgv_danhsachtra
            // 
            this.dgv_danhsachtra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_danhsachtra.Location = new System.Drawing.Point(16, 79);
            this.dgv_danhsachtra.Name = "dgv_danhsachtra";
            this.dgv_danhsachtra.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_danhsachtra.RowHeadersWidth = 102;
            this.dgv_danhsachtra.RowTemplate.Height = 40;
            this.dgv_danhsachtra.Size = new System.Drawing.Size(1177, 397);
            this.dgv_danhsachtra.TabIndex = 0;
            // 
            // txt_tendocgia
            // 
            this.txt_tendocgia.Location = new System.Drawing.Point(364, 161);
            this.txt_tendocgia.Name = "txt_tendocgia";
            this.txt_tendocgia.Size = new System.Drawing.Size(250, 38);
            this.txt_tendocgia.TabIndex = 15;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_lammoi);
            this.groupBox3.Controls.Add(this.btn_xoa);
            this.groupBox3.Controls.Add(this.btn_capnhat);
            this.groupBox3.Controls.Add(this.btn_them);
            this.groupBox3.Location = new System.Drawing.Point(48, 1011);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(824, 165);
            this.groupBox3.TabIndex = 21;
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
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(386, 55);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(128, 56);
            this.btn_xoa.TabIndex = 24;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.Location = new System.Drawing.Point(190, 55);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(169, 56);
            this.btn_capnhat.TabIndex = 23;
            this.btn_capnhat.Text = "Cập nhật";
            this.btn_capnhat.UseVisualStyleBackColor = true;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(28, 55);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(134, 56);
            this.btn_them.TabIndex = 22;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_timkiem);
            this.groupBox2.Controls.Add(this.txt_timkiem);
            this.groupBox2.Location = new System.Drawing.Point(969, 1011);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 165);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Location = new System.Drawing.Point(278, 55);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(169, 68);
            this.btn_timkiem.TabIndex = 21;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(22, 65);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(250, 38);
            this.txt_timkiem.TabIndex = 20;
            // 
            // gbx_thongtin
            // 
            this.gbx_thongtin.Controls.Add(this.txt_tendocgia);
            this.gbx_thongtin.Controls.Add(this.txt_sodt);
            this.gbx_thongtin.Controls.Add(this.txt_madocgia);
            this.gbx_thongtin.Controls.Add(this.lbl_sodienthoai);
            this.gbx_thongtin.Controls.Add(this.lbl_tendocgia);
            this.gbx_thongtin.Controls.Add(this.lbl_madocgia);
            this.gbx_thongtin.Location = new System.Drawing.Point(48, 37);
            this.gbx_thongtin.Name = "gbx_thongtin";
            this.gbx_thongtin.Size = new System.Drawing.Size(1485, 280);
            this.gbx_thongtin.TabIndex = 23;
            this.gbx_thongtin.TabStop = false;
            this.gbx_thongtin.Text = "Thông tin trả";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_danhsachtra);
            this.groupBox1.Location = new System.Drawing.Point(48, 373);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1368, 581);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách trả";
            // 
            // quanlyTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1746, 1589);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbx_thongtin);
            this.Controls.Add(this.groupBox1);
            this.Name = "quanlyTra";
            this.Text = "Quản lý trả";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachtra)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbx_thongtin.ResumeLayout(false);
            this.gbx_thongtin.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_sodt;
        private System.Windows.Forms.TextBox txt_madocgia;
        private System.Windows.Forms.Label lbl_sodienthoai;
        private System.Windows.Forms.Label lbl_tendocgia;
        private System.Windows.Forms.Label lbl_madocgia;
        private System.Windows.Forms.DataGridView dgv_danhsachtra;
        private System.Windows.Forms.TextBox txt_tendocgia;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_lammoi;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_capnhat;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.GroupBox gbx_thongtin;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}