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
    public partial class quanlySach : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string str = "Data Source=DESKTOP-CNGEDRR\\MSSQLSERVER01;Initial Catalog=QuanLyThuVien;UID=sa;Password=12345";
        SqlDataAdapter adt = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public quanlySach()
        {
            InitializeComponent();
        }

        private void quanlySach_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            loadSach();
        }
        private void loadSach()
        {
            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Sach";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt.Clear();
                da.Fill(dt);
                dgv_danhsach.DataSource = dt;
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
                cmd.CommandText = "insert into Sach values(@MaSach, @TenSach, @TacGia, @MaTheLoai, @NXB, @NamXuatBan)";
                cmd.Parameters.AddWithValue("@MaSach", txt_masach.Text);
                cmd.Parameters.AddWithValue("@TenSach", txt_tensach.Text);
                cmd.Parameters.AddWithValue("@TacGia", txt_tacgia.Text);
                cmd.Parameters.AddWithValue("@MaTheLoai", txt_theloai.Text);
                cmd.Parameters.AddWithValue("@NXB", txt_nxb.Text);
                cmd.Parameters.AddWithValue("@NamXuatBan", txt_namxb.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                loadSach();
                lammoi();
                
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

        private void dgv_danhsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv_danhsach.CurrentRow.Index;
            txt_masach.Text = dgv_danhsach.Rows[i].Cells[0].Value.ToString();
            txt_tensach.Text = dgv_danhsach.Rows[i].Cells[1].Value.ToString();
            txt_theloai.Text = dgv_danhsach.Rows[i].Cells[3].Value.ToString();
            txt_tacgia.Text = dgv_danhsach.Rows[i].Cells[2].Value.ToString();
            txt_nxb.Text = dgv_danhsach.Rows[i].Cells[4].Value.ToString();
            txt_namxb.Text = dgv_danhsach.Rows[i].Cells[5].Value.ToString();
            txt_masach.ReadOnly = true;
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE Sach SET MaSach = @MaSach, TenSach = @TenSach, TacGia = @TacGia, " +
                                  "MaTheLoai = @MaTheLoai, NXB = @NXB, NamXuatBan = @NamXuatBan " +
                                  "WHERE MaSach = @MaSach";  

                cmd.Parameters.AddWithValue("@MaSach", txt_masach.Text);
                txt_masach.ReadOnly = true;
                cmd.Parameters.AddWithValue("@TenSach", txt_tensach.Text);
                cmd.Parameters.AddWithValue("@TacGia", txt_tacgia.Text);
                cmd.Parameters.AddWithValue("@MaTheLoai", txt_theloai.Text);
                cmd.Parameters.AddWithValue("@NXB", txt_nxb.Text);
                cmd.Parameters.AddWithValue("@NamXuatBan", txt_namxb.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công");
                conn.Close();
                loadSach();
                lammoi();
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
                cmd.CommandText = "delete from Sach where MaSach = @MaSach";
                cmd.Parameters.AddWithValue("@MaSach", txt_masach.Text);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Xóa thành công.");
                loadSach();
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
            lammoi();   
            loadSach();
            timkiem();

        }
        private void lammoi()
        {
            txt_masach.Text = "";
            txt_tensach.Text = "";
            txt_tacgia.Text = "";
            txt_theloai.Text = "";
            txt_namxb.Text = "";
            txt_nxb.Text = "";
            txt_timkiem.Text = "";
            txt_masach.ReadOnly = false;
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            timkiem();
        }
        private void timkiem()
        {
            try
            {
                string searchQuery = "SELECT * FROM Sach WHERE 1=1";

                if (!string.IsNullOrEmpty(txt_timkiem.Text))
                {
                    searchQuery += " AND (MaSach LIKE @Keyword OR TenSach LIKE @Keyword OR TacGia LIKE @Keyword OR MaTheLoai LIKE @Keyword OR NXB LIKE @Keyword OR NamXuatBan LIKE @Keyword)";
                }

                conn.Open();
                cmd = new SqlCommand(searchQuery, conn);
                cmd.Parameters.AddWithValue("@Keyword", "%" + txt_timkiem.Text + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt.Clear();
                da.Fill(dt);
                dgv_danhsach.DataSource = dt;
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
    }
}
