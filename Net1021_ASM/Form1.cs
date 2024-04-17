using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Net1021_ASM
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string str = "Data Source=DESKTOP-CNGEDRR\\MSSQLSERVER01;Initial Catalog=QuanLyThuVien;UID=sa;Password=12345";
        SqlDataAdapter adt = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void link_lbl_quenmk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            quenMK quenmatkhau = new quenMK();
            quenmatkhau.ShowDialog();
        }

        //private void link_lbl_dk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    frmDangKy dk = new frmDangKy();
        //    dk.ShowDialog();
        //}
        Modify modify = new Modify();

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string tentk = txt_taikhoan.Text.Trim();
            string matkhau = txt_matkhau.Text.Trim();

            if (string.IsNullOrEmpty(tentk))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!");
            }
            else if (string.IsNullOrEmpty(matkhau))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
            }
            else
            {
                string query = "select VaiTro from TaiKhoan where TaiKhoan = '" + tentk + "' and MatKhau = '" + matkhau + "'";

                // Thực hiện truy vấn để lấy vai trò của người dùng
                string vaiTro = modify.LayVaiTro(query);

                if (!string.IsNullOrEmpty(vaiTro))
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    menuQuanLy menuql = new menuQuanLy(vaiTro); // Truyền vai trò vào constructor mới của menuQuanLy
                    menuql.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ckb_showmk_CheckedChanged(object sender, EventArgs e)
        {
            txt_matkhau.UseSystemPasswordChar = !ckb_showmk.Checked;

        }

        private void link_lbl_dk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
        }

        private void txt_matkhau_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
