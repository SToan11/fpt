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
    public partial class quanlyDocGia : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string str = "Data Source=DESKTOP-CNGEDRR\\MSSQLSERVER01;Initial Catalog=QuanLyThuVien;UID=sa;Password=12345";
        SqlDataAdapter adt = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public quanlyDocGia()
        {
            InitializeComponent();
        }

        private void quanlyDocGia_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            loadDocGia();
        }
        private void loadDocGia()
        {
            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM DocGia";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt.Clear();
                da.Fill(dt);
                dgv_danhsachdocgia.DataSource = dt;
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
                cmd.CommandText = "insert into DocGia values(@MaDocGia, @TenDocGia, @SoDienThoai)";

                // Thêm các tham số vào command
                cmd.Parameters.AddWithValue("@MaDocGia", txt_madocgia.Text);
                cmd.Parameters.AddWithValue("@TenDocGia", txt_tendocgia.Text);
                cmd.Parameters.AddWithValue("@SoDienThoai", txt_sodt.Text);


                cmd.ExecuteNonQuery();
                conn.Close();
                loadDocGia();

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
                cmd.CommandText = "UPDATE DocGia SET MaDocGia = @MaDocGia, TenDocGia = @TenDocGia, SoDienThoai = @SoDienThoai where MaDocGia = @MaDocGia";

                cmd.Parameters.AddWithValue("@MaDocGia", txt_madocgia.Text);
                cmd.Parameters.AddWithValue("@TenDocGia", txt_tendocgia.Text);
                cmd.Parameters.AddWithValue("@SoDienThoai", txt_sodt.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công");
                conn.Close();
                loadDocGia();
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
                cmd.CommandText = "delete from DocGia where MaDocGia = @MaDocGia";
                cmd.Parameters.AddWithValue("@MaDocGia", txt_madocgia.Text);
                cmd.ExecuteNonQuery();
                conn.Close();


                MessageBox.Show("Xóa thành công.");
                loadDocGia();
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
            txt_madocgia.Text = "";
            txt_tendocgia.Text = "";
            txt_sodt.Text = "";
            txt_madocgia.ReadOnly = false;
            loadDocGia();
            timkiem();
        }

        private void dgv_danhsachdocgia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv_danhsachdocgia.CurrentRow.Index;
            txt_madocgia.Text = dgv_danhsachdocgia.Rows[i].Cells[0].Value.ToString();
            txt_tendocgia.Text = dgv_danhsachdocgia.Rows[i].Cells[1].Value.ToString();
            txt_sodt.Text = dgv_danhsachdocgia.Rows[i].Cells[2].Value.ToString();
            txt_madocgia.ReadOnly = true;
        }
        private void timkiem()
        {
            try
            {
                // Tạo câu truy vấn
                string searchQuery = "SELECT * FROM DocGia WHERE 1=1";

                // Kiểm tra và thêm điều kiện tìm kiếm vào câu truy vấn
                if (!string.IsNullOrEmpty(txt_timkiem.Text))
                {
                    searchQuery += " AND (MaDocGia LIKE @Keyword OR TenDocGia LIKE @Keyword OR SoDienThoai LIKE @Keyword)";
                }

                // Mở kết nối và thực hiện truy vấn
                conn.Open();
                cmd = new SqlCommand(searchQuery, conn);
                cmd.Parameters.AddWithValue("@Keyword", "%" + txt_timkiem.Text + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt.Clear();
                da.Fill(dt);
                dgv_danhsachdocgia.DataSource = dt;
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

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            timkiem();
        }
    }
}
