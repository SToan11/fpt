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
    public partial class quanlyTK : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string str = "Data Source=DESKTOP-CNGEDRR\\MSSQLSERVER01;Initial Catalog=QuanLyThuVien;UID=sa;Password=12345";
        SqlDataAdapter adt = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public quanlyTK()
        {
            InitializeComponent();
        }

        private void quanlyTK_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            loadTK();
        }

        private void loadTK()
        {
            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM TaiKhoan";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt.Clear();
                da.Fill(dt);
                dgv_danhsachtk.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = "insert into TaiKhoan values(@MaNhanVien, @HoTen, @NgaySinh, @SoDienThoai, @VaiTro, @TaiKhoan, @MatKhau)";

                // Thêm các tham số vào command
                cmd.Parameters.AddWithValue("@MaNhanVien", txt_manv.Text);
                cmd.Parameters.AddWithValue("@HoTen", txt_hoten.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", dtp_ngaysinh.Text);
                cmd.Parameters.AddWithValue("@SoDienThoai", txt_sodt.Text);
                cmd.Parameters.AddWithValue("@VaiTro", txt_vaitro.Text);
                cmd.Parameters.AddWithValue("@TaiKhoan", txt_tk.Text);
                cmd.Parameters.AddWithValue("@MatKhau", txt_mk.Text);
                DateTime ngaySinh = dtp_ngaysinh.Value;
                int age = DateTime.Today.Year - ngaySinh.Year;
                if (age < 18)
                {
                    MessageBox.Show("Ngày sinh không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                cmd.ExecuteNonQuery();
                conn.Close();
                loadTK();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE TaiKhoan SET MaNhanVien = @MaNhanVien, HoTen = @HoTen, NgaySinh = @NgaySinh, " +
                                  "SoDienThoai = @SoDienThoai, VaiTro = @VaiTro, TaiKhoan = @TaiKhoan, MatKhau = @MatKhau " +
                                  "WHERE MaNhanVien = @MaNhanVien";  

                cmd.Parameters.AddWithValue("@MaNhanVien", txt_manv.Text);
                cmd.Parameters.AddWithValue("@HoTen", txt_hoten.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", dtp_ngaysinh.Text);
                cmd.Parameters.AddWithValue("@SoDienThoai", txt_sodt.Text);
                cmd.Parameters.AddWithValue("@VaiTro", txt_vaitro.Text);
                cmd.Parameters.AddWithValue("@TaiKhoan", txt_tk.Text);
                cmd.Parameters.AddWithValue("@MatKhau", txt_mk.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công");
                conn.Close();
                loadTK();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = "delete from TaiKhoan where MaNhanVien = @MaNhanVien";
                cmd.Parameters.AddWithValue("@MaNhanVien", txt_manv.Text);
                cmd.ExecuteNonQuery();
                conn.Close();


                MessageBox.Show("Xóa thành công.");
                loadTK();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            txt_manv.Text = "";
            txt_hoten.Text = "";
            txt_sodt.Text = "";
            txt_vaitro.Text = "";
            txt_tk.Text = "";
            txt_mk.Text = "";
            txt_timkiem.Text = "";
            dtp_ngaysinh.Value = DateTime.Now;
            loadTK();
            timkiem();
            
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            timkiem();
        }
        private void timkiem()
        {
            try
            {
                // Tạo câu truy vấn
                string searchQuery = "SELECT * FROM TaiKhoan WHERE 1=1";

                // Kiểm tra và thêm điều kiện tìm kiếm vào câu truy vấn
                if (!string.IsNullOrEmpty(txt_timkiem.Text))
                {
                    searchQuery += " AND (MaNhanVien LIKE @Keyword OR HoTen LIKE @Keyword OR NgaySinh LIKE @Keyword OR SoDienThoai LIKE @Keyword OR VaiTro LIKE @Keyword OR TaiKhoan LIKE @Keyword OR MatKhau LIKE @Keyword)";
                }

                // Mở kết nối và thực hiện truy vấn
                conn.Open();
                cmd = new SqlCommand(searchQuery, conn);
                cmd.Parameters.AddWithValue("@Keyword", "%" + txt_timkiem.Text + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt.Clear();
                da.Fill(dt);
                dgv_danhsachtk.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Đảm bảo kết nối được đóng sau khi sử dụng
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }

        private void dgv_danhsachtk_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv_danhsachtk.CurrentRow.Index;
            txt_manv.Text = dgv_danhsachtk.Rows[i].Cells[0].Value.ToString();
            txt_hoten.Text = dgv_danhsachtk.Rows[i].Cells[1].Value.ToString();
            dtp_ngaysinh.Text = dgv_danhsachtk.Rows[i].Cells[2].Value.ToString();
            txt_sodt.Text = dgv_danhsachtk.Rows[i].Cells[3].Value.ToString();
            txt_vaitro.Text = dgv_danhsachtk.Rows[i].Cells[4].Value.ToString();
            txt_tk.Text = dgv_danhsachtk.Rows[i].Cells[5].Value.ToString();
            txt_mk.Text = dgv_danhsachtk.Rows[i].Cells[6].Value.ToString();
            txt_manv.ReadOnly = true;
        }
    }
}
