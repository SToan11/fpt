using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace Net1021_ASM
{
    public partial class menuQuanLy : Form
    {
        private string MaNhanVien, HoTen, NgaySinh, SoDienThoai, VaiTro, TaiKhoan, MatKhau;

        SqlConnection conn;
        SqlCommand cmd;
        string str = "Data Source=DESKTOP-CNGEDRR\\MSSQLSERVER01;Initial Catalog=QuanLyThuVien;UID=sa;Password=12345";
        SqlDataAdapter adt = new SqlDataAdapter();
        DataTable dt = new DataTable();
        bool sidebarExpand;
        public menuQuanLy()
        {
            InitializeComponent();
            //checkVT();
        }
        public menuQuanLy(string VaiTro)
        {
            InitializeComponent();
            CheckVaiTro(VaiTro);
        }

        private void slidebarTimer_tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    slidebar_timer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    slidebar_timer.Stop();
                }
            }
        }

        private void picture_menu_Click(object sender, EventArgs e)
        {
            slidebar_timer.Start();
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(childForm);
            panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void menuQuanLy_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
        }
        private void btn_home_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }

        private void btn_qlsach_Click(object sender, EventArgs e)
        {
            OpenChildForm(new quanlySach());
        }

        private void btn_qldocgia_Click(object sender, EventArgs e)
        {
            OpenChildForm(new quanlyDocGia());
        }

        private void btn_qlmuontra_Click(object sender, EventArgs e)
        {
            OpenChildForm(new quanlyMuonTra());
        }

        private void txt_vaitro_TextChanged(object sender, EventArgs e)
        {

        }

        //private void btn_baocao_Click(object sender, EventArgs e)
        //{
        //    OpenChildForm(new quanlyTra());
        //}

        private void btn_qlTK_Click(object sender, EventArgs e)
        {
            OpenChildForm(new baoCaoThongKe());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new quanlyTK());
                //if (VaiTro == "Admin")
                //{
                //    OpenChildForm(new quanlyTK());
                //}
                //else if (VaiTro == "User")
                //{
                //    MessageBox.Show("Bạn không đủ quyền!");
                //}
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Form1 f1 = new Form1();
                f1.ShowDialog();
                this.Close();
            }
        }

        private void CheckVaiTro(string vaiTro)
        {
            if (vaiTro == "admin")
            {
                // Cho phép sử dụng tất cả các button
                btn_qlsach.Visible = true;
                btn_qldocgia.Visible = true;
                btn_qlmuontra.Visible = true;
                btn_qlTK.Visible = true;
                btn_thoat.Visible = true;
            }
            else if (vaiTro == "user")
            {
                btn_qlTK.Enabled = false;
            }
        }

            //private void checkVT()
            //{
            //    try
            //    {
            //        string query = "SELECT VaiTro FROM TaiKhoan WHERE MaNhanVien = @MaNhanVien";
            //        SqlCommand cmd = new SqlCommand(query, conn);
            //        cmd.Parameters.AddWithValue("@VaiTro", txt_maNhanVien.Text); // Giả sử txt_maNhanVien là textbox chứa mã nhân viên
            //        conn.Open();
            //        string vaitro = cmd.ExecuteScalar()?.ToString();
            //        if (vaitro == "Admin")
            //        {
            //            check_Admin();
            //        }
            //        else if (vaitro == "User")
            //        {
            //            check_User();
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //    finally
            //    {
            //        if (conn.State != ConnectionState.Closed)
            //        {
            //            conn.Close();
            //        }
            //    }
            //}

            //private void check_Admin()
            //{
            //    if (btn_qlTK != null)
            //    {
            //        btn_qlTK.Enabled = true;
            //    }
            //}

            //private void check_User()
            //{
            //    if (btn_qlTK != null)
            //    {
            //        btn_qlTK.Enabled = false;
            //    }
            //}

        }
}
