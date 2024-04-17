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
    public partial class quanlyMuonTra : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string str = "Data Source=DESKTOP-CNGEDRR\\MSSQLSERVER01;Initial Catalog=QuanLyThuVien;UID=sa;Password=12345";
        SqlDataAdapter adt = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public quanlyMuonTra()
        {
            InitializeComponent();
        }

        private void quanlyMuonTra_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            loadPhieuMuon();
        }
        private void loadPhieuMuon()
        {
            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM PhieuMuon";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt.Clear();
                da.Fill(dt);
                dgv_danhsachmuon.DataSource = dt;
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
                cmd.CommandText = "insert into PhieuMuon values(@MaPhieu, @MaNhanVien, @MaDocGia, @NgayMuon, @NgayHetHan, @TrangThaiTra, @NgayTra, @GhiChu)";

                cmd.Parameters.AddWithValue("@MaPhieu", txt_maphieu.Text);
                cmd.Parameters.AddWithValue("@MaNhanVien", txt_manhanvien.Text);
                cmd.Parameters.AddWithValue("@MaDocGia", txt_madocgia.Text);
                cmd.Parameters.AddWithValue("@NgayMuon", dtp_ngaymuon.Text);
                cmd.Parameters.AddWithValue("@NgayHetHan", dtp_nayhethan.Text);
                cmd.Parameters.AddWithValue("@TrangThaiTra", cbo_trangthaitra.Text);
                cmd.Parameters.AddWithValue("@NgayTra", dtp_ngaytra.Text);
                cmd.Parameters.AddWithValue("@GhiChu", txt_ghichu.Text);


                cmd.ExecuteNonQuery();
                conn.Close();
                loadPhieuMuon();

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
                cmd.CommandText = "UPDATE PhieuMuon SET MaPhieu = @MaPhieu, MaNhanVien = @MaNhanVien, MaDocGia = @MaDocGia, " +
                                  "NgayMuon = @NgayMuon, NgayHetHan = @NgayHetHan, TrangThaiTra = @TrangThaiTra, NgayTra = @NgayTra, GhiChu = @GhiChu where MaPhieu = @MaPhieu";

                cmd.Parameters.AddWithValue("@MaPhieu", txt_maphieu.Text);
                cmd.Parameters.AddWithValue("@MaNhanVien", txt_manhanvien.Text);
                cmd.Parameters.AddWithValue("@MaDocGia", txt_madocgia.Text);
                cmd.Parameters.AddWithValue("@NgayMuon", dtp_ngaymuon.Text);
                cmd.Parameters.AddWithValue("@NgayHetHan", dtp_nayhethan.Text);
                cmd.Parameters.AddWithValue("@TrangThaiTra", cbo_trangthaitra.Text);
                cmd.Parameters.AddWithValue("@NgayTra", dtp_ngaytra.Text);
                cmd.Parameters.AddWithValue("@GhiChu", txt_ghichu.Text);



                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công");
                conn.Close();
                loadPhieuMuon();
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
                cmd.CommandText = "delete from PhieuMuon where MaPhieu = @MaPhieu";
                cmd.Parameters.AddWithValue("@MaPhieu", txt_maphieu.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Xóa thành công.");
                loadPhieuMuon();
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
            txt_maphieu.Text = "";
            txt_manhanvien.Text = "";
            txt_madocgia.Text = "";
            txt_ghichu.Text = "";
            dtp_ngaymuon.Value = DateTime.Now;
            dtp_ngaytra.Value = DateTime.Now;
            dtp_nayhethan.Value = DateTime.Now;
            cbo_trangthaitra.SelectedIndex = -1;
            txt_timkiem.Text = "";
            txt_maphieu.ReadOnly = false;
            loadPhieuMuon();
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
                string searchQuery = "SELECT * FROM PhieuMuon WHERE 1=1";

                if (!string.IsNullOrEmpty(txt_timkiem.Text))
                {
                    searchQuery += " AND (MaPhieu LIKE @Keyword OR MaNhanVien LIKE @Keyword OR MaDocGia LIKE @Keyword OR NgayMuon LIKE @Keyword OR NgayHetHan LIKE @Keyword OR TrangThaiTra LIKE @Keyword OR NgayTra LIKE @Keyword OR GhiChu LIKE @Keyword)";
                }

                conn.Open();
                cmd = new SqlCommand(searchQuery, conn);
                cmd.Parameters.AddWithValue("@Keyword", "%" + txt_timkiem.Text + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt.Clear();
                da.Fill(dt);
                dgv_danhsachmuon.DataSource = dt;
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

        private void dgv_danhsachmuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv_danhsachmuon.CurrentRow.Index;
            txt_maphieu.Text = dgv_danhsachmuon.Rows[i].Cells[0].Value.ToString();
            txt_manhanvien.Text = dgv_danhsachmuon.Rows[i].Cells[1].Value.ToString();
            txt_madocgia.Text = dgv_danhsachmuon.Rows[i].Cells[2].Value.ToString();
            dtp_ngaymuon.Text = dgv_danhsachmuon.Rows[i].Cells[3].Value.ToString();
            dtp_nayhethan.Text = dgv_danhsachmuon.Rows[i].Cells[4].Value.ToString();
            cbo_trangthaitra.Text = dgv_danhsachmuon.Rows[i].Cells[5].Value.ToString();
            dtp_ngaytra.Text = dgv_danhsachmuon.Rows[i].Cells[6].Value.ToString();
            txt_ghichu.Text = dgv_danhsachmuon.Rows[i].Cells[7].Value.ToString();
            txt_maphieu.ReadOnly = true;
        }
    }
}
